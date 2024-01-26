using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using PiServer.SenseHat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
  internal class SenseHat : ISenseHat
  {
    private readonly Iot.Device.SenseHat.SenseHat senseHat;

    public event EventHandler TemperatureChanged;
    public event EventHandler HumidityChanged;
    public event EventHandler MagnetometerChanged;
    public event EventHandler AccelerometerChanged;
    public event EventHandler AngularRateChanged;
    public event EventHandler JoystickChanged;

    private readonly Timer updateTimer;

    public SenseHat()
    {
      senseHat = new Iot.Device.SenseHat.SenseHat();
      if (senseHat is null)
      {
        throw new Exception("Failed to create Sense HAT device object");
      }

      updateTimer = new Timer(
        InvokeUpdates,
        null,
        TimeSpan.FromSeconds(0.25),
        TimeSpan.FromSeconds(0.25));
    }

    private void InvokeUpdates(object? state)
    {
      TemperatureChanged?.Invoke(this, new EventArgs());
      HumidityChanged?.Invoke(this, new EventArgs());
      MagnetometerChanged?.Invoke(this, new EventArgs());
      AccelerometerChanged?.Invoke(this, new EventArgs());
      AngularRateChanged?.Invoke(this, new EventArgs());
      JoystickChanged?.Invoke(this, new EventArgs());
    }

    public double Temperature =>
      (senseHat.Temperature.DegreesCelsius + senseHat.Temperature2.DegreesCelsius) / 2.0;

    public double Humidity => senseHat.Humidity.Percent;

    public (double, double, double) Magnetometer => _Magnetometer();
    private (double, double, double) _Magnetometer()
    {
      var reading = senseHat.Magnetometer.MagneticInduction;
      return (reading.X, reading.Y, reading.Z);
    }

    public (double, double, double) Accelerometer =>
      (senseHat.Acceleration.X, senseHat.Acceleration.Y, senseHat.Acceleration.Z);

    public (double, double, double) AngularRate =>
      (senseHat.AngularRate.X, senseHat.AngularRate.Y, senseHat.AngularRate.Z);

    public (bool, bool, bool, bool, bool) Joystick =>
      (senseHat.Joystick.HoldingUp,
      senseHat.Joystick.HoldingDown,
      senseHat.Joystick.HoldingLeft,
      senseHat.Joystick.HoldingRight,
      senseHat.Joystick.HoldingButton);

    public void SetMatrixColor(byte red, byte green, byte blue)
    {
      senseHat.LedMatrix.Fill(System.Drawing.Color.FromArgb(red, green, blue));
    }
  }
}
