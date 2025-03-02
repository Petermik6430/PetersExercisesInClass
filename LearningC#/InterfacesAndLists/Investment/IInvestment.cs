﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndLists.Investment
{
    internal interface IInvestment
    {
        public abstract string InvestSummary();

        public abstract int? PriceCalculate();
    }
}
