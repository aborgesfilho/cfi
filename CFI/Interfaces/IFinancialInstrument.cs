using System;

namespace CFI.Interfaces
{
    interface IFinancialInstrument
    {
        double MarketValue { get; }
        string Type { get; }
    }
}
