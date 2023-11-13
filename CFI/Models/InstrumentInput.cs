using CFI.Interfaces;
using System;

namespace CFI.Models
{
    public class InstrumentInput : IInstrumentInput
    {
        public int InstrumentInputId { get; set; }
        public string NickName { get; set; }
        public double MarketValue { get; set; }
        public string Type { get; set; }
        public DateTime ProcessDate { get; set; }
    }
}
