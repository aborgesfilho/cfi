using System;

namespace CFI.Interfaces
{
    interface IInstrumentOutput
    {
        int InstrumentOutputId { get; set; }
        string NickName { get; set; }
        double MarketValue { get; set; }
        string Type { get; set; }
        string CategoryCode { get; set; }
        string CategoryDescription { get; set; }
        DateTime ProcessDate { get; set; }
    }
}
