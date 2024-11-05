using System;
using System.Drawing;
using System.Windows.Forms;

namespace triangle_form
{
    public partial class Form1 : Form
    {
        private Button btn;
        private Triangle triangle;
        private PictureBox pb;
        private ListView listView;
        private TextBox txtA, txtB, txtC;
        private Label lblA, lblB, lblC;

        public Form1()
        {
            InitializeComponent();

            this.Height = 400;
            this.Width = 800;
            this.Text = "Kolmnurga vorm";

            // Button
            btn = new Button
            {
                Text = "Käivita",
                Height = 60,
                Width = 120,
                Location = new Point(600, 50),
                BackColor = Color.FromArgb(255, 255, 192),
                Font = new Font("Arial", 20),
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat
            };
            btn.Click += Run_button_Click; 

            
            pb = new PictureBox
            {
                Size = new Size(200, 200),
                Location = new Point(550, 165),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Image.FromFile("triangle.png")
            };

            
            txtA = new TextBox { Location = new Point(25, 100), Width = 100 };
            Label lblA = new Label
            {
                Text = "A:",
                Location = new Point(25, 80)
              
            };
            txtB = new TextBox { Location = new Point(150, 100), Width = 100 };
            Label lblB = new Label
            {
                Text = "B:",
                Location = new Point(150, 80)
                
            };
            txtC = new TextBox { Location = new Point(275, 100), Width = 100 };
            Label lblC = new Label
            {
                Text = "C:",
                Location = new Point(275, 80)
               
            };



            listView = new ListView
            {
                Size = new Size(500, 200),
                Location = new Point(25, 150),
                View = View.Details
            };

           
            listView.Columns.Add("Omadus", 100);
            listView.Columns.Add("Väärtus", 150);

            
            this.Controls.Add(btn);
            this.Controls.Add(pb);
            this.Controls.Add(listView);
            this.Controls.Add(txtA);
            this.Controls.Add(txtB);
            this.Controls.Add(txtC);
            this.Controls.Add(lblA);
            this.Controls.Add(lblB);
            this.Controls.Add(lblC);
        }

        
        private void Run_button_Click(object sender, EventArgs e)
        {
            try
            {
                
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);

                
                triangle = new Triangle(a, b, c, 0); 

                
                listView.Items.Clear();
                listView.Items.Add(new ListViewItem(new[] { "Külg a", triangle.outputA() }));
                listView.Items.Add(new ListViewItem(new[] { "Külg b", triangle.outputB() }));
                listView.Items.Add(new ListViewItem(new[] { "Külg c", triangle.outputC() }));
                listView.Items.Add(new ListViewItem(new[] { "Ümbermõõt", triangle.Perimeter().ToString() }));
                listView.Items.Add(new ListViewItem(new[] { "Pindala", triangle.Surface().ToString() }));
                listView.Items.Add(new ListViewItem(new[] { "Eksisteerib?", triangle.ExistTriangle ? "Eksisteerib" : "Ei eksisteeri" }));
                listView.Items.Add(new ListViewItem(new[] { "Tüüp", triangle.TriangleType }));
            }
            catch (FormatException)
            {
                MessageBox.Show("Sisestage külgede a, b ja c jaoks kehtivad väärtused.", "Sisestusviga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
