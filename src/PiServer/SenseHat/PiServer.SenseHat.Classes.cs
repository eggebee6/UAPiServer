/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace PiServer.SenseHat
{
    #region Sensor3DState Class
    #if (!OPCUA_EXCLUDE_Sensor3DState)
    /// <summary>
    /// Stores an instance of the Sensor3DType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Sensor3DState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Sensor3DState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PiServer.SenseHat.ObjectTypes.Sensor3DType, PiServer.SenseHat.Namespaces.SenseHat, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACwAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9QaVNlcnZlci9TZW5zZUhhdP////8EYIAC" +
           "AQAAAAEAFAAAAFNlbnNvcjNEVHlwZUluc3RhbmNlAQEBAAEBAQABAAAA/////wMAAAA1YIkKAgAAAAEA" +
           "AQAAAFgBAQIAAwAAAAANAAAAWC1heGlzIG91dHB1dAAvAD8CAAAAAAv/////AQH/////AAAAADVgiQoC" +
           "AAAAAQABAAAAWQEBAwADAAAAAA0AAABZLWF4aXMgb3V0cHV0AC8APwMAAAAAC/////8BAf////8AAAAA" +
           "NWCJCgIAAAABAAEAAABaAQEEAAMAAAAADQAAAFotYXhpcyBvdXRwdXQALwA/BAAAAAAL/////wEB////" +
           "/wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> X
        {
            get
            {
                return m_x;
            }

            set
            {
                if (!Object.ReferenceEquals(m_x, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_x = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Y
        {
            get
            {
                return m_y;
            }

            set
            {
                if (!Object.ReferenceEquals(m_y, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_y = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Z
        {
            get
            {
                return m_z;
            }

            set
            {
                if (!Object.ReferenceEquals(m_z, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_z = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_x != null)
            {
                children.Add(m_x);
            }

            if (m_y != null)
            {
                children.Add(m_y);
            }

            if (m_z != null)
            {
                children.Add(m_z);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case PiServer.SenseHat.BrowseNames.X:
                {
                    if (createOrReplace)
                    {
                        if (X == null)
                        {
                            if (replacement == null)
                            {
                                X = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                X = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = X;
                    break;
                }

                case PiServer.SenseHat.BrowseNames.Y:
                {
                    if (createOrReplace)
                    {
                        if (Y == null)
                        {
                            if (replacement == null)
                            {
                                Y = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Y = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Y;
                    break;
                }

                case PiServer.SenseHat.BrowseNames.Z:
                {
                    if (createOrReplace)
                    {
                        if (Z == null)
                        {
                            if (replacement == null)
                            {
                                Z = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Z = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Z;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_x;
        private BaseDataVariableState<double> m_y;
        private BaseDataVariableState<double> m_z;
        #endregion
    }
    #endif
    #endregion

    #region PushbuttonEventState Class
    #if (!OPCUA_EXCLUDE_PushbuttonEventState)
    /// <summary>
    /// Stores an instance of the PushbuttonEventType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PushbuttonEventState : BaseEventState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PushbuttonEventState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PiServer.SenseHat.ObjectTypes.PushbuttonEventType, PiServer.SenseHat.Namespaces.SenseHat, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACwAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9QaVNlcnZlci9TZW5zZUhhdP////8EYIAC" +
           "AQAAAAEAGwAAAFB1c2hidXR0b25FdmVudFR5cGVJbnN0YW5jZQEBBQABAQUABQAAAP////8JAAAAFWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQEGAAAuAEQGAAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAA" +
           "RXZlbnRUeXBlAQEHAAAuAEQHAAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9k" +
           "ZQEBCAAALgBECAAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAQkAAC4A" +
           "RAkAAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQEKAAAuAEQKAAAAAQAmAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBCwAALgBECwAAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBDQAALgBEDQAAAAAV/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAACAAAAFNldmVyaXR5AQEOAAAuAEQOAAAAAAX/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAUHVz" +
           "aGJ1dHRvblN0YXRlAQEPAAAuAEQPAAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<bool> PushbuttonState
        {
            get
            {
                return m_pushbuttonState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pushbuttonState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pushbuttonState = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_pushbuttonState != null)
            {
                children.Add(m_pushbuttonState);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case PiServer.SenseHat.BrowseNames.PushbuttonState:
                {
                    if (createOrReplace)
                    {
                        if (PushbuttonState == null)
                        {
                            if (replacement == null)
                            {
                                PushbuttonState = new PropertyState<bool>(this);
                            }
                            else
                            {
                                PushbuttonState = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = PushbuttonState;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<bool> m_pushbuttonState;
        #endregion
    }
    #endif
    #endregion

    #region JoystickState Class
    #if (!OPCUA_EXCLUDE_JoystickState)
    /// <summary>
    /// Stores an instance of the JoystickType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class JoystickState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public JoystickState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PiServer.SenseHat.ObjectTypes.JoystickType, PiServer.SenseHat.Namespaces.SenseHat, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACwAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9QaVNlcnZlci9TZW5zZUhhdP////+EYIAC" +
           "AQAAAAEAFAAAAEpveXN0aWNrVHlwZUluc3RhbmNlAQEQAAEBEAAQAAAAAQEAAAAAJAABARUABQAAADVg" +
           "iQoCAAAAAQACAAAAVXABAREAAwAAAAAMAAAAVXAgZGlyZWN0aW9uAC8APxEAAAAAAf////8BAf////8A" +
           "AAAANWCJCgIAAAABAAQAAABEb3duAQESAAMAAAAADgAAAERvd24gZGlyZWN0aW9uAC8APxIAAAAAAf//" +
           "//8BAf////8AAAAANWCJCgIAAAABAAQAAABMZWZ0AQETAAMAAAAADgAAAExlZnQgZGlyZWN0aW9uAC8A" +
           "PxMAAAAAAf////8BAf////8AAAAANWCJCgIAAAABAAUAAABSaWdodAEBFAADAAAAAA8AAABSaWdodCBk" +
           "aXJlY3Rpb24ALwA/FAAAAAAB/////wEB/////wAAAAA1YIkKAgAAAAEACgAAAFB1c2hidXR0b24BARUA" +
           "AwAAAAAKAAAAUHVzaGJ1dHRvbgAvAD8VAAAAAAH/////AQEBAAAAACQBAQEQAAAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> Up
        {
            get
            {
                return m_up;
            }

            set
            {
                if (!Object.ReferenceEquals(m_up, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_up = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Down
        {
            get
            {
                return m_down;
            }

            set
            {
                if (!Object.ReferenceEquals(m_down, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_down = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Left
        {
            get
            {
                return m_left;
            }

            set
            {
                if (!Object.ReferenceEquals(m_left, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_left = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Right
        {
            get
            {
                return m_right;
            }

            set
            {
                if (!Object.ReferenceEquals(m_right, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_right = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> Pushbutton
        {
            get
            {
                return m_pushbutton;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pushbutton, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pushbutton = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_up != null)
            {
                children.Add(m_up);
            }

            if (m_down != null)
            {
                children.Add(m_down);
            }

            if (m_left != null)
            {
                children.Add(m_left);
            }

            if (m_right != null)
            {
                children.Add(m_right);
            }

            if (m_pushbutton != null)
            {
                children.Add(m_pushbutton);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case PiServer.SenseHat.BrowseNames.Up:
                {
                    if (createOrReplace)
                    {
                        if (Up == null)
                        {
                            if (replacement == null)
                            {
                                Up = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Up = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Up;
                    break;
                }

                case PiServer.SenseHat.BrowseNames.Down:
                {
                    if (createOrReplace)
                    {
                        if (Down == null)
                        {
                            if (replacement == null)
                            {
                                Down = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Down = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Down;
                    break;
                }

                case PiServer.SenseHat.BrowseNames.Left:
                {
                    if (createOrReplace)
                    {
                        if (Left == null)
                        {
                            if (replacement == null)
                            {
                                Left = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Left = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Left;
                    break;
                }

                case PiServer.SenseHat.BrowseNames.Right:
                {
                    if (createOrReplace)
                    {
                        if (Right == null)
                        {
                            if (replacement == null)
                            {
                                Right = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Right = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Right;
                    break;
                }

                case PiServer.SenseHat.BrowseNames.Pushbutton:
                {
                    if (createOrReplace)
                    {
                        if (Pushbutton == null)
                        {
                            if (replacement == null)
                            {
                                Pushbutton = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Pushbutton = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Pushbutton;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_up;
        private BaseDataVariableState<bool> m_down;
        private BaseDataVariableState<bool> m_left;
        private BaseDataVariableState<bool> m_right;
        private BaseDataVariableState<bool> m_pushbutton;
        #endregion
    }
    #endif
    #endregion

    #region SetColorMethodState Class
    #if (!OPCUA_EXCLUDE_SetColorMethodState)
    /// <summary>
    /// Stores an instance of the SetColor Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetColorMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SetColorMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new SetColorMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACwAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9QaVNlcnZlci9TZW5zZUhhdP////8EYYIK" +
           "BAAAAAEACAAAAFNldENvbG9yAQEWAAAvAQEWABYAAAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEBFwAALgBEFwAAAJYDAAAAAQAqAQESAAAAAwAAAFJlZAAD/////wAAAAAAAQAqAQEU" +
           "AAAABQAAAEdyZWVuAAP/////AAAAAAABACoBARMAAAAEAAAAQmx1ZQAD/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAwAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public SetColorMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            byte red = (byte)_inputArguments[0];
            byte green = (byte)_inputArguments[1];
            byte blue = (byte)_inputArguments[2];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    red,
                    green,
                    blue);
            }

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult SetColorMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        byte red,
        byte green,
        byte blue);
    #endif
    #endregion

    #region LEDMatrixState Class
    #if (!OPCUA_EXCLUDE_LEDMatrixState)
    /// <summary>
    /// Stores an instance of the LEDMatrixType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LEDMatrixState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LEDMatrixState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PiServer.SenseHat.ObjectTypes.LEDMatrixType, PiServer.SenseHat.Namespaces.SenseHat, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACwAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9QaVNlcnZlci9TZW5zZUhhdP////8EYIAC" +
           "AQAAAAEAFQAAAExFRE1hdHJpeFR5cGVJbnN0YW5jZQEBGAABARgAGAAAAP////8BAAAABGGCCgQAAAAB" +
           "AA4AAABTZXRNYXRyaXhDb2xvcgEBGQAALwEBGQAZAAAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5w" +
           "dXRBcmd1bWVudHMBARoAAC4ARBoAAACWAwAAAAEAKgEBEgAAAAMAAABSZWQAA/////8AAAAAAAEAKgEB" +
           "FAAAAAUAAABHcmVlbgAD/////wAAAAAAAQAqAQETAAAABAAAAEJsdWUAA/////8AAAAAAAEAKAEBAAAA" +
           "AQAAAAMAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public SetColorMethodState SetMatrixColor
        {
            get
            {
                return m_setMatrixColorMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setMatrixColorMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setMatrixColorMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_setMatrixColorMethod != null)
            {
                children.Add(m_setMatrixColorMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case PiServer.SenseHat.BrowseNames.SetMatrixColor:
                {
                    if (createOrReplace)
                    {
                        if (SetMatrixColor == null)
                        {
                            if (replacement == null)
                            {
                                SetMatrixColor = new SetColorMethodState(this);
                            }
                            else
                            {
                                SetMatrixColor = (SetColorMethodState)replacement;
                            }
                        }
                    }

                    instance = SetMatrixColor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private SetColorMethodState m_setMatrixColorMethod;
        #endregion
    }
    #endif
    #endregion

    #region SenseHatState Class
    #if (!OPCUA_EXCLUDE_SenseHatState)
    /// <summary>
    /// Stores an instance of the SenseHatType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SenseHatState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SenseHatState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PiServer.SenseHat.ObjectTypes.SenseHatType, PiServer.SenseHat.Namespaces.SenseHat, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACwAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9QaVNlcnZlci9TZW5zZUhhdP////+EYIAC" +
           "AQAAAAEAFAAAAFNlbnNlSGF0VHlwZUluc3RhbmNlAQEbAAEBGwAbAAAAAQIAAAAAMAABASoAADABAQDN" +
           "CAcAAAA1YIkKAgAAAAEACwAAAFRlbXBlcmF0dXJlAQEcAAMAAAAACwAAAFRlbXBlcmF0dXJlAC8APxwA" +
           "AAAAC/////8BAf////8AAAAANWCJCgIAAAABAAgAAABIdW1pZGl0eQEBHQADAAAAAAgAAABIdW1pZGl0" +
           "eQAvAD8dAAAAAAv/////AQH/////AAAAAARggAoBAAAAAQAMAAAATWFnbmV0b21ldGVyAQEeAAAvAQEB" +
           "AB4AAAD/////AwAAADVgiQoCAAAAAQABAAAAWAEBHwADAAAAAA0AAABYLWF4aXMgb3V0cHV0AC8APx8A" +
           "AAAAC/////8BAf////8AAAAANWCJCgIAAAABAAEAAABZAQEgAAMAAAAADQAAAFktYXhpcyBvdXRwdXQA" +
           "LwA/IAAAAAAL/////wEB/////wAAAAA1YIkKAgAAAAEAAQAAAFoBASEAAwAAAAANAAAAWi1heGlzIG91" +
           "dHB1dAAvAD8hAAAAAAv/////AQH/////AAAAAARggAoBAAAAAQANAAAAQWNjZWxlcm9tZXRlcgEBIgAA" +
           "LwEBAQAiAAAA/////wMAAAA1YIkKAgAAAAEAAQAAAFgBASMAAwAAAAANAAAAWC1heGlzIG91dHB1dAAv" +
           "AD8jAAAAAAv/////AQH/////AAAAADVgiQoCAAAAAQABAAAAWQEBJAADAAAAAA0AAABZLWF4aXMgb3V0" +
           "cHV0AC8APyQAAAAAC/////8BAf////8AAAAANWCJCgIAAAABAAEAAABaAQElAAMAAAAADQAAAFotYXhp" +
           "cyBvdXRwdXQALwA/JQAAAAAL/////wEB/////wAAAAAEYMAKAQAAAAsAAABBbmd1bGFyUmF0ZQEAEwAA" +
           "AEFuZ3VsYXIgcmF0ZSBzZW5zb3IBASYAAC8BAQEAJgAAAP////8DAAAANWCJCgIAAAABAAEAAABYAQEn" +
           "AAMAAAAADQAAAFgtYXhpcyBvdXRwdXQALwA/JwAAAAAL/////wEB/////wAAAAA1YIkKAgAAAAEAAQAA" +
           "AFkBASgAAwAAAAANAAAAWS1heGlzIG91dHB1dAAvAD8oAAAAAAv/////AQH/////AAAAADVgiQoCAAAA" +
           "AQABAAAAWgEBKQADAAAAAA0AAABaLWF4aXMgb3V0cHV0AC8APykAAAAAC/////8BAf////8AAAAAhGDA" +
           "CgEAAAAIAAAASm95c3RpY2sBACcAAABGb3VyLWRpcmVjdGlvbiBqb3lzdGljayB3aXRoIHB1c2hidXR0" +
           "b24BASoAAC8BARAAKgAAAAECAAAAADABAQEbAAAkAAEBLwAFAAAANWCJCgIAAAABAAIAAABVcAEBKwAD" +
           "AAAAAAwAAABVcCBkaXJlY3Rpb24ALwA/KwAAAAAB/////wEB/////wAAAAA1YIkKAgAAAAEABAAAAERv" +
           "d24BASwAAwAAAAAOAAAARG93biBkaXJlY3Rpb24ALwA/LAAAAAAB/////wEB/////wAAAAA1YIkKAgAA" +
           "AAEABAAAAExlZnQBAS0AAwAAAAAOAAAATGVmdCBkaXJlY3Rpb24ALwA/LQAAAAAB/////wEB/////wAA" +
           "AAA1YIkKAgAAAAEABQAAAFJpZ2h0AQEuAAMAAAAADwAAAFJpZ2h0IGRpcmVjdGlvbgAvAD8uAAAAAAH/" +
           "////AQH/////AAAAADVgiQoCAAAAAQAKAAAAUHVzaGJ1dHRvbgEBLwADAAAAAAoAAABQdXNoYnV0dG9u" +
           "AC8APy8AAAAAAf////8BAQEAAAAAJAEBASoAAAAAAARgwAoBAAAACQAAAExFRE1hdHJpeAEADgAAAFJH" +
           "QiBMRUQgTWF0cml4AQEwAAAvAQEYADAAAAD/////AQAAAARhggoEAAAAAQAOAAAAU2V0TWF0cml4Q29s" +
           "b3IBATEAAC8BARkAMQAAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEyAAAu" +
           "AEQyAAAAlgMAAAABACoBARIAAAADAAAAUmVkAAP/////AAAAAAABACoBARQAAAAFAAAAR3JlZW4AA///" +
           "//8AAAAAAAEAKgEBEwAAAAQAAABCbHVlAAP/////AAAAAAABACgBAQAAAAEAAAADAAAAAQH/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> Temperature
        {
            get
            {
                return m_temperature;
            }

            set
            {
                if (!Object.ReferenceEquals(m_temperature, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_temperature = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> Humidity
        {
            get
            {
                return m_humidity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_humidity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_humidity = value;
            }
        }

        /// <remarks />
        public Sensor3DState Magnetometer
        {
            get
            {
                return m_magnetometer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_magnetometer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_magnetometer = value;
            }
        }

        /// <remarks />
        public Sensor3DState Accelerometer
        {
            get
            {
                return m_accelerometer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_accelerometer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_accelerometer = value;
            }
        }

        /// <remarks />
        public Sensor3DState AngularRate
        {
            get
            {
                return m_angularRate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_angularRate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_angularRate = value;
            }
        }

        /// <remarks />
        public JoystickState Joystick
        {
            get
            {
                return m_joystick;
            }

            set
            {
                if (!Object.ReferenceEquals(m_joystick, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_joystick = value;
            }
        }

        /// <remarks />
        public LEDMatrixState LEDMatrix
        {
            get
            {
                return m_lEDMatrix;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lEDMatrix, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lEDMatrix = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_temperature != null)
            {
                children.Add(m_temperature);
            }

            if (m_humidity != null)
            {
                children.Add(m_humidity);
            }

            if (m_magnetometer != null)
            {
                children.Add(m_magnetometer);
            }

            if (m_accelerometer != null)
            {
                children.Add(m_accelerometer);
            }

            if (m_angularRate != null)
            {
                children.Add(m_angularRate);
            }

            if (m_joystick != null)
            {
                children.Add(m_joystick);
            }

            if (m_lEDMatrix != null)
            {
                children.Add(m_lEDMatrix);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case PiServer.SenseHat.BrowseNames.Temperature:
                {
                    if (createOrReplace)
                    {
                        if (Temperature == null)
                        {
                            if (replacement == null)
                            {
                                Temperature = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Temperature = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Temperature;
                    break;
                }

                case PiServer.SenseHat.BrowseNames.Humidity:
                {
                    if (createOrReplace)
                    {
                        if (Humidity == null)
                        {
                            if (replacement == null)
                            {
                                Humidity = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Humidity = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Humidity;
                    break;
                }

                case PiServer.SenseHat.BrowseNames.Magnetometer:
                {
                    if (createOrReplace)
                    {
                        if (Magnetometer == null)
                        {
                            if (replacement == null)
                            {
                                Magnetometer = new Sensor3DState(this);
                            }
                            else
                            {
                                Magnetometer = (Sensor3DState)replacement;
                            }
                        }
                    }

                    instance = Magnetometer;
                    break;
                }

                case PiServer.SenseHat.BrowseNames.Accelerometer:
                {
                    if (createOrReplace)
                    {
                        if (Accelerometer == null)
                        {
                            if (replacement == null)
                            {
                                Accelerometer = new Sensor3DState(this);
                            }
                            else
                            {
                                Accelerometer = (Sensor3DState)replacement;
                            }
                        }
                    }

                    instance = Accelerometer;
                    break;
                }

                case PiServer.SenseHat.BrowseNames.AngularRate:
                {
                    if (createOrReplace)
                    {
                        if (AngularRate == null)
                        {
                            if (replacement == null)
                            {
                                AngularRate = new Sensor3DState(this);
                            }
                            else
                            {
                                AngularRate = (Sensor3DState)replacement;
                            }
                        }
                    }

                    instance = AngularRate;
                    break;
                }

                case PiServer.SenseHat.BrowseNames.Joystick:
                {
                    if (createOrReplace)
                    {
                        if (Joystick == null)
                        {
                            if (replacement == null)
                            {
                                Joystick = new JoystickState(this);
                            }
                            else
                            {
                                Joystick = (JoystickState)replacement;
                            }
                        }
                    }

                    instance = Joystick;
                    break;
                }

                case PiServer.SenseHat.BrowseNames.LEDMatrix:
                {
                    if (createOrReplace)
                    {
                        if (LEDMatrix == null)
                        {
                            if (replacement == null)
                            {
                                LEDMatrix = new LEDMatrixState(this);
                            }
                            else
                            {
                                LEDMatrix = (LEDMatrixState)replacement;
                            }
                        }
                    }

                    instance = LEDMatrix;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_temperature;
        private BaseDataVariableState<double> m_humidity;
        private Sensor3DState m_magnetometer;
        private Sensor3DState m_accelerometer;
        private Sensor3DState m_angularRate;
        private JoystickState m_joystick;
        private LEDMatrixState m_lEDMatrix;
        #endregion
    }
    #endif
    #endregion
}