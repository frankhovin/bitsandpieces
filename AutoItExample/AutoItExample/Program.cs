using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsOperations;

namespace AutoItExample {
    class Program {
        static void Main(string[] args) {
            //Notepad np = new Notepad();
            //np.OpenAndWrite("Notepad is opened by AutoItX.\\nThis is a string typed by AutoItX.");

            Chrome cr = new Chrome();
            cr.OpenAndLoginSelenium("999666adan@dn13", "Password2018");
            //cr.OpenAndLogin("999666adan@dn13", "Password2018");

            //InputBox ib = new InputBox();
            //ib.Input("tekst");
        }
    }
}
