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

namespace UAServer.SenseHat
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
            return Opc.Ua.NodeId.Create(UAServer.SenseHat.ObjectTypes.Sensor3DType, UAServer.SenseHat.Namespaces.SenseHat, namespaceUris);
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
           "AQAAACMAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9TZW5zZUhhdP////8EYIACAQAAAAEAFAAA" +
           "AFNlbnNvcjNEVHlwZUluc3RhbmNlAQEBAAEBAQABAAAA/////wQAAAA1YIkKAgAAAAEAAQAAAFgBAQIA" +
           "AwAAAAANAAAAWC1heGlzIG91dHB1dAAvAD8CAAAAAAv/////AQH/////AAAAADVgiQoCAAAAAQABAAAA" +
           "WQEBAwADAAAAAA0AAABZLWF4aXMgb3V0cHV0AC8APwMAAAAAC/////8BAf////8AAAAANWCJCgIAAAAB" +
           "AAEAAABaAQEEAAMAAAAADQAAAFotYXhpcyBvdXRwdXQALwA/BAAAAAAL/////wEB/////wAAAAA1YIkK" +
           "AgAAAAEABQAAAFVuaXRzAQEFAAMAAAAADAAAAFNlbnNvciB1bml0cwAuAEQFAAAAAAz/////AQH/////" +
           "AAAAAA==";
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

        /// <remarks />
        public PropertyState<string> Units
        {
            get
            {
                return m_units;
            }

            set
            {
                if (!Object.ReferenceEquals(m_units, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_units = value;
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

            if (m_units != null)
            {
                children.Add(m_units);
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
                case UAServer.SenseHat.BrowseNames.X:
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

                case UAServer.SenseHat.BrowseNames.Y:
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

                case UAServer.SenseHat.BrowseNames.Z:
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

                case UAServer.SenseHat.BrowseNames.Units:
                {
                    if (createOrReplace)
                    {
                        if (Units == null)
                        {
                            if (replacement == null)
                            {
                                Units = new PropertyState<string>(this);
                            }
                            else
                            {
                                Units = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Units;
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
        private PropertyState<string> m_units;
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
            return Opc.Ua.NodeId.Create(UAServer.SenseHat.ObjectTypes.PushbuttonEventType, UAServer.SenseHat.Namespaces.SenseHat, namespaceUris);
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
           "AQAAACMAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9TZW5zZUhhdP////8EYIACAQAAAAEAGwAA" +
           "AFB1c2hidXR0b25FdmVudFR5cGVJbnN0YW5jZQEBBgABAQYABgAAAP////8JAAAAFWCJCgIAAAAAAAcA" +
           "AABFdmVudElkAQEHAAAuAEQHAAAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRUeXBl" +
           "AQEIAAAuAEQIAAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBCQAALgBE" +
           "CQAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAQoAAC4ARAoAAAAADP//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQELAAAuAEQLAAAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBDAAALgBEDAAAAAEAJgH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAATWVzc2FnZQEBDgAALgBEDgAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNl" +
           "dmVyaXR5AQEPAAAuAEQPAAAAAAX/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAUHVzaGJ1dHRvblN0" +
           "YXRlAQEQAAAuAEQQAAAAAAH/////AQH/////AAAAAA==";
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
                case UAServer.SenseHat.BrowseNames.PushbuttonState:
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
            return Opc.Ua.NodeId.Create(UAServer.SenseHat.ObjectTypes.JoystickType, UAServer.SenseHat.Namespaces.SenseHat, namespaceUris);
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
           "AQAAACMAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9TZW5zZUhhdP////+EYIACAQAAAAEAFAAA" +
           "AEpveXN0aWNrVHlwZUluc3RhbmNlAQERAAEBEQARAAAAAQEAAAAAJAABARYABQAAADVgiQoCAAAAAQAC" +
           "AAAAVXABARIAAwAAAAAMAAAAVXAgZGlyZWN0aW9uAC8APxIAAAAAAf////8BAf////8AAAAANWCJCgIA" +
           "AAABAAQAAABEb3duAQETAAMAAAAADgAAAERvd24gZGlyZWN0aW9uAC8APxMAAAAAAf////8BAf////8A" +
           "AAAANWCJCgIAAAABAAQAAABMZWZ0AQEUAAMAAAAADgAAAExlZnQgZGlyZWN0aW9uAC8APxQAAAAAAf//" +
           "//8BAf////8AAAAANWCJCgIAAAABAAUAAABSaWdodAEBFQADAAAAAA8AAABSaWdodCBkaXJlY3Rpb24A" +
           "LwA/FQAAAAAB/////wEB/////wAAAAA1YIkKAgAAAAEACgAAAFB1c2hidXR0b24BARYAAwAAAAAKAAAA" +
           "UHVzaGJ1dHRvbgAvAD8WAAAAAAH/////AQEBAAAAACQBAQERAAAAAAA=";
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
                case UAServer.SenseHat.BrowseNames.Up:
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

                case UAServer.SenseHat.BrowseNames.Down:
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

                case UAServer.SenseHat.BrowseNames.Left:
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

                case UAServer.SenseHat.BrowseNames.Right:
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

                case UAServer.SenseHat.BrowseNames.Pushbutton:
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

    #region SetRGBLEDColorMethodState Class
    #if (!OPCUA_EXCLUDE_SetRGBLEDColorMethodState)
    /// <summary>
    /// Stores an instance of the SetRGBLEDColor Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SetRGBLEDColorMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SetRGBLEDColorMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new SetRGBLEDColorMethodState(parent);
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
           "AQAAACMAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9TZW5zZUhhdP////8EYYIKBAAAAAEADgAA" +
           "AFNldFJHQkxFRENvbG9yAQEXAAAvAQEXABcAAAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFy" +
           "Z3VtZW50cwEBGAAALgBEGAAAAJYDAAAAAQAqAQESAAAAAwAAAFJlZAAD/////wAAAAAAAQAqAQEUAAAA" +
           "BQAAAEdyZWVuAAP/////AAAAAAABACoBARMAAAAEAAAAQmx1ZQAD/////wAAAAAAAQAoAQEAAAABAAAA" +
           "AwAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public SetRGBLEDColorMethodStateMethodCallHandler OnCall;
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
    public delegate ServiceResult SetRGBLEDColorMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        byte red,
        byte green,
        byte blue);
    #endif
    #endregion

    #region RGBLEDState Class
    #if (!OPCUA_EXCLUDE_RGBLEDState)
    /// <summary>
    /// Stores an instance of the RGBLEDType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RGBLEDState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RGBLEDState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(UAServer.SenseHat.ObjectTypes.RGBLEDType, UAServer.SenseHat.Namespaces.SenseHat, namespaceUris);
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
           "AQAAACMAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9TZW5zZUhhdP////8EYIACAQAAAAEAEgAA" +
           "AFJHQkxFRFR5cGVJbnN0YW5jZQEBGQABARkAGQAAAP////8EAAAANWCJCgIAAAABAAMAAABSZWQBARoA" +
           "AwAAAAANAAAAUmVkIGludGVuc2l0eQAvAD8aAAAAAAP/////AQH/////AAAAADVgiQoCAAAAAQAFAAAA" +
           "R3JlZW4BARsAAwAAAAAPAAAAR3JlZW4gaW50ZW5zaXR5AC8APxsAAAAAA/////8BAf////8AAAAANWCJ" +
           "CgIAAAABAAQAAABCbHVlAQEcAAMAAAAADgAAAEJsdWUgaW50ZW5zaXR5AC8APxwAAAAAA/////8BAf//" +
           "//8AAAAABGGCCgQAAAABAAgAAABTZXRDb2xvcgEBHQAALwEBHQAdAAAAAQH/////AQAAABdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAR4AAC4ARB4AAACWAwAAAAEAKgEBEgAAAAMAAABSZWQAA/////8A" +
           "AAAAAAEAKgEBFAAAAAUAAABHcmVlbgAD/////wAAAAAAAQAqAQETAAAABAAAAEJsdWUAA/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAMAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<byte> Red
        {
            get
            {
                return m_red;
            }

            set
            {
                if (!Object.ReferenceEquals(m_red, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_red = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<byte> Green
        {
            get
            {
                return m_green;
            }

            set
            {
                if (!Object.ReferenceEquals(m_green, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_green = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<byte> Blue
        {
            get
            {
                return m_blue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_blue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_blue = value;
            }
        }

        /// <remarks />
        public SetRGBLEDColorMethodState SetColor
        {
            get
            {
                return m_setColorMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setColorMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setColorMethod = value;
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
            if (m_red != null)
            {
                children.Add(m_red);
            }

            if (m_green != null)
            {
                children.Add(m_green);
            }

            if (m_blue != null)
            {
                children.Add(m_blue);
            }

            if (m_setColorMethod != null)
            {
                children.Add(m_setColorMethod);
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
                case UAServer.SenseHat.BrowseNames.Red:
                {
                    if (createOrReplace)
                    {
                        if (Red == null)
                        {
                            if (replacement == null)
                            {
                                Red = new BaseDataVariableState<byte>(this);
                            }
                            else
                            {
                                Red = (BaseDataVariableState<byte>)replacement;
                            }
                        }
                    }

                    instance = Red;
                    break;
                }

                case UAServer.SenseHat.BrowseNames.Green:
                {
                    if (createOrReplace)
                    {
                        if (Green == null)
                        {
                            if (replacement == null)
                            {
                                Green = new BaseDataVariableState<byte>(this);
                            }
                            else
                            {
                                Green = (BaseDataVariableState<byte>)replacement;
                            }
                        }
                    }

                    instance = Green;
                    break;
                }

                case UAServer.SenseHat.BrowseNames.Blue:
                {
                    if (createOrReplace)
                    {
                        if (Blue == null)
                        {
                            if (replacement == null)
                            {
                                Blue = new BaseDataVariableState<byte>(this);
                            }
                            else
                            {
                                Blue = (BaseDataVariableState<byte>)replacement;
                            }
                        }
                    }

                    instance = Blue;
                    break;
                }

                case UAServer.SenseHat.BrowseNames.SetColor:
                {
                    if (createOrReplace)
                    {
                        if (SetColor == null)
                        {
                            if (replacement == null)
                            {
                                SetColor = new SetRGBLEDColorMethodState(this);
                            }
                            else
                            {
                                SetColor = (SetRGBLEDColorMethodState)replacement;
                            }
                        }
                    }

                    instance = SetColor;
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
        private BaseDataVariableState<byte> m_red;
        private BaseDataVariableState<byte> m_green;
        private BaseDataVariableState<byte> m_blue;
        private SetRGBLEDColorMethodState m_setColorMethod;
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
            return Opc.Ua.NodeId.Create(UAServer.SenseHat.ObjectTypes.SenseHatType, UAServer.SenseHat.Namespaces.SenseHat, namespaceUris);
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
           "AQAAACMAAABodHRwOi8vbWtlY3liZXJ0ZWNoLmNvbS9VQS9TZW5zZUhhdP////+EYIACAQAAAAEAFAAA" +
           "AFNlbnNlSGF0VHlwZUluc3RhbmNlAQEfAAEBHwAfAAAAAQIAAAAAMAABAS8AADABAQDNCAUAAAAEYIAK" +
           "AQAAAAEADAAAAE1hZ25ldG9tZXRlcgEBIAAALwEBAQAgAAAA/////wQAAAA1YIkKAgAAAAEAAQAAAFgB" +
           "ASEAAwAAAAANAAAAWC1heGlzIG91dHB1dAAvAD8hAAAAAAv/////AQH/////AAAAADVgiQoCAAAAAQAB" +
           "AAAAWQEBIgADAAAAAA0AAABZLWF4aXMgb3V0cHV0AC8APyIAAAAAC/////8BAf////8AAAAANWCJCgIA" +
           "AAABAAEAAABaAQEjAAMAAAAADQAAAFotYXhpcyBvdXRwdXQALwA/IwAAAAAL/////wEB/////wAAAAA1" +
           "YIkKAgAAAAEABQAAAFVuaXRzAQEkAAMAAAAADAAAAFNlbnNvciB1bml0cwAuAEQkAAAAAAz/////AQH/" +
           "////AAAAAARggAoBAAAAAQANAAAAQWNjZWxlcm9tZXRlcgEBJQAALwEBAQAlAAAA/////wQAAAA1YIkK" +
           "AgAAAAEAAQAAAFgBASYAAwAAAAANAAAAWC1heGlzIG91dHB1dAAvAD8mAAAAAAv/////AQH/////AAAA" +
           "ADVgiQoCAAAAAQABAAAAWQEBJwADAAAAAA0AAABZLWF4aXMgb3V0cHV0AC8APycAAAAAC/////8BAf//" +
           "//8AAAAANWCJCgIAAAABAAEAAABaAQEoAAMAAAAADQAAAFotYXhpcyBvdXRwdXQALwA/KAAAAAAL////" +
           "/wEB/////wAAAAA1YIkKAgAAAAEABQAAAFVuaXRzAQEpAAMAAAAADAAAAFNlbnNvciB1bml0cwAuAEQp" +
           "AAAAAAz/////AQH/////AAAAAARgwAoBAAAACwAAAEFuZ3VsYXJSYXRlAQATAAAAQW5ndWxhciByYXRl" +
           "IHNlbnNvcgEBKgAALwEBAQAqAAAA/////wQAAAA1YIkKAgAAAAEAAQAAAFgBASsAAwAAAAANAAAAWC1h" +
           "eGlzIG91dHB1dAAvAD8rAAAAAAv/////AQH/////AAAAADVgiQoCAAAAAQABAAAAWQEBLAADAAAAAA0A" +
           "AABZLWF4aXMgb3V0cHV0AC8APywAAAAAC/////8BAf////8AAAAANWCJCgIAAAABAAEAAABaAQEtAAMA" +
           "AAAADQAAAFotYXhpcyBvdXRwdXQALwA/LQAAAAAL/////wEB/////wAAAAA1YIkKAgAAAAEABQAAAFVu" +
           "aXRzAQEuAAMAAAAADAAAAFNlbnNvciB1bml0cwAuAEQuAAAAAAz/////AQH/////AAAAAIRgwAoBAAAA" +
           "CAAAAEpveXN0aWNrAQAnAAAARm91ci1kaXJlY3Rpb24gam95c3RpY2sgd2l0aCBwdXNoYnV0dG9uAQEv" +
           "AAAvAQERAC8AAAABAgAAAAAwAQEBHwAAJAABATQABQAAADVgiQoCAAAAAQACAAAAVXABATAAAwAAAAAM" +
           "AAAAVXAgZGlyZWN0aW9uAC8APzAAAAAAAf////8BAf////8AAAAANWCJCgIAAAABAAQAAABEb3duAQEx" +
           "AAMAAAAADgAAAERvd24gZGlyZWN0aW9uAC8APzEAAAAAAf////8BAf////8AAAAANWCJCgIAAAABAAQA" +
           "AABMZWZ0AQEyAAMAAAAADgAAAExlZnQgZGlyZWN0aW9uAC8APzIAAAAAAf////8BAf////8AAAAANWCJ" +
           "CgIAAAABAAUAAABSaWdodAEBMwADAAAAAA8AAABSaWdodCBkaXJlY3Rpb24ALwA/MwAAAAAB/////wEB" +
           "/////wAAAAA1YIkKAgAAAAEACgAAAFB1c2hidXR0b24BATQAAwAAAAAKAAAAUHVzaGJ1dHRvbgAvAD80" +
           "AAAAAAH/////AQEBAAAAACQBAQEvAAAAAAAEYMAKAQAAAAMAAABMRUQBAAcAAABSR0IgTEVEAQE1AAAv" +
           "AQEZADUAAAD/////BAAAADVgiQoCAAAAAQADAAAAUmVkAQE2AAMAAAAADQAAAFJlZCBpbnRlbnNpdHkA" +
           "LwA/NgAAAAAD/////wEB/////wAAAAA1YIkKAgAAAAEABQAAAEdyZWVuAQE3AAMAAAAADwAAAEdyZWVu" +
           "IGludGVuc2l0eQAvAD83AAAAAAP/////AQH/////AAAAADVgiQoCAAAAAQAEAAAAQmx1ZQEBOAADAAAA" +
           "AA4AAABCbHVlIGludGVuc2l0eQAvAD84AAAAAAP/////AQH/////AAAAAARhggoEAAAAAQAIAAAAU2V0" +
           "Q29sb3IBATkAAC8BAR0AOQAAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE6" +
           "AAAuAEQ6AAAAlgMAAAABACoBARIAAAADAAAAUmVkAAP/////AAAAAAABACoBARQAAAAFAAAAR3JlZW4A" +
           "A/////8AAAAAAAEAKgEBEwAAAAQAAABCbHVlAAP/////AAAAAAABACgBAQAAAAEAAAADAAAAAQH/////" +
           "AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
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
        public RGBLEDState LED
        {
            get
            {
                return m_lED;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lED, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lED = value;
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

            if (m_lED != null)
            {
                children.Add(m_lED);
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
                case UAServer.SenseHat.BrowseNames.Magnetometer:
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

                case UAServer.SenseHat.BrowseNames.Accelerometer:
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

                case UAServer.SenseHat.BrowseNames.AngularRate:
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

                case UAServer.SenseHat.BrowseNames.Joystick:
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

                case UAServer.SenseHat.BrowseNames.LED:
                {
                    if (createOrReplace)
                    {
                        if (LED == null)
                        {
                            if (replacement == null)
                            {
                                LED = new RGBLEDState(this);
                            }
                            else
                            {
                                LED = (RGBLEDState)replacement;
                            }
                        }
                    }

                    instance = LED;
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
        private Sensor3DState m_magnetometer;
        private Sensor3DState m_accelerometer;
        private Sensor3DState m_angularRate;
        private JoystickState m_joystick;
        private RGBLEDState m_lED;
        #endregion
    }
    #endif
    #endregion
}