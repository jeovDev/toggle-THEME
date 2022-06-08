
namespace theme
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
            this.siticoneOSToggleSwith1 = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // siticoneOSToggleSwith1
            // 
            this.siticoneOSToggleSwith1.Location = new System.Drawing.Point(275, 171);
            this.siticoneOSToggleSwith1.Name = "siticoneOSToggleSwith1";
            this.siticoneOSToggleSwith1.Size = new System.Drawing.Size(38, 22);
            this.siticoneOSToggleSwith1.TabIndex = 0;
            this.siticoneOSToggleSwith1.Text = "siticoneOSToggleSwith1";
            this.siticoneOSToggleSwith1.CheckedChanged += new System.EventHandler(this.siticoneOSToggleSwith1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(244, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "THEME";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(214, 257);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton1.TabIndex = 2;
            this.siticoneButton1.Text = "Restart";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 326);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneOSToggleSwith1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneOSToggleSwith siticoneOSToggleSwith1;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
    }
}

