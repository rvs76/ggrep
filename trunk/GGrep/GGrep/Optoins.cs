using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GGrep
{
    public partial class Optoins : Form
    {
        #region Contructor

        /// <summary>
        /// Contructor
        /// </summary>
        public Optoins()
        {
            InitializeComponent();
            rbDefault.Checked = !Properties.Settings.Default.UseCustomEditor;
            rbCustom.Checked = Properties.Settings.Default.UseCustomEditor;
            tbCustomEditor.Text = Properties.Settings.Default.CustomEditorPath;
            tbArguments.Text = Properties.Settings.Default.CustomEditorArguments;
            SetActive(rbCustom.Checked);
        }

        #endregion

        #region Events

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                tbCustomEditor.Text = ofd.FileName;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CustomEditorPath = tbCustomEditor.Text;
            Properties.Settings.Default.CustomEditorArguments = tbArguments.Text;
            Properties.Settings.Default.UseCustomEditor = rbCustom.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            SetActive(rbCustom.Checked);
        }
        #endregion

        #region Method

        /// <summary>
        /// Activity Setting
        /// </summary>
        /// <param name="active"></param>
        private void SetActive(bool active)
        {
            tbArguments.Enabled = active;
            tbCustomEditor.Enabled = active;
            btnBrowse.Enabled = active;
        }

        #endregion
    }
}
