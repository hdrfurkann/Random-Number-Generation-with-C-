namespace furkanhidirCProje
{
    partial class AboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMe));
            this.label1 = new System.Windows.Forms.Label();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.github_btn = new System.Windows.Forms.Button();
            this.buymecoffee = new System.Windows.Forms.Button();
            this.linkedln = new System.Windows.Forms.Button();
            this.instagram = new System.Windows.Forms.Button();
            this.Oky_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(178, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hakkımda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Enabled = true;
            this.modalEffect_Timer.Interval = 1;
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(426, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.MaximumSize = new System.Drawing.Size(400, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // github_btn
            // 
            this.github_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.github_btn.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.github_btn.ForeColor = System.Drawing.Color.White;
            this.github_btn.Location = new System.Drawing.Point(44, 157);
            this.github_btn.Name = "github_btn";
            this.github_btn.Size = new System.Drawing.Size(91, 35);
            this.github_btn.TabIndex = 3;
            this.github_btn.Text = "GitHub";
            this.github_btn.UseVisualStyleBackColor = true;
            this.github_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // buymecoffee
            // 
            this.buymecoffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buymecoffee.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buymecoffee.ForeColor = System.Drawing.Color.White;
            this.buymecoffee.Location = new System.Drawing.Point(141, 157);
            this.buymecoffee.Name = "buymecoffee";
            this.buymecoffee.Size = new System.Drawing.Size(91, 35);
            this.buymecoffee.TabIndex = 4;
            this.buymecoffee.Text = "Support Me";
            this.buymecoffee.UseVisualStyleBackColor = true;
            this.buymecoffee.Click += new System.EventHandler(this.buymecoffee_Click);
            // 
            // linkedln
            // 
            this.linkedln.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkedln.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkedln.ForeColor = System.Drawing.Color.White;
            this.linkedln.Location = new System.Drawing.Point(238, 157);
            this.linkedln.Name = "linkedln";
            this.linkedln.Size = new System.Drawing.Size(91, 35);
            this.linkedln.TabIndex = 5;
            this.linkedln.Text = "Linkedln";
            this.linkedln.UseVisualStyleBackColor = true;
            this.linkedln.Click += new System.EventHandler(this.linkedln_Click);
            // 
            // instagram
            // 
            this.instagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instagram.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.instagram.ForeColor = System.Drawing.Color.White;
            this.instagram.Location = new System.Drawing.Point(335, 157);
            this.instagram.Name = "instagram";
            this.instagram.Size = new System.Drawing.Size(91, 35);
            this.instagram.TabIndex = 6;
            this.instagram.Text = "Instagram";
            this.instagram.UseVisualStyleBackColor = true;
            this.instagram.Click += new System.EventHandler(this.instagram_Click);
            // 
            // Oky_btn
            // 
            this.Oky_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Oky_btn.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Oky_btn.ForeColor = System.Drawing.Color.White;
            this.Oky_btn.Location = new System.Drawing.Point(351, 227);
            this.Oky_btn.Name = "Oky_btn";
            this.Oky_btn.Size = new System.Drawing.Size(75, 40);
            this.Oky_btn.TabIndex = 7;
            this.Oky_btn.Text = "Tamam";
            this.Oky_btn.UseVisualStyleBackColor = true;
            this.Oky_btn.Click += new System.EventHandler(this.Oky_btn_Click);
            // 
            // AboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 279);
            this.Controls.Add(this.Oky_btn);
            this.Controls.Add(this.instagram);
            this.Controls.Add(this.linkedln);
            this.Controls.Add(this.buymecoffee);
            this.Controls.Add(this.github_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutMe";
            this.Opacity = 0D;
            this.Text = "AboutMe";
            this.Load += new System.EventHandler(this.AboutMe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer modalEffect_Timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button github_btn;
        private System.Windows.Forms.Button buymecoffee;
        private System.Windows.Forms.Button linkedln;
        private System.Windows.Forms.Button instagram;
        private System.Windows.Forms.Button Oky_btn;
    }
}