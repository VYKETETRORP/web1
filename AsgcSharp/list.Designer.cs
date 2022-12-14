namespace AsgcSharp
{
    partial class list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.imgImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblcost = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 26;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.imgImage);
            this.bunifuPanel1.Controls.Add(this.lblcost);
            this.bunifuPanel1.Controls.Add(this.lbltitle);
            this.bunifuPanel1.Location = new System.Drawing.Point(10, 1);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(263, 134);
            this.bunifuPanel1.TabIndex = 1;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // imgImage
            // 
            this.imgImage.AllowFocused = false;
            this.imgImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imgImage.AutoSizeHeight = true;
            this.imgImage.BorderRadius = 0;
            this.imgImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgImage.Image = global::AsgcSharp.Properties.Resources.images__2_;
            this.imgImage.IsCircle = true;
            this.imgImage.Location = new System.Drawing.Point(156, 26);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(82, 82);
            this.imgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgImage.TabIndex = 2;
            this.imgImage.TabStop = false;
            this.imgImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // lblcost
            // 
            this.lblcost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblcost.AutoSize = true;
            this.lblcost.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblcost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblcost.Location = new System.Drawing.Point(9, 89);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(79, 37);
            this.lblcost.TabIndex = 1;
            this.lblcost.Text = "$1.75";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbltitle.Location = new System.Drawing.Point(12, 13);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(115, 23);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Runch Burger";
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "list";
            this.Size = new System.Drawing.Size(282, 137);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public Bunifu.UI.WinForms.BunifuPictureBox imgImage;
        public System.Windows.Forms.Label lblcost;
        public System.Windows.Forms.Label lbltitle;
    }
}
