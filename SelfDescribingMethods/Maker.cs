using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SelfDescribingMethods
{
    public class Maker
    {

        public static int CheckNougatTemperature()
        {
            Random random = new Random();
            int temp = random.Next(100,200);
            return temp;
        }
        public static void CheckAirSystem()
        {
            MessageBox.Show("Sprawdzam czy w systemie nie ma powietrza.", "Maszyna do robienia batonów, typ 5");
            MessageBox.Show("Procedura opróżniania systemu chłodzenia izolacji batonów została wykonana pomyślnie.", "Maszyna do robienia batonów, typ 5");
        }
    }
}
