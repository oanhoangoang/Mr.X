namespace Mr_X
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.picBackGround = new System.Windows.Forms.PictureBox();
            this.pnlDecription = new System.Windows.Forms.Panel();
            this.lblDecription = new System.Windows.Forms.Label();
            this.tmrDecription = new System.Windows.Forms.Timer(this.components);
            this.btnSkip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            this.pnlDecription.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBackGround
            // 
            this.picBackGround.Image = ((System.Drawing.Image)(resources.GetObject("picBackGround.Image")));
            this.picBackGround.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBackGround.InitialImage")));
            this.picBackGround.Location = new System.Drawing.Point(-70, -70);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(1357, 773);
            this.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackGround.TabIndex = 0;
            this.picBackGround.TabStop = false;
            // 
            // pnlDecription
            // 
            this.pnlDecription.BackColor = System.Drawing.Color.White;
            this.pnlDecription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecription.Controls.Add(this.lblDecription);
            this.pnlDecription.Location = new System.Drawing.Point(97, 41);
            this.pnlDecription.Name = "pnlDecription";
            this.pnlDecription.Size = new System.Drawing.Size(586, 249);
            this.pnlDecription.TabIndex = 1;
            // 
            // lblDecription
            // 
            this.lblDecription.BackColor = System.Drawing.Color.White;
            this.lblDecription.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.lblDecription.Location = new System.Drawing.Point(2, 223);
            this.lblDecription.Name = "lblDecription";
            this.lblDecription.Size = new System.Drawing.Size(580, 405);
            this.lblDecription.TabIndex = 0;
            this.lblDecription.Text = resources.GetString("lblDecription.Text");
            // 
            // tmrDecription
            // 
            this.tmrDecription.Enabled = true;
            this.tmrDecription.Interval = 50;
            this.tmrDecription.Tick += new System.EventHandler(this.tmrDecription_Tick);
            // 
            // btnSkip
            // 
            this.btnSkip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSkip.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.LightGray;
            this.btnSkip.Location = new System.Drawing.Point(1072, 590);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(109, 43);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 663);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.pnlDecription);
            this.Controls.Add(this.picBackGround);
            this.Font = new System.Drawing.Font("Canter Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.Text = "Mr.X";
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            this.pnlDecription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackGround;
        private System.Windows.Forms.Panel pnlDecription;
        private System.Windows.Forms.Label lblDecription;
        private System.Windows.Forms.Timer tmrDecription;
        private System.Windows.Forms.Button btnSkip;
    }
}

