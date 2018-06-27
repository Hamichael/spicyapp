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
            this.pnlIntro = new System.Windows.Forms.Panel();
            this.btnIntPanelClose = new System.Windows.Forms.Button();
            this.btnIntPanelShow = new System.Windows.Forms.Button();
            this.btnIngPanel = new System.Windows.Forms.Button();
            this.btnRecPanel = new System.Windows.Forms.Button();
            this.btnCrdPanel = new System.Windows.Forms.Button();
            this.pnlIng = new System.Windows.Forms.Panel();
            this.pnlRec = new System.Windows.Forms.Panel();
            this.pnlCrd = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblIngTitle = new System.Windows.Forms.Label();
            this.pnlIntro.SuspendLayout();
            this.pnlIng.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIntro
            // 
            this.pnlIntro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIntro.Controls.Add(this.btnIntPanelClose);
            this.pnlIntro.Location = new System.Drawing.Point(393, 12);
            this.pnlIntro.Name = "pnlIntro";
            this.pnlIntro.Size = new System.Drawing.Size(132, 50);
            this.pnlIntro.TabIndex = 0;
            // 
            // btnIntPanelClose
            // 
            this.btnIntPanelClose.Location = new System.Drawing.Point(30, 3);
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
            this.pnlIng.Controls.Add(this.lblIngTitle);
            this.pnlIng.Location = new System.Drawing.Point(147, 76);
            this.pnlIng.Name = "pnlIng";
            this.pnlIng.Size = new System.Drawing.Size(411, 107);
            this.pnlIng.TabIndex = 1;
            // 
            // pnlRec
            // 
            this.pnlRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRec.Location = new System.Drawing.Point(147, 189);
            this.pnlRec.Name = "pnlRec";
            this.pnlRec.Size = new System.Drawing.Size(411, 105);
            this.pnlRec.TabIndex = 2;
            // 
            // pnlCrd
            // 
            this.pnlCrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCrd.Location = new System.Drawing.Point(147, 300);
            this.pnlCrd.Name = "pnlCrd";
            this.pnlCrd.Size = new System.Drawing.Size(411, 115);
            this.pnlCrd.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblIngTitle
            // 
            this.lblIngTitle.Location = new System.Drawing.Point(109, 10);
            this.lblIngTitle.Name = "lblIngTitle";
            this.lblIngTitle.Size = new System.Drawing.Size(100, 23);
            this.lblIngTitle.TabIndex = 0;
            this.lblIngTitle.Text = "Ingredients";
            this.lblIngTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Controls.Add(this.pnlIntro);
            this.Controls.Add(this.btnIntPanelShow);
            this.Name = "SpicyApp";
            this.Text = "SpicyApp";
            this.pnlIntro.ResumeLayout(false);
            this.pnlIng.ResumeLayout(false);
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
    }
}

