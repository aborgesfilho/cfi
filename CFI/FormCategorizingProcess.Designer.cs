
namespace CFI
{
    partial class FormCategorizingProcess
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.dtgrdInstrumentInput = new System.Windows.Forms.DataGridView();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.txtJsonFile = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.dtgrdInstrumentOutput = new System.Windows.Forms.DataGridView();
            this.btnProcessOutput = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdInstrumentInput)).BeginInit();
            this.grpOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdInstrumentOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.dtgrdInstrumentInput);
            this.grpInput.Controls.Add(this.btnChooseFile);
            this.grpInput.Controls.Add(this.txtJsonFile);
            this.grpInput.Location = new System.Drawing.Point(27, 22);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(604, 199);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // dtgrdInstrumentInput
            // 
            this.dtgrdInstrumentInput.AllowUserToAddRows = false;
            this.dtgrdInstrumentInput.AllowUserToDeleteRows = false;
            this.dtgrdInstrumentInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdInstrumentInput.Location = new System.Drawing.Point(7, 52);
            this.dtgrdInstrumentInput.Name = "dtgrdInstrumentInput";
            this.dtgrdInstrumentInput.RowTemplate.Height = 25;
            this.dtgrdInstrumentInput.Size = new System.Drawing.Size(465, 141);
            this.dtgrdInstrumentInput.TabIndex = 2;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(481, 21);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(117, 24);
            this.btnChooseFile.TabIndex = 1;
            this.btnChooseFile.Text = "Choose File ...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtJsonFile
            // 
            this.txtJsonFile.Location = new System.Drawing.Point(7, 23);
            this.txtJsonFile.Name = "txtJsonFile";
            this.txtJsonFile.ReadOnly = true;
            this.txtJsonFile.Size = new System.Drawing.Size(465, 23);
            this.txtJsonFile.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.btnProcessOutput);
            this.grpOutput.Controls.Add(this.dtgrdInstrumentOutput);
            this.grpOutput.Location = new System.Drawing.Point(27, 237);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(604, 199);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // dtgrdInstrumentOutput
            // 
            this.dtgrdInstrumentOutput.AllowUserToAddRows = false;
            this.dtgrdInstrumentOutput.AllowUserToDeleteRows = false;
            this.dtgrdInstrumentOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdInstrumentOutput.Location = new System.Drawing.Point(7, 22);
            this.dtgrdInstrumentOutput.Name = "dtgrdInstrumentOutput";
            this.dtgrdInstrumentOutput.RowTemplate.Height = 25;
            this.dtgrdInstrumentOutput.Size = new System.Drawing.Size(465, 171);
            this.dtgrdInstrumentOutput.TabIndex = 2;
            // 
            // btnProcessOutput
            // 
            this.btnProcessOutput.Location = new System.Drawing.Point(481, 22);
            this.btnProcessOutput.Name = "btnProcessOutput";
            this.btnProcessOutput.Size = new System.Drawing.Size(117, 24);
            this.btnProcessOutput.TabIndex = 3;
            this.btnProcessOutput.Text = "ProcessOutput";
            this.btnProcessOutput.UseVisualStyleBackColor = true;
            this.btnProcessOutput.Click += new System.EventHandler(this.btnProcessOutput_Click);
            // 
            // FormCategorizingProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(819, 666);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategorizingProcess";
            this.Text = "FormCategorizingProcess";
            this.Load += new System.EventHandler(this.FormCategorizingProcess_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdInstrumentInput)).EndInit();
            this.grpOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdInstrumentOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox txtJsonFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dtgrdInstrumentInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.DataGridView dtgrdInstrumentOutput;
        private System.Windows.Forms.Button btnProcessOutput;
    }
}