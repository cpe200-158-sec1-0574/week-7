using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class ShowScore : Form, View
    {
        Model model;
        public ShowScore(Model model)
        {
            this.model = model;
            this.model.AttachObserver(this);
            InitializeComponent();
        }

        public void Notify(Model model)
        {
            label2.Text = Convert.ToString(((TwoZeroFourEightModel)model).getScore());
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
