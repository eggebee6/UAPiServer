// Based on the OPC Foundation .NET samples
// https://github.com/OPCFoundation

using Microsoft.Extensions.Logging;
using Opc.Ua.Server;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiServer.SenseHat
{
  public class SenseHatNodeManager : CustomNodeManager2
  {
    #region Constructors
    public SenseHatNodeManager(
      IServerInternal internalServer,
      ApplicationConfiguration configuration,
      ISenseHat senseHat)
      : base(internalServer, configuration, Namespaces.SenseHat)
    {
      this.senseHat = senseHat ?? throw new ArgumentNullException(nameof(senseHat));

      SystemContext.NodeIdFactory = this;

      // Initialize namespaces
      List<string> namespaceUris = new List<string>()
      {
        Namespaces.SenseHat,
        Namespaces.SenseHat + "/Instance"
      };

      NamespaceUris = namespaceUris;

      typeNamespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[0]);
      namespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[1]);

      // Initialize UA nodes
      senseHatNode = new SenseHatState(null);
    }
    #endregion

    #region IDisposable Members
    /// <summary>
    /// An overrideable version of the Dispose.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
      }
    }
    #endregion

    #region INodeIdFactory Members
    /// <summary>
    /// Creates the NodeId for the specified node.
    /// </summary>
    public override NodeId New(ISystemContext context, NodeState node)
    {
      return node.NodeId;
    }
    #endregion

    #region INodeManager Members
    /// <summary>
    /// Does any initialization required before the address space can be used.
    /// </summary>
    /// <remarks>
    /// The externalReferences is an out parameter that allows the node manager to link to nodes
    /// in other node managers. For example, the 'Objects' node is managed by the CoreNodeManager and
    /// should have a reference to the root folder node(s) exposed by this node manager.  
    /// </remarks>
    public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
    {
      lock (Lock)
      {
        base.CreateAddressSpace(externalReferences);

        if (!externalReferences.TryGetValue(Opc.Ua.ObjectIds.RootFolder, out IList<IReference>? references))
        {
          references = new List<IReference>();
          externalReferences[Opc.Ua.ObjectIds.RootFolder] = references;
        }

        // Add SenseHat folder
        FolderState senseHatFolder = new FolderState(null);
        senseHatFolder.Create(
          SystemContext,
          new NodeId(Guid.NewGuid(), NamespaceIndex),
          new QualifiedName("SenseHat", namespaceIndex),
          null,
          false);

        references.Add(new NodeStateReference(ReferenceTypeIds.Organizes, false, senseHatFolder.NodeId));
        senseHatFolder.AddReference(ReferenceTypeIds.Organizes, true, Opc.Ua.ObjectIds.RootFolder);

        AddPredefinedNode(SystemContext, senseHatFolder);

        // Add SenseHat node
        senseHatNode.Create(
          SystemContext,
          null,
          new QualifiedName("SenseHat", namespaceIndex),
          null,
          true);

        senseHatNode.AddReference(ReferenceTypeIds.Organizes, true, senseHatFolder.NodeId);
        senseHatFolder.AddReference(ReferenceTypeIds.Organizes, false, senseHatNode.NodeId);

        senseHatNode.AddReference(ReferenceTypeIds.HasNotifier, true, senseHatFolder.NodeId);
        senseHatFolder.AddReference(ReferenceTypeIds.HasNotifier, false, senseHatNode.NodeId);

        AddPredefinedNode(SystemContext, senseHatNode);

        InitializeSenseHatNode();
      }
    }

    /// <summary>
    /// Frees any resources allocated for the address space.
    /// </summary>
    public override void DeleteAddressSpace()
    {
      lock (Lock)
      {
        base.DeleteAddressSpace();
      }
    }

    /// <summary>
    /// Returns a unique handle for the node.
    /// </summary>
    protected override NodeHandle GetManagerHandle(ServerSystemContext context, NodeId nodeId, IDictionary<NodeId, NodeState> cache)
    {
      lock (Lock)
      {
        // quickly exclude nodes that are not in the namespace. 
        if (!IsNodeIdInNamespace(nodeId))
        {
          return null;
        }

        NodeState node = null;

        if (!PredefinedNodes.TryGetValue(nodeId, out node))
        {
          return null;
        }

        NodeHandle handle = new NodeHandle();

        handle.NodeId = nodeId;
        handle.Node = node;
        handle.Validated = true;

        return handle;
      }
    }

    /// <summary>
    /// Verifies that the specified node exists.
    /// </summary>
    protected override NodeState ValidateNode(
        ServerSystemContext context,
        NodeHandle handle,
        IDictionary<NodeId, NodeState> cache)
    {
      // not valid if no root.
      if (handle == null)
      {
        return null;
      }

      // check if previously validated.
      if (handle.Validated)
      {
        return handle.Node;
      }

      // TBD

      return null;
    }
    #endregion

    #region Implementation specific methods
    public void InitializeSenseHatNode()
    {
      // Set initial node values
      senseHatNode.Temperature.Value = senseHat.Temperature;
      senseHatNode.Humidity.Value = senseHat.Humidity;

      (var magX, var magY, var magZ) = senseHat.Magnetometer;
      senseHatNode.Magnetometer.X.Value = magX;
      senseHatNode.Magnetometer.Y.Value = magY;
      senseHatNode.Magnetometer.Z.Value = magZ;

      (var accelX, var accelY, var accelZ) = senseHat.Accelerometer;
      senseHatNode.Accelerometer.X.Value = accelX;
      senseHatNode.Accelerometer.Y.Value = accelY;
      senseHatNode.Accelerometer.Z.Value = accelZ;

      (var angularX, var angularY, var angularZ) = senseHat.AngularRate;
      senseHatNode.AngularRate.X.Value = angularX;
      senseHatNode.AngularRate.Y.Value = angularY;
      senseHatNode.AngularRate.Z.Value = angularZ;

      (var up, var down, var left, var right, var button) = senseHat.Joystick;
      senseHatNode.Joystick.Up.Value = up;
      senseHatNode.Joystick.Down.Value = down;
      senseHatNode.Joystick.Left.Value = left;
      senseHatNode.Joystick.Right.Value = right;
      senseHatNode.Joystick.Pushbutton.Value = button;

      // Add node method callbacks
      senseHatNode.LEDMatrix.SetMatrixColor.OnCall = SetLEDColor;

      // Add interface event handlers
      senseHat.TemperatureChanged += OnTemperatureChanged;
      senseHat.HumidityChanged += OnHumidityChanged;
      senseHat.MagnetometerChanged += OnMagnetometerChanged;
      senseHat.AccelerometerChanged += OnAccelerometerChanged;
      senseHat.AngularRateChanged += OnAngularRateChanged;
      senseHat.JoystickChanged += OnJoystickChanged;
    }

    public void DeinitializeSenseHatNode()
    {
      // Remove interface event handlers
      senseHat.TemperatureChanged -= OnTemperatureChanged;
      senseHat.HumidityChanged -= OnHumidityChanged;
      senseHat.MagnetometerChanged -= OnMagnetometerChanged;
      senseHat.AccelerometerChanged -= OnAccelerometerChanged;
      senseHat.AngularRateChanged -= OnAngularRateChanged;
      senseHat.JoystickChanged -= OnJoystickChanged;
    }

    private void OnTemperatureChanged(object? sender, EventArgs args)
    {
      // Get sensor reading
      var reading = senseHat.Temperature;

      // Update node
      senseHatNode.Temperature.Value = reading;
      senseHatNode.ClearChangeMasks(SystemContext, true);
    }

    private void OnHumidityChanged(object? sender, EventArgs args)
    {
      // Get sensor reading
      var reading = senseHat.Humidity;

      // Update node
      senseHatNode.Humidity.Value = reading;
      senseHatNode.ClearChangeMasks(SystemContext, true);
    }

    private void OnMagnetometerChanged(object? sender, EventArgs args)
    {
      // Get sensor reading
      (var x, var y, var z) = senseHat.Magnetometer;

      // Update node
      senseHatNode.Magnetometer.X.Value = x;
      senseHatNode.Magnetometer.Y.Value = y;
      senseHatNode.Magnetometer.Z.Value = z;
      senseHatNode.ClearChangeMasks(SystemContext, true);
    }

    private void OnAccelerometerChanged(object? sender, EventArgs args)
    {
      // Get sensor reading
      (var x, var y, var z) = senseHat.Accelerometer;

      // Update node
      senseHatNode.Accelerometer.X.Value = x;
      senseHatNode.Accelerometer.Y.Value = y;
      senseHatNode.Accelerometer.Z.Value = z;
      senseHatNode.ClearChangeMasks(SystemContext, true);
    }

    private void OnAngularRateChanged(object? sender, EventArgs args)
    {
      // Get sensor reading
      (var x, var y, var z) = senseHat.AngularRate;

      // Update node
      senseHatNode.AngularRate.X.Value = x;
      senseHatNode.AngularRate.Y.Value = y;
      senseHatNode.AngularRate.Z.Value = z;
      senseHatNode.ClearChangeMasks(SystemContext, true);
    }

    private void OnJoystickChanged(object? sender, EventArgs args)
    {
      // Get sensor reading
      (var up, var down, var left, var right, var button) = senseHat.Joystick;

      // Update node
      senseHatNode.Joystick.Up.Value = up;
      senseHatNode.Joystick.Down.Value = down;
      senseHatNode.Joystick.Left.Value = left;
      senseHatNode.Joystick.Right.Value = right;
      senseHatNode.Joystick.Pushbutton.Value = button;
      senseHatNode.ClearChangeMasks(SystemContext, true);

      // Report event if pushbutton state changes
      if (button != prevButtonState)
      {
        // Initialize event
        var evt = new PushbuttonEventState(senseHatNode.Joystick.Pushbutton);
        evt.Initialize(
          SystemContext,
          senseHatNode.Joystick.Pushbutton,
          EventSeverity.Min,
          button ? "Button pressed" : "Button released");

        evt.SetChildValue(
          SystemContext,
          Opc.Ua.BrowseNames.SourceName,
          "SenseHat joystick pushbutton",
          false);
        evt.SetChildValue(
          SystemContext,
          new QualifiedName(BrowseNames.PushbuttonState, NamespaceIndex),
          button,
          false);

        // Report event
        senseHatNode.Joystick.Pushbutton.ReportEvent(SystemContext, evt);

        // Update previous button state
        prevButtonState = button;
      }
    }

    private ServiceResult SetLEDColor(
      ISystemContext context,
      MethodState method,
      NodeId objectId,
      byte red,
      byte green,
      byte blue)
    {
      try
      {
        senseHat.SetMatrixColor(red, green, blue);
      }
      catch (Exception ex)
      {
        return new ServiceResult(ex);
      }

      return ServiceResult.Good;
    }
    #endregion

    #region Private Fields
    private ushort namespaceIndex;
    private ushort typeNamespaceIndex;

    private readonly ISenseHat senseHat;
    private SenseHatState senseHatNode;

    private bool prevButtonState = false;
    #endregion
  }
}
