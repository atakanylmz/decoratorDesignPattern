using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekoratorOdevi
{
    public class GolgeliPencere : Window
    {
        public GolgeliPencere(Window HerHangiPencere) : base(HerHangiPencere)
        {
        }

        public override string Paint()
        {
            return EskiPencere.Paint() + " Pencereye gölge eklendi. ";
        }
    }
}
