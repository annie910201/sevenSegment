namespace SevenSeg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputHeight = new System.Windows.Forms.TextBox();
            this.inputWidth = new System.Windows.Forms.TextBox();
            this.sure = new System.Windows.Forms.Button();
            this.inputNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "高";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "寬";
            // 
            // inputHeight
            // 
            this.inputHeight.Location = new System.Drawing.Point(55, 68);
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(56, 25);
            this.inputHeight.TabIndex = 2;
            // 
            // inputWidth
            // 
            this.inputWidth.Location = new System.Drawing.Point(55, 124);
            this.inputWidth.Name = "inputWidth";
            this.inputWidth.Size = new System.Drawing.Size(56, 25);
            this.inputWidth.TabIndex = 4;
            // 
            // sure
            // 
            this.sure.Location = new System.Drawing.Point(16, 187);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(95, 33);
            this.sure.TabIndex = 5;
            this.sure.Text = "確定";
            this.sure.UseVisualStyleBackColor = true;
            this.sure.Click += new System.EventHandler(this.sure_Click);
            // 
            // inputNum
            // 
            this.inputNum.Location = new System.Drawing.Point(16, 344);
            this.inputNum.Name = "inputNum";
            this.inputNum.Size = new System.Drawing.Size(100, 25);
            this.inputNum.TabIndex = 6;
            this.inputNum.TextChanged += new System.EventHandler(this.inputNum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "請輸數字(-9~99)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputNum);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.inputWidth);
            this.Controls.Add(this.inputHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputHeight;
        private System.Windows.Forms.TextBox inputWidth;
        private System.Windows.Forms.Button sure;
        private System.Windows.Forms.TextBox inputNum;
        private System.Windows.Forms.Label label3;
    }
}

