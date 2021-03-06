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
            
            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.Image = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsApp211103\\WindowsFormsApp211103\\img\\sunSymbol2.png");
            pictureBox2.Top = margin["top"] + margin["lineHeight"] * 2 + 150;
            // pictureBox2.Left = pictureBox2.Width / 10;
            pictureBox2.Width = 150;
            pictureBox2.Height = 150;
            pictureBox2.Left = (form1.Width - pictureBox2.Width) / 2;
            pictureBox2.Parent = form1;
            
            Label label3 = new Label();
            label3.Top = margin["top"] + 260;
            label3.Left = margin["left"];
            label3.Width = 400;
            label3.Height = margin["lineHeight"];
            for (int i = 0; i < 5; i++)
            {
                // label3.Text += i + " 号車を表示します。\n"; // Failed 
                label3.Height += margin["lineHeight"];
                label3.Text += string.Format("{0} 号車を表示するで。\n", i.ToString());
            }
            label3.Parent = form1;

            PictureBox[] pictureBoxes = new PictureBox[4];
            for (int j = 0; j < pictureBoxes.Length; j++)
            {
                pictureBoxes[j] = new PictureBox();
                pictureBoxes[j].Image = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsApp211103\\WindowsFormsApp211103\\img\\sunSymbol3.png");
                pictureBoxes[j].Top = 460;
                pictureBoxes[j].Width = 32;
                pictureBoxes[j].Height = 32;
                pictureBoxes[j].Left = margin["left"] + pictureBoxes[j].Width * j + 10;
                pictureBoxes[j].Parent = form1;
            }

            Label label4 = new Label();
            label4.Top = margin["top"];
            label4.Left = margin["left"] + 400;
            label4.Width = 200;
            label4.Height = margin["lineHeight"];
            string[] strings = new string[]
            {
                "Hideru",
                "Hizuru",
                "Alma",
                "Sally"
            };
            foreach (string s in strings)
            {
                label4.Text += string.Format("{0}, ", s);
            }
            label4.Parent = form1;

            Label label5 = new Label();
            label5.Top = margin["top"];
            label5.Left = margin["left"] + 600;
            label5.Width = 400;
            label5.Height = margin["lineHeight"] * 2;
            string[,] strings2 = new string[4, 3]
            {
                {"Hideru", "ヒデル", "28"},
                {"Hizuru", "ヒヅル", "46"},
                {"Alma", "アルマ", "37"},
                {"Sally", "サリー", "34"}
            };
            string temp = "";
            for (int k = 0; k < 4; k++)
            {
                temp += "(";
                for (int l = 0; l < 3; l++)
                {
                    temp += strings2[k, l];
                    if(l < 2){ temp += ", "; }
                }
                temp += ")\n";
            }
            label5.Text = temp;
            label5.Parent = form1;

            Label label6 = new Label();
            label6.Top = margin["top"] + 100;
            label6.Left = margin["left"] + 600;
            label6.Width = 400;
            label6.Height = margin["lineHeight"] * 2;
            string[][] strings3 = new string[4][]
            {
                new string[] {"白金ヒデル", "Shirogane Hideru", "28"},
                new string[] {"白金ヒヅル", "Shirogane Hizuru"},
                new string[] {"白金アルマ", "Shirogane Alma", "37"},
                new string[] {"サリー・Ｂ", "Sally=B"},
            };
            string temp6 = "";
            for (int m = 0; m < strings3.Length; m++)
            {
                temp6 += "(";
                for (int n = 0; n < strings3[m].Length; n++)
                {
                    temp6 += strings3[m][n];
                    if(n < (strings3[m].Length - 1)){ temp6 += ", "; }
                }
                temp6 += "),\n";
            }
            label6.Text = temp6;
            label6.Parent = form1;
            
            // Application.Run(new Form1()); // Succeeded
            Application.Run(form1);
        }
    }
}