
namespace Win11GulimFix
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.on_btn = new System.Windows.Forms.Button();
            this.off_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AboutlinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // on_btn
            // 
            this.on_btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.on_btn.Location = new System.Drawing.Point(14, 60);
            this.on_btn.Name = "on_btn";
            this.on_btn.Size = new System.Drawing.Size(225, 38);
            this.on_btn.TabIndex = 0;
            this.on_btn.Text = "적용하기!";
            this.on_btn.UseVisualStyleBackColor = true;
            this.on_btn.Click += new System.EventHandler(this.on_btn_Click);
            // 
            // off_btn
            // 
            this.off_btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.off_btn.Location = new System.Drawing.Point(246, 60);
            this.off_btn.Name = "off_btn";
            this.off_btn.Size = new System.Drawing.Size(229, 38);
            this.off_btn.TabIndex = 1;
            this.off_btn.Text = "되돌리기!";
            this.off_btn.UseVisualStyleBackColor = true;
            this.off_btn.Click += new System.EventHandler(this.off_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Win11/Win10 굴림체 패치";
            // 
            // AboutlinkLabel
            // 
            this.AboutlinkLabel.AutoSize = true;
            this.AboutlinkLabel.Location = new System.Drawing.Point(14, 102);
            this.AboutlinkLabel.Name = "AboutlinkLabel";
            this.AboutlinkLabel.Size = new System.Drawing.Size(101, 15);
            this.AboutlinkLabel.TabIndex = 3;
            this.AboutlinkLabel.TabStop = true;
            this.AboutlinkLabel.Text = "ITStory - Win11Fix";
            this.AboutlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutlinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "v1.2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(489, 128);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AboutlinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.off_btn);
            this.Controls.Add(this.on_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win11/Win10 Gulim Fix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button on_btn;
        private System.Windows.Forms.Button off_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel AboutlinkLabel;
        private System.Windows.Forms.Label label2;
    }
}

