using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2020
{
    public partial class Recomposition : Form
    {
        public Recomposition()
        {
            InitializeComponent();
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form FormDécomposition = new Décomposition();
            FormDécomposition.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form FormSignal = new Signal();
            FormSignal.Show();
            this.Hide();
        }
    }
}

