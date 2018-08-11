using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekoratorOdevi
{
    public abstract class Window
    {
        public Window EskiPencere;
        public Window() { }
        public Window(Window HerHangiPencere)
        {
            this.EskiPencere = HerHangiPencere;
        }
        public abstract string  Paint();
    }
}
