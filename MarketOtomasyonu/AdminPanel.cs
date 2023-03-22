using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        private void buttonUser_Click(object sender, EventArgs e)
        {
            User ekle = new User();
            ekle.ShowDialog();
        }
        private void buttonProductOfficer_Click(object sender, EventArgs e)
        {
            ProductOfficerPanel ekle = new ProductOfficerPanel();
            ekle.ShowDialog();
        }
        private void buttonProcurementOfficer_Click(object sender, EventArgs e)
        {
            ProcurementOfficerPanel ekle = new ProcurementOfficerPanel();
            ekle.ShowDialog();
        }
        private void buttonCashier_Click(object sender, EventArgs e)
        {
            CashierPanel ekle = new CashierPanel();
            ekle.ShowDialog();
        }
        private void buttonUser_MouseMove(object sender, MouseEventArgs e)
        {
            buttonUser.BackColor = System.Drawing.ColorTranslator.FromHtml("#F3B37D");
        }
        private void buttonUser_MouseLeave(object sender, EventArgs e)
        {
            buttonUser.BackColor = Color.SandyBrown;
        }
        private void buttonProductOfficer_MouseMove(object sender, MouseEventArgs e)
        {
            buttonProductOfficer.BackColor = System.Drawing.ColorTranslator.FromHtml("#F3B37D");
        }
        private void buttonProductOfficer_MouseLeave(object sender, EventArgs e)
        {
            buttonProductOfficer.BackColor = Color.SandyBrown;
        }
        private void buttonProcurementOfficer_MouseMove(object sender, MouseEventArgs e)
        {
            buttonProcurementOfficer.BackColor = System.Drawing.ColorTranslator.FromHtml("#F3B37D");
        }
        private void buttonProcurementOfficer_MouseLeave(object sender, EventArgs e)
        {
            buttonProcurementOfficer.BackColor = Color.SandyBrown;
        }
        private void buttonCashier_MouseMove(object sender, MouseEventArgs e)
        {
            buttonCashier.BackColor = System.Drawing.ColorTranslator.FromHtml("#F3B37D");
        }
        private void buttonCashier_MouseLeave(object sender, EventArgs e)
        {
            buttonCashier.BackColor = Color.SandyBrown;
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }
    }
}
