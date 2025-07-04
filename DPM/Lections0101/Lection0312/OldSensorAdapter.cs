﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lection0312
{
    public class OldSensorAdapter : IDevice
    {
        private readonly OldSensor _sensor = new();

        public int GetData()
        {
            var data = _sensor.ReadDataPort();
            data = data.Replace("t=", "");
            data = data.Split(' ')[0];
            return int.Parse(data);
        }
    }
}