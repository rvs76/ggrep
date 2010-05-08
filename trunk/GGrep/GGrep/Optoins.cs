using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace GGrep
{
    public partial class Optoins : Form
    {
        #region Members
        private static string SHELL_KEY_NAME = "GGREP";
        private static string SHELL_MENU_TEXT = "G&Grep";
        #endregion

        #region Contructor

        /// <summary>
        /// Contructor
        /// </summary>
        public Optoins()
        {
            InitializeComponent();
            cbShowInDirContextMenu.Checked = Properties.Settings.Default.ShowGrepInDirContextMenu;
            rbDefault.Checked = !Properties.Settings.Default.UseCustomEditor;
            rbCustom.Checked = Properties.Settings.Default.UseCustomEditor;
            tbCustomEditor.Text = Properties.Settings.Default.CustomEditorPath;
            tbArguments.Text = Properties.Settings.Default.CustomEditorArguments;
            SetActive(rbCustom.Checked);
        }

        #endregion

        #region Events

        private void cbShowInDirContextMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (!Utils.IsAdministrators)
            {
                MessageBox.Show(this, Properties.Resources.MSG_ERROR_06, Properties.Resources.MSG_TITLE_01, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                cbShowInDirContextMenu.Checked = false;
                return;
            }
        }

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
            if (cbShowInDirContextMenu.Checked)
            {
                RegistShell("Directory");
                //RegistShell("Drive");
                //RegistShell("*");
            }
            else
            {
                RemoveShell("Directory");
                //RemoveShell("Drive");
                //RemoveShell("*");
            }

            Properties.Settings.Default.CustomEditorPath = tbCustomEditor.Text;
            Properties.Settings.Default.CustomEditorArguments = tbArguments.Text;
            Properties.Settings.Default.UseCustomEditor = rbCustom.Checked;
            Properties.Settings.Default.ShowGrepInDirContextMenu = cbShowInDirContextMenu.Checked;
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


        private void RegistShell(string location)
        {
            if (IsShellRegistered(location))
            {
                RemoveShell(location);
            }

            string regPath = GetRegistPath(location);

            // add context menu to the registry

            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(regPath))
            {
                key.SetValue(null, SHELL_MENU_TEXT);
            }

            // add command that is invoked to the registry
            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(string.Format(@"{0}\command", regPath)))
            {
                key.SetValue(null, string.Format("\"{0}\" \"%1\"", Application.ExecutablePath));
            }
        }

        private bool IsShellRegistered(string location)
        {
            try
            {
                return Registry.ClassesRoot.OpenSubKey(GetRegistPath(location)) != null;
            }
            catch (UnauthorizedAccessException)
            {
            }
            return false;
        }


        private void RemoveShell(string location)
        {
            if (IsShellRegistered(location))
            {
                Registry.ClassesRoot.DeleteSubKeyTree(GetRegistPath(location));
            }
        }

        private string GetRegistPath(string location)
        {
            return string.Format(@"{0}\shell\{1}", location, SHELL_KEY_NAME);
        }

        #endregion
    }
}
