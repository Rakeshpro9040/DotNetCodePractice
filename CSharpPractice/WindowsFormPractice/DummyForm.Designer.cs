
namespace WindowsFormPractice
{
    partial class DummyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_dummy = new System.Windows.Forms.Button();
            this.lbl_dummy = new System.Windows.Forms.Label();
            this.btn_changecolor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dummy
            // 
            this.btn_dummy.AutoSize = true;
            this.btn_dummy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dummy.Location = new System.Drawing.Point(341, 78);
            this.btn_dummy.Name = "btn_dummy";
            this.btn_dummy.Size = new System.Drawing.Size(136, 39);
            this.btn_dummy.TabIndex = 0;
            this.btn_dummy.Text = "Click Me";
            this.btn_dummy.UseVisualStyleBackColor = true;
            this.btn_dummy.Click += new System.EventHandler(this.btn_dummy_Click);
            // 
            // lbl_dummy
            // 
            this.lbl_dummy.AutoSize = true;
            this.lbl_dummy.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dummy.Location = new System.Drawing.Point(341, 191);
            this.lbl_dummy.Name = "lbl_dummy";
            this.lbl_dummy.Size = new System.Drawing.Size(64, 25);
            this.lbl_dummy.TabIndex = 1;
            this.lbl_dummy.Text = "Empty";
            // 
            // btn_changecolor
            // 
            this.btn_changecolor.AutoSize = true;
            this.btn_changecolor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_changecolor.Location = new System.Drawing.Point(499, 78);
            this.btn_changecolor.Name = "btn_changecolor";
            this.btn_changecolor.Size = new System.Drawing.Size(136, 39);
            this.btn_changecolor.TabIndex = 2;
            this.btn_changecolor.Text = "Color Change";
            this.btn_changecolor.UseVisualStyleBackColor = true;
            this.btn_changecolor.Click += new System.EventHandler(this.btn_changecolor_Click);
            // 
            // DummyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_changecolor);
            this.Controls.Add(this.lbl_dummy);
            this.Controls.Add(this.btn_dummy);
            this.Name = "DummyForm";
            this.Text = "DummyForm";
            this.Load += new System.EventHandler(this.DummyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dummy;
        private System.Windows.Forms.Label lbl_dummy;
        private System.Windows.Forms.Button btn_changecolor;
    }
}

