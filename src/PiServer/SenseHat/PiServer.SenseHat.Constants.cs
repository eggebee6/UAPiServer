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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace PiServer.SenseHat
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the SetColor Method.
        /// </summary>
        public const uint SetColor = 22;

        /// <summary>
        /// The identifier for the LEDMatrixType_SetMatrixColor Method.
        /// </summary>
        public const uint LEDMatrixType_SetMatrixColor = 25;

        /// <summary>
        /// The identifier for the SenseHatType_LEDMatrix_SetMatrixColor Method.
        /// </summary>
        public const uint SenseHatType_LEDMatrix_SetMatrixColor = 49;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer Object.
        /// </summary>
        public const uint SenseHatType_Magnetometer = 30;

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer Object.
        /// </summary>
        public const uint SenseHatType_Accelerometer = 34;

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate Object.
        /// </summary>
        public const uint SenseHatType_AngularRate = 38;

        /// <summary>
        /// The identifier for the SenseHatType_Joystick Object.
        /// </summary>
        public const uint SenseHatType_Joystick = 42;

        /// <summary>
        /// The identifier for the SenseHatType_LEDMatrix Object.
        /// </summary>
        public const uint SenseHatType_LEDMatrix = 48;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the Sensor3DType ObjectType.
        /// </summary>
        public const uint Sensor3DType = 1;

        /// <summary>
        /// The identifier for the PushbuttonEventType ObjectType.
        /// </summary>
        public const uint PushbuttonEventType = 5;

        /// <summary>
        /// The identifier for the JoystickType ObjectType.
        /// </summary>
        public const uint JoystickType = 16;

        /// <summary>
        /// The identifier for the LEDMatrixType ObjectType.
        /// </summary>
        public const uint LEDMatrixType = 24;

        /// <summary>
        /// The identifier for the SenseHatType ObjectType.
        /// </summary>
        public const uint SenseHatType = 27;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the Sensor3DType_X Variable.
        /// </summary>
        public const uint Sensor3DType_X = 2;

        /// <summary>
        /// The identifier for the Sensor3DType_Y Variable.
        /// </summary>
        public const uint Sensor3DType_Y = 3;

        /// <summary>
        /// The identifier for the Sensor3DType_Z Variable.
        /// </summary>
        public const uint Sensor3DType_Z = 4;

        /// <summary>
        /// The identifier for the PushbuttonEventType_PushbuttonState Variable.
        /// </summary>
        public const uint PushbuttonEventType_PushbuttonState = 15;

        /// <summary>
        /// The identifier for the JoystickType_Up Variable.
        /// </summary>
        public const uint JoystickType_Up = 17;

        /// <summary>
        /// The identifier for the JoystickType_Down Variable.
        /// </summary>
        public const uint JoystickType_Down = 18;

        /// <summary>
        /// The identifier for the JoystickType_Left Variable.
        /// </summary>
        public const uint JoystickType_Left = 19;

        /// <summary>
        /// The identifier for the JoystickType_Right Variable.
        /// </summary>
        public const uint JoystickType_Right = 20;

        /// <summary>
        /// The identifier for the JoystickType_Pushbutton Variable.
        /// </summary>
        public const uint JoystickType_Pushbutton = 21;

        /// <summary>
        /// The identifier for the SetColor_InputArguments Variable.
        /// </summary>
        public const uint SetColor_InputArguments = 23;

        /// <summary>
        /// The identifier for the LEDMatrixType_SetMatrixColor_InputArguments Variable.
        /// </summary>
        public const uint LEDMatrixType_SetMatrixColor_InputArguments = 26;

        /// <summary>
        /// The identifier for the SenseHatType_Temperature Variable.
        /// </summary>
        public const uint SenseHatType_Temperature = 28;

        /// <summary>
        /// The identifier for the SenseHatType_Humidity Variable.
        /// </summary>
        public const uint SenseHatType_Humidity = 29;

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_X Variable.
        /// </summary>
        public const uint SenseHatType_Magnetometer_X = 31;

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_Y Variable.
        /// </summary>
        public const uint SenseHatType_Magnetometer_Y = 32;

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_Z Variable.
        /// </summary>
        public const uint SenseHatType_Magnetometer_Z = 33;

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_X Variable.
        /// </summary>
        public const uint SenseHatType_Accelerometer_X = 35;

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_Y Variable.
        /// </summary>
        public const uint SenseHatType_Accelerometer_Y = 36;

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_Z Variable.
        /// </summary>
        public const uint SenseHatType_Accelerometer_Z = 37;

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_X Variable.
        /// </summary>
        public const uint SenseHatType_AngularRate_X = 39;

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_Y Variable.
        /// </summary>
        public const uint SenseHatType_AngularRate_Y = 40;

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_Z Variable.
        /// </summary>
        public const uint SenseHatType_AngularRate_Z = 41;

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Up Variable.
        /// </summary>
        public const uint SenseHatType_Joystick_Up = 43;

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Down Variable.
        /// </summary>
        public const uint SenseHatType_Joystick_Down = 44;

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Left Variable.
        /// </summary>
        public const uint SenseHatType_Joystick_Left = 45;

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Right Variable.
        /// </summary>
        public const uint SenseHatType_Joystick_Right = 46;

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Pushbutton Variable.
        /// </summary>
        public const uint SenseHatType_Joystick_Pushbutton = 47;

        /// <summary>
        /// The identifier for the SenseHatType_LEDMatrix_SetMatrixColor_InputArguments Variable.
        /// </summary>
        public const uint SenseHatType_LEDMatrix_SetMatrixColor_InputArguments = 50;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the SetColor Method.
        /// </summary>
        public static readonly ExpandedNodeId SetColor = new ExpandedNodeId(PiServer.SenseHat.Methods.SetColor, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the LEDMatrixType_SetMatrixColor Method.
        /// </summary>
        public static readonly ExpandedNodeId LEDMatrixType_SetMatrixColor = new ExpandedNodeId(PiServer.SenseHat.Methods.LEDMatrixType_SetMatrixColor, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_LEDMatrix_SetMatrixColor Method.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_LEDMatrix_SetMatrixColor = new ExpandedNodeId(PiServer.SenseHat.Methods.SenseHatType_LEDMatrix_SetMatrixColor, PiServer.SenseHat.Namespaces.SenseHat);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer Object.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Magnetometer = new ExpandedNodeId(PiServer.SenseHat.Objects.SenseHatType_Magnetometer, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer Object.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Accelerometer = new ExpandedNodeId(PiServer.SenseHat.Objects.SenseHatType_Accelerometer, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate Object.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_AngularRate = new ExpandedNodeId(PiServer.SenseHat.Objects.SenseHatType_AngularRate, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Joystick Object.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Joystick = new ExpandedNodeId(PiServer.SenseHat.Objects.SenseHatType_Joystick, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_LEDMatrix Object.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_LEDMatrix = new ExpandedNodeId(PiServer.SenseHat.Objects.SenseHatType_LEDMatrix, PiServer.SenseHat.Namespaces.SenseHat);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the Sensor3DType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Sensor3DType = new ExpandedNodeId(PiServer.SenseHat.ObjectTypes.Sensor3DType, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the PushbuttonEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PushbuttonEventType = new ExpandedNodeId(PiServer.SenseHat.ObjectTypes.PushbuttonEventType, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the JoystickType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId JoystickType = new ExpandedNodeId(PiServer.SenseHat.ObjectTypes.JoystickType, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the LEDMatrixType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LEDMatrixType = new ExpandedNodeId(PiServer.SenseHat.ObjectTypes.LEDMatrixType, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType = new ExpandedNodeId(PiServer.SenseHat.ObjectTypes.SenseHatType, PiServer.SenseHat.Namespaces.SenseHat);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the Sensor3DType_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor3DType_X = new ExpandedNodeId(PiServer.SenseHat.Variables.Sensor3DType_X, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the Sensor3DType_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor3DType_Y = new ExpandedNodeId(PiServer.SenseHat.Variables.Sensor3DType_Y, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the Sensor3DType_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor3DType_Z = new ExpandedNodeId(PiServer.SenseHat.Variables.Sensor3DType_Z, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the PushbuttonEventType_PushbuttonState Variable.
        /// </summary>
        public static readonly ExpandedNodeId PushbuttonEventType_PushbuttonState = new ExpandedNodeId(PiServer.SenseHat.Variables.PushbuttonEventType_PushbuttonState, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the JoystickType_Up Variable.
        /// </summary>
        public static readonly ExpandedNodeId JoystickType_Up = new ExpandedNodeId(PiServer.SenseHat.Variables.JoystickType_Up, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the JoystickType_Down Variable.
        /// </summary>
        public static readonly ExpandedNodeId JoystickType_Down = new ExpandedNodeId(PiServer.SenseHat.Variables.JoystickType_Down, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the JoystickType_Left Variable.
        /// </summary>
        public static readonly ExpandedNodeId JoystickType_Left = new ExpandedNodeId(PiServer.SenseHat.Variables.JoystickType_Left, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the JoystickType_Right Variable.
        /// </summary>
        public static readonly ExpandedNodeId JoystickType_Right = new ExpandedNodeId(PiServer.SenseHat.Variables.JoystickType_Right, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the JoystickType_Pushbutton Variable.
        /// </summary>
        public static readonly ExpandedNodeId JoystickType_Pushbutton = new ExpandedNodeId(PiServer.SenseHat.Variables.JoystickType_Pushbutton, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SetColor_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SetColor_InputArguments = new ExpandedNodeId(PiServer.SenseHat.Variables.SetColor_InputArguments, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the LEDMatrixType_SetMatrixColor_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LEDMatrixType_SetMatrixColor_InputArguments = new ExpandedNodeId(PiServer.SenseHat.Variables.LEDMatrixType_SetMatrixColor_InputArguments, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Temperature Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Temperature = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_Temperature, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Humidity Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Humidity = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_Humidity, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Magnetometer_X = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_Magnetometer_X, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Magnetometer_Y = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_Magnetometer_Y, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Magnetometer_Z = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_Magnetometer_Z, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Accelerometer_X = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_Accelerometer_X, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Accelerometer_Y = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_Accelerometer_Y, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Accelerometer_Z = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_Accelerometer_Z, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_AngularRate_X = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_AngularRate_X, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_AngularRate_Y = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_AngularRate_Y, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_AngularRate_Z = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_AngularRate_Z, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Up Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Joystick_Up = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_Joystick_Up, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Down Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Joystick_Down = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_Joystick_Down, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Left Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Joystick_Left = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_Joystick_Left, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Right Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Joystick_Right = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_Joystick_Right, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Pushbutton Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Joystick_Pushbutton = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_Joystick_Pushbutton, PiServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_LEDMatrix_SetMatrixColor_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_LEDMatrix_SetMatrixColor_InputArguments = new ExpandedNodeId(PiServer.SenseHat.Variables.SenseHatType_LEDMatrix_SetMatrixColor_InputArguments, PiServer.SenseHat.Namespaces.SenseHat);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Accelerometer component.
        /// </summary>
        public const string Accelerometer = "Accelerometer";

        /// <summary>
        /// The BrowseName for the AngularRate component.
        /// </summary>
        public const string AngularRate = "Angular rate sensor";

        /// <summary>
        /// The BrowseName for the Down component.
        /// </summary>
        public const string Down = "Down";

        /// <summary>
        /// The BrowseName for the Humidity component.
        /// </summary>
        public const string Humidity = "Humidity";

        /// <summary>
        /// The BrowseName for the Joystick component.
        /// </summary>
        public const string Joystick = "Four-direction joystick with pushbutton";

        /// <summary>
        /// The BrowseName for the JoystickType component.
        /// </summary>
        public const string JoystickType = "JoystickType";

        /// <summary>
        /// The BrowseName for the LEDMatrix component.
        /// </summary>
        public const string LEDMatrix = "RGB LED Matrix";

        /// <summary>
        /// The BrowseName for the LEDMatrixType component.
        /// </summary>
        public const string LEDMatrixType = "LEDMatrixType";

        /// <summary>
        /// The BrowseName for the Left component.
        /// </summary>
        public const string Left = "Left";

        /// <summary>
        /// The BrowseName for the Magnetometer component.
        /// </summary>
        public const string Magnetometer = "Magnetometer";

        /// <summary>
        /// The BrowseName for the Pushbutton component.
        /// </summary>
        public const string Pushbutton = "Pushbutton";

        /// <summary>
        /// The BrowseName for the PushbuttonEventType component.
        /// </summary>
        public const string PushbuttonEventType = "PushbuttonEventType";

        /// <summary>
        /// The BrowseName for the PushbuttonState component.
        /// </summary>
        public const string PushbuttonState = "PushbuttonState";

        /// <summary>
        /// The BrowseName for the Right component.
        /// </summary>
        public const string Right = "Right";

        /// <summary>
        /// The BrowseName for the SenseHatType component.
        /// </summary>
        public const string SenseHatType = "SenseHatType";

        /// <summary>
        /// The BrowseName for the Sensor3DType component.
        /// </summary>
        public const string Sensor3DType = "Sensor3DType";

        /// <summary>
        /// The BrowseName for the SetColor component.
        /// </summary>
        public const string SetColor = "SetColor";

        /// <summary>
        /// The BrowseName for the SetMatrixColor component.
        /// </summary>
        public const string SetMatrixColor = "SetMatrixColor";

        /// <summary>
        /// The BrowseName for the Temperature component.
        /// </summary>
        public const string Temperature = "Temperature";

        /// <summary>
        /// The BrowseName for the Up component.
        /// </summary>
        public const string Up = "Up";

        /// <summary>
        /// The BrowseName for the X component.
        /// </summary>
        public const string X = "X";

        /// <summary>
        /// The BrowseName for the Y component.
        /// </summary>
        public const string Y = "Y";

        /// <summary>
        /// The BrowseName for the Z component.
        /// </summary>
        public const string Z = "Z";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the SenseHat namespace (.NET code namespace is 'PiServer.SenseHat').
        /// </summary>
        public const string SenseHat = "http://mkecybertech.com/UA/PiServer/SenseHat";
    }
    #endregion
}