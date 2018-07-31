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
 * ------------------------*------------*
 * Development Version 2.1 * 07/31/2018 *
 * 
 * Method getObjectRef() implemented. Implements references to reuse code with different objects.
 * Added extra display and adding ingredient lines
 * Add edit line [WIP]
 * Updated references in code
 * Updated ingData to include spicyness [float]
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
            //Getting References
            TextBox refTXTIngName = null;
            Button refButton = null;
            getObjectRef(sender, ref refTXTIngName, ref refButton);

            string regexTextOnly = @"^[^\d\s]+$";
            bool isValidText = Regex.IsMatch(refTXTIngName.Text, regexTextOnly);
            //Empty Validation
            if (refTXTIngName.Text == String.Empty)
            {
                refButton.Enabled = false;
                return;
            }
            //Regex Validation
            if (!isValidText)
            {
                MessageBox.Show("Ingredient name has to be valid.");
                refTXTIngName.Focus();
                refTXTIngName.SelectAll();
                refButton.Enabled = false;
                return;
            }
            //Editing check
            if (isEditLine(sender) == false)
            {
                //Check if name already exists in the database
                for (int i = 0; i < myIngDataList.Count; i++)
                {
                    ingData readIngData = getListItem(i);
                    if (readIngData.Name == refTXTIngName.Text)
                    {
                        MessageBox.Show("Name already exist.");
                        refTXTIngName.Focus();
                        refTXTIngName.SelectAll();
                        refButton.Enabled = false;
                        return;
                    }
                }
            }
            //If Validation passes
            refButton.Enabled = true;
        }

        //Button in IngPanel that adds the ingredient to data
        private void btnIngAdd_Click(object sender, EventArgs e)
        {
            //Getting References
            TextBox refTXTIngName = null;
            NumericUpDown refUPDIngQuantity = null;
            ComboBox refCBOIngUnit = null;
            NumericUpDown refUPDIngSpicy = null;
            Button refButton = null;
            getObjectRef(sender, ref refTXTIngName, ref refUPDIngQuantity, ref refCBOIngUnit, ref refUPDIngSpicy, ref refButton);

            string regexTextOnly = @"^[^\d\s]+$";//Text only, no numbers or spaces
            bool isValidText = Regex.IsMatch(refTXTIngName.Text, regexTextOnly);
            //Regex backup check
            if (refTXTIngName.Text == String.Empty || !isValidText)
            {
                return;
            }
            //Units check
            if (refCBOIngUnit.Text == String.Empty)
            {
                MessageBox.Show("Must have a Unit.");
                return;
            }
            //Editing backup check
            if (isEditLine(sender) == false)
            {
                //Check if name already exists in the database
                for (int i = 0; i < myIngDataList.Count; i++)
                {
                    ingData readIngData = getListItem(i);
                    if (readIngData.Name == refTXTIngName.Text)
                    {
                        return;
                    }
                }
            }


            //Reading out data to SpicyAppIngredients.txt

            //Text-file for appending ingredient data
            /**TODO: Replace file with Database at some point*/
            FileStream outFile = new FileStream("SpicyAppIngredients.txt", FileMode.Append);
            StreamWriter binWriter = new StreamWriter(outFile);

            //Temp ingData and Store user data entered
            ingData tempIngData = new ingData(refTXTIngName.Text, Convert.ToInt32(refUPDIngQuantity.Text), refCBOIngUnit.Text, float.Parse(refUPDIngSpicy.Text));

            //Add tempIngData to myIngDataList.
            //Note: The following piece of code fixes issues in displaying correct data via Combo Box
            myIngDataList.Add(tempIngData);

            //Write data to the file
            binWriter.WriteLine(tempIngData.Name + "," + tempIngData.Quantity + "," + tempIngData.Unit + "," + tempIngData.Spicyness);

            //Close
            binWriter.Close();
            outFile.Close();

            //Refresh list after adding items.
            //Note: Make sure to put this method after close
            RefreshIngList();

            //Clear text, disable add button
            clearData(ref refTXTIngName, ref refUPDIngQuantity, ref refCBOIngUnit, ref refUPDIngSpicy);
            refButton.Enabled = false;
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
            cboIngList00.Items.Clear();
            cboIngList01.Items.Clear();
            cboIngList02.Items.Clear();
            cboIngListE0.Items.Clear();

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

                string[] fields = new string[4];
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
                    tempIngData.Spicyness = float.Parse(fields[3]);

                    //Add tempIngData to myIngDataList
                    myIngDataList.Add(tempIngData);

                    //Add name to combo box
                    cboIngList00.Items.Add(tempIngData.Name);
                    cboIngList01.Items.Add(tempIngData.Name);
                    cboIngList02.Items.Add(tempIngData.Name);
                    cboIngListE0.Items.Add(tempIngData.Name);

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
            //Getting References
            ComboBox refCBOIngName = null;
            Label refLBLIngQuantity = null;
            Label refLBLIngUnit = null;
            Label refLBLIngSpicy = null;
            Button refButton = null;
            getObjectRef(sender, ref refCBOIngName, ref refLBLIngQuantity, ref refLBLIngUnit, ref refLBLIngSpicy, ref refButton);

            //Grabs index of item
            int index = refCBOIngName.SelectedIndex;

            //Grabs item data to display
            if (index != -1)
            {
                //Temp ingData, gets item from index location
                ingData tempIngData = getListItem(index);

                //Display
                refLBLIngQuantity.Text = (tempIngData.Quantity).ToString();
                refLBLIngUnit.Text = tempIngData.Unit;
                refLBLIngSpicy.Text = (tempIngData.Spicyness).ToString();
            }
        }

        //Takes the integer inputed, and retrieves the item at the index number
        private ingData getListItem(int index)
        {
            return myIngDataList.Skip(index).Take(1).First();
        }

        //Takes an object, and retrieves the relevent reference. getObjectRef() methods.
        //txtIngName_Validating version
        private void getObjectRef(object sender, ref TextBox refTXTIngName, ref Button refButton)
        {
            if (Object.ReferenceEquals(sender, txtIngNameE0))
            {
                refTXTIngName = txtIngNameE0;
                refButton = btnConfirmE0;
            }
            else if (Object.ReferenceEquals(sender, txtIngName01))
            {
                refTXTIngName = txtIngName01;
                refButton = btnIngAdd01;
            }
            else if(Object.ReferenceEquals(sender, txtIngName02))
            {
                refTXTIngName = txtIngName02;
                refButton = btnIngAdd02;
            }
            else if(Object.ReferenceEquals(sender, txtIngName03))
            {
                refTXTIngName = txtIngName03;
                refButton = btnIngAdd03;
            }
            return;
        }

        //btnIngAdd_Click version
        private void getObjectRef(object sender, ref TextBox refTXTIngName, ref NumericUpDown refUPDIngQuantity, ref ComboBox refCBOIngUnit, ref NumericUpDown refUPDIngSpicy, ref Button refButton)
        {
            if (Object.ReferenceEquals(sender, btnConfirmE0))
            {
                refTXTIngName = txtIngNameE0;
                refUPDIngQuantity = updIngQuantityE0;
                refCBOIngUnit = cboIngQuantityUnitsE0;
                refUPDIngSpicy = updIngSpicyE0;
                refButton = btnConfirmE0;
            }
            else if (Object.ReferenceEquals(sender, btnIngAdd01))
            {
                refTXTIngName = txtIngName01;
                refUPDIngQuantity = updIngQuantity01;
                refCBOIngUnit = cboIngQuantityUnits01;
                refUPDIngSpicy = updIngSpicy01;
                refButton = btnIngAdd01;
            }
            else if (Object.ReferenceEquals(sender, btnIngAdd02))
            {
                refTXTIngName = txtIngName02;
                refUPDIngQuantity = updIngQuantity02;
                refCBOIngUnit = cboIngQuantityUnits02;
                refUPDIngSpicy = updIngSpicy02;
                refButton = btnIngAdd02;
            }
            else if (Object.ReferenceEquals(sender, btnIngAdd03))
            {
                refTXTIngName = txtIngName03;
                refUPDIngQuantity = updIngQuantity03;
                refCBOIngUnit = cboIngQuantityUnits03;
                refUPDIngSpicy = updIngSpicy03;
                refButton = btnIngAdd03;
            }
            return;
        }

        //cboIngList_SelectedIndexChanged version
        private void getObjectRef(object sender, ref ComboBox refCBOIngName, ref Label refLBLIngQuantity, ref Label refLBLIngUnit, ref Label refLBLIngSpicy, ref Button refButton)
        {
            if (Object.ReferenceEquals(sender, cboIngList00))
            {
                refCBOIngName = cboIngList00;
                refLBLIngQuantity = lblIngQuantity00;
                refLBLIngUnit = lblIngQuantityUnits00;
                refLBLIngSpicy = lblSpicy00;
                refButton = btnView00;
            }
            else if (Object.ReferenceEquals(sender, cboIngList01))
            {
                refCBOIngName = cboIngList01;
                refLBLIngQuantity = lblIngQuantity01;
                refLBLIngUnit = lblIngQuantityUnits01;
                refLBLIngSpicy = lblSpicy01;
                refButton = btnView01;
            }
            else if (Object.ReferenceEquals(sender, cboIngList02))
            {
                refCBOIngName = cboIngList02;
                refLBLIngQuantity = lblIngQuantity02;
                refLBLIngUnit = lblIngQuantityUnits02;
                refLBLIngSpicy = lblSpicy02;
                refButton = btnView02;
            }
            else if (Object.ReferenceEquals(sender, cboIngListE0))
            {
                refCBOIngName = cboIngListE0;
                refLBLIngQuantity = lblIngQuantityE0;
                refLBLIngUnit = lblIngQuantityUnitsE0;
                refLBLIngSpicy = lblSpicyE0;
                refButton = btnEditE0;
            }
            return;
        }
        //End getObjectRef() methods.

        //Method to clear data to defaults
        private void clearData(ref TextBox refTXTIngName, ref NumericUpDown refUPDIngQuantity, ref ComboBox refCBOIngUnit, ref NumericUpDown refUPDIngSpicy)
        {
            refTXTIngName.Text = String.Empty;
            refUPDIngQuantity.Text = "0";
            refCBOIngUnit.Text = String.Empty;
            refUPDIngSpicy.Text = "0.0";
        }
        private void clearData(ref ComboBox refCBOIngName, ref Label refLBLIngQuantity, ref Label refLBLIngUnit, ref Label refLBLIngSpicy)
        {
            refCBOIngName.Text = String.Empty;
            refLBLIngQuantity.Text = "0";
            refLBLIngUnit.Text = String.Empty;
            refLBLIngSpicy.Text = "0.0";
        }
        //Clear data end

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cboIngListE0.Text == String.Empty)
            {
                MessageBox.Show("Please select an item to edit.\n");
                return;
            }

            if (btnConfirmE0.Enabled == false)
            {
                //Enabled edit line
                txtIngNameE0.Enabled = true;
                updIngQuantityE0.Enabled = true;
                cboIngQuantityUnitsE0.Enabled = true;
                updIngSpicyE0.Enabled = true;
                btnConfirmE0.Enabled = true;
                //Disable combo box
                cboIngListE0.Enabled = false;
                //Change button name
                btnEditE0.Text = "Cancel";

                //Get index to transfer data to edit line
                int index = cboIngListE0.SelectedIndex;

                //Grabs item data to display
                if (index != -1)
                {
                    //Temp ingData, gets item from index location
                    ingData tempIngData = getListItem(index);

                    //Display
                    txtIngNameE0.Text = tempIngData.Name;
                    updIngQuantityE0.Text = (tempIngData.Quantity).ToString();
                    cboIngQuantityUnitsE0.Text = tempIngData.Unit;
                    updIngSpicyE0.Text = (tempIngData.Spicyness).ToString();
                }
            }
            else if (btnConfirmE0.Enabled == true)
            {
                //Disable edit line
                txtIngNameE0.Enabled = false;
                updIngQuantityE0.Enabled = false;
                cboIngQuantityUnitsE0.Enabled = false;
                updIngSpicyE0.Enabled = false;
                btnConfirmE0.Enabled = false;
                //Enable combo box
                cboIngListE0.Enabled = true;
                //Change button name
                btnEditE0.Text = "Edit";

                //Clear display
                clearData(ref txtIngNameE0, ref updIngQuantityE0, ref cboIngQuantityUnitsE0, ref updIngSpicyE0);
            }
            return;
        }

        

        //Checks if the object is a edit line
        private bool isEditLine(object sender)
        {
            if (Object.ReferenceEquals(sender, txtIngNameE0))
            {
                return true;
            }
            return false;
        }

        //TODO: Finish
        private void btnConfirmE0_Click(object sender, EventArgs e)
        {
            string regexTextOnly = @"^[^\d\s]+$";//Text only, no numbers or spaces
            bool isValidText = Regex.IsMatch(txtIngNameE0.Text, regexTextOnly);
            //Regex backup check
            if (txtIngNameE0.Text == String.Empty || !isValidText)
            {
                return;
            }
            //Units check
            if (txtIngNameE0.Text == String.Empty)
            {
                MessageBox.Show("Must have a Unit.");
                return;
            }


            //Get index
            int index = cboIngListE0.SelectedIndex;

            //Temp ingData, gets item from index location
            ingData tempIngData = getListItem(index);

            //Grabs item data to write
            //TODO: Update display automatically
            if (index != -1)
            {
                //Write
                tempIngData.Name = txtIngNameE0.Text;
                tempIngData.Quantity = Convert.ToInt32(updIngQuantityE0.Text);
                tempIngData.Unit = cboIngQuantityUnitsE0.Text;
                tempIngData.Spicyness = float.Parse(updIngSpicyE0.Text);

                //Display
                txtIngNameE0.Text = txtIngNameE0.Text;
                lblIngQuantityE0.Text = updIngQuantityE0.Text;
                lblIngQuantityUnitsE0.Text = cboIngQuantityUnitsE0.Text;
                lblSpicyE0.Text = updIngSpicyE0.Text;

                //Change Button Name
                btnEditE0.Text = "Done";
            }

            //Write to file in line


        }
    }
}
