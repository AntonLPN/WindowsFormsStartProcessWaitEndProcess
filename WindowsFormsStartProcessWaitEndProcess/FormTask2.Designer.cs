﻿
namespace WindowsFormsStartProcessWaitEndProcess
{
    partial class FormTask2
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
            this.buttonWaitEnd = new System.Windows.Forms.Button();
            this.buttonForcedStop = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonWaitEnd
            // 
            this.buttonWaitEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWaitEnd.Location = new System.Drawing.Point(43, 27);
            this.buttonWaitEnd.Name = "buttonWaitEnd";
            this.buttonWaitEnd.Size = new System.Drawing.Size(437, 78);
            this.buttonWaitEnd.TabIndex = 0;
            this.buttonWaitEnd.Text = "Open Notepad and wait for  the end";
            this.buttonWaitEnd.UseVisualStyleBackColor = true;
            this.buttonWaitEnd.Click += new System.EventHandler(this.buttonWaitEnd_Click);
            // 
            // buttonForcedStop
            // 
            this.buttonForcedStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForcedStop.Location = new System.Drawing.Point(31, 55);
            this.buttonForcedStop.Name = "buttonForcedStop";
            this.buttonForcedStop.Size = new System.Drawing.Size(437, 78);
            this.buttonForcedStop.TabIndex = 1;
            this.buttonForcedStop.Text = "Open Notepad whith function forced stop";
            this.buttonForcedStop.UseVisualStyleBackColor = true;
            this.buttonForcedStop.Click += new System.EventHandler(this.buttonForcedStop_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(31, 169);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(437, 78);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Controls.Add(this.buttonForcedStop);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 316);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Раздел принудительной остановки";
            // 
            // FormTask2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonWaitEnd);
            this.Name = "FormTask2";
            this.Text = "FormTask2";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWaitEnd;
        private System.Windows.Forms.Button buttonForcedStop;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}