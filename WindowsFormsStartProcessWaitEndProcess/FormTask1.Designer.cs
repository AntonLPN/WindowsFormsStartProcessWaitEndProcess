
namespace WindowsFormsStartProcessWaitEndProcess
{
    partial class FormTask1
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
            this.buttonOpenNotepad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenNotepad
            // 
            this.buttonOpenNotepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenNotepad.Location = new System.Drawing.Point(45, 27);
            this.buttonOpenNotepad.Name = "buttonOpenNotepad";
            this.buttonOpenNotepad.Size = new System.Drawing.Size(339, 112);
            this.buttonOpenNotepad.TabIndex = 0;
            this.buttonOpenNotepad.Text = "Open Notepad";
            this.buttonOpenNotepad.UseVisualStyleBackColor = true;
            this.buttonOpenNotepad.Click += new System.EventHandler(this.buttonOpenNotepad_Click);
            // 
            // FormTask1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 179);
            this.Controls.Add(this.buttonOpenNotepad);
            this.Name = "FormTask1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTask1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenNotepad;
    }
}