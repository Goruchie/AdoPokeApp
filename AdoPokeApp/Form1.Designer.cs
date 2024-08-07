namespace AdoPokeApp
{
    partial class AdoPokeApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdoPokeApp));
            this.dgvPokemons = new System.Windows.Forms.DataGridView();
            this.pbxPokemon = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.btnDeleteL = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblField = new System.Windows.Forms.Label();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.lblCriteria = new System.Windows.Forms.Label();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.lblAdFilter = new System.Windows.Forms.Label();
            this.txbAdFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemons
            // 
            this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemons.Location = new System.Drawing.Point(12, 81);
            this.dgvPokemons.MultiSelect = false;
            this.dgvPokemons.Name = "dgvPokemons";
            this.dgvPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemons.Size = new System.Drawing.Size(685, 289);
            this.dgvPokemons.TabIndex = 0;
            this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
            // 
            // pbxPokemon
            // 
            this.pbxPokemon.Location = new System.Drawing.Point(703, 81);
            this.pbxPokemon.Name = "pbxPokemon";
            this.pbxPokemon.Size = new System.Drawing.Size(327, 289);
            this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemon.TabIndex = 1;
            this.pbxPokemon.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(94, 390);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.Location = new System.Drawing.Point(175, 390);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteP.TabIndex = 4;
            this.btnDeleteP.Text = "Delete Physically";
            this.btnDeleteP.UseVisualStyleBackColor = true;
            this.btnDeleteP.Click += new System.EventHandler(this.btnDeleteP_Click);
            // 
            // btnDeleteL
            // 
            this.btnDeleteL.Location = new System.Drawing.Point(294, 390);
            this.btnDeleteL.Name = "btnDeleteL";
            this.btnDeleteL.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteL.TabIndex = 5;
            this.btnDeleteL.Text = "Delete Logically";
            this.btnDeleteL.UseVisualStyleBackColor = true;
            this.btnDeleteL.Click += new System.EventHandler(this.btnDeleteL_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 56);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(63, 13);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Quick Filter:";
            // 
            // txbFilter
            // 
            this.txbFilter.Location = new System.Drawing.Point(81, 53);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(169, 20);
            this.txbFilter.TabIndex = 7;
            this.txbFilter.TextChanged += new System.EventHandler(this.txbFilter_TextChanged);
            this.txbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFilter_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(618, 441);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(15, 446);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(29, 13);
            this.lblField.TabIndex = 9;
            this.lblField.Text = "Field";
            // 
            // cboField
            // 
            this.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(76, 442);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 21);
            this.cboField.TabIndex = 10;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // lblCriteria
            // 
            this.lblCriteria.AutoSize = true;
            this.lblCriteria.Location = new System.Drawing.Point(223, 446);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(39, 13);
            this.lblCriteria.TabIndex = 11;
            this.lblCriteria.Text = "Criteria";
            // 
            // cboCriteria
            // 
            this.cboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriteria.FormattingEnabled = true;
            this.cboCriteria.Location = new System.Drawing.Point(284, 442);
            this.cboCriteria.Name = "cboCriteria";
            this.cboCriteria.Size = new System.Drawing.Size(121, 21);
            this.cboCriteria.TabIndex = 12;
            // 
            // lblAdFilter
            // 
            this.lblAdFilter.AutoSize = true;
            this.lblAdFilter.Location = new System.Drawing.Point(431, 446);
            this.lblAdFilter.Name = "lblAdFilter";
            this.lblAdFilter.Size = new System.Drawing.Size(29, 13);
            this.lblAdFilter.TabIndex = 13;
            this.lblAdFilter.Text = "Filter";
            // 
            // txbAdFilter
            // 
            this.txbAdFilter.Location = new System.Drawing.Point(492, 442);
            this.txbAdFilter.Name = "txbAdFilter";
            this.txbAdFilter.Size = new System.Drawing.Size(100, 20);
            this.txbAdFilter.TabIndex = 14;
            // 
            // AdoPokeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 493);
            this.Controls.Add(this.txbAdFilter);
            this.Controls.Add(this.lblAdFilter);
            this.Controls.Add(this.cboCriteria);
            this.Controls.Add(this.lblCriteria);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnDeleteL);
            this.Controls.Add(this.btnDeleteP);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbxPokemon);
            this.Controls.Add(this.dgvPokemons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdoPokeApp";
            this.Text = "AdoPokeApp";
            this.Load += new System.EventHandler(this.AdoPokeApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemons;
        private System.Windows.Forms.PictureBox pbxPokemon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDeleteP;
        private System.Windows.Forms.Button btnDeleteL;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.Label lblAdFilter;
        private System.Windows.Forms.TextBox txbAdFilter;
    }
}

