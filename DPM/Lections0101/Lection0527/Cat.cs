using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection0527
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public string FullInfo => $"{Name}, возраст: {Age}";
    }
}