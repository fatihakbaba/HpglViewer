using Hpgl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HpglViewer
{
    public partial class MForm : Form
    {
        public MForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "HPGL Files (*.hpg,*.plt,*.hpgl)|*.hpg;*.plt;*.hpgl|All files (*.*)|*.*"
            };

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            base.Cursor = Cursors.WaitCursor;

            HpglFile hpgl = new HpglFile(dlg.FileName);

            //errorList1.SetErrorList(hpgl.Errors);
            plotControl1.Plot(hpgl);
            //plotInfoControl1.SetInfo(hpgl);

            base.Cursor = Cursors.Default;
        }

        private void plotControl1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
