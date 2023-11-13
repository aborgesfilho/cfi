using CFI.DB;
using CFI.Models;
using CFI.Interfaces;
using CFI.Repositories;
using CFI.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;

namespace CFI
{
    public partial class FormCategories : Form
    {
        public IConfiguration Configuration { get; set; }
        protected bool fieldChanged;
        protected bool newRecord;

        private readonly Category _Category;
        private readonly ICategoryController _ICategoryController;

        public FormCategories()
        {
            InitializeComponent();
            //_ICategory = (ICategory)Program.ServiceProvider.GetService(typeof(ICategory));
            
            _Category = (Category)FormatterServices.GetUninitializedObject(typeof(Category));

            _ICategoryController = (ICategoryController)Program.ServiceProvider.GetService(typeof(ICategoryController));
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            fieldChanged = false;
            newRecord = false;
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            try
            {
                dtgrdCategories.DataSource = GetAllCategories();
                dtgrdCategories.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Category> GetAllCategories()
        {
            var allCategories = _ICategoryController.GetAllCategoryData();
            return allCategories;
        }

        private bool NotAllFieldsFullfiled()
        {
            return (txtMinimumValue.Text.Trim() == "" ||
                    txtMaximumValue.Text.Trim() == "" ||
                    txtCode.Text.Trim() == "" ||
                    txtDescription.Text.Trim() == "");
        }

        private void dtgrdCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtId.Text = dtgrdCategories.Rows[e.RowIndex].Cells[0].Value.ToString();
                // Visible fields
                txtMinimumValue.Text = dtgrdCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaximumValue.Text = dtgrdCategories.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCode.Text = dtgrdCategories.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDescription.Text = dtgrdCategories.Rows[e.RowIndex].Cells[4].Value.ToString();
                // Temp fields
                txtMinimumValueTemp.Text = dtgrdCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaximumValueTemp.Text = dtgrdCategories.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCodeTemp.Text = dtgrdCategories.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDescriptionTemp.Text = dtgrdCategories.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (newRecord)
                return;

            if ((txtMinimumValue.Text.Trim() != txtMinimumValueTemp.Text.Trim())
                || (txtMaximumValue.Text.Trim() != txtMaximumValueTemp.Text.Trim())
                || (txtCode.Text.Trim() != txtCodeTemp.Text.Trim())
                || (txtDescription.Text.Trim() != txtDescriptionTemp.Text.Trim()))
                fieldChanged = true;
            else
                fieldChanged = false;

            grpCategory.Text = grpCategory.Text.Replace(" (Modified)", "") + (fieldChanged ? " (Modified)" : "");
            btnSave.Enabled = fieldChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fieldChanged)
            {
                if (MessageBox.Show("Dischard Changes ?", "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtMinimumValue.Text = txtMinimumValueTemp.Text;
                    txtMaximumValue.Text = txtMaximumValueTemp.Text;
                    txtCode.Text = txtCodeTemp.Text;
                    txtDescription.Text = txtDescriptionTemp.Text;
                    fieldChanged = false;
                    grpCategory.Text = grpCategory.Text.Replace(" (Modified)", "") + (fieldChanged ? " (Modified)" : "");
                    btnSave.Enabled = fieldChanged;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            fieldChanged = true;
            newRecord = true;
            txtMinimumValue.Text = "";
            txtMaximumValue.Text = "";
            txtCode.Text = "";
            txtDescription.Text = "";
            btnSave.Enabled = fieldChanged;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Save changes ?", "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (newRecord)
            {
                _Category.MinimumValue = Convert.ToDouble(txtMinimumValue.Text);
                _Category.MaximumValue = Convert.ToDouble(txtMaximumValue.Text);
                _Category.Code = txtCode.Text;
                _Category.Description = txtDescription.Text;
                _ICategoryController.InsertCategory(_Category);
            }
            else
            {
                _Category.CategoryId = Convert.ToInt32(txtId.Text);
                _Category.MinimumValue = Convert.ToDouble(txtMinimumValue.Text);
                _Category.MaximumValue = Convert.ToDouble(txtMaximumValue.Text);
                _Category.Code = txtCode.Text;
                _Category.Description = txtDescription.Text;
                _ICategoryController.UpdateCategory(_Category);
            }

            newRecord = false;
            LoadDataGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete record ?", "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _ICategoryController.DeleteCategory(Convert.ToInt32(txtId.Text));
            newRecord = false;
            LoadDataGrid();
        }
    }
}
