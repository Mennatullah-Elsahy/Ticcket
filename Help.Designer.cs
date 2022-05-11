
namespace Ticcket
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.bTnDesign5 = new Ticcket.Resources.BTnDesign();
            this.SuspendLayout();
            // 
            // bTnDesign5
            // 
            this.bTnDesign5.BackColor = System.Drawing.Color.Blue;
            this.bTnDesign5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bTnDesign5.BackgroundImage")));
            this.bTnDesign5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bTnDesign5.BorderColor = System.Drawing.Color.White;
            this.bTnDesign5.BorderRadius = 40;
            this.bTnDesign5.BorderSize = 3;
            this.bTnDesign5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTnDesign5.FlatAppearance.BorderSize = 2;
            this.bTnDesign5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.bTnDesign5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bTnDesign5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bTnDesign5.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTnDesign5.ForeColor = System.Drawing.Color.White;
            this.bTnDesign5.Location = new System.Drawing.Point(418, 139);
            this.bTnDesign5.Name = "bTnDesign5";
            this.bTnDesign5.Size = new System.Drawing.Size(63, 55);
            this.bTnDesign5.TabIndex = 206;
            this.bTnDesign5.TextColor = System.Drawing.Color.White;
            this.bTnDesign5.UseVisualStyleBackColor = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion
        private Resources.BTnDesign bTnDesign5;
    }
}