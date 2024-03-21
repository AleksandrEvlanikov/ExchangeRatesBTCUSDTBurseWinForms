using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesBTCUSDTBurseWinForms.Interfaces
{
    internal interface IExchanges
    {
        Task<decimal?> GetQuotesAsync(string pair);

        public abstract string Name { get; }
    }
}
