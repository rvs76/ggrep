namespace GGrep
{
    partial class Optoins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Optoins));
            this.label1 = new System.Windows.Forms.Label();
            this.gbEditor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbArguments = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbCustomEditor = new System.Windows.Forms.TextBox();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbDefault = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbShell = new System.Windows.Forms.GroupBox();
            this.cbShowInDirContextMenu = new System.Windows.Forms.CheckBox();
            this.gbEditor.SuspendLayout();
            this.gbShell.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // gbEditor
            // 
            this.gbEditor.Controls.Add(this.label2);
            this.gbEditor.Controls.Add(this.tbArguments);
            this.gbEditor.Controls.Add(this.btnBrowse);
            this.gbEditor.Controls.Add(this.tbCustomEditor);
            this.gbEditor.Controls.Add(this.rbCustom);
            this.gbEditor.Controls.Add(this.rbDefault);
            this.gbEditor.Controls.Add(this.label1);
            resources.ApplyResources(this.gbEditor, "gbEditor");
            this.gbEditor.Name = "gbEditor";
            this.gbEditor.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbArguments
            // 
            resources.ApplyResources(this.tbArguments, "tbArguments");
            this.tbArguments.Name = "tbArguments";
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbCustomEditor
            // 
            resources.ApplyResources(this.tbCustomEditor, "tbCustomEditor");
            this.tbCustomEditor.Name = "tbCustomEditor";
            // 
            // rbCustom
            // 
            resources.ApplyResources(this.rbCustom, "rbCustom");
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.TabStop = true;
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // rbDefault
            // 
            resources.ApplyResources(this.rbDefault, "rbDefault");
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.TabStop = true;
            this.rbDefault.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbShell
            // 
            this.gbShell.Controls.Add(this.cbShowInDirContextMenu);
            resources.ApplyResources(this.gbShell, "gbShell");
            this.gbShell.Name = "gbShell";
            this.gbShell.TabStop = false;
            // 
            // cbShowInDirContextMenu
            // 
            resources.ApplyResources(this.cbShowInDirContextMenu, "cbShowInDirContextMenu");
            this.cbShowInDirContextMenu.Name = "cbShowInDirContextMenu";
            this.cbShowInDirContextMenu.UseVisualStyleBackColor = true;
            this.cbShowInDirContextMenu.CheckedChanged += new System.EventHandler(this.cbShowInDirContextMenu_CheckedChanged);
            // 
            // Optoins
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.gbShell);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Optoins";
            this.ShowInTaskbar = false;
            this.gbEditor.ResumeLayout(false);
            this.gbEditor.PerformLayout();
            this.gbShell.ResumeLayout(false);
            this.gbShell.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEditor;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbDefault;
        private System.Windows.Forms.TextBox tbCustomEditor;
        private System.Windows.Forms.TextBox tbArguments;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbShell;
        private System.Windows.Forms.CheckBox cbShowInDirContextMenu;
    }
}