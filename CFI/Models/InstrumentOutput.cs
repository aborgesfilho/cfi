using CFI.Interfaces;
using System;

namespace CFI.Models
{
    public class InstrumentOutput : IInstrumentOutput
    {
        public int InstrumentOutputId { get; set; }
        public string NickName { get; set; }
        public double MarketValue { get; set; }
        public string Type { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryDescription { get; set; }
        public DateTime ProcessDate { get; set; }
    }
}
