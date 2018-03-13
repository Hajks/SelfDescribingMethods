using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfDescribingMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Today i have a little bit harder task for me. I have to modify code which look like this:
         * 
         * int t = n.chkTemp();
         * if (t > 160)
         *      {
         *      T obj = new T();
         *      obj.clsTrp\(2);
         *      ics.Fill();
         *      ics.Vent();
         *      m.airsyschk();
         * }
         * 
         * To be more selfdescribing and i have to create all of methods and classes by reading specification included here:
         * https://i.imgur.com/VOrAjiE.png
         */

        public Boolean IsNougatTooHot() // So i created method which use Boolean which gonna return true or false and it depends from nougat temeprature. If temperature is higher then 160 it will start doing SCIB procedure.
        {

            int temp = Maker.CheckNougatTemperature();
            if (temp > 160)
            {
                MessageBox.Show("Temperatura nugatu wynosi " + temp + " stopni celsjusza. Przeprowadzam procedurę SCIB.", "Maszyna do robienia batonów, typ 5");
                return true;
            }
            else
            {
                MessageBox.Show("Temperatura nugatu wynosi " + temp + " stopni celsjusza. Kontunuuje pracę.", "Maszyna do robienia batonów, typ 5");
                return false;
            }
        }
        public void DoSCIBVentProcedure() //Most of methods included in this classes are simple text ones. It's pointless to desribe rest because they should be already selfdescribed
        {
            Turbine turbineController = new Turbine();
            turbineController.CloseTripValve(2);
            IsolationCoolingSystem.Fill();
            IsolationCoolingSystem.Vent();
            Maker.CheckAirSystem();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsNougatTooHot() == true)

            {
                DoSCIBVentProcedure();
            }
    }
    }
}
