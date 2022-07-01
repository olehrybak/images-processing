using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CG_Task1
{
    public partial class Form2 : Form
    {
        PolylineBox Box = new PolylineBox();
        Form1 Mainform;
        public Form2(Form1 form)
        {
            InitializeComponent();
            Box.Height = 256;
            Box.Width = 256;
            Box.Location = new Point(12, 12);
            Box.BackColor = System.Drawing.Color.DarkGray;
            Controls.Add(Box);
            Mainform = form;
        }
        public void Inversion()
        {
            Box.Inversion();
            Button applyButton = new Button();
            applyButton.Text = "Apply";
            applyButton.Width = 75;
            applyButton.Height = 25;
            applyButton.Location = new Point(100, 280);
            applyButton.Click += (sender, e) => { Mainform.invertImage(); Close(); };
            Controls.Add(applyButton);
        }
        public void Brightness(double val)
        {
            Box.Brightness(val);

            Button applyButton = new Button();
            applyButton.Text = "Apply";
            applyButton.Width = 75;
            applyButton.Height = 25;
            applyButton.Location = new Point(100, 280);
            applyButton.Click += (sender, e)=> { Mainform.changeBrightness(val); Close(); };
            Controls.Add(applyButton);
        }
        public void Gamma(double val)
        {
            Box.Gamma(val);

            Button applyButton = new Button();
            applyButton.Text = "Apply";
            applyButton.Width = 75;
            applyButton.Height = 25;
            applyButton.Location = new Point(100, 280);
            applyButton.Click += (sender, e) => { Mainform.changeGamma(val); Close(); };
            Controls.Add(applyButton);
        }

        
    }
}
