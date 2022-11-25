using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Login_e_Registro_Sistema.Services;
using Login_e_Registro_Sistema.Services.Interfaces;
using static System.Windows.Forms.DataFormats;
using Color = System.Drawing.Color;

namespace Login_e_Registro_Sistema
{
    public partial class frmHome : Form
    {

        //Fields
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;

        public readonly IUserServices _userServices;

        //Constructor
        public frmHome(IUserServices userServices)
        {

            _userServices = userServices;

            InitializeComponent();

            
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 60)
            };
            panelMenu.Controls.Add(leftBorderBtn);

            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(65, 163, 23);
            public static Color color2 = Color.FromArgb(65, 163, 23);
            public static Color color3 = Color.FromArgb(65, 163, 23);
        }


        //Metodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                Disablebutton();

                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 38, 0);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left Border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            };
        }


        private void Disablebutton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(47, 79, 79);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void OpenChildForm(Form childForm)
        {
            currentChildForm?.Close();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmHome2());
        }


        private void btnClientList_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new frmClientList(_userServices));
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);

            DialogResult dialogResult = MessageBox.Show("Tem Certeza?", "Retornar ao Login", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                {
                    frmLogin frm2 = new frmLogin();
                    frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
                    frm2.Show();

                    this.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnLogo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            Disablebutton();
            leftBorderBtn.Visible = false;
        }

    }
}
