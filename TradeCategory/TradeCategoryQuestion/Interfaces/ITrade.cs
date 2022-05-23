using System;
using System.Collections.Generic;
using System.Text;

namespace TradeCategoryQuestion.Interfaces
{
    public interface ITrade
    {
        double Value { get; } // Indicates the transaction amount in dollars
        string ClientSector { get; } // Indicates the client's sector which can be "Public" or "Private"
        DateTime NextPaymentDate { get; } //Indicates when the next payment from the client to the bank is expected
    }
}
