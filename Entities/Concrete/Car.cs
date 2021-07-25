﻿
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarID { get; set; }
        public string Model { get; set; }
        public short CarYear { get; set; }
        public string Category { get; set; }
    }
}
