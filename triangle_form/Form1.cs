using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace triangle_form
{
    public partial class Form1 : Form
    {
        Button btn;
        Triangle triangle = new Triangle();

        public Form1()
        {
            InitializeComponent(); 

            this.Height = 400;
            this.Width = 800;
            this.Text = "Kolmnurk vorm";

            btn = new Button();
            btn.Text = "Запуск"; 
            btn.Height = 100;
            btn.Width = 190;
            btn.Location = new Point(150, 50);
            btn.BackColor = Color.FromArgb(255, 255, 192); 
            btn.Font = new Font("Arial", 28); 
            btn.Cursor = Cursors.Hand; 
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            btn.FlatAppearance.BorderSize = 10; 
            btn.FlatStyle = FlatStyle.Flat; 

            this.Controls.Add(btn);
           

            
        }
    }
}
