﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureValue
{
    public class General
    {
        /// <summary>
        /// Return the future value.
        /// </summary>
        /// <param name="presentValue">
        /// The current value of something
        /// </param>
        /// <param name="rate">
        /// The current interest rate
        /// </param>
        /// <param name="time">
        /// The duration.
        /// </param>
        /// <returns></returns>
        public double SimpleInterest(double presentValue, double rate, int time)
        {
            return presentValue * (1 + rate * time);
        }


        public double CompoundInterest(double presentValue, double rate, int time)
        {
            return presentValue * Math.Pow((1 + rate), time);
        }

    }
}
