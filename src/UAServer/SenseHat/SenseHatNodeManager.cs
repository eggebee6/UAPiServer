// Based on the OPC Foundation .NET samples
// https://github.com/OPCFoundation

using Microsoft.Extensions.Logging;
using Opc.Ua.Server;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Text;

namespace UAServer.SenseHat
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

      List<string> namespaceUris = new List<string>()
      {
        Namespaces.SenseHat,
        Namespaces.SenseHat + "/Instance"
      };

      NamespaceUris = namespaceUris;

      typeNamespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[0]);
      namespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[1]);
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
        senseHatNode = new SenseHatState(null);
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

        InitializeSenseHatNode(senseHatNode);
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
    public void InitializeSenseHatNode(SenseHatState node)
    {
      node.Temperature.Units.Value = SenseHat.TemperatureUnits;
      node.Pressure.Units.Value = SenseHat.PressureUnits;
      node.Humidity.Units.Value = SenseHat.HumidityUnits;
      node.Magnetometer.Units.Value = SenseHat.MagnetometerUnits;
      node.Accelerometer.Units.Value = SenseHat.AccelerometerUnits;
      node.AngularRate.Units.Value = SenseHat.AngularRateUnits;

      SenseHat.AccelerometerChanged += SenseHat_AccelerometerChanged;
      SenseHat.AngularRateChanged += SenseHat_AngularRateChanged;
      SenseHat.HumidityChanged += SenseHat_HumidityChanged;
      SenseHat.JoystickChanged += SenseHat_JoystickChanged;
      SenseHat.JoystickChanged += SenseHat_JoystickEventGenerator;
      SenseHat.MagnetometerChanged += SenseHat_MagnetometerChanged;
      SenseHat.PressureChanged += SenseHat_PressureChanged;
      SenseHat.TemperatureChanged += SenseHat_TemperatureChanged;

      node.LED.SetColor.OnCall = SetLEDColor;
    }
    #endregion

    #region Private Fields
    private ushort namespaceIndex;
    private ushort typeNamespaceIndex;

    private readonly ISenseHat senseHat;
    private SenseHatState? senseHatNode;
    #endregion
  }
}
