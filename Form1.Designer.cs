namespace wfTic
{
    partial class frmNildaTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNildaTicTacToe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1btnzerozero = new System.Windows.Forms.Button();
            this.A2btnTopCenter = new System.Windows.Forms.Button();
            this.A3btnTopRight = new System.Windows.Forms.Button();
            this.B1btnMiddleLeft = new System.Windows.Forms.Button();
            this.B2btnCenterMiddle = new System.Windows.Forms.Button();
            this.B3btnMiddleRight = new System.Windows.Forms.Button();
            this.C1btnBottomLeft = new System.Windows.Forms.Button();
            this.C2btnBottomCenter = new System.Windows.Forms.Button();
            this.C3btnBottomRight = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(623, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // A1btnzerozero
            // 
            this.A1btnzerozero.BackColor = System.Drawing.Color.Pink;
            this.A1btnzerozero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1btnzerozero.ForeColor = System.Drawing.Color.Maroon;
            this.A1btnzerozero.Location = new System.Drawing.Point(162, 268);
            this.A1btnzerozero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.A1btnzerozero.Name = "A1btnzerozero";
            this.A1btnzerozero.Size = new System.Drawing.Size(84, 110);
            this.A1btnzerozero.TabIndex = 1;
            this.A1btnzerozero.UseVisualStyleBackColor = false;
            this.A1btnzerozero.Click += new System.EventHandler(this.button_click);
            // 
            // A2btnTopCenter
            // 
            this.A2btnTopCenter.BackColor = System.Drawing.Color.Pink;
            this.A2btnTopCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2btnTopCenter.ForeColor = System.Drawing.Color.Maroon;
            this.A2btnTopCenter.Location = new System.Drawing.Point(266, 268);
            this.A2btnTopCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.A2btnTopCenter.Name = "A2btnTopCenter";
            this.A2btnTopCenter.Size = new System.Drawing.Size(84, 110);
            this.A2btnTopCenter.TabIndex = 2;
            this.A2btnTopCenter.UseVisualStyleBackColor = false;
            this.A2btnTopCenter.Click += new System.EventHandler(this.button_click);
            // 
            // A3btnTopRight
            // 
            this.A3btnTopRight.BackColor = System.Drawing.Color.Pink;
            this.A3btnTopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3btnTopRight.ForeColor = System.Drawing.Color.Maroon;
            this.A3btnTopRight.Location = new System.Drawing.Point(370, 268);
            this.A3btnTopRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.A3btnTopRight.Name = "A3btnTopRight";
            this.A3btnTopRight.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.A3btnTopRight.Size = new System.Drawing.Size(84, 110);
            this.A3btnTopRight.TabIndex = 3;
            this.A3btnTopRight.UseVisualStyleBackColor = false;
            this.A3btnTopRight.Click += new System.EventHandler(this.button_click);
            // 
            // B1btnMiddleLeft
            // 
            this.B1btnMiddleLeft.BackColor = System.Drawing.Color.Pink;
            this.B1btnMiddleLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1btnMiddleLeft.ForeColor = System.Drawing.Color.Maroon;
            this.B1btnMiddleLeft.Location = new System.Drawing.Point(162, 401);
            this.B1btnMiddleLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.B1btnMiddleLeft.Name = "B1btnMiddleLeft";
            this.B1btnMiddleLeft.Size = new System.Drawing.Size(84, 110);
            this.B1btnMiddleLeft.TabIndex = 4;
            this.B1btnMiddleLeft.UseVisualStyleBackColor = false;
            this.B1btnMiddleLeft.Click += new System.EventHandler(this.button_click);
            // 
            // B2btnCenterMiddle
            // 
            this.B2btnCenterMiddle.BackColor = System.Drawing.Color.Pink;
            this.B2btnCenterMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2btnCenterMiddle.ForeColor = System.Drawing.Color.Maroon;
            this.B2btnCenterMiddle.Location = new System.Drawing.Point(266, 401);
            this.B2btnCenterMiddle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.B2btnCenterMiddle.Name = "B2btnCenterMiddle";
            this.B2btnCenterMiddle.Size = new System.Drawing.Size(84, 110);
            this.B2btnCenterMiddle.TabIndex = 5;
            this.B2btnCenterMiddle.UseVisualStyleBackColor = false;
            this.B2btnCenterMiddle.Click += new System.EventHandler(this.button_click);
            // 
            // B3btnMiddleRight
            // 
            this.B3btnMiddleRight.BackColor = System.Drawing.Color.LightPink;
            this.B3btnMiddleRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3btnMiddleRight.ForeColor = System.Drawing.Color.Maroon;
            this.B3btnMiddleRight.Location = new System.Drawing.Point(370, 401);
            this.B3btnMiddleRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.B3btnMiddleRight.Name = "B3btnMiddleRight";
            this.B3btnMiddleRight.Size = new System.Drawing.Size(84, 110);
            this.B3btnMiddleRight.TabIndex = 6;
            this.B3btnMiddleRight.UseVisualStyleBackColor = false;
            this.B3btnMiddleRight.Click += new System.EventHandler(this.button_click);
            // 
            // C1btnBottomLeft
            // 
            this.C1btnBottomLeft.BackColor = System.Drawing.Color.Pink;
            this.C1btnBottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1btnBottomLeft.ForeColor = System.Drawing.Color.Maroon;
            this.C1btnBottomLeft.Location = new System.Drawing.Point(162, 539);
            this.C1btnBottomLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.C1btnBottomLeft.Name = "C1btnBottomLeft";
            this.C1btnBottomLeft.Size = new System.Drawing.Size(84, 110);
            this.C1btnBottomLeft.TabIndex = 7;
            this.C1btnBottomLeft.UseVisualStyleBackColor = false;
            this.C1btnBottomLeft.Click += new System.EventHandler(this.button_click);
            // 
            // C2btnBottomCenter
            // 
            this.C2btnBottomCenter.BackColor = System.Drawing.Color.Pink;
            this.C2btnBottomCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2btnBottomCenter.ForeColor = System.Drawing.Color.Maroon;
            this.C2btnBottomCenter.Location = new System.Drawing.Point(266, 539);
            this.C2btnBottomCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.C2btnBottomCenter.Name = "C2btnBottomCenter";
            this.C2btnBottomCenter.Size = new System.Drawing.Size(84, 110);
            this.C2btnBottomCenter.TabIndex = 8;
            this.C2btnBottomCenter.UseVisualStyleBackColor = false;
            this.C2btnBottomCenter.Click += new System.EventHandler(this.button_click);
            // 
            // C3btnBottomRight
            // 
            this.C3btnBottomRight.BackColor = System.Drawing.Color.Pink;
            this.C3btnBottomRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.C3btnBottomRight.FlatAppearance.BorderSize = 5;
            this.C3btnBottomRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.C3btnBottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3btnBottomRight.ForeColor = System.Drawing.Color.Maroon;
            this.C3btnBottomRight.Location = new System.Drawing.Point(370, 539);
            this.C3btnBottomRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.C3btnBottomRight.Name = "C3btnBottomRight";
            this.C3btnBottomRight.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.C3btnBottomRight.Size = new System.Drawing.Size(84, 110);
            this.C3btnBottomRight.TabIndex = 9;
            this.C3btnBottomRight.UseVisualStyleBackColor = false;
            this.C3btnBottomRight.Click += new System.EventHandler(this.button_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.pictureBox1.Size = new System.Drawing.Size(360, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmNildaTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(623, 705);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.C3btnBottomRight);
            this.Controls.Add(this.C2btnBottomCenter);
            this.Controls.Add(this.C1btnBottomLeft);
            this.Controls.Add(this.B3btnMiddleRight);
            this.Controls.Add(this.B2btnCenterMiddle);
            this.Controls.Add(this.B1btnMiddleLeft);
            this.Controls.Add(this.A3btnTopRight);
            this.Controls.Add(this.A2btnTopCenter);
            this.Controls.Add(this.A1btnzerozero);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmNildaTicTacToe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.frmNildaTicTacToe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1btnzerozero;
        private System.Windows.Forms.Button A2btnTopCenter;
        private System.Windows.Forms.Button A3btnTopRight;
        private System.Windows.Forms.Button B1btnMiddleLeft;
        private System.Windows.Forms.Button B2btnCenterMiddle;
        private System.Windows.Forms.Button B3btnMiddleRight;
        private System.Windows.Forms.Button C1btnBottomLeft;
        private System.Windows.Forms.Button C2btnBottomCenter;
        private System.Windows.Forms.Button C3btnBottomRight;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

