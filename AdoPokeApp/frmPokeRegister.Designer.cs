﻿namespace AdoPokeApp
{
    partial class frmPokeRegister
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblWeakness = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboWeakness = new System.Windows.Forms.ComboBox();
            this.txbUrlImage = new System.Windows.Forms.TextBox();
            this.lblUrlImage = new System.Windows.Forms.Label();
            this.pbxPokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumber.Location = new System.Drawing.Point(75, 28);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(69, 20);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(89, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDescription.Location = new System.Drawing.Point(51, 117);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(164, 28);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(119, 20);
            this.txbNumber.TabIndex = 0;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(164, 73);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(119, 20);
            this.txbName.TabIndex = 1;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(164, 117);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(119, 20);
            this.txbDescription.TabIndex = 2;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(69, 311);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(208, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblType.Location = new System.Drawing.Point(97, 202);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 20);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type:";
            // 
            // lblWeakness
            // 
            this.lblWeakness.AutoSize = true;
            this.lblWeakness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWeakness.Location = new System.Drawing.Point(51, 250);
            this.lblWeakness.Name = "lblWeakness";
            this.lblWeakness.Size = new System.Drawing.Size(88, 20);
            this.lblWeakness.TabIndex = 9;
            this.lblWeakness.Text = "Weakness:";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(164, 201);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 4;
            // 
            // cboWeakness
            // 
            this.cboWeakness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeakness.FormattingEnabled = true;
            this.cboWeakness.Location = new System.Drawing.Point(164, 249);
            this.cboWeakness.Name = "cboWeakness";
            this.cboWeakness.Size = new System.Drawing.Size(121, 21);
            this.cboWeakness.TabIndex = 5;
            // 
            // txbUrlImage
            // 
            this.txbUrlImage.Location = new System.Drawing.Point(164, 160);
            this.txbUrlImage.Name = "txbUrlImage";
            this.txbUrlImage.Size = new System.Drawing.Size(119, 20);
            this.txbUrlImage.TabIndex = 3;
            this.txbUrlImage.Leave += new System.EventHandler(this.txbUrlImage_Leave);
            // 
            // lblUrlImage
            // 
            this.lblUrlImage.AutoSize = true;
            this.lblUrlImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUrlImage.Location = new System.Drawing.Point(51, 160);
            this.lblUrlImage.Name = "lblUrlImage";
            this.lblUrlImage.Size = new System.Drawing.Size(82, 20);
            this.lblUrlImage.TabIndex = 12;
            this.lblUrlImage.Text = "Url Image:";
            // 
            // pbxPokemon
            // 
            this.pbxPokemon.Location = new System.Drawing.Point(340, 28);
            this.pbxPokemon.Name = "pbxPokemon";
            this.pbxPokemon.Size = new System.Drawing.Size(344, 306);
            this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemon.TabIndex = 14;
            this.pbxPokemon.TabStop = false;
            // 
            // frmPokeRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 365);
            this.Controls.Add(this.pbxPokemon);
            this.Controls.Add(this.txbUrlImage);
            this.Controls.Add(this.lblUrlImage);
            this.Controls.Add(this.cboWeakness);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblWeakness);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmPokeRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Pokemon";
            this.Load += new System.EventHandler(this.frmPokeRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblWeakness;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboWeakness;
        private System.Windows.Forms.TextBox txbUrlImage;
        private System.Windows.Forms.Label lblUrlImage;
        private System.Windows.Forms.PictureBox pbxPokemon;
    }
}