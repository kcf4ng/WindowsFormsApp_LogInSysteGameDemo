namespace prjGameDemo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic = new System.Windows.Forms.PictureBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.picUp = new System.Windows.Forms.PictureBox();
            this.picDown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(483, 230);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(50, 50);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // picLeft
            // 
            this.picLeft.Image = ((System.Drawing.Image)(resources.GetObject("picLeft.Image")));
            this.picLeft.Location = new System.Drawing.Point(375, 200);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(50, 50);
            this.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeft.TabIndex = 1;
            this.picLeft.TabStop = false;
            this.picLeft.Visible = false;
            // 
            // picRight
            // 
            this.picRight.Image = ((System.Drawing.Image)(resources.GetObject("picRight.Image")));
            this.picRight.Location = new System.Drawing.Point(375, 256);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(50, 50);
            this.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRight.TabIndex = 2;
            this.picRight.TabStop = false;
            this.picRight.Visible = false;
            // 
            // picUp
            // 
            this.picUp.Image = ((System.Drawing.Image)(resources.GetObject("picUp.Image")));
            this.picUp.Location = new System.Drawing.Point(375, 312);
            this.picUp.Name = "picUp";
            this.picUp.Size = new System.Drawing.Size(50, 50);
            this.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUp.TabIndex = 3;
            this.picUp.TabStop = false;
            this.picUp.Visible = false;
            // 
            // picDown
            // 
            this.picDown.Image = ((System.Drawing.Image)(resources.GetObject("picDown.Image")));
            this.picDown.Location = new System.Drawing.Point(375, 368);
            this.picDown.Name = "picDown";
            this.picDown.Size = new System.Drawing.Size(50, 50);
            this.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDown.TabIndex = 4;
            this.picDown.TabStop = false;
            this.picDown.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picDown);
            this.Controls.Add(this.picUp);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.picLeft);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.PictureBox picLeft;
        private System.Windows.Forms.PictureBox picRight;
        private System.Windows.Forms.PictureBox picUp;
        private System.Windows.Forms.PictureBox picDown;
    }
}

