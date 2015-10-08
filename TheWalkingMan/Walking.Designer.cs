namespace TheWalkingMan
{
    partial class frmWalking
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
            this.btnStartWalking = new System.Windows.Forms.Button();
            this.picManWalking = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picManWalking)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartWalking
            // 
            this.btnStartWalking.Location = new System.Drawing.Point(123, 257);
            this.btnStartWalking.Name = "btnStartWalking";
            this.btnStartWalking.Size = new System.Drawing.Size(136, 23);
            this.btnStartWalking.TabIndex = 1;
            this.btnStartWalking.Text = "Start";
            this.btnStartWalking.UseVisualStyleBackColor = true;
            this.btnStartWalking.Click += new System.EventHandler(this.btnStartWalking_Click);
            // 
            // picManWalking
            // 
            this.picManWalking.Image = global::TheWalkingMan.Properties.Resources.walk1;
            this.picManWalking.Location = new System.Drawing.Point(107, 30);
            this.picManWalking.Name = "picManWalking";
            this.picManWalking.Size = new System.Drawing.Size(182, 182);
            this.picManWalking.TabIndex = 0;
            this.picManWalking.TabStop = false;
            // 
            // frmWalking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 326);
            this.Controls.Add(this.btnStartWalking);
            this.Controls.Add(this.picManWalking);
            this.Name = "frmWalking";
            this.Text = "The Walking Man";
            ((System.ComponentModel.ISupportInitialize)(this.picManWalking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picManWalking;
        private System.Windows.Forms.Button btnStartWalking;
    }
}

