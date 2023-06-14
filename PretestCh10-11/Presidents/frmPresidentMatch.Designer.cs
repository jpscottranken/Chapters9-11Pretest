namespace Presidents
{
    partial class frmPresidentMatch
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.ddlFirstName = new System.Windows.Forms.ComboBox();
            this.ddlLastName = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.pbPresidentImage = new System.Windows.Forms.PictureBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGoToMainForm = new System.Windows.Forms.Button();
            this.gbParty = new System.Windows.Forms.GroupBox();
            this.rbIndependent = new System.Windows.Forms.RadioButton();
            this.rbRepublican = new System.Windows.Forms.RadioButton();
            this.rbDemocrat = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPresidentImage)).BeginInit();
            this.gbParty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(87, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(904, 92);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Match The U.S. Presidents Game";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ddlFirstName
            // 
            this.ddlFirstName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlFirstName.FormattingEnabled = true;
            this.ddlFirstName.Location = new System.Drawing.Point(63, 211);
            this.ddlFirstName.Name = "ddlFirstName";
            this.ddlFirstName.Size = new System.Drawing.Size(274, 37);
            this.ddlFirstName.TabIndex = 0;
            // 
            // ddlLastName
            // 
            this.ddlLastName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlLastName.FormattingEnabled = true;
            this.ddlLastName.Location = new System.Drawing.Point(446, 211);
            this.ddlLastName.Name = "ddlLastName";
            this.ddlLastName.Size = new System.Drawing.Size(274, 37);
            this.ddlLastName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblFirstName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.Location = new System.Drawing.Point(95, 154);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(222, 43);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLastName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.lblLastName.Location = new System.Drawing.Point(480, 154);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(222, 43);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPresidentImage
            // 
            this.pbPresidentImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbPresidentImage.Location = new System.Drawing.Point(379, 268);
            this.pbPresidentImage.Name = "pbPresidentImage";
            this.pbPresidentImage.Size = new System.Drawing.Size(375, 380);
            this.pbPresidentImage.TabIndex = 5;
            this.pbPresidentImage.TabStop = false;
            // 
            // btnMatch
            // 
            this.btnMatch.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatch.Location = new System.Drawing.Point(63, 293);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(274, 73);
            this.btnMatch.TabIndex = 2;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(63, 416);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(274, 73);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(63, 547);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(274, 73);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGoToMainForm
            // 
            this.btnGoToMainForm.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToMainForm.Location = new System.Drawing.Point(788, 575);
            this.btnGoToMainForm.Name = "btnGoToMainForm";
            this.btnGoToMainForm.Size = new System.Drawing.Size(274, 73);
            this.btnGoToMainForm.TabIndex = 5;
            this.btnGoToMainForm.Text = "Go To Main Form";
            this.btnGoToMainForm.UseVisualStyleBackColor = true;
            this.btnGoToMainForm.Click += new System.EventHandler(this.btnGoToMainForm_Click);
            // 
            // gbParty
            // 
            this.gbParty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbParty.Controls.Add(this.rbIndependent);
            this.gbParty.Controls.Add(this.rbRepublican);
            this.gbParty.Controls.Add(this.rbDemocrat);
            this.gbParty.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParty.Location = new System.Drawing.Point(824, 268);
            this.gbParty.Name = "gbParty";
            this.gbParty.Size = new System.Drawing.Size(200, 242);
            this.gbParty.TabIndex = 10;
            this.gbParty.TabStop = false;
            this.gbParty.Text = "Party";
            // 
            // rbIndependent
            // 
            this.rbIndependent.AutoSize = true;
            this.rbIndependent.Location = new System.Drawing.Point(21, 168);
            this.rbIndependent.Name = "rbIndependent";
            this.rbIndependent.Size = new System.Drawing.Size(148, 33);
            this.rbIndependent.TabIndex = 2;
            this.rbIndependent.TabStop = true;
            this.rbIndependent.Text = "Independent";
            this.rbIndependent.UseVisualStyleBackColor = true;
            // 
            // rbRepublican
            // 
            this.rbRepublican.AutoSize = true;
            this.rbRepublican.Location = new System.Drawing.Point(21, 103);
            this.rbRepublican.Name = "rbRepublican";
            this.rbRepublican.Size = new System.Drawing.Size(136, 33);
            this.rbRepublican.TabIndex = 1;
            this.rbRepublican.TabStop = true;
            this.rbRepublican.Text = "Republican";
            this.rbRepublican.UseVisualStyleBackColor = true;
            // 
            // rbDemocrat
            // 
            this.rbDemocrat.AutoSize = true;
            this.rbDemocrat.Location = new System.Drawing.Point(21, 45);
            this.rbDemocrat.Name = "rbDemocrat";
            this.rbDemocrat.Size = new System.Drawing.Size(123, 33);
            this.rbDemocrat.TabIndex = 0;
            this.rbDemocrat.TabStop = true;
            this.rbDemocrat.Text = "Democrat";
            this.rbDemocrat.UseVisualStyleBackColor = true;
            // 
            // frmPresidentMatch
            // 
            this.AcceptButton = this.btnMatch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1086, 702);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbParty);
            this.Controls.Add(this.btnGoToMainForm);
            this.Controls.Add(this.pbPresidentImage);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.ddlLastName);
            this.Controls.Add(this.ddlFirstName);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmPresidentMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "President Match";
            this.Load += new System.EventHandler(this.frmPresidentMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPresidentImage)).EndInit();
            this.gbParty.ResumeLayout(false);
            this.gbParty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox ddlFirstName;
        private System.Windows.Forms.ComboBox ddlLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.PictureBox pbPresidentImage;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGoToMainForm;
        private System.Windows.Forms.GroupBox gbParty;
        private System.Windows.Forms.RadioButton rbIndependent;
        private System.Windows.Forms.RadioButton rbRepublican;
        private System.Windows.Forms.RadioButton rbDemocrat;
        private System.Windows.Forms.Timer timer1;
    }
}

