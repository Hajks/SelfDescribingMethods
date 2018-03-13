using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfDescribingMethods
{
    class Turbine
    {
        public void CloseTripValve(int domeNumber)
        {
            MessageBox.Show("Zawór regulacyjny turbiny nr 2 został zamknięty.", "Maszyna do robienia batonów, typ 5");
        }
    }
}
