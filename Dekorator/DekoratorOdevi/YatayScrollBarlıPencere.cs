using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekoratorOdevi
{
    public class YatayScrollBarlıPencere : Window
    {
        public YatayScrollBarlıPencere(Window HerHangiPencere) : base(HerHangiPencere)
        {
        }

        public override string Paint()
        {
            return EskiPencere.Paint() + " Pencereye yatay scroll bar eklendi. ";
        }
    }
}
