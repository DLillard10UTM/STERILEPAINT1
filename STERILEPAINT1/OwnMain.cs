using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace STERILEPAINT1
{
    class OwnMain
    {
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [System.STAThreadAttribute()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public static void Main()
        {
            STERILEPAINT1.App app = new STERILEPAINT1.App();
            app.InitializeComponent();

            Window win = new Window();
            TextBox text = new TextBox();
            text.Name = "Textbox";
            text.Text = "B - B - B - Bennie and the Jets\n" +
                "Oh but they're weird and they're wonderful\n" +
                "Oh Bennie she's really keen\n" +
                "She's got electric boots a mohair suit\n" +
                "You know I read it in a magazine\n" +
                "B - B - B - Bennie and the Jets\n" +
                "And the changes, dont want to be pushed at all.";

            win.Content = text;
            win.Show();
            app.Run();
        }
    }
}
