
namespace WindowsFormPractice
{
    partial class AsyncAndAwait
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
            this.btnProcessFIleNormal = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnProcessFIleAsync = new System.Windows.Forms.Button();
            this.btnProcessFileThreadJoin = new System.Windows.Forms.Button();
            this.btnProcessFileBeingInvokeLambda = new System.Windows.Forms.Button();
            this.btnProcessFileThreadWithoutJoin = new System.Windows.Forms.Button();
            this.btnProcessFileBeingInvokeWithoutLambda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcessFIleNormal
            // 
            this.btnProcessFIleNormal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcessFIleNormal.Location = new System.Drawing.Point(95, 110);
            this.btnProcessFIleNormal.Name = "btnProcessFIleNormal";
            this.btnProcessFIleNormal.Size = new System.Drawing.Size(166, 38);
            this.btnProcessFIleNormal.TabIndex = 0;
            this.btnProcessFIleNormal.Text = "Process File - Normal";
            this.btnProcessFIleNormal.UseVisualStyleBackColor = true;
            this.btnProcessFIleNormal.Click += new System.EventHandler(this.btnProcessFIleNormal_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(261, 309);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 17);
            this.lblCount.TabIndex = 1;
            this.lblCount.Click += new System.EventHandler(this.btnProcessFIleNormal_Click);
            // 
            // btnProcessFIleAsync
            // 
            this.btnProcessFIleAsync.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcessFIleAsync.Location = new System.Drawing.Point(298, 110);
            this.btnProcessFIleAsync.Name = "btnProcessFIleAsync";
            this.btnProcessFIleAsync.Size = new System.Drawing.Size(212, 38);
            this.btnProcessFIleAsync.TabIndex = 2;
            this.btnProcessFIleAsync.Text = "Process File - Async";
            this.btnProcessFIleAsync.UseVisualStyleBackColor = true;
            this.btnProcessFIleAsync.Click += new System.EventHandler(this.btnProcessFIleAsync_Click);
            // 
            // btnProcessFileThreadJoin
            // 
            this.btnProcessFileThreadJoin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcessFileThreadJoin.Location = new System.Drawing.Point(95, 168);
            this.btnProcessFileThreadJoin.Name = "btnProcessFileThreadJoin";
            this.btnProcessFileThreadJoin.Size = new System.Drawing.Size(165, 35);
            this.btnProcessFileThreadJoin.TabIndex = 3;
            this.btnProcessFileThreadJoin.Text = "Process File - ThreadJoin";
            this.btnProcessFileThreadJoin.UseVisualStyleBackColor = true;
            this.btnProcessFileThreadJoin.Click += new System.EventHandler(this.btnProcessFileThreadJoin_Click);
            // 
            // btnProcessFileBeingInvokeLambda
            // 
            this.btnProcessFileBeingInvokeLambda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcessFileBeingInvokeLambda.Location = new System.Drawing.Point(547, 168);
            this.btnProcessFileBeingInvokeLambda.Name = "btnProcessFileBeingInvokeLambda";
            this.btnProcessFileBeingInvokeLambda.Size = new System.Drawing.Size(219, 35);
            this.btnProcessFileBeingInvokeLambda.TabIndex = 4;
            this.btnProcessFileBeingInvokeLambda.Text = "Process File - BeingInvokeLambda";
            this.btnProcessFileBeingInvokeLambda.UseVisualStyleBackColor = true;
            this.btnProcessFileBeingInvokeLambda.Click += new System.EventHandler(this.btnProcessFileBeingInvokeLambda_Click);
            // 
            // btnProcessFileThreadWithoutJoin
            // 
            this.btnProcessFileThreadWithoutJoin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcessFileThreadWithoutJoin.Location = new System.Drawing.Point(298, 168);
            this.btnProcessFileThreadWithoutJoin.Name = "btnProcessFileThreadWithoutJoin";
            this.btnProcessFileThreadWithoutJoin.Size = new System.Drawing.Size(212, 35);
            this.btnProcessFileThreadWithoutJoin.TabIndex = 5;
            this.btnProcessFileThreadWithoutJoin.Text = "Process File - ThreadWithoutJoin";
            this.btnProcessFileThreadWithoutJoin.UseVisualStyleBackColor = true;
            this.btnProcessFileThreadWithoutJoin.Click += new System.EventHandler(this.btnProcessFileThreadWithoutJoin_Click);
            // 
            // btnProcessFileBeingInvokeWithoutLambda
            // 
            this.btnProcessFileBeingInvokeWithoutLambda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcessFileBeingInvokeWithoutLambda.Location = new System.Drawing.Point(547, 226);
            this.btnProcessFileBeingInvokeWithoutLambda.Name = "btnProcessFileBeingInvokeWithoutLambda";
            this.btnProcessFileBeingInvokeWithoutLambda.Size = new System.Drawing.Size(219, 45);
            this.btnProcessFileBeingInvokeWithoutLambda.TabIndex = 6;
            this.btnProcessFileBeingInvokeWithoutLambda.Text = "Process File - BeingInvokeWithoutLambda";
            this.btnProcessFileBeingInvokeWithoutLambda.UseVisualStyleBackColor = true;
            this.btnProcessFileBeingInvokeWithoutLambda.Click += new System.EventHandler(this.btnProcessFileBeingInvokeWithoutLambda_Click);
            // 
            // AsyncAndAwait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcessFileBeingInvokeWithoutLambda);
            this.Controls.Add(this.btnProcessFileThreadWithoutJoin);
            this.Controls.Add(this.btnProcessFileBeingInvokeLambda);
            this.Controls.Add(this.btnProcessFileThreadJoin);
            this.Controls.Add(this.btnProcessFIleAsync);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnProcessFIleNormal);
            this.Name = "AsyncAndAwait";
            this.Text = "AsyncAndAwait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcessFIleNormal;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnProcessFIleAsync;
        private System.Windows.Forms.Button btnProcessFileThreadJoin;
        private System.Windows.Forms.Button btnProcessFileBeingInvokeLambda;
        private System.Windows.Forms.Button btnProcessFileThreadWithoutJoin;
        private System.Windows.Forms.Button btnProcessFileBeingInvokeWithoutLambda;
    }
}