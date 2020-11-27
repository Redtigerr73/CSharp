using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeBonneOeuvre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void labelCommentaire_Click(object sender, EventArgs e)
        {
            labelCommentaire.Text = comboBox1.SelectedItem.ToString();

            switch (labelCommentaire.Text)
            {
                case "1":
                    labelCommentaire.Text = "Ok";
                    break;
                case "10":
                    labelCommentaire.Text = "Cool";
                    break;
                case "100":
                    labelCommentaire.Text = "Waow";
                    break;
                case "1000":
                    labelCommentaire.Text = "Génial";
                    break;
                default:
                    break;
            }
        }

        private void label1Confirmation_Click(object sender, EventArgs e)
        {

        }

        private void button1Confirmer_Click(object sender, EventArgs e)
        {
            label1Confirmation.Text = "Merci pour votre don de " + comboBox1.SelectedItem.ToString();
        }
    }
}
