using CFI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFI.Controllers.Interfaces
{
    interface IFinancialInstrumentController
    {
        InstrumentOutput GenerateAndBringOutput(string nickName, double marketValue, string type);
    }
}
