using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bybit.Net.Clients;
using ExchangeRatesBTCUSDTBurseWinForms.Interfaces;
using Kucoin.Net.Clients;

namespace ExchangeRatesBTCUSDTBurseWinForms.Exchanges
{
    internal class KucoinExchanges : IExchanges
    {
        private readonly KucoinSocketClient _client;

        public KucoinExchanges()
        {
            _client = new KucoinSocketClient();
        }

        public string Name => "Kucoin";

        public async Task<decimal?> GetQuotesAsync(string pair)
        {
            decimal? lastPrice = -1;
            if (pair.Contains("/"))
            {
                pair = pair.Replace("/", "-");
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
