using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DekoratorOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHepsiniDene_Click(object sender, EventArgs e)
        {
            TemelPencere TemelPen = new TemelPencere();
            BaslikliPencere Baslikli = new BaslikliPencere(TemelPen);
            ArkaPlanRenkliPencere APRenkli = new ArkaPlanRenkliPencere(Baslikli);
            ArkaPlanResimliPencere APResimli = new ArkaPlanResimliPencere(APRenkli);
            CerceveliPencere Cerceveli = new CerceveliPencere(APResimli);
            DuseyScrollBarlıPencere DScrollBarlı = new DuseyScrollBarlıPencere(Cerceveli);
            YatayScrollBarlıPencere YScrollBarlı = new YatayScrollBarlıPencere(DScrollBarlı);
            GolgeliPencere Golgeli = new GolgeliPencere(YScrollBarlı);
            MessageBox.Show(Golgeli.Paint());
        }
    }
}
