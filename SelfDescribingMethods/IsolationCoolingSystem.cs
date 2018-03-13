using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfDescribingMethods
{
    class IsolationCoolingSystem
    {
        public static void Fill()
        {
            MessageBox.Show("Izolowany system chłodzenia strumieniem wody został uzupełniony.", "Maszyna do robienia batonów, typ 5");
        }
        public static void Vent()
        {
            MessageBox.Show("Izolowany system chłodzenia strumieniem wody został opróżniony.", "Maszyna do robienia batonów, typ 5");
        }
    }
}
