namespace WindowsApplication1
{
    partial class Form1
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
            this.myColorEdit1 = new CustomEditors.MyColorEdit();
            ((System.ComponentModel.ISupportInitialize)(this.myColorEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // myColorEdit1
            // 
            this.myColorEdit1.EditValue = System.Drawing.Color.Empty;
            this.myColorEdit1.Location = new System.Drawing.Point(12, 12);
            this.myColorEdit1.Name = "myColorEdit1";
            this.myColorEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myColorEdit1.Size = new System.Drawing.Size(225, 20);
            this.myColorEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.myColorEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myColorEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomEditors.MyColorEdit myColorEdit1;

    }
}

