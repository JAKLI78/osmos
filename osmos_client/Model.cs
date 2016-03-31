using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace osmos_client
{
    class Model
    {
        public int speedGame;

        public CUnit unit;

        public Model(int AspeedGame)
        {
            this.speedGame = AspeedGame;

            this.unit = new CUnit();
        }

        public void play()
        {
            while (true)
            {
                Thread.Sleep(speedGame);
                unit.move();
            }
        }
    }
}
