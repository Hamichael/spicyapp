using SpicyApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Version Control - Development version 2
 * Future TODOs: 4
 * 
 * ===================== *
 * Development Version 1 *
 * 
 * Farmework developed
 * Panel Size Controls added
 * Panel Methods added
 * 
 * ===================== *
 * Development Version 2 *
 * 
 * Method RefreshIngList() added
 * Controls to read and write to text file added
 * Cleared up comments
 * Cleaned up files
 * Implement class ingData to mirror data
 * TODO [Dev 3]: Add and Update data in batchs
 * 
 * ===================== *
 * 
 */

namespace SpicyAppSpace
{
    public partial class SpicyApp : Form
    {
        //Declare instance of a list for adding ing data
        ingData myIngData = new ingData();

        //Create a list of ingData
        List<ingData> myIngDataList = new List<ingData>();

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

            //Run as default active panel
            RecPanelMethod();
            //Run Refreshing List to populate ingredient list
            RefreshIngList();
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
            Close(); /**TODO: Placeholder for MessageBox*/
        }

        //Panel Control methods
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
        //End Panel Control methods

        //Validating Ingredient name
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

        //Button in IngPanel that adds the ingredient to data
        private void btnIngAdd_Click(object sender, EventArgs e)
        {
            string regexTextOnly = @"^[^\d\s]+$";//Text only, no numbers or spaces
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


            //Reading out data to SpicyAppIngredients.txt

            //Text-file for appending ingredient data
            /**TODO: Replace file with Database at some point*/
            FileStream outFile = new FileStream("SpicyAppIngredients.txt", FileMode.Append);
            StreamWriter binWriter = new StreamWriter(outFile);

            //Temp ingData and Store user data entered
            ingData tempIngData = new ingData(txtIngName.Text, Convert.ToInt32(updIngQuantity.Text), cboIngQuantityUnits.Text);

            //Write data to the file
            binWriter.WriteLine(tempIngData.Name + "," + tempIngData.Quantity + "," + tempIngData.Unit);

            //Add tempIngData to myIngDataList.
            //Note: The following piece of code fixes issues in displaying correct data via Combo Box
            myIngDataList.Add(tempIngData);

            //Close
            binWriter.Close();
            outFile.Close();

            //Refresh list after adding items.
            //Note: Make sure to put this method after close
            RefreshIngList();

            //Clear text, disable add button
            txtIngName.Text = String.Empty;
            updIngQuantity.Text = String.Empty;
            cboIngQuantityUnits.Text = String.Empty;
            btnIngAdd.Enabled = false;
        }

        //Refreshes the combo box list on click
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshIngList();
        }

        //Method to Refresh combo list
        private void RefreshIngList()
        {
            //Clear combo list
            cboIngList.Items.Clear();

            //Temp ingData
            ingData tempIngData = new ingData();

            try
            {
                //Create an instance of a FileStream for reading
                FileStream inFile = new FileStream("SpicyAppIngredients.txt", FileMode.Open);

                //Create an instance of a StreamReader
                StreamReader myReader = new StreamReader(inFile);

                //Declare a temp string line
                string line;

                //Read in a line from the file and priming read
                line = myReader.ReadLine();

                string[] fields = new string[3];
                char[] sep = new char[1];

                sep[0] = ',';
                //sep[1] = '\n';

                while (line != null)
                {
                    tempIngData = new ingData();

                    fields = line.Split(sep);

                    tempIngData.Name = fields[0];
                    tempIngData.Quantity = Convert.ToInt32(fields[1]);
                    tempIngData.Unit = fields[2];

                    //Add tempIngData to myIngDataList
                    myIngDataList.Add(tempIngData);

                    //Add name to combo box
                    cboIngList.Items.Add(tempIngData.Name);

                    //Read in next line
                    line = myReader.ReadLine();
                }

                //Close
                inFile.Close();
                myReader.Close();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found!\n");
            }
        }
        //Runs after selecting an item
        private void cboIngList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Grabs index of item
            int index = cboIngList.SelectedIndex;
            
            //Grabs item data to display
            /**TODO: Turn this part into a method*/
            if (index != -1)
            {
                //Temp ingData
                ingData tempIngData = new ingData();

                //Grab the corresponding data
                tempIngData = myIngDataList.Skip(index).Take(1).First();

                //Display
                lblIngQuantity.Text = (tempIngData.Quantity).ToString();
                lblIngQuantityUnits.Text = tempIngData.Unit;
            }
        }
    }
}
