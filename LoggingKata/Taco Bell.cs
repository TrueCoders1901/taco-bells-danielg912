﻿using System;
using System.Collections.Generic;
using System.Text;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class TacoBell : ITrackable
    {
        public string Name { get; set; }
        public Point Location { get; set; }
    }
}
