using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWindowForm
{
    class Mainform : Form
    {

        Button btClickMe;
        bool toggle = false;
        Label iptLabel;
        TextBox textbox;
        ComboBox combobox;
        RadioButton radiobutton1;
        RadioButton radiobutton2;
        RadioButton radiobutton3;
        int paddingLef = 0;
        DateTimePicker datepicker;

        public Mainform()
        {
            this.paddingLef = 20;
            this.Text = "Input your name";
            this.Text = "Hello World";
            this.Size = new Size(800, 600);
            this.DoubleBuffered = true;
            //  this.WindowState = FormWindowState.Maximized;
            /*btClickMe = new Button()
            {
                Text = "Click me",
                Size = new Size(100, 50),
                Location = new Point(350,270),

            };
            btClickMe.Click += btClickMe_Click;
            this.Controls.Add(btClickMe);*/

            iptLabel = new Label()
            {
                Text = "Input your name",
                Font = new Font("GenericMonospace",20, FontStyle.Bold),
                Size = new Size(Text.Length * 50, 70)
            };
            textbox = new TextBox()
            {
                Size = new Size (200,50),
                Location = new Point (0 + paddingLef, 50)

            };


            btClickMe = new Button()
            {
                Text = "Add",
                Location = new Point (250,50)
            };

            btClickMe.Click += BtClickMe_Click;


            combobox = new ComboBox()
            {
                 Location = new Point(0 + paddingLef,80),
                 Size = new Size(200,50),
            };

            radiobutton1 = new RadioButton()
            {
                Text = "Male",
                Location = new Point (0 + paddingLef, 100),
            };

            radiobutton3 = new RadioButton()
            {
                Text = "Other",
                Location = new Point(0 + paddingLef, 160),
            };


            radiobutton2 = new RadioButton()
            {
                Text = "FeMmale",
                Location = new Point(0 + paddingLef, 130)
            };

            datepicker = new DateTimePicker()
            {
                Location = new Point(300, 80),
                Size = new Size(200, 50),

        };
            this.Controls.Add(radiobutton3);
            this.Controls.Add(datepicker);
            this.Controls.Add(combobox);
            this.Controls.Add(radiobutton1);
            this.Controls.Add(radiobutton2);
            this.Controls.Add(btClickMe);
            this.Controls.Add(textbox);
            this.Controls.Add(iptLabel);

           
            
        }

        private void BtClickMe_Click(object sender, EventArgs e)
        {
            combobox.Items.Add(textbox.Text + " : " + datepicker.Value.ToShortDateString());
            textbox.Text = "";
        }

    }
}
