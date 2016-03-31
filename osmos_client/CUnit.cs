using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace osmos_client
{
    class CUnit
    {
        protected int x, y;//позиция
        protected double scale;//размер
        protected int radX, radY;//координаты круга 
        protected int radUnit;

        public Image img = Properties.Resources.player;

        public void cheackCollide(CUnit unit)
        {
            double d = Math.Sqrt(Math.Pow((this.x + ((this.scale ) * this.radX)) -
                    (unit.x + ((unit.scale ) * unit.radX)), 2) +
                    Math.Pow((this.y + (this.scale * this.radY)) -
                    (unit.y + (unit.scale * radY)), 2));

            if (d < (this.scale * this.radUnit + unit.scale * unit.radUnit))
            {
                if (this.scale > unit.scale)
                {
                    //пересчет скейла + зависит от скорости/инерции
                }
                else
                {
                    //пересчет скейла - зависит от скорости/инерции
                }

                return;
            }
        }

        public void draw()
        {
            x = ++y;
            //отрисовка
        }
            
        


    }
}
