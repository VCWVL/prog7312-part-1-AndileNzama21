using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServices_Part_1
{
   
        partial class MainForm
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            private void InitializeComponent()
            {
                this.btnReport = new System.Windows.Forms.Button();
                this.btnEvents = new System.Windows.Forms.Button();
                this.btnStatus = new System.Windows.Forms.Button();
                this.btnExit = new System.Windows.Forms.Button();
                this.label1 = new System.Windows.Forms.Label();
                this.SuspendLayout();
                // 
                // btnReport
                // 
                this.btnReport.BackColor = System.Drawing.Color.SteelBlue;
                this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnReport.ForeColor = System.Drawing.Color.White;
                this.btnReport.Location = new System.Drawing.Point(100, 100);
                this.btnReport.Name = "btnReport";
                this.btnReport.Size = new System.Drawing.Size(300, 50);
                this.btnReport.TabIndex = 0;
                this.btnReport.Text = "Report Issues";
                this.btnReport.UseVisualStyleBackColor = false;
                this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
                // 
                // btnEvents
                // 
                this.btnEvents.BackColor = System.Drawing.Color.Gray;
                this.btnEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnEvents.ForeColor = System.Drawing.Color.White;
                this.btnEvents.Location = new System.Drawing.Point(100, 170);
                this.btnEvents.Name = "btnEvents";
                this.btnEvents.Size = new System.Drawing.Size(300, 50);
                this.btnEvents.TabIndex = 1;
                this.btnEvents.Text = "Local Events and Announcements";
                this.btnEvents.UseVisualStyleBackColor = false;
                // 
                // btnStatus
                // 
                this.btnStatus.BackColor = System.Drawing.Color.Gray;
                this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnStatus.ForeColor = System.Drawing.Color.White;
                this.btnStatus.Location = new System.Drawing.Point(100, 240);
                this.btnStatus.Name = "btnStatus";
                this.btnStatus.Size = new System.Drawing.Size(300, 50);
                this.btnStatus.TabIndex = 2;
                this.btnStatus.Text = "Service Request Status";
                this.btnStatus.UseVisualStyleBackColor = false;
                // 
                // btnExit
                // 
                this.btnExit.BackColor = System.Drawing.Color.Firebrick;
                this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnExit.ForeColor = System.Drawing.Color.White;
                this.btnExit.Location = new System.Drawing.Point(100, 320);
                this.btnExit.Name = "btnExit";
                this.btnExit.Size = new System.Drawing.Size(300, 40);
                this.btnExit.TabIndex = 3;
                this.btnExit.Text = "Exit Application";
                this.btnExit.UseVisualStyleBackColor = false;
                this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label1.Location = new System.Drawing.Point(120, 40);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(260, 26);
                this.label1.TabIndex = 4;
                this.label1.Text = "Municipal Services App";
                // 
                // MainForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.WhiteSmoke;
                this.ClientSize = new System.Drawing.Size(500, 400);
                this.Controls.Add(this.label1);
                this.Controls.Add(this.btnExit);
                this.Controls.Add(this.btnStatus);
                this.Controls.Add(this.btnEvents);
                this.Controls.Add(this.btnReport);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                this.MaximizeBox = false;
                this.Name = "MainForm";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "Municipal Services";
                this.Load += new System.EventHandler(this.MainForm_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Button btnReport;
            private System.Windows.Forms.Button btnEvents;
            private System.Windows.Forms.Button btnStatus;
            private System.Windows.Forms.Button btnExit;
            private System.Windows.Forms.Label label1;
        }
    }


