﻿using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RouteManager.v2.Logging.Logger;

namespace RouteManager.v2.dataStructures
{
    public class Settings
    {
        public static logLevel currentLogLevel  = logLevel.Informational;

        public static float minDieselQuantity   = 100;

        public static float minWaterQuantity    = 500;

        public static float minCoalQuantity     = 0.5f;
    }
}
