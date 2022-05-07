
namespace Ticcket
{
    partial class organiser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(organiser));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnevent = new System.Windows.Forms.Button();
            this.Btnaccount = new System.Windows.Forms.Button();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.Btnsearch = new System.Windows.Forms.Button();
            this.Btnhome = new System.Windows.Forms.Button();
            this.oragniser_account1 = new Ticcket.oragniser_account();
            this.organiser_search1 = new Ticcket.organiser_search();
            this.organiser_event1 = new Ticcket.organiser_event();
            this.organiser_Home1 = new Ticcket.organiser_Home();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(184, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 83);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(125, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 35);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(631, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 35);
            this.button1.TabIndex = 129;
            this.button1.Text = "✖️";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.BtnLogOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btnevent);
            this.panel1.Controls.Add(this.Btnaccount);
            this.panel1.Controls.Add(this.Sidepanel);
            this.panel1.Controls.Add(this.Btnsearch);
            this.panel1.Controls.Add(this.Btnhome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 469);
            this.panel1.TabIndex = 0;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.White;
            this.BtnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogOut.BackgroundImage")));
            this.BtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogOut.FlatAppearance.BorderSize = 0;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.BtnLogOut.ForeColor = System.Drawing.Color.White;
            this.BtnLogOut.Location = new System.Drawing.Point(1, 344);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(119, 67);
            this.BtnLogOut.TabIndex = 11;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(5, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btnevent
            // 
            this.Btnevent.BackColor = System.Drawing.Color.White;
            this.Btnevent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btnevent.BackgroundImage")));
            this.Btnevent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnevent.FlatAppearance.BorderSize = 0;
            this.Btnevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnevent.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Btnevent.ForeColor = System.Drawing.Color.White;
            this.Btnevent.Location = new System.Drawing.Point(12, 271);
            this.Btnevent.Name = "Btnevent";
            this.Btnevent.Size = new System.Drawing.Size(119, 67);
            this.Btnevent.TabIndex = 8;
            this.Btnevent.Text = "My Events";
            this.Btnevent.UseVisualStyleBackColor = false;
            this.Btnevent.Click += new System.EventHandler(this.Btnevent_Click_1);
            // 
            // Btnaccount
            // 
            this.Btnaccount.BackColor = System.Drawing.Color.White;
            this.Btnaccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btnaccount.BackgroundImage")));
            this.Btnaccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnaccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btnaccount.FlatAppearance.BorderSize = 0;
            this.Btnaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnaccount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Btnaccount.ForeColor = System.Drawing.Color.White;
            this.Btnaccount.Location = new System.Drawing.Point(16, 125);
            this.Btnaccount.Name = "Btnaccount";
            this.Btnaccount.Size = new System.Drawing.Size(119, 67);
            this.Btnaccount.TabIndex = 6;
            this.Btnaccount.Text = "My Account";
            this.Btnaccount.UseVisualStyleBackColor = false;
            this.Btnaccount.Click += new System.EventHandler(this.Btnaccount_Click_1);
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Sidepanel.Location = new System.Drawing.Point(3, 52);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(10, 50);
            this.Sidepanel.TabIndex = 2;
            this.Sidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidepanel_Paint);
            // 
            // Btnsearch
            // 
            this.Btnsearch.BackColor = System.Drawing.Color.White;
            this.Btnsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btnsearch.BackgroundImage")));
            this.Btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnsearch.FlatAppearance.BorderSize = 0;
            this.Btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Btnsearch.ForeColor = System.Drawing.Color.White;
            this.Btnsearch.Location = new System.Drawing.Point(3, 198);
            this.Btnsearch.Name = "Btnsearch";
            this.Btnsearch.Size = new System.Drawing.Size(105, 67);
            this.Btnsearch.TabIndex = 7;
            this.Btnsearch.Text = "Search";
            this.Btnsearch.UseVisualStyleBackColor = false;
            this.Btnsearch.Click += new System.EventHandler(this.Btnsearch_Click_1);
            // 
            // Btnhome
            // 
            this.Btnhome.BackColor = System.Drawing.Color.White;
            this.Btnhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btnhome.BackgroundImage")));
            this.Btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnhome.FlatAppearance.BorderSize = 0;
            this.Btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnhome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnhome.ForeColor = System.Drawing.Color.White;
            this.Btnhome.Location = new System.Drawing.Point(1, 52);
            this.Btnhome.Name = "Btnhome";
            this.Btnhome.Size = new System.Drawing.Size(105, 67);
            this.Btnhome.TabIndex = 0;
            this.Btnhome.Text = "Home";
            this.Btnhome.UseVisualStyleBackColor = false;
            this.Btnhome.Click += new System.EventHandler(this.Btnhome_Click_1);
            // 
            // oragniser_account1
            // 
            this.oragniser_account1.BackColor = System.Drawing.Color.White;
            this.oragniser_account1.Location = new System.Drawing.Point(139, 87);
            this.oragniser_account1.Name = "oragniser_account1";
            this.oragniser_account1.Size = new System.Drawing.Size(661, 370);
            this.oragniser_account1.TabIndex = 2;
            // 
            // organiser_search1
            // 
            this.organiser_search1.BackColor = System.Drawing.Color.White;
            this.organiser_search1.Location = new System.Drawing.Point(139, 87);
            this.organiser_search1.Name = "organiser_search1";
            this.organiser_search1.Size = new System.Drawing.Size(661, 370);
            this.organiser_search1.TabIndex = 3;
            // 
            // organiser_event1
            // 
            this.organiser_event1.BackColor = System.Drawing.Color.White;
            this.organiser_event1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organiser_event1.Location = new System.Drawing.Point(139, 87);
            this.organiser_event1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.organiser_event1.Name = "organiser_event1";
            this.organiser_event1.Size = new System.Drawing.Size(661, 370);
            this.organiser_event1.TabIndex = 4;
            // 
            // organiser_Home1
            // 
            this.organiser_Home1.BackColor = System.Drawing.Color.White;
            this.organiser_Home1.Location = new System.Drawing.Point(139, 87);
            this.organiser_Home1.Name = "organiser_Home1";
            this.organiser_Home1.Size = new System.Drawing.Size(661, 370);
            this.organiser_Home1.TabIndex = 5;
            // 
            // organiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 469);
            this.Controls.Add(this.organiser_Home1);
            this.Controls.Add(this.organiser_event1);
            this.Controls.Add(this.organiser_search1);
            this.Controls.Add(this.oragniser_account1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "organiser";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Button Btnhome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btnevent;
        private System.Windows.Forms.Button Btnsearch;
        private System.Windows.Forms.Button Btnaccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLogOut;
        private oragniser_account oragniser_account1;
        private organiser_search organiser_search1;
        private organiser_event organiser_event1;
        private organiser_Home organiser_Home1;
    }
}