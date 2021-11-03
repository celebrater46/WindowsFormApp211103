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
            
            Form1 form1 = new Form1();
            form1.Text = "Hello World!";
            form1.Width = 1000;
            form1.Height = 700;
            
            // Label label1 = new Label();
            // label1.Text = "Hello World Again!";
            // label1.Parent = form1;
            
            Label label2 = new Label();
            int num = 100;
            // label2.Text = "変数 num の値は " + num + "です。";
            // label2.Text = (string)num;
            label2.Text = string.Format("変数 num の値は {0} です。", num);
            label2.Parent = form1;

            PictureBox pictureBox = new PictureBox();
            // pictureBox.Image = Image.FromFile("img/sunSymbol.png");
            // pictureBox.Image = Image.FromFile("img\\sunSymbol.png");
            pictureBox.Image = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsApp211103\\WindowsFormsApp211103\\img\\sunSymbol.png");
            pictureBox.Top = 30;
            pictureBox.Left = pictureBox.Width / 10;
            pictureBox.Width = 150;
            pictureBox.Height = 150;
            pictureBox.Parent = form1;
            
            // Application.Run(new Form1()); // Succeeded
            Application.Run(form1);
        }
    }
}