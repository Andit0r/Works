﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lection0312
{
    public class Subscriber
    {
        public void OnVideoPublished(string title) 
            => Console.WriteLine($"смотри {title}");
    }
}