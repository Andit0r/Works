﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lection0312
{
    public class DataService : IService
    {
        public void Execute() 
            => Console.WriteLine("data process...");
    }
}