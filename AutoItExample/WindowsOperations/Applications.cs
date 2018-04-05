using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoIt;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System.Windows.Forms;

namespace WindowsOperations
{
    public class InputBox {
        public void Input (string text) {
            Microsoft.VisualBasic.Interaction.InputBox("Did you know your question goes here?", "Title", "Default Text");
            SendKeys.SendWait(text);
        }
    }

    public class Notepad {
        public void OpenAndWrite (string text) {
            AutoItX.Run("notepad.exe", "", 1);
            AutoItX.WinWaitActive("Untitled");
            AutoItX.Send(text);
            IntPtr winHandle = AutoItX.WinGetHandle("Untitled");
            AutoItX.WinKill(winHandle);
        }
    }

    public class Chrome {
        public void OpenAndLogin (string username, string password) {
            //AutoItX.Run("calc.exe", "", 1);
            AutoItX.Run("C:/Program Files (x86)/Google/Chrome/Application/chrome.exe http://my-lab-drop2.telecomputing.com", "", 1);
            AutoItX.WinActivate("Authentication required", "");

            SendKeys.SendWait(username);

        }
        public static IWebDriver Instance { get; set; }
        /**
         *  Nagivate to a web page (using Selenium) that requires authentication, and log in.
         *
         *  Note: This doesn't require AutoItX - it can be done with System.Windows.Forms -> SendKeys.SendWait() (see below).
         */
        public void OpenAndLoginSelenium (string username, string password) {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            Instance = new ChromeDriver(driverService);
            //Instance = new FirefoxDriver();

            Instance.Navigate().GoToUrl("http://my-lab-drop2.telecomputing.com");
            //Instance.Navigate().GoToUrl("https://flow.telecomputing.com");
            //Instance.Navigate().GoToUrl("http://aev25.no");
            //AutoItX.WinActivate("Authentication required", "");
            AutoItX.Send(username);
            //AutoItX.Send("{TAB}");
            //AutoItX.Send(password);
            //AutoItX.Send("{TAB}");
            //AutoItX.Send("{ENTER}");

            //SendKeys.SendWait(username);
            //SendKeys.SendWait("{TAB}");
            //SendKeys.SendWait(password);

            //Instance.SwitchTo().Alert().SetAuthenticationCredentials("test", "test");
            //Instance.SwitchTo().Alert().Accept();

            //IAlert confirmationAlert = Instance.SwitchTo().Alert();
            //confirmationAlert.Dismiss();

        }
    }
}
