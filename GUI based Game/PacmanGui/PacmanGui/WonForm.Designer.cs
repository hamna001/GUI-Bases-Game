
namespace PacmanGui
{
    partial class WonForm
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
            this.btnWonformexit = new System.Windows.Forms.Button();
            this.btnreplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWonformexit
            // 
            this.btnWonformexit.BackColor = System.Drawing.Color.Aqua;
            this.btnWonformexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWonformexit.ForeColor = System.Drawing.Color.Black;
            this.btnWonformexit.Location = new System.Drawing.Point(347, 389);
            this.btnWonformexit.Name = "btnWonformexit";
            this.btnWonformexit.Size = new System.Drawing.Size(110, 49);
            this.btnWonformexit.TabIndex = 0;
            this.btnWonformexit.Text = "EXIT";
            this.btnWonformexit.UseVisualStyleBackColor = false;
            this.btnWonformexit.Click += new System.EventHandler(this.btnWonformexit_Click);
            // 
            // btnreplay
            // 
            this.btnreplay.BackColor = System.Drawing.Color.Aqua;
            this.btnreplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreplay.ForeColor = System.Drawing.Color.Black;
            this.btnreplay.Location = new System.Drawing.Point(316, 320);
            this.btnreplay.Name = "btnreplay";
            this.btnreplay.Size = new System.Drawing.Size(166, 49);
            this.btnreplay.TabIndex = 1;
            this.btnreplay.Text = "Play Again";
            this.btnreplay.UseVisualStyleBackColor = false;
            this.btnreplay.Click += new System.EventHandler(this.btnreplay_Click);
            // 
            // WonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacmanGui.Properties.Resources.depositphotos_279259336_stock_video_digital_animation_of_a_you;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreplay);
            this.Controls.Add(this.btnWonformexit);
            this.Name = "WonForm";
            this.Text = "WonForm";
            this.Load += new System.EventHandler(this.WonForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWonformexit;
        private System.Windows.Forms.Button btnreplay;
    }
}