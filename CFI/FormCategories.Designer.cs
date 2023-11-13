
namespace CFI
{
    partial class FormCategories
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
            this.dtgrdCategories = new System.Windows.Forms.DataGridView();
            this.txtDescriptionTemp = new System.Windows.Forms.TextBox();
            this.txtCodeTemp = new System.Windows.Forms.TextBox();
            this.txtMaximumValueTemp = new System.Windows.Forms.TextBox();
            this.txtMinimumValueTemp = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtMaximumValue = new System.Windows.Forms.TextBox();
            this.txtMinimumValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdCategories)).BeginInit();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrdCategories
            // 
            this.dtgrdCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdCategories.Location = new System.Drawing.Point(30, 196);
            this.dtgrdCategories.Name = "dtgrdCategories";
            this.dtgrdCategories.RowTemplate.Height = 25;
            this.dtgrdCategories.RowTemplate.ReadOnly = true;
            this.dtgrdCategories.ShowEditingIcon = false;
            this.dtgrdCategories.Size = new System.Drawing.Size(685, 216);
            this.dtgrdCategories.TabIndex = 0;
            this.dtgrdCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdCategories_CellClick);
            // 
            // txtDescriptionTemp
            // 
            this.txtDescriptionTemp.Location = new System.Drawing.Point(126, 461);
            this.txtDescriptionTemp.Name = "txtDescriptionTemp";
            this.txtDescriptionTemp.Size = new System.Drawing.Size(459, 23);
            this.txtDescriptionTemp.TabIndex = 9;
            this.txtDescriptionTemp.Visible = false;
            // 
            // txtCodeTemp
            // 
            this.txtCodeTemp.Location = new System.Drawing.Point(462, 421);
            this.txtCodeTemp.Name = "txtCodeTemp";
            this.txtCodeTemp.Size = new System.Drawing.Size(124, 23);
            this.txtCodeTemp.TabIndex = 8;
            this.txtCodeTemp.Visible = false;
            // 
            // txtMaximumValueTemp
            // 
            this.txtMaximumValueTemp.Location = new System.Drawing.Point(310, 420);
            this.txtMaximumValueTemp.Name = "txtMaximumValueTemp";
            this.txtMaximumValueTemp.Size = new System.Drawing.Size(109, 23);
            this.txtMaximumValueTemp.TabIndex = 7;
            this.txtMaximumValueTemp.Visible = false;
            // 
            // txtMinimumValueTemp
            // 
            this.txtMinimumValueTemp.Location = new System.Drawing.Point(125, 418);
            this.txtMinimumValueTemp.Name = "txtMinimumValueTemp";
            this.txtMinimumValueTemp.Size = new System.Drawing.Size(114, 23);
            this.txtMinimumValueTemp.TabIndex = 6;
            this.txtMinimumValueTemp.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.button1);
            this.grpCategory.Controls.Add(this.btnDelete);
            this.grpCategory.Controls.Add(this.btnSave);
            this.grpCategory.Controls.Add(this.btnNew);
            this.grpCategory.Controls.Add(this.txtId);
            this.grpCategory.Controls.Add(this.txtDescription);
            this.grpCategory.Controls.Add(this.txtCode);
            this.grpCategory.Controls.Add(this.txtMaximumValue);
            this.grpCategory.Controls.Add(this.txtMinimumValue);
            this.grpCategory.Location = new System.Drawing.Point(30, 17);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(685, 173);
            this.grpCategory.TabIndex = 10;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Category Details";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(587, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(587, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 32);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.Location = new System.Drawing.Point(587, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNew.Location = new System.Drawing.Point(587, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(72, 32);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(25, 144);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 23);
            this.txtId.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(75, 103);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(459, 23);
            this.txtDescription.TabIndex = 9;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(75, 62);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(114, 23);
            this.txtCode.TabIndex = 8;
            // 
            // txtMaximumValue
            // 
            this.txtMaximumValue.Location = new System.Drawing.Point(310, 19);
            this.txtMaximumValue.Name = "txtMaximumValue";
            this.txtMaximumValue.Size = new System.Drawing.Size(114, 23);
            this.txtMaximumValue.TabIndex = 7;
            // 
            // txtMinimumValue
            // 
            this.txtMinimumValue.Location = new System.Drawing.Point(75, 22);
            this.txtMinimumValue.Name = "txtMinimumValue";
            this.txtMinimumValue.Size = new System.Drawing.Size(114, 23);
            this.txtMinimumValue.TabIndex = 6;
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.txtDescriptionTemp);
            this.Controls.Add(this.txtCodeTemp);
            this.Controls.Add(this.txtMaximumValueTemp);
            this.Controls.Add(this.txtMinimumValueTemp);
            this.Controls.Add(this.dtgrdCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.FormCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdCategories)).EndInit();
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdCategories;
        private System.Windows.Forms.TextBox txtDescriptionTemp;
        private System.Windows.Forms.TextBox txtCodeTemp;
        private System.Windows.Forms.TextBox txtMaximumValueTemp;
        private System.Windows.Forms.TextBox txtMinimumValueTemp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtMaximumValue;
        private System.Windows.Forms.TextBox txtMinimumValue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button button1;
    }
}