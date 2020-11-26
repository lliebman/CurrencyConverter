using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyProj
{
    public partial class CurrencyConverterForm : Form
    {
        private static readonly CurrencyConverter currencyConverter = new CurrencyConverter();
        private List<ICurrency> allCurrencies = new List<ICurrency>();
        private USD usd;
        private CAD cad;
        private GBP gbp;
        private EUR eur;
        private NIS nis;
        private JPY jpy;
        private AUD aud;

        public CurrencyConverterForm()
        {
            InitializeComponent();
            InitializeCurrencies();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void USDQuant_TextChanged(object sender, EventArgs e)
        {
            usd.Quantity = USDQuant.Text;
            currencyConverter.covertFromQuantity(usd, allCurrencies);
            UpdateQuantityTextBoxes();
        }


        private void GBP_Quant_TextChanged(object sender, EventArgs e)
        {
            gbp.Quantity = GBPQuant.Text;
            currencyConverter.covertFromQuantity(gbp, allCurrencies);
            UpdateQuantityTextBoxes();
        }

        private void CAD_Quant_TextChanged(object sender, EventArgs e)
        {
            cad.Quantity = CADQuant.Text;
            currencyConverter.covertFromQuantity(cad, allCurrencies);
            UpdateQuantityTextBoxes();
        }

        private void EUR_Quant_TextChanged(object sender, EventArgs e)
        {
            eur.Quantity = EURQuant.Text;
            currencyConverter.covertFromQuantity(eur, allCurrencies);
            UpdateQuantityTextBoxes();
        }

        private void NIS_Quant_TextChanged(object sender, EventArgs e)
        {
            nis.Quantity = NISQuant.Text;
            currencyConverter.covertFromQuantity(nis, allCurrencies);
            UpdateQuantityTextBoxes();
        }

        private void JPY_Quant_TextChanged(object sender, EventArgs e)
        {
            jpy.Quantity = JPYQuant.Text;
            currencyConverter.covertFromQuantity(jpy, allCurrencies);
            UpdateQuantityTextBoxes();
        }

        private void AUD_Quant_TextChanged(object sender, EventArgs e)
        {
            aud.Quantity = AUDQuant.Text;
            currencyConverter.covertFromQuantity(aud, allCurrencies);
            UpdateQuantityTextBoxes();
        }

        private void CAD_Rate_TextChanged(object sender, EventArgs e)
        {
            cad.Rate = CADRate.Text;
            currencyConverter.convertFromRate(cad, usd.Quantity);
            CADQuant.Text = cad.Quantity;
        }

        private void GBP_Rate_TextChanged(object sender, EventArgs e)
        {
            gbp.Rate = GBPRate.Text;
            currencyConverter.convertFromRate(gbp, usd.Quantity);
            GBPQuant.Text = gbp.Quantity;
        }

        private void EUR_Rate_TextChanged(object sender, EventArgs e)
        {
            eur.Rate = EURRate.Text;
            currencyConverter.convertFromRate(eur, usd.Quantity);
            EURQuant.Text = eur.Quantity;
        }

        private void NIS_Rate_TextChanged(object sender, EventArgs e)
        {
            nis.Rate = NISRate.Text;
            currencyConverter.convertFromRate(nis, usd.Quantity);
            NISQuant.Text = nis.Quantity;
        }

        private void JPY_Rate_TextChanged(object sender, EventArgs e)
        {
            jpy.Rate = JPYRate.Text;
            currencyConverter.convertFromRate(jpy, usd.Quantity);
            JPYQuant.Text = jpy.Quantity;
        }

        private void AUD_Rate_TextChanged(object sender, EventArgs e)
        {
            aud.Rate = AUDRate.Text;
            currencyConverter.convertFromRate(aud, usd.Quantity);
            AUDQuant.Text = aud.Quantity;
        }

        private void InitializeCurrencies()
        {
            usd = new USD("1", USDQuant.Text);
            cad = new CAD(CADRate.Text, CADQuant.Text);
            gbp = new GBP(GBPRate.Text, GBPQuant.Text);
            eur = new EUR(EURRate.Text, EURQuant.Text);
            nis = new NIS(NISRate.Text, NISQuant.Text);
            jpy = new JPY(JPYRate.Text, JPYQuant.Text);
            aud = new AUD(AUDRate.Text, AUDQuant.Text);
            allCurrencies.Add(usd);
            allCurrencies.Add(cad);
            allCurrencies.Add(gbp);
            allCurrencies.Add(eur);
            allCurrencies.Add(nis);
            allCurrencies.Add(jpy);
            allCurrencies.Add(aud);
        }

        private void UpdateQuantityTextBoxes()
        {
            USDQuant.Text = usd.Quantity;
            CADQuant.Text = cad.Quantity;
            GBPQuant.Text = gbp.Quantity;
            EURQuant.Text = eur.Quantity;
            NISQuant.Text = nis.Quantity;
            JPYQuant.Text = jpy.Quantity;
            AUDQuant.Text = aud.Quantity;
            USDQuant.Text = usd.Quantity;
        }
    }
}
