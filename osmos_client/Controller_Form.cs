using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace osmos_client
{
    public partial class Controller_Form : Form
    {
        View view;
        Model model;

        public Controller_Form() : this(50) { }
        public Controller_Form(int speedGame)
        {
            InitializeComponent();

            model = new Model(speedGame);

            view = new View(model);
            this.Controls.Add(view);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread modelPlay = new Thread(model.play);
            modelPlay.Start();
        }
    }
}
