using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySense.Core.Domain.ValueObjects
{
    public class Coin
    {
        public double Value { get; }

        public Coin(double value)
        {
            Value = value;
        }
    }
}
