
namespace WindowsFormsStartProcessWaitEndProcess
{
    partial class FormTask3
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
            this.v = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // v
            // 
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v.Location = new System.Drawing.Point(12, 21);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(393, 76);
            this.v.TabIndex = 0;
            this.v.Text = "Start Console App";
            this.v.UseVisualStyleBackColor = true;
            this.v.Click += new System.EventHandler(this.v_Click);
            // 
            // FormTask3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 226);
            this.Controls.Add(this.v);
            this.Name = "FormTask3";
            this.Text = "FormTask3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button v;
    }
}