using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace osmos_client
{
     partial class View : UserControl
    {
        Model model;
        public View(Model Amodel)
        {
            InitializeComponent();
            this.model = Amodel;
            
        }

        void draw(PaintEventArgs e)
        {
            Thread.Sleep(model.speedGame);
            e.Graphics.DrawImage(model.unit.img, new Point(model.unit.x, model.unit.y));
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            draw(e);
            
        }

        
    }
}
