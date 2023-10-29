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

namespace UAServer.SenseHat
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
        /// The identifier for the SetRGBLEDColor Method.
        /// </summary>
        public const uint SetRGBLEDColor = 23;

        /// <summary>
        /// The identifier for the RGBLEDType_SetColor Method.
        /// </summary>
        public const uint RGBLEDType_SetColor = 29;

        /// <summary>
        /// The identifier for the SenseHatType_LED_SetColor Method.
        /// </summary>
        public const uint SenseHatType_LED_SetColor = 57;
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
        public const uint SenseHatType_Magnetometer = 32;

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer Object.
        /// </summary>
        public const uint SenseHatType_Accelerometer = 37;

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate Object.
        /// </summary>
        public const uint SenseHatType_AngularRate = 42;

        /// <summary>
        /// The identifier for the SenseHatType_Joystick Object.
        /// </summary>
        public const uint SenseHatType_Joystick = 47;

        /// <summary>
        /// The identifier for the SenseHatType_LED Object.
        /// </summary>
        public const uint SenseHatType_LED = 53;
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
        public const uint PushbuttonEventType = 6;

        /// <summary>
        /// The identifier for the JoystickType ObjectType.
        /// </summary>
        public const uint JoystickType = 17;

        /// <summary>
        /// The identifier for the RGBLEDType ObjectType.
        /// </summary>
        public const uint RGBLEDType = 25;

        /// <summary>
        /// The identifier for the SenseHatType ObjectType.
        /// </summary>
        public const uint SenseHatType = 31;
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
        /// The identifier for the Sensor3DType_Units Variable.
        /// </summary>
        public const uint Sensor3DType_Units = 5;

        /// <summary>
        /// The identifier for the PushbuttonEventType_PushbuttonState Variable.
        /// </summary>
        public const uint PushbuttonEventType_PushbuttonState = 16;

        /// <summary>
        /// The identifier for the JoystickType_Up Variable.
        /// </summary>
        public const uint JoystickType_Up = 18;

        /// <summary>
        /// The identifier for the JoystickType_Down Variable.
        /// </summary>
        public const uint JoystickType_Down = 19;

        /// <summary>
        /// The identifier for the JoystickType_Left Variable.
        /// </summary>
        public const uint JoystickType_Left = 20;

        /// <summary>
        /// The identifier for the JoystickType_Right Variable.
        /// </summary>
        public const uint JoystickType_Right = 21;

        /// <summary>
        /// The identifier for the JoystickType_Pushbutton Variable.
        /// </summary>
        public const uint JoystickType_Pushbutton = 22;

        /// <summary>
        /// The identifier for the SetRGBLEDColor_InputArguments Variable.
        /// </summary>
        public const uint SetRGBLEDColor_InputArguments = 24;

        /// <summary>
        /// The identifier for the RGBLEDType_Red Variable.
        /// </summary>
        public const uint RGBLEDType_Red = 26;

        /// <summary>
        /// The identifier for the RGBLEDType_Green Variable.
        /// </summary>
        public const uint RGBLEDType_Green = 27;

        /// <summary>
        /// The identifier for the RGBLEDType_Blue Variable.
        /// </summary>
        public const uint RGBLEDType_Blue = 28;

        /// <summary>
        /// The identifier for the RGBLEDType_SetColor_InputArguments Variable.
        /// </summary>
        public const uint RGBLEDType_SetColor_InputArguments = 30;

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_X Variable.
        /// </summary>
        public const uint SenseHatType_Magnetometer_X = 33;

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_Y Variable.
        /// </summary>
        public const uint SenseHatType_Magnetometer_Y = 34;

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_Z Variable.
        /// </summary>
        public const uint SenseHatType_Magnetometer_Z = 35;

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_Units Variable.
        /// </summary>
        public const uint SenseHatType_Magnetometer_Units = 36;

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_X Variable.
        /// </summary>
        public const uint SenseHatType_Accelerometer_X = 38;

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_Y Variable.
        /// </summary>
        public const uint SenseHatType_Accelerometer_Y = 39;

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_Z Variable.
        /// </summary>
        public const uint SenseHatType_Accelerometer_Z = 40;

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_Units Variable.
        /// </summary>
        public const uint SenseHatType_Accelerometer_Units = 41;

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_X Variable.
        /// </summary>
        public const uint SenseHatType_AngularRate_X = 43;

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_Y Variable.
        /// </summary>
        public const uint SenseHatType_AngularRate_Y = 44;

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_Z Variable.
        /// </summary>
        public const uint SenseHatType_AngularRate_Z = 45;

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_Units Variable.
        /// </summary>
        public const uint SenseHatType_AngularRate_Units = 46;

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Up Variable.
        /// </summary>
        public const uint SenseHatType_Joystick_Up = 48;

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Down Variable.
        /// </summary>
        public const uint SenseHatType_Joystick_Down = 49;

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Left Variable.
        /// </summary>
        public const uint SenseHatType_Joystick_Left = 50;

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Right Variable.
        /// </summary>
        public const uint SenseHatType_Joystick_Right = 51;

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Pushbutton Variable.
        /// </summary>
        public const uint SenseHatType_Joystick_Pushbutton = 52;

        /// <summary>
        /// The identifier for the SenseHatType_LED_Red Variable.
        /// </summary>
        public const uint SenseHatType_LED_Red = 54;

        /// <summary>
        /// The identifier for the SenseHatType_LED_Green Variable.
        /// </summary>
        public const uint SenseHatType_LED_Green = 55;

        /// <summary>
        /// The identifier for the SenseHatType_LED_Blue Variable.
        /// </summary>
        public const uint SenseHatType_LED_Blue = 56;

        /// <summary>
        /// The identifier for the SenseHatType_LED_SetColor_InputArguments Variable.
        /// </summary>
        public const uint SenseHatType_LED_SetColor_InputArguments = 58;
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
        /// The identifier for the SetRGBLEDColor Method.
        /// </summary>
        public static readonly ExpandedNodeId SetRGBLEDColor = new ExpandedNodeId(UAServer.SenseHat.Methods.SetRGBLEDColor, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the RGBLEDType_SetColor Method.
        /// </summary>
        public static readonly ExpandedNodeId RGBLEDType_SetColor = new ExpandedNodeId(UAServer.SenseHat.Methods.RGBLEDType_SetColor, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_LED_SetColor Method.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_LED_SetColor = new ExpandedNodeId(UAServer.SenseHat.Methods.SenseHatType_LED_SetColor, UAServer.SenseHat.Namespaces.SenseHat);
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
        public static readonly ExpandedNodeId SenseHatType_Magnetometer = new ExpandedNodeId(UAServer.SenseHat.Objects.SenseHatType_Magnetometer, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer Object.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Accelerometer = new ExpandedNodeId(UAServer.SenseHat.Objects.SenseHatType_Accelerometer, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate Object.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_AngularRate = new ExpandedNodeId(UAServer.SenseHat.Objects.SenseHatType_AngularRate, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Joystick Object.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Joystick = new ExpandedNodeId(UAServer.SenseHat.Objects.SenseHatType_Joystick, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_LED Object.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_LED = new ExpandedNodeId(UAServer.SenseHat.Objects.SenseHatType_LED, UAServer.SenseHat.Namespaces.SenseHat);
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
        public static readonly ExpandedNodeId Sensor3DType = new ExpandedNodeId(UAServer.SenseHat.ObjectTypes.Sensor3DType, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the PushbuttonEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PushbuttonEventType = new ExpandedNodeId(UAServer.SenseHat.ObjectTypes.PushbuttonEventType, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the JoystickType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId JoystickType = new ExpandedNodeId(UAServer.SenseHat.ObjectTypes.JoystickType, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the RGBLEDType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId RGBLEDType = new ExpandedNodeId(UAServer.SenseHat.ObjectTypes.RGBLEDType, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType = new ExpandedNodeId(UAServer.SenseHat.ObjectTypes.SenseHatType, UAServer.SenseHat.Namespaces.SenseHat);
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
        public static readonly ExpandedNodeId Sensor3DType_X = new ExpandedNodeId(UAServer.SenseHat.Variables.Sensor3DType_X, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the Sensor3DType_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor3DType_Y = new ExpandedNodeId(UAServer.SenseHat.Variables.Sensor3DType_Y, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the Sensor3DType_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor3DType_Z = new ExpandedNodeId(UAServer.SenseHat.Variables.Sensor3DType_Z, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the Sensor3DType_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sensor3DType_Units = new ExpandedNodeId(UAServer.SenseHat.Variables.Sensor3DType_Units, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the PushbuttonEventType_PushbuttonState Variable.
        /// </summary>
        public static readonly ExpandedNodeId PushbuttonEventType_PushbuttonState = new ExpandedNodeId(UAServer.SenseHat.Variables.PushbuttonEventType_PushbuttonState, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the JoystickType_Up Variable.
        /// </summary>
        public static readonly ExpandedNodeId JoystickType_Up = new ExpandedNodeId(UAServer.SenseHat.Variables.JoystickType_Up, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the JoystickType_Down Variable.
        /// </summary>
        public static readonly ExpandedNodeId JoystickType_Down = new ExpandedNodeId(UAServer.SenseHat.Variables.JoystickType_Down, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the JoystickType_Left Variable.
        /// </summary>
        public static readonly ExpandedNodeId JoystickType_Left = new ExpandedNodeId(UAServer.SenseHat.Variables.JoystickType_Left, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the JoystickType_Right Variable.
        /// </summary>
        public static readonly ExpandedNodeId JoystickType_Right = new ExpandedNodeId(UAServer.SenseHat.Variables.JoystickType_Right, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the JoystickType_Pushbutton Variable.
        /// </summary>
        public static readonly ExpandedNodeId JoystickType_Pushbutton = new ExpandedNodeId(UAServer.SenseHat.Variables.JoystickType_Pushbutton, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SetRGBLEDColor_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SetRGBLEDColor_InputArguments = new ExpandedNodeId(UAServer.SenseHat.Variables.SetRGBLEDColor_InputArguments, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the RGBLEDType_Red Variable.
        /// </summary>
        public static readonly ExpandedNodeId RGBLEDType_Red = new ExpandedNodeId(UAServer.SenseHat.Variables.RGBLEDType_Red, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the RGBLEDType_Green Variable.
        /// </summary>
        public static readonly ExpandedNodeId RGBLEDType_Green = new ExpandedNodeId(UAServer.SenseHat.Variables.RGBLEDType_Green, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the RGBLEDType_Blue Variable.
        /// </summary>
        public static readonly ExpandedNodeId RGBLEDType_Blue = new ExpandedNodeId(UAServer.SenseHat.Variables.RGBLEDType_Blue, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the RGBLEDType_SetColor_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RGBLEDType_SetColor_InputArguments = new ExpandedNodeId(UAServer.SenseHat.Variables.RGBLEDType_SetColor_InputArguments, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Magnetometer_X = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_Magnetometer_X, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Magnetometer_Y = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_Magnetometer_Y, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Magnetometer_Z = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_Magnetometer_Z, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Magnetometer_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Magnetometer_Units = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_Magnetometer_Units, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Accelerometer_X = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_Accelerometer_X, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Accelerometer_Y = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_Accelerometer_Y, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Accelerometer_Z = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_Accelerometer_Z, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Accelerometer_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Accelerometer_Units = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_Accelerometer_Units, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_AngularRate_X = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_AngularRate_X, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_AngularRate_Y = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_AngularRate_Y, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_AngularRate_Z = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_AngularRate_Z, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_AngularRate_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_AngularRate_Units = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_AngularRate_Units, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Up Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Joystick_Up = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_Joystick_Up, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Down Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Joystick_Down = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_Joystick_Down, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Left Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Joystick_Left = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_Joystick_Left, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Right Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Joystick_Right = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_Joystick_Right, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_Joystick_Pushbutton Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_Joystick_Pushbutton = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_Joystick_Pushbutton, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_LED_Red Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_LED_Red = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_LED_Red, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_LED_Green Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_LED_Green = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_LED_Green, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_LED_Blue Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_LED_Blue = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_LED_Blue, UAServer.SenseHat.Namespaces.SenseHat);

        /// <summary>
        /// The identifier for the SenseHatType_LED_SetColor_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SenseHatType_LED_SetColor_InputArguments = new ExpandedNodeId(UAServer.SenseHat.Variables.SenseHatType_LED_SetColor_InputArguments, UAServer.SenseHat.Namespaces.SenseHat);
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
        /// The BrowseName for the Blue component.
        /// </summary>
        public const string Blue = "Blue";

        /// <summary>
        /// The BrowseName for the Down component.
        /// </summary>
        public const string Down = "Down";

        /// <summary>
        /// The BrowseName for the Green component.
        /// </summary>
        public const string Green = "Green";

        /// <summary>
        /// The BrowseName for the Joystick component.
        /// </summary>
        public const string Joystick = "Four-direction joystick with pushbutton";

        /// <summary>
        /// The BrowseName for the JoystickType component.
        /// </summary>
        public const string JoystickType = "JoystickType";

        /// <summary>
        /// The BrowseName for the LED component.
        /// </summary>
        public const string LED = "RGB LED";

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
        /// The BrowseName for the Red component.
        /// </summary>
        public const string Red = "Red";

        /// <summary>
        /// The BrowseName for the RGBLEDType component.
        /// </summary>
        public const string RGBLEDType = "RGBLEDType";

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
        /// The BrowseName for the SetRGBLEDColor component.
        /// </summary>
        public const string SetRGBLEDColor = "SetRGBLEDColor";

        /// <summary>
        /// The BrowseName for the Units component.
        /// </summary>
        public const string Units = "Units";

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
        /// The URI for the SenseHat namespace (.NET code namespace is 'UAServer.SenseHat').
        /// </summary>
        public const string SenseHat = "http://mkecybertech.com/UA/SenseHat";
    }
    #endregion
}