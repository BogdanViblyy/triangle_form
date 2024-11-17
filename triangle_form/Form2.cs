using System;
using System.Drawing;
using System.Windows.Forms;

namespace triangle_form
{
    public partial class Form2 : Form
    {
        private Button btnCalculate;
        private Button btnClose;
        private TextBox txtAngleA, txtAngleB, txtAngleC;
        private Label lblAngleA, lblAngleB, lblAngleC;
        private ListView listView;
        private Triangle triangle;

        public Form2()
        {
            InitializeComponent();

            this.Height = 500;
            this.Width = 800;
            this.Text = "Kolmnurga vorm (Kraadid)";

            btnCalculate = new Button
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
            btnCalculate.Click += BtnCalculate_Click;

            btnClose = new Button
            {
                Text = "Tagasi",
                Height = 50,
                Width = 120,
                Location = new Point(600, 120),
                BackColor = Color.FromArgb(255, 255, 192),
                Font = new Font("Arial", 14),
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat
            };
            btnClose.Click += BtnBack_Click;

            txtAngleA = new TextBox { Location = new Point(25, 100), Width = 100 };
            lblAngleA = new Label { Text = "Nurga A (kraadid):", Location = new Point(25, 80) };

            txtAngleB = new TextBox { Location = new Point(150, 100), Width = 100 };
            lblAngleB = new Label { Text = "Nurga B (kraadid):", Location = new Point(150, 80) };

            txtAngleC = new TextBox { Location = new Point(275, 100), Width = 100 };
            lblAngleC = new Label { Text = "Nurga C (kraadid):", Location = new Point(275, 80) };

            listView = new ListView
            {
                Size = new Size(500, 200),
                Location = new Point(25, 200),
                View = View.Details
            };
            listView.Columns.Add("Omadus", 100);
            listView.Columns.Add("Väärtus", 150);

            this.Controls.Add(btnCalculate);
            this.Controls.Add(btnClose);
            this.Controls.Add(txtAngleA);
            this.Controls.Add(txtAngleB);
            this.Controls.Add(txtAngleC);
            this.Controls.Add(lblAngleA);
            this.Controls.Add(lblAngleB);
            this.Controls.Add(lblAngleC);
            this.Controls.Add(listView);
        }
       

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double Ac = Convert.ToDouble(txtAngleA.Text);
                double Bc = Convert.ToDouble(txtAngleB.Text);
                double Cc = Convert.ToDouble(txtAngleC.Text);

               
                

                Triangle triangle = new Triangle(Ac, Bc, Cc, 0, true );

                listView.Items.Clear();
                listView.Items.Add(new ListViewItem(new[] { "Nurga A", Ac.ToString() }));
                listView.Items.Add(new ListViewItem(new[] { "Nurga B", Bc.ToString() }));
                listView.Items.Add(new ListViewItem(new[] { "Nurga C", Cc.ToString() }));
                listView.Items.Add(new ListViewItem(new[] { "Eksisteerib?", triangle.ExistTriangleCorner ? "Eksisteerib" : "Ei eksisteeri" }));
                listView.Items.Add(new ListViewItem(new[] { "Tüüp", triangle.TriangleTypeByCorners }));
                triangle.SaveToXML();
            }
            catch (FormatException)
            {
                MessageBox.Show("Sisestage kehtivad nurgad.", "Sisestusviga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
