using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp211103
{
    static class Program
    {
        // int num = 100;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Form1 form1 = new Form1();
            // Form1 form = new Form1();
            // form1.Text = "Hello World!";
            // form.Text = "Hello World!";
            // Form form = new Form();
            // form.Text = "Hello World!";
            
            // ^ Do not write the code that defines New Form here. It should write under these two Application
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            int num = 100;
            Dictionary<string, int> margin = new Dictionary<string, int>()
            {
                {"top", 10},
                {"right", 10},
                {"bottom", 10},
                {"left", 10},
                {"lineHeight", 25}
            };
            
            Form1 form1 = new Form1();
            form1.Text = "Hello World!";
            form1.Width = 1000;
            form1.Height = 700;
            
            Label label1 = new Label();
            label1.Top = margin["top"];
            label1.Left = margin["left"];
            label1.Text = "Hello World Again!";
            label1.Parent = form1;
            
            Label label2 = new Label();

            label2.Top = margin["top"] + margin["lineHeight"];
            label2.Left = margin["left"];
            label2.Width = 300; // A part of string will be hidden without this
            
            // var num = "100"; // Succeeded
            // label2.Text = "変数 num の値は " + num + "です。";
            // label2.Text = num; // Failed
            // label2.Text = num.ToString(); // Succeeded
            // label2.Text = (string)num;
            // Console.WriteLine(num);
            // label2.Text = string.Format("変数 num の値は {0} です。", num); // Failed
            // string msg = num.ToString();
            // string msg2 = "である。";
            
            label2.Text = string.Format("変数 num の値は {0} です。", num.ToString());
            
            // label2.Text = string.Format("{0} {1}", msg, msg2); // Failed
            // label2.Text = "変数 num の値は " + (num.ToString()) + "です。";
            label2.Parent = form1;

            PictureBox pictureBox = new PictureBox();
            // pictureBox.Image = Image.FromFile("img/sunSymbol.png");
            // pictureBox.Image = Image.FromFile("img\\sunSymbol.png");
            pictureBox.Image = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsApp211103\\WindowsFormsApp211103\\img\\sunSymbol.png");
            // pictureBox.Top = 60;
            pictureBox.Top = margin["top"] + margin["lineHeight"] * 2;
            pictureBox.Left = pictureBox.Width / 10;
            pictureBox.Width = 150;
            pictureBox.Height = 150;
            pictureBox.Parent = form1;
            
            // Application.Run(new Form1()); // Succeeded
            Application.Run(form1);
        }
    }
}