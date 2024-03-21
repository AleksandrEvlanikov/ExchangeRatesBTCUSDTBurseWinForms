using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bitget.Net.Clients;
using ExchangeRatesBTCUSDTBurseWinForms.Interfaces;

namespace ExchangeRatesBTCUSDTBurseWinForms.Exchanges
{
    internal class BitgetExchanges : IExchanges
    {
        private readonly BitgetSocketClient _client;

        public BitgetExchanges()
        {
            _client = new BitgetSocketClient();
        }

        public string Name => "Bitget";

        public async Task<decimal?> GetQuotesAsync(string pair)
        {
            decimal? lastPrice = -1;
            if (pair.Contains("/"))
            {
                pair = pair.Replace("/", "");
            }
            var subscriptionResult = await _client.SpotApi.SubscribeToTickerUpdatesAsync(pair, (update) =>
            {
                lastPrice = update.Data.LastPrice;
            });
            await Task.Delay(1000);

            return lastPrice;
        }
    }
}
