using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bybit.Net.Clients;
using ExchangeRatesBTCUSDTBurseWinForms.Interfaces;

namespace ExchangeRatesBTCUSDTBurseWinForms.Exchanges
{
    internal class BybitExchanges : IExchanges
    {
        private readonly BybitSocketClient _client;

        public BybitExchanges()
        {
            _client = new BybitSocketClient();
        }

        public string Name => "Bybit";

        public async Task<decimal?> GetQuotesAsync(string pair)
        {
            decimal? lastPrice = -1;
            if (pair.Contains("/"))
            {
                pair = pair.Replace("/", "");
            }
            var subscriptionResult = await _client.V5SpotApi.SubscribeToTickerUpdatesAsync(pair, (update) =>
            {
                lastPrice = update.Data.LastPrice;
            });
            await Task.Delay(1000);

            return lastPrice;
        }
    }
}
