using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiServer.SenseHat
{
  public interface ISenseHat
  {
    /// <summary>Get temperature reading</summary>
    /// <returns>Temperature reading</returns>
    public double Temperature { get; }
    event EventHandler TemperatureChanged;

    /// <summary>Get humidity reading</summary>
    /// <returns>Humidity reading</returns>
    public double Humidity { get; }
    event EventHandler HumidityChanged;

    /// <summary>Get magnetometer reading</summary>
    /// <returns>(X, Y, Z) of magnetometer reading</returns>
    public (double, double, double) Magnetometer { get; }
    event EventHandler MagnetometerChanged;

    /// <summary>Get accelerometer reading</summary>
    /// <returns>(X, Y, Z) of accelerometer reading</returns>
    public (double, double, double) Accelerometer { get; }
    event EventHandler AccelerometerChanged;

    /// <summary>Get angular rate reading</summary>
    /// <returns>(X, Y, Z) of angular rate reading</returns>
    public (double, double, double) AngularRate { get; }
    event EventHandler AngularRateChanged;

    /// <summary>Get joystick state</summary>
    /// <returns>(Up, Down, Left, Right, Pushbutton) of joystick</returns>
    public (bool, bool, bool, bool, bool) Joystick { get; }
    event EventHandler JoystickChanged;

    /// <summary>Set the LED matrix color</summary>
    /// <param name="red">Red intensity</param>
    /// <param name="green">Green intensity</param>
    /// <param name="blue">Blue intensity</param>
    void SetMatrixColor(byte red, byte green, byte blue);
  }
}
