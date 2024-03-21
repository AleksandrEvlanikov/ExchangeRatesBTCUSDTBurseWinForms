using ExchangeRatesBTCUSDTBurseWinForms.Exchanges;
using ExchangeRatesBTCUSDTBurseWinForms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesBTCUSDTBurseWinForms.Services
{
    internal class ExchangeManager
    {
        private readonly IExchanges _exchanges;

        public ExchangeManager(IExchanges exchanges)
        {
            _exchanges = exchanges;
        }
        public IExchanges Exchange => _exchanges;
        public async Task<decimal?> GetQuotesAsync(string pair)
        {
            return await _exchanges.GetQuotesAsync(pair);
        }
    }
}
