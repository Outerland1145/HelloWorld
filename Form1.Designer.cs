
namespace HelloWorld
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
            this.BtnGo = new System.Windows.Forms.Button();
            this.EnterA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGo
            // 
            this.BtnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGo.Location = new System.Drawing.Point(515, 198);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(145, 22);
            this.BtnGo.TabIndex = 0;
            this.BtnGo.Text = "登入";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // EnterA
            // 
            this.EnterA.Location = new System.Drawing.Point(108, 198);
            this.EnterA.Name = "EnterA";
            this.EnterA.Size = new System.Drawing.Size(382, 22);
            this.EnterA.TabIndex = 1;
            this.EnterA.Text = "請輸入帳戶";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterA);
            this.Controls.Add(this.BtnGo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.TextBox EnterA;
    }
}

