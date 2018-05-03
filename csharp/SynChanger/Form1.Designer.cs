namespace SynChanger
{
    partial class mainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.beforeTextBox = new System.Windows.Forms.RichTextBox();
            this.afterTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // beforeTextBox
            // 
            this.beforeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.beforeTextBox.Location = new System.Drawing.Point(12, 12);
            this.beforeTextBox.Name = "beforeTextBox";
            this.beforeTextBox.Size = new System.Drawing.Size(250, 337);
            this.beforeTextBox.TabIndex = 2;
            this.beforeTextBox.Text = "";
            this.beforeTextBox.TextChanged += new System.EventHandler(this.beforeTextBox_TextChanged);
            this.beforeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.beforeTextBox_KeyDown);
            // 
            // afterTextBox
            // 
            this.afterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.afterTextBox.Location = new System.Drawing.Point(322, 12);
            this.afterTextBox.Name = "afterTextBox";
            this.afterTextBox.Size = new System.Drawing.Size(250, 337);
            this.afterTextBox.TabIndex = 3;
            this.afterTextBox.Text = "";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.afterTextBox);
            this.Controls.Add(this.beforeTextBox);
            this.Name = "mainForm";
            this.Text = "SynChanger";
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox beforeTextBox;
        private System.Windows.Forms.RichTextBox afterTextBox;
    }
}

