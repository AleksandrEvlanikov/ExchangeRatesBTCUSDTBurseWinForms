using ExchangeRatesBTCUSDTBurseWinForms.Exchanges;
using ExchangeRatesBTCUSDTBurseWinForms.Services;

namespace ExchangeRatesBTCUSDTBurseWinForms
{
    public partial class ExchangeQuotesDesktop : Form
    {
        ExchangeManager exchangeManagerBinance;
        ExchangeManager exchangeManagerBybit;
        ExchangeManager exchangeManagerBitget;
        ExchangeManager exchangeManagerKucoin;
        private bool timetIncluded = false;

        public ExchangeQuotesDesktop()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dropDownList.Items.Add("BTC/USDT");
            dropDownList.Items.Add("ETH/USDT");
            BinanceExchanges binanceExchanges = new BinanceExchanges();
            BitgetExchanges bitGetExchanges = new BitgetExchanges();
            BybitExchanges bybitExchanges = new BybitExchanges();
            KucoinExchanges kucoinExchanges = new KucoinExchanges();
            exchangeManagerBinance = new ExchangeManager(binanceExchanges);
            exchangeManagerBitget = new ExchangeManager(bitGetExchanges);
            exchangeManagerBybit = new ExchangeManager(bybitExchanges);
            exchangeManagerKucoin = new ExchangeManager(kucoinExchanges);

        }

        private async void TimerTick(object sender, EventArgs e)
        {
            await UpdateCourses();
        }

        private async Task UpdateCourses()
        {
            if (dropDownList.SelectedItem != null)
            {
                string selectePair = dropDownList.SelectedItem.ToString();

                Task<decimal?> taskBinance = exchangeManagerBinance.GetQuotesAsync(selectePair);
                Task<decimal?> taskBitget = exchangeManagerBitget.GetQuotesAsync(selectePair);
                Task<decimal?> taskBybit = exchangeManagerBybit.GetQuotesAsync(selectePair);
                Task<decimal?> taskKucoin = exchangeManagerKucoin.GetQuotesAsync(selectePair);

                await Task.WhenAll(taskBinance, taskBitget, taskBybit, taskKucoin);

                decimal? quotesBinance = taskBinance.Result;
                decimal? quotesBitget = taskBitget.Result;
                decimal? quotesBybit = taskBybit.Result;
                decimal? quotesKucoin = taskKucoin.Result;

                TextInApplication(selectePair,quotesBinance, quotesBitget, quotesBybit, quotesKucoin);
            }
            else
            {
                textBoxBinance.Text = "Выберите пару из списка.";
                textBoxBitget.Text = "Выберите пару из списка.";
                textBoxBybit.Text = "Выберите пару из списка.";
                textBoxKucoin.Text = "Выберите пару из списка.";
                textBoxAll.Text = "Выберите пару из списка.";
            }
        }

        private void TextInApplication(string selectePair, decimal? quotesBinance, decimal? quotesBitget, decimal? quotesBybit, decimal? quotesKucoin)
        {
            textBoxBinance.Text = $"{exchangeManagerBinance.Exchange.Name}: {selectePair} => {quotesBinance}";
            textBoxBitget.Text = $"{exchangeManagerBitget.Exchange.Name}: {selectePair} => {quotesBitget}";
            textBoxBybit.Text = $"{exchangeManagerBybit.Exchange.Name}: {selectePair} => {quotesBybit}";
            textBoxKucoin.Text = $"{exchangeManagerKucoin.Exchange.Name}: {selectePair} => {quotesKucoin}";
            textBoxAll.Text =
                $"{exchangeManagerBinance.Exchange.Name}: {selectePair} => {quotesBinance}" + Environment.NewLine +
                $"{exchangeManagerBitget.Exchange.Name}: {selectePair} => {quotesBitget}" + Environment.NewLine +
                $"{exchangeManagerBybit.Exchange.Name}: {selectePair} => {quotesBybit}" + Environment.NewLine +
                $"{exchangeManagerKucoin.Exchange.Name}: {selectePair} => {quotesKucoin}";

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if(!timetIncluded)
            {
                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 5000;
                timer.Tick += TimerTick;
                timer.Start();
                timetIncluded = true;
            }
        }

    }
}
