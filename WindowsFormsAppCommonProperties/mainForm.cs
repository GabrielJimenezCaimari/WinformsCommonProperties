using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCommonProperties
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.Size = new Size(800, 600);
            localizarPosicionTituloForm();
            localizarPosicionLabelForm();
            iniciarListBox();
            locationTargetButton();
        }

        private void localizarPosicionTituloForm()
        {
            string x = this.Location.X.ToString();
            string y = this.Location.Y.ToString();

            this.Text = "(" + x + ", " + y + ") Winforms Components - Common Controls";
        }

        private void localizarPosicionLabelForm()
        {
            string x = this.Size.Width.ToString();
            string y = this.Size.Height.ToString();

            formSizeLabel.Text = "Form size " + x + ", " + y;
        }

        private void mainForm_Move(object sender, EventArgs e)
        {
            localizarPosicionTituloForm();
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            localizarPosicionLabelForm();
        }

        private void iniciarListBox()
        {
            comboBox1.Items.Add("None");
            comboBox1.Items.Add("Fixed single");
            comboBox1.Items.Add("Fixed 3D");
            comboBox1.Items.Add("Fixed Dialog");
            comboBox1.Items.Add("Sizable");
            comboBox1.Items.Add("Fixed tool window");
            comboBox1.Items.Add("Sizable tool window");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "None")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
            if (comboBox1.SelectedItem == "Fixed single")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            }
            if (comboBox1.SelectedItem == "Fixed 3D")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            }
            if (comboBox1.SelectedItem == "Fixed Dialog")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            }
            if (comboBox1.SelectedItem == "Sizable")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
            if (comboBox1.SelectedItem == "Fixed tool window")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            }
            if (comboBox1.SelectedItem == "Sizable tool window")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            }

        }

        private void buttonVisible_Click(object sender, EventArgs e)
        {
            if (targetButton.Visible == false)
            {
                targetButton.Visible = true;
                buttonVisible.Text = "Visible = true";
            }
            else
            {
                targetButton.Visible = false;
                buttonVisible.Text = "Visible = false";
            }
        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            if (targetButton.Enabled == false)
            {
                targetButton.Enabled = true;
                buttonEnable.Text = "Enabled = true";
            }
            else
            {
                targetButton.Enabled = false;
                buttonEnable.Text = "Enabled = false";
            }
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            int x = this.Size.Width / 2 - 50;
            int y = this.Size.Height / 2 - 50;

            targetButton.Location = new Point(x, y);
            locationTargetButton();
        }

        private void locationTargetButton()
        {
            string x = targetButton.Location.X.ToString();
            string y = targetButton.Location.Y.ToString();

            targetButton.Text = "Target" + Environment.NewLine + "X = " + x + Environment.NewLine +"Y = " + y;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;

            targetButton.Location = new Point(x, y - 5);
            locationTargetButton();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;

            targetButton.Location = new Point(x, y + 5);
            locationTargetButton();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;

            targetButton.Location = new Point(x + 5, y);
            locationTargetButton();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;

            targetButton.Location = new Point(x - 5, y);
            locationTargetButton();
        }
    }
}
