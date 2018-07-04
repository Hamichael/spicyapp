namespace TestPanelClose
{
    partial class SpicyApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlIntro = new System.Windows.Forms.Panel();
            this.btnIntPanelClose = new System.Windows.Forms.Button();
            this.btnIntPanelShow = new System.Windows.Forms.Button();
            this.btnIngPanel = new System.Windows.Forms.Button();
            this.btnRecPanel = new System.Windows.Forms.Button();
            this.btnCrdPanel = new System.Windows.Forms.Button();
            this.pnlIng = new System.Windows.Forms.Panel();
            this.cboIngQuantityUnits = new System.Windows.Forms.ComboBox();
            this.updIngQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblAddIngPrompt = new System.Windows.Forms.Label();
            this.txtIngName = new System.Windows.Forms.TextBox();
            this.lblIngTitle = new System.Windows.Forms.Label();
            this.pnlRec = new System.Windows.Forms.Panel();
            this.lblRecTitle = new System.Windows.Forms.Label();
            this.pnlCrd = new System.Windows.Forms.Panel();
            this.lblCrdTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tipSpicyApp = new System.Windows.Forms.ToolTip(this.components);
            this.btnIngAdd = new System.Windows.Forms.Button();
            this.pnlIntro.SuspendLayout();
            this.pnlIng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updIngQuantity)).BeginInit();
            this.pnlRec.SuspendLayout();
            this.pnlCrd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIntro
            // 
            this.pnlIntro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIntro.Controls.Add(this.btnIntPanelClose);
            this.pnlIntro.Location = new System.Drawing.Point(12, 12);
            this.pnlIntro.Name = "pnlIntro";
            this.pnlIntro.Size = new System.Drawing.Size(693, 415);
            this.pnlIntro.TabIndex = 0;
            // 
            // btnIntPanelClose
            // 
            this.btnIntPanelClose.Location = new System.Drawing.Point(311, 379);
            this.btnIntPanelClose.Name = "btnIntPanelClose";
            this.btnIntPanelClose.Size = new System.Drawing.Size(75, 23);
            this.btnIntPanelClose.TabIndex = 0;
            this.btnIntPanelClose.Text = "Got it!";
            this.btnIntPanelClose.UseVisualStyleBackColor = true;
            this.btnIntPanelClose.Click += new System.EventHandler(this.btn_introPanelClose_Click);
            // 
            // btnIntPanelShow
            // 
            this.btnIntPanelShow.Location = new System.Drawing.Point(12, 12);
            this.btnIntPanelShow.Name = "btnIntPanelShow";
            this.btnIntPanelShow.Size = new System.Drawing.Size(75, 50);
            this.btnIntPanelShow.TabIndex = 1;
            this.btnIntPanelShow.Text = "introPanelText";
            this.btnIntPanelShow.UseVisualStyleBackColor = true;
            this.btnIntPanelShow.Click += new System.EventHandler(this.btnIntroPanelShow_Click);
            // 
            // btnIngPanel
            // 
            this.btnIngPanel.Location = new System.Drawing.Point(12, 68);
            this.btnIngPanel.Name = "btnIngPanel";
            this.btnIngPanel.Size = new System.Drawing.Size(75, 50);
            this.btnIngPanel.TabIndex = 2;
            this.btnIngPanel.Text = "ingredientsPanelText";
            this.btnIngPanel.UseVisualStyleBackColor = true;
            this.btnIngPanel.Click += new System.EventHandler(this.btnIngPanel_Click);
            // 
            // btnRecPanel
            // 
            this.btnRecPanel.Location = new System.Drawing.Point(12, 124);
            this.btnRecPanel.Name = "btnRecPanel";
            this.btnRecPanel.Size = new System.Drawing.Size(75, 50);
            this.btnRecPanel.TabIndex = 3;
            this.btnRecPanel.Text = "recipePanelText";
            this.btnRecPanel.UseVisualStyleBackColor = true;
            this.btnRecPanel.Click += new System.EventHandler(this.btnRecPanel_Click);
            // 
            // btnCrdPanel
            // 
            this.btnCrdPanel.Location = new System.Drawing.Point(12, 180);
            this.btnCrdPanel.Name = "btnCrdPanel";
            this.btnCrdPanel.Size = new System.Drawing.Size(75, 50);
            this.btnCrdPanel.TabIndex = 4;
            this.btnCrdPanel.Text = "creditsPanelText";
            this.btnCrdPanel.UseVisualStyleBackColor = true;
            this.btnCrdPanel.Click += new System.EventHandler(this.btnCrdPanel_Click);
            // 
            // pnlIng
            // 
            this.pnlIng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIng.Controls.Add(this.btnIngAdd);
            this.pnlIng.Controls.Add(this.cboIngQuantityUnits);
            this.pnlIng.Controls.Add(this.updIngQuantity);
            this.pnlIng.Controls.Add(this.lblAddIngPrompt);
            this.pnlIng.Controls.Add(this.txtIngName);
            this.pnlIng.Controls.Add(this.lblIngTitle);
            this.pnlIng.Location = new System.Drawing.Point(147, 76);
            this.pnlIng.Name = "pnlIng";
            this.pnlIng.Size = new System.Drawing.Size(509, 107);
            this.pnlIng.TabIndex = 1;
            // 
            // cboIngQuantityUnits
            // 
            this.cboIngQuantityUnits.FormattingEnabled = true;
            this.cboIngQuantityUnits.Items.AddRange(new object[] {
            "cups",
            "tsp",
            "oz"});
            this.cboIngQuantityUnits.Location = new System.Drawing.Point(356, 76);
            this.cboIngQuantityUnits.Name = "cboIngQuantityUnits";
            this.cboIngQuantityUnits.Size = new System.Drawing.Size(73, 21);
            this.cboIngQuantityUnits.TabIndex = 4;
            // 
            // updIngQuantity
            // 
            this.updIngQuantity.Location = new System.Drawing.Point(297, 77);
            this.updIngQuantity.Name = "updIngQuantity";
            this.updIngQuantity.Size = new System.Drawing.Size(53, 20);
            this.updIngQuantity.TabIndex = 3;
            this.tipSpicyApp.SetToolTip(this.updIngQuantity, "Quantity");
            // 
            // lblAddIngPrompt
            // 
            this.lblAddIngPrompt.Location = new System.Drawing.Point(3, 75);
            this.lblAddIngPrompt.Name = "lblAddIngPrompt";
            this.lblAddIngPrompt.Size = new System.Drawing.Size(114, 23);
            this.lblAddIngPrompt.TabIndex = 2;
            this.lblAddIngPrompt.Text = "Add new Ingredient:";
            this.lblAddIngPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIngName
            // 
            this.txtIngName.Location = new System.Drawing.Point(123, 77);
            this.txtIngName.MaxLength = 16;
            this.txtIngName.Name = "txtIngName";
            this.txtIngName.Size = new System.Drawing.Size(168, 20);
            this.txtIngName.TabIndex = 1;
            this.tipSpicyApp.SetToolTip(this.txtIngName, "Ingredient Name");
            this.txtIngName.Validating += new System.ComponentModel.CancelEventHandler(this.txtIngName_Validating);
            // 
            // lblIngTitle
            // 
            this.lblIngTitle.Location = new System.Drawing.Point(151, -1);
            this.lblIngTitle.Name = "lblIngTitle";
            this.lblIngTitle.Size = new System.Drawing.Size(100, 23);
            this.lblIngTitle.TabIndex = 0;
            this.lblIngTitle.Text = "Ingredients";
            this.lblIngTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRec
            // 
            this.pnlRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRec.Controls.Add(this.lblRecTitle);
            this.pnlRec.Location = new System.Drawing.Point(147, 189);
            this.pnlRec.Name = "pnlRec";
            this.pnlRec.Size = new System.Drawing.Size(509, 105);
            this.pnlRec.TabIndex = 2;
            // 
            // lblRecTitle
            // 
            this.lblRecTitle.Location = new System.Drawing.Point(151, 0);
            this.lblRecTitle.Name = "lblRecTitle";
            this.lblRecTitle.Size = new System.Drawing.Size(100, 23);
            this.lblRecTitle.TabIndex = 1;
            this.lblRecTitle.Text = "Recipes";
            this.lblRecTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCrd
            // 
            this.pnlCrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCrd.Controls.Add(this.lblCrdTitle);
            this.pnlCrd.Location = new System.Drawing.Point(147, 300);
            this.pnlCrd.Name = "pnlCrd";
            this.pnlCrd.Size = new System.Drawing.Size(509, 115);
            this.pnlCrd.TabIndex = 3;
            // 
            // lblCrdTitle
            // 
            this.lblCrdTitle.Location = new System.Drawing.Point(151, 0);
            this.lblCrdTitle.Name = "lblCrdTitle";
            this.lblCrdTitle.Size = new System.Drawing.Size(100, 23);
            this.lblCrdTitle.TabIndex = 2;
            this.lblCrdTitle.Text = "Credits";
            this.lblCrdTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnIngAdd
            // 
            this.btnIngAdd.Enabled = false;
            this.btnIngAdd.Location = new System.Drawing.Point(433, 75);
            this.btnIngAdd.Name = "btnIngAdd";
            this.btnIngAdd.Size = new System.Drawing.Size(43, 23);
            this.btnIngAdd.TabIndex = 5;
            this.btnIngAdd.Text = "Add";
            this.btnIngAdd.UseVisualStyleBackColor = true;
            this.btnIngAdd.Click += new System.EventHandler(this.btnIngAdd_Click);
            // 
            // SpicyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 439);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlCrd);
            this.Controls.Add(this.pnlRec);
            this.Controls.Add(this.pnlIng);
            this.Controls.Add(this.btnCrdPanel);
            this.Controls.Add(this.btnRecPanel);
            this.Controls.Add(this.btnIngPanel);
            this.Controls.Add(this.btnIntPanelShow);
            this.Controls.Add(this.pnlIntro);
            this.Name = "SpicyApp";
            this.Text = "SpicyApp";
            this.pnlIntro.ResumeLayout(false);
            this.pnlIng.ResumeLayout(false);
            this.pnlIng.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updIngQuantity)).EndInit();
            this.pnlRec.ResumeLayout(false);
            this.pnlCrd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIntro;
        private System.Windows.Forms.Button btnIntPanelClose;
        private System.Windows.Forms.Button btnIntPanelShow;
        private System.Windows.Forms.Button btnIngPanel;
        private System.Windows.Forms.Button btnRecPanel;
        private System.Windows.Forms.Button btnCrdPanel;
        private System.Windows.Forms.Panel pnlIng;
        private System.Windows.Forms.Panel pnlRec;
        private System.Windows.Forms.Panel pnlCrd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblIngTitle;
        private System.Windows.Forms.Label lblRecTitle;
        private System.Windows.Forms.Label lblCrdTitle;
        private System.Windows.Forms.NumericUpDown updIngQuantity;
        private System.Windows.Forms.Label lblAddIngPrompt;
        private System.Windows.Forms.TextBox txtIngName;
        private System.Windows.Forms.ToolTip tipSpicyApp;
        private System.Windows.Forms.ComboBox cboIngQuantityUnits;
        private System.Windows.Forms.Button btnIngAdd;
    }
}

