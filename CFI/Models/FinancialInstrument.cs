using CFI.DB;
using CFI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFI.Models
{
    public class FinancialInstrument : IFinancialInstrument
    {
        private readonly DbSession db;
        public FinancialInstrument()
        {

        }

        public double MarketValue { get; private set; }
        public string Type { get; private set; }

        public InstrumentOutput InstrumentOutput { get; private set; }
    }
}
