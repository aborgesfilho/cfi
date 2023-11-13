using CFI.Controllers.Interfaces;
using CFI.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
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
    public partial class FormCategorizingProcess : Form
    {
        public IConfiguration Configuration { get; set; }
        private readonly InstrumentOutput _InstrumentOutput;
        private readonly IFinancialInstrumentController _IFinancialInstrumentController;
        public FormCategorizingProcess()
        {
            InitializeComponent();
            _InstrumentOutput = (InstrumentOutput)FormatterServices.GetUninitializedObject(typeof(InstrumentOutput));
            _IFinancialInstrumentController = (IFinancialInstrumentController)Program.ServiceProvider.GetService(typeof(IFinancialInstrumentController));
        }

        private void FormCategorizingProcess_Load(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "json";
            openFileDialog1.Filter = "JSon files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtJsonFile.Text = openFileDialog1.FileName;
                LoadInputDataGrid();
            }
        }

        private void LoadInputDataGrid()
        {

            Cursor = Cursors.WaitCursor;
            
            string jsonFileContents = @"[" + File.ReadAllText(txtJsonFile.Text) + @"]";

            var result = JsonConvert.DeserializeObject<List<JSonInput>>(jsonFileContents);

            dtgrdInstrumentInput.DataSource = result;

            Cursor = Cursors.Default;
        }

        private void btnProcessOutput_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            List<InstrumentOutput> lstInstrumentOutput = new List<InstrumentOutput>();

            for(int i = 0; i < dtgrdInstrumentInput.Rows.Count; i++)
            {
                string nickName = dtgrdInstrumentInput.Rows[i].Cells[0].Value.ToString();
                double marketValue = Convert.ToDouble(dtgrdInstrumentInput.Rows[i].Cells[1].Value.ToString());
                string type = dtgrdInstrumentInput.Rows[i].Cells[2].Value.ToString();
                var instrumentOutput = _IFinancialInstrumentController.GenerateAndBringOutput(nickName, marketValue, type);

                if (instrumentOutput != null)
                    lstInstrumentOutput.Add(instrumentOutput);
            }

            if (lstInstrumentOutput.Count > 0)
                dtgrdInstrumentOutput.DataSource = lstInstrumentOutput;

            dtgrdInstrumentOutput.Columns[0].Visible = false;

            Cursor = Cursors.Default;

        }


    }
}
