﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySense.Core.Domain.ValueObjects
{
    public class Description
    {
        public Description(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }
}
