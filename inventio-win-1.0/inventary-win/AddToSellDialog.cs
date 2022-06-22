using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inventio_win
{
    public partial class AddToSellDialog : Form
    {
        public static String id;
        public static String name;
        public static String price;

        public AddToSellDialog()
        {
            InitializeComponent();
            ix.Text = id;
            pname.Text = name;
            price_in.Text = price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellObj so = new SellObj();
            so.product_id = int.Parse(id);
            so.q = int.Parse(q.Text);
            SellObj.sell.Add(so);
            Dispose();
        }

        private void price_in_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(price_in.Text, "  ^ [0-9]"))
            {
                price_in.Text = "";
            }
        }

        private void ix_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ix.Text, "  ^ [0-9]"))
            {
                ix.Text = "";
            }
        }

        private void q_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(q.Text, "  ^ [0-9]"))
            {
                q.Text = "";
            }
        }
    }
}
