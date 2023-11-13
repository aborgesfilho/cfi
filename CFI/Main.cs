using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CFI
{
    public partial class Main : Form
    {
        protected IConfiguration Configuration { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void CloseAllForms()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
                childForm.Dispose();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", optional: false);

                Configuration = builder.Build();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw ex;
            }

        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void categoryMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            CloseAllForms();

            FormCategories formCategories = Program.ServiceProvider.GetRequiredService<FormCategories>();
            formCategories.MdiParent = this;
            formCategories.Configuration = this.Configuration;
            formCategories.Show();

            Cursor = Cursors.Default;

        }

        private void categorizingProcessMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            CloseAllForms();

            FormCategorizingProcess formCategorizingProcess = Program.ServiceProvider.GetRequiredService<FormCategorizingProcess>();
            formCategorizingProcess.MdiParent = this;
            formCategorizingProcess.Configuration = this.Configuration;
            formCategorizingProcess.Show();

            Cursor = Cursors.Default;
        }
    }
}
