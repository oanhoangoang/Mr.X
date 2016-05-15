namespace Mr_X
{
    partial class Intro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.picBackGr = new System.Windows.Forms.PictureBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tmrDescription = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBackGr)).BeginInit();
            this.pnlDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBackGr
            // 
            this.picBackGr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBackGr.Image = ((System.Drawing.Image)(resources.GetObject("picBackGr.Image")));
            this.picBackGr.Location = new System.Drawing.Point(-50, 0);
            this.picBackGr.Name = "picBackGr";
            this.picBackGr.Size = new System.Drawing.Size(1267, 663);
            this.picBackGr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackGr.TabIndex = 0;
            this.picBackGr.TabStop = false;
            // 
            // btnSkip
            // 
            this.btnSkip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSkip.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.LightGray;
            this.btnSkip.Location = new System.Drawing.Point(568, 315);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(115, 47);
            this.btnSkip.TabIndex = 1;
            this.btnSkip.Text = "Bỏ qua";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.White;
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Location = new System.Drawing.Point(97, 41);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(586, 249);
            this.pnlDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.lblDescription.Location = new System.Drawing.Point(2, 223);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(580, 369);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // tmrDescription
            // 
            this.tmrDescription.Enabled = true;
            this.tmrDescription.Interval = 50;
            this.tmrDescription.Tick += new System.EventHandler(this.tmrDescription_Tick);
            // 
            // Intro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.picBackGr);
            this.Name = "Intro";
            this.Size = new System.Drawing.Size(1217, 663);
            this.Load += new System.EventHandler(this.Intro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackGr)).EndInit();
            this.pnlDescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackGr;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Timer tmrDescription;
    }
}
