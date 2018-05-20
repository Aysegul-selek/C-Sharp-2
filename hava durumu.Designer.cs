namespace telefonum
{
    partial class hava_durumu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.güneşli = new System.Windows.Forms.PictureBox();
            this.bulutlu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.güneşli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulutlu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // güneşli
            // 
            this.güneşli.Image = global::telefonum.Properties.Resources.HqFh13EV_400x400;
            this.güneşli.Location = new System.Drawing.Point(131, 87);
            this.güneşli.Name = "güneşli";
            this.güneşli.Size = new System.Drawing.Size(115, 75);
            this.güneşli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.güneşli.TabIndex = 4;
            this.güneşli.TabStop = false;
            this.güneşli.Visible = false;
            // 
            // bulutlu
            // 
            this.bulutlu.Image = global::telefonum.Properties.Resources.cloud_2017524_960_720;
            this.bulutlu.Location = new System.Drawing.Point(131, 77);
            this.bulutlu.Name = "bulutlu";
            this.bulutlu.Size = new System.Drawing.Size(115, 75);
            this.bulutlu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulutlu.TabIndex = 2;
            this.bulutlu.TabStop = false;
            this.bulutlu.Visible = false;
            // 
            // hava_durumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(361, 190);
            this.Controls.Add(this.güneşli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bulutlu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "hava_durumu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hava_durumu";
            this.Load += new System.EventHandler(this.hava_durumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.güneşli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulutlu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox bulutlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox güneşli;
    }
}