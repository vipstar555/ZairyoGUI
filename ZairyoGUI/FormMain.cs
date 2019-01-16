using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KabutanLib;

namespace ZairyoGUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var kabuCon = new KabutanPostgreSQLContext();
            var yahooCon = new YahooFinanceDbContext();

            var today = DateTime.Parse("2019/01/16").Date;
            var kabuItems = kabuCon.KaiziItems.Take(10).ToList();
            var yahooItems = yahooCon.TradeIndexs.Where(x => x.date == today).FirstOrDefault();
            
            return;
        }
    }
}
