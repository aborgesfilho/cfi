using System;

namespace CFI.Interfaces
{
    interface IInstrumentInput
    {
        int InstrumentInputId { get; set; }
        string NickName { get; set; }
        double MarketValue { get; set; }
        string Type { get; set; }
        DateTime ProcessDate { get; set; }
    }
}
