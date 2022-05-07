
namespace Ticcket
{
    partial class organiser_search
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bTnDesign1 = new Ticcket.Resources.BTnDesign();
            this.bTnDesign4 = new Ticcket.Resources.BTnDesign();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bTnDesign2 = new Ticcket.Resources.BTnDesign();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bTnDesign1
            // 
            this.bTnDesign1.BackColor = System.Drawing.Color.White;
            this.bTnDesign1.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.bTnDesign1.BorderRadius = 40;
            this.bTnDesign1.BorderSize = 1;
            this.bTnDesign1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.bTnDesign1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bTnDesign1.ForeColor = System.Drawing.Color.White;
            this.bTnDesign1.Location = new System.Drawing.Point(35, 15);
            this.bTnDesign1.Name = "bTnDesign1";
            this.bTnDesign1.Size = new System.Drawing.Size(503, 40);
            this.bTnDesign1.TabIndex = 1;
            this.bTnDesign1.Text = "bTnDesign1";
            this.bTnDesign1.TextColor = System.Drawing.Color.White;
            this.bTnDesign1.UseVisualStyleBackColor = false;
            // 
            // bTnDesign4
            // 
            this.bTnDesign4.BackColor = System.Drawing.Color.White;
            this.bTnDesign4.BorderColor = System.Drawing.Color.Navy;
            this.bTnDesign4.BorderRadius = 40;
            this.bTnDesign4.BorderSize = 2;
            this.bTnDesign4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bTnDesign4.FlatAppearance.BorderSize = 2;
            this.bTnDesign4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTnDesign4.Font = new System.Drawing.Font("Urdu Typesetting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTnDesign4.ForeColor = System.Drawing.Color.White;
            this.bTnDesign4.Location = new System.Drawing.Point(68, 8);
            this.bTnDesign4.Name = "bTnDesign4";
            this.bTnDesign4.Size = new System.Drawing.Size(495, 50);
            this.bTnDesign4.TabIndex = 33;
            this.bTnDesign4.TextColor = System.Drawing.Color.White;
            this.bTnDesign4.UseVisualStyleBackColor = false;
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.White;
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.textSearch.Location = new System.Drawing.Point(122, 18);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(435, 29);
            this.textSearch.TabIndex = 40;
            this.textSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(86, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "🔍 ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // bTnDesign2
            // 
            this.bTnDesign2.BackColor = System.Drawing.Color.White;
            this.bTnDesign2.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.bTnDesign2.BorderRadius = 40;
            this.bTnDesign2.BorderSize = 1;
            this.bTnDesign2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.bTnDesign2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bTnDesign2.ForeColor = System.Drawing.Color.White;
            this.bTnDesign2.Location = new System.Drawing.Point(79, 7);
            this.bTnDesign2.Name = "bTnDesign2";
            this.bTnDesign2.Size = new System.Drawing.Size(490, 49);
            this.bTnDesign2.TabIndex = 39;
            this.bTnDesign2.TextColor = System.Drawing.Color.White;
            this.bTnDesign2.UseVisualStyleBackColor = false;
            this.bTnDesign2.Click += new System.EventHandler(this.bTnDesign2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Downloads";
            // 
            // organiser_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bTnDesign2);
            this.Name = "organiser_search";
            this.Size = new System.Drawing.Size(616, 362);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Resources.BTnDesign bTnDesign1;
        private Resources.BTnDesign bTnDesign4;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label1;
        private Resources.BTnDesign bTnDesign2;
        private System.Windows.Forms.Label label2;
    }
}
