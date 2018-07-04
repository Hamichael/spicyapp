using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPanelClose
{
    public partial class SpicyApp : Form
    {
        

        public SpicyApp()
        {
            InitializeComponent();

            

            //Panel Text
            const String INTRO_PANEL_TEXT = "Introduction";
            const String INGREDIENTS_PANEL_TEXT = "&Ingredients";
            const String RECIPE_PANEL_TEXT = "&Recipe";
            const String CREDITS_PANEL_TEXT = "&Credits";

            /*Size of non-Intro Panels [Add or remove the "/" after the "*"]*
            const int PANEL_WIDTH = 100;
            const int PANEL_HEIGHT = 100;

            //Apply Const Width & Height to Panels
            pnlIng.Size = new Size(PANEL_WIDTH, PANEL_HEIGHT);
            pnlRec.Size = new Size(PANEL_WIDTH, PANEL_HEIGHT);
            pnlCrd.Size = new Size(PANEL_WIDTH, PANEL_HEIGHT);
            /**/

            //Display panel text
            btnIntPanelShow.Text = INTRO_PANEL_TEXT;
            btnIngPanel.Text = INGREDIENTS_PANEL_TEXT;
            btnRecPanel.Text = RECIPE_PANEL_TEXT;
            btnCrdPanel.Text = CREDITS_PANEL_TEXT;

            //lblIngTitle.Text = "Ingredients";
            //lblRecTitle.Text = "Recipes";
            //lblCrdTitle.Text = "Credits";

            //Run RecPanelMethod as default
            RecPanelMethod();
        }

        private void btn_introPanelClose_Click(object sender, EventArgs e)
        {
            pnlIntro.Visible = false;
        }

        private void btnIntroPanelShow_Click(object sender, EventArgs e)
        {
            pnlIntro.Visible = true;
        }

        private void btnIngPanel_Click(object sender, EventArgs e)
        {
            IngPanelMethod();
        }

        private void btnRecPanel_Click(object sender, EventArgs e)
        {
            RecPanelMethod();
        }

        private void btnCrdPanel_Click(object sender, EventArgs e)
        {
            CrdPanelMethod();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); //TODO: Placeholder for MessageBox
        }

        private void IngPanelMethod()
        {
            pnlIng.Visible = true;
            pnlRec.Visible = false;
            pnlCrd.Visible = false;

            btnIngPanel.Enabled = false;
            btnRecPanel.Enabled = true;
            btnCrdPanel.Enabled = true;
        }

        private void RecPanelMethod()
        {
            pnlIng.Visible = false;
            pnlRec.Visible = true;
            pnlCrd.Visible = false;

            btnIngPanel.Enabled = true;
            btnRecPanel.Enabled = false;
            btnCrdPanel.Enabled = true;
        }

        private void CrdPanelMethod()
        {
            pnlIng.Visible = false;
            pnlRec.Visible = false;
            pnlCrd.Visible = true;

            btnIngPanel.Enabled = true;
            btnRecPanel.Enabled = true;
            btnCrdPanel.Enabled = false;
        }

        private void txtIngName_Validating(object sender, CancelEventArgs e)
        {
            string regexTextOnly = @"^[^\d\s]+$";
            bool isValidText = Regex.IsMatch(txtIngName.Text, regexTextOnly);
            //Empty Validation
            if (txtIngName.Text == String.Empty)
            {
                btnIngAdd.Enabled = false;
                return;
            }
            //Regex Validation
            if (!isValidText)
            {
                MessageBox.Show("Ingredient name has to be valid.");
                txtIngName.Focus();
                txtIngName.SelectAll();
                btnIngAdd.Enabled = false;
                return;
            }
            //If Validation passes
            btnIngAdd.Enabled = true;
        }

        private void btnIngAdd_Click(object sender, EventArgs e)
        {
            string regexTextOnly = @"^[^\d\s]+$";
            bool isValidText = Regex.IsMatch(txtIngName.Text, regexTextOnly);
            //Regex backup check
            if (txtIngName.Text == String.Empty || !isValidText)
            {
                return;
            }
            //Units check
            if (cboIngQuantityUnits.Text == String.Empty)
            {
                MessageBox.Show("Must have a Unit.");
                return;
            }
        }
    }
}
