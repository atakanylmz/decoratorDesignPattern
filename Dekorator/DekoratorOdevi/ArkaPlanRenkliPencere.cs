﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekoratorOdevi
{
    public class ArkaPlanRenkliPencere : Window
    {
        public ArkaPlanRenkliPencere(Window HerHangiPencere) : base(HerHangiPencere)
        {
        }

        public override string Paint()
        {
            return EskiPencere.Paint() + " Pencereye arka plan rengi eklendi. ";
        }
    }
}
