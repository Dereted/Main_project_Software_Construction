using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Main_project_Software_Construction
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private Form activeForm;


        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button activeButton)
        {
            Color pressedColor = Color.FromArgb(193, 246, 102); 
            Color normalColor = Color.FromArgb(223, 223, 215); 
            Color textColor = Color.FromArgb(92, 92, 90);    

            Guna.UI2.WinForms.Guna2Button[] menuButtons =
            {
                Lab_one_button,
                Lab_two_button,
                Lab_three_button,
                Lab_four_button,
                Lab_five_button,
                Lab_six_button,
                Lab_seven_button,
                Lab_eight_button,
                Settings_button,
            };

            foreach (var btn in menuButtons)
            {
                btn.FillColor = normalColor;
                btn.ForeColor = textColor;
            }

            activeButton.FillColor = pressedColor;
            activeButton.ForeColor = textColor;
        }

        private void OpenChildForm(Form childForm, object btnSenter)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Main_panel.Controls.Clear();
            Main_panel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void Lab_one_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1(), sender);
            SetActiveButton(Lab_one_button);
        }

        private void Lab_two_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2(), sender);
            SetActiveButton(Lab_two_button);
        }

        private void Lab_three_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3(), sender);
            SetActiveButton(Lab_three_button);
        }

        private void Lab_four_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4(), sender);
            SetActiveButton(Lab_four_button);
        }

        private void Lab_five_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5(), sender);
            SetActiveButton(Lab_five_button);
        }

        private void Lab_six_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form6(), sender);
            SetActiveButton(Lab_six_button);
        }

        private void Lab_seven_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form7(), sender);
            SetActiveButton(Lab_seven_button);
        }

        private void Lab_eight_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form8(), sender);
            SetActiveButton(Lab_eight_button);
        }

        private void Settings_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Settings(), sender);
            SetActiveButton(Settings_button);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
