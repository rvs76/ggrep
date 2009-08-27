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
            this.gbEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // gbEditor
            // 
            this.gbEditor.AccessibleDescription = null;
            this.gbEditor.AccessibleName = null;
            resources.ApplyResources(this.gbEditor, "gbEditor");
            this.gbEditor.BackgroundImage = null;
            this.gbEditor.Controls.Add(this.label2);
            this.gbEditor.Controls.Add(this.tbArguments);
            this.gbEditor.Controls.Add(this.btnBrowse);
            this.gbEditor.Controls.Add(this.tbCustomEditor);
            this.gbEditor.Controls.Add(this.rbCustom);
            this.gbEditor.Controls.Add(this.rbDefault);
            this.gbEditor.Controls.Add(this.label1);
            this.gbEditor.Font = null;
            this.gbEditor.Name = "gbEditor";
            this.gbEditor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // tbArguments
            // 
            this.tbArguments.AccessibleDescription = null;
            this.tbArguments.AccessibleName = null;
            resources.ApplyResources(this.tbArguments, "tbArguments");
            this.tbArguments.BackgroundImage = null;
            this.tbArguments.Font = null;
            this.tbArguments.Name = "tbArguments";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleDescription = null;
            this.btnBrowse.AccessibleName = null;
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.BackgroundImage = null;
            this.btnBrowse.Font = null;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbCustomEditor
            // 
            this.tbCustomEditor.AccessibleDescription = null;
            this.tbCustomEditor.AccessibleName = null;
            resources.ApplyResources(this.tbCustomEditor, "tbCustomEditor");
            this.tbCustomEditor.BackgroundImage = null;
            this.tbCustomEditor.Font = null;
            this.tbCustomEditor.Name = "tbCustomEditor";
            // 
            // rbCustom
            // 
            this.rbCustom.AccessibleDescription = null;
            this.rbCustom.AccessibleName = null;
            resources.ApplyResources(this.rbCustom, "rbCustom");
            this.rbCustom.BackgroundImage = null;
            this.rbCustom.Font = null;
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.TabStop = true;
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // rbDefault
            // 
            this.rbDefault.AccessibleDescription = null;
            this.rbDefault.AccessibleName = null;
            resources.ApplyResources(this.rbDefault, "rbDefault");
            this.rbDefault.BackgroundImage = null;
            this.rbDefault.Font = null;
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.TabStop = true;
            this.rbDefault.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.AccessibleDescription = null;
            this.btnOk.AccessibleName = null;
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.BackgroundImage = null;
            this.btnOk.Font = null;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = null;
            this.btnCancel.AccessibleName = null;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackgroundImage = null;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Optoins
            // 
            this.AcceptButton = this.btnOk;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Optoins";
            this.gbEditor.ResumeLayout(false);
            this.gbEditor.PerformLayout();
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
    }
}