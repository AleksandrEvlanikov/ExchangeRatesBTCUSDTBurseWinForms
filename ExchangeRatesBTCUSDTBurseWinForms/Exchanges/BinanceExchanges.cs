using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Binance.Net.Clients;
using Binance.Net.Objects.Models.Spot;
using CryptoExchange.Net.CommonObjects;
using ExchangeRatesBTCUSDTBurseWinForms.Interfaces;

namespace ExchangeRatesBTCUSDTBurseWinForms.Exchanges
{
    internal class BinanceExchanges : IExchanges
    {

        private readonly BinanceSocketClient _client;

        public BinanceExchanges()
        {
            _client = new BinanceSocketClient();
        }

        public string Name => "Binance";

        public async Task<decimal?> GetQuotesAsync(string pair)
        {
            
            decimal? lastPrice = -1;
            if (pair.Contains("/"))
            {
                pair = pair.Replace("/", "");
            }

            var subscriptionResult = await _client.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync(pair, (update) =>
            {
                lastPrice = update.Data.LastPrice;
                Console.WriteLine($"Последняя цена {pair}: {lastPrice}");

            });
            await Task.Delay(1000);

            return lastPrice;
        }
    }
}
