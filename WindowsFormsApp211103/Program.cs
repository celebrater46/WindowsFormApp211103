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
            
            Label label = new Label();
            label.Text = "Hello World Again!";
            label.Parent = form1;

            PictureBox pictureBox = new PictureBox();
            // pictureBox.Image = Image.FromFile("img/sunSymbol.png");
            // pictureBox.Image = Image.FromFile("img\\sunSymbol.png");
            pictureBox.Image = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsApp211103\\WindowsFormsApp211103\\img\\sunSymbol.png");
            pictureBox.Top = 30;
            pictureBox.Width = 150;
            pictureBox.Height = 150;
            pictureBox.Parent = form1;
            
            // Application.Run(new Form1()); // Succeeded
            Application.Run(form1);
        }
    }
}