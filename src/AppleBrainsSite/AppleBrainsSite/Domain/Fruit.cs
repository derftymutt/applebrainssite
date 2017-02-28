﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppleBrainsSite.Domain
{
    public class Fruit
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string UserId { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModfied { get; set; }
    }
}