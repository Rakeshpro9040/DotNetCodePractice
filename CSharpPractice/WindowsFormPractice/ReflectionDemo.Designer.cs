
namespace WindowsFormPractice
{
    partial class ReflectionDemo
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
            this.lbl_typename = new System.Windows.Forms.Label();
            this.txtbx_typename = new System.Windows.Forms.TextBox();
            this.lbl_constructors = new System.Windows.Forms.Label();
            this.lbl_properties = new System.Windows.Forms.Label();
            this.lbl_methods = new System.Windows.Forms.Label();
            this.lstbx_methods = new System.Windows.Forms.ListBox();
            this.lstbx_properties = new System.Windows.Forms.ListBox();
            this.lstbx_constructors = new System.Windows.Forms.ListBox();
            this.btn_discovertypeinfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_typename
            // 
            this.lbl_typename.AutoSize = true;
            this.lbl_typename.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_typename.Location = new System.Drawing.Point(42, 26);
            this.lbl_typename.Name = "lbl_typename";
            this.lbl_typename.Size = new System.Drawing.Size(69, 15);
            this.lbl_typename.TabIndex = 0;
            this.lbl_typename.Text = "Type Name";
            this.lbl_typename.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbx_typename
            // 
            this.txtbx_typename.Location = new System.Drawing.Point(117, 23);
            this.txtbx_typename.Name = "txtbx_typename";
            this.txtbx_typename.Size = new System.Drawing.Size(211, 23);
            this.txtbx_typename.TabIndex = 1;
            // 
            // lbl_constructors
            // 
            this.lbl_constructors.AutoSize = true;
            this.lbl_constructors.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_constructors.Location = new System.Drawing.Point(603, 141);
            this.lbl_constructors.Name = "lbl_constructors";
            this.lbl_constructors.Size = new System.Drawing.Size(78, 15);
            this.lbl_constructors.TabIndex = 2;
            this.lbl_constructors.Text = "Constructors";
            // 
            // lbl_properties
            // 
            this.lbl_properties.AutoSize = true;
            this.lbl_properties.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_properties.Location = new System.Drawing.Point(309, 141);
            this.lbl_properties.Name = "lbl_properties";
            this.lbl_properties.Size = new System.Drawing.Size(65, 15);
            this.lbl_properties.TabIndex = 3;
            this.lbl_properties.Text = "Properties";
            // 
            // lbl_methods
            // 
            this.lbl_methods.AutoSize = true;
            this.lbl_methods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_methods.Location = new System.Drawing.Point(42, 141);
            this.lbl_methods.Name = "lbl_methods";
            this.lbl_methods.Size = new System.Drawing.Size(56, 15);
            this.lbl_methods.TabIndex = 4;
            this.lbl_methods.Text = "Methods";
            // 
            // lstbx_methods
            // 
            this.lstbx_methods.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstbx_methods.FormattingEnabled = true;
            this.lstbx_methods.ItemHeight = 15;
            this.lstbx_methods.Location = new System.Drawing.Point(46, 172);
            this.lstbx_methods.Name = "lstbx_methods";
            this.lstbx_methods.Size = new System.Drawing.Size(185, 439);
            this.lstbx_methods.TabIndex = 5;
            // 
            // lstbx_properties
            // 
            this.lstbx_properties.FormattingEnabled = true;
            this.lstbx_properties.ItemHeight = 15;
            this.lstbx_properties.Location = new System.Drawing.Point(309, 172);
            this.lstbx_properties.Name = "lstbx_properties";
            this.lstbx_properties.Size = new System.Drawing.Size(185, 439);
            this.lstbx_properties.TabIndex = 6;
            // 
            // lstbx_constructors
            // 
            this.lstbx_constructors.FormattingEnabled = true;
            this.lstbx_constructors.ItemHeight = 15;
            this.lstbx_constructors.Location = new System.Drawing.Point(603, 172);
            this.lstbx_constructors.Name = "lstbx_constructors";
            this.lstbx_constructors.Size = new System.Drawing.Size(185, 439);
            this.lstbx_constructors.TabIndex = 7;
            // 
            // btn_discovertypeinfo
            // 
            this.btn_discovertypeinfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_discovertypeinfo.Location = new System.Drawing.Point(433, 26);
            this.btn_discovertypeinfo.Name = "btn_discovertypeinfo";
            this.btn_discovertypeinfo.Size = new System.Drawing.Size(355, 23);
            this.btn_discovertypeinfo.TabIndex = 8;
            this.btn_discovertypeinfo.Text = "Discover Type Information";
            this.btn_discovertypeinfo.UseVisualStyleBackColor = true;
            this.btn_discovertypeinfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReflectionDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.btn_discovertypeinfo);
            this.Controls.Add(this.lstbx_constructors);
            this.Controls.Add(this.lstbx_properties);
            this.Controls.Add(this.lstbx_methods);
            this.Controls.Add(this.lbl_methods);
            this.Controls.Add(this.lbl_properties);
            this.Controls.Add(this.lbl_constructors);
            this.Controls.Add(this.txtbx_typename);
            this.Controls.Add(this.lbl_typename);
            this.Name = "ReflectionDemo";
            this.Text = "Reflection Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_typename;
        private System.Windows.Forms.TextBox txtbx_typename;
        private System.Windows.Forms.Label lbl_constructors;
        private System.Windows.Forms.Label lbl_properties;
        private System.Windows.Forms.Label lbl_methods;
        private System.Windows.Forms.ListBox lstbx_methods;
        private System.Windows.Forms.ListBox lstbx_properties;
        private System.Windows.Forms.ListBox lstbx_constructors;
        private System.Windows.Forms.Button btn_discovertypeinfo;
    }
}