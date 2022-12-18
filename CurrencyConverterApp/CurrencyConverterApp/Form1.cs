using System.Xml;

namespace CurrencyConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
  

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string TcmbLink = "https://www.tcmb.gov.tr/kurlar/today.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(TcmbLink);

            string USDbuy = doc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            USDBuyText.Text = USDbuy;
            string USDsell = doc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            USDSellText.Text = USDsell;
            string Eurobuy = doc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            EuroBuyText.Text = Eurobuy;
            string Eurosell = doc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            EuroSellText.Text = Eurosell;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrencyTxtbox.Text = USDBuyText.Text;
        }

        private void CurrencyTxtbox_TextChanged(object sender, EventArgs e)
        {
            CurrencyTxtbox.Text = CurrencyTxtbox.Text.Replace(".", ",");
        }

        private void UsdSellBtn_Click(object sender, EventArgs e)
        {
            CurrencyTxtbox.Text = USDSellText.Text;
        }

        private void EuroBuyBtn_Click(object sender, EventArgs e)
        {
            CurrencyTxtbox.Text = EuroBuyText.Text;
        }

        private void EuroSellBtn_Click(object sender, EventArgs e)
        {
            CurrencyTxtbox.Text = EuroSellText.Text;
        }

        decimal currency, amount, total, remain;

        private void TotalTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reversebtn_Click(object sender, EventArgs e)
        {
            currency = decimal.Parse(CurrencyTxtbox.Text);
            amount = decimal.Parse(AmountTxtbox.Text);
            total = amount / currency;
            remain = amount % currency;
            TotalTxtbox.Text = Math.Round(total,2).ToString();
            RemainingTxtbox.Text = Math.Round(remain,2).ToString(); 
           
        }

        private void CurrencyTxtbox_TextChanged_1(object sender, EventArgs e)
        {
            CurrencyTxtbox.Text = CurrencyTxtbox.Text.Replace(".", ",");
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            currency = decimal.Parse(CurrencyTxtbox.Text);
            amount = decimal.Parse(AmountTxtbox.Text);
            total = currency * amount;
            TotalTxtbox.Text = total.ToString();
        }
    }
}