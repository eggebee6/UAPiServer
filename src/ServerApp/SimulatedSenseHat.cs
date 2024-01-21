using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using PiServer.SenseHat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerApp
{
  internal class SimulatedSenseHat : ISenseHat
  {
    private readonly Random rng = new Random();

    public event EventHandler TemperatureChanged;
    public event EventHandler HumidityChanged;
    public event EventHandler MagnetometerChanged;
    public event EventHandler AccelerometerChanged;
    public event EventHandler AngularRateChanged;
    public event EventHandler JoystickChanged;

    private readonly ILogger<ISenseHat> logger;
    private readonly Timer updateTimer;

    public SimulatedSenseHat(LoggerFactory loggerFactory)
    {
      logger = loggerFactory?.CreateLogger<ISenseHat>() ?? new NullLogger<ISenseHat>();

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

    public double Temperature => (rng.NextDouble() * 60) + 10;

    public double Humidity => (rng.NextDouble() * 30) + 20;

    public (double, double, double) Magnetometer => 
      (rng.NextDouble() * 22e-6, rng.NextDouble() * 22e-6, rng.NextDouble() * 22e-6);

    public (double, double, double) Accelerometer =>
      (rng.NextDouble() * 0.3, rng.NextDouble() * 0.3, rng.NextDouble() * 0.3);

    public (double, double, double) AngularRate =>
      (rng.NextDouble(), rng.NextDouble(), rng.NextDouble());

    public (bool, bool, bool, bool, bool) Joystick =>
      (rng.NextDouble() > 0.75,
      rng.NextDouble() > 0.75,
      rng.NextDouble() > 0.75,
      rng.NextDouble() > 0.75,
      rng.NextDouble() > 0.95);

    public void SetMatrixColor(byte red, byte green, byte blue)
    {
      string msg = $"LED matrix changed: {red} red, {green} green, {blue} blue";
      logger.LogInformation(msg);
    }
  }
}
