namespace hong2_1
{
    partial class Form1
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
            this.Pintbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.재고ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재고확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재고주문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pintbtn
            // 
            this.Pintbtn.Location = new System.Drawing.Point(103, 151);
            this.Pintbtn.Name = "Pintbtn";
            this.Pintbtn.Size = new System.Drawing.Size(155, 97);
            this.Pintbtn.TabIndex = 0;
            this.Pintbtn.Text = "파인트";
            this.Pintbtn.UseVisualStyleBackColor = true;
            this.Pintbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "쿼터";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(511, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 97);
            this.button3.TabIndex = 2;
            this.button3.Text = "패밀리";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(710, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 97);
            this.button4.TabIndex = 3;
            this.button4.Text = "하프갤론";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.재고ToolStripMenuItem,
            this.주문ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 재고ToolStripMenuItem
            // 
            this.재고ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.재고확인ToolStripMenuItem,
            this.재고주문ToolStripMenuItem});
            this.재고ToolStripMenuItem.Name = "재고ToolStripMenuItem";
            this.재고ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.재고ToolStripMenuItem.Text = "재고";
            // 
            // 재고확인ToolStripMenuItem
            // 
            this.재고확인ToolStripMenuItem.Name = "재고확인ToolStripMenuItem";
            this.재고확인ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.재고확인ToolStripMenuItem.Text = "재고확인";
            this.재고확인ToolStripMenuItem.Click += new System.EventHandler(this.재고확인ToolStripMenuItem_Click);
            // 
            // 재고주문ToolStripMenuItem
            // 
            this.재고주문ToolStripMenuItem.Name = "재고주문ToolStripMenuItem";
            this.재고주문ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.재고주문ToolStripMenuItem.Text = "재고주문";
            this.재고주문ToolStripMenuItem.Click += new System.EventHandler(this.재고주문ToolStripMenuItem_Click);
            // 
            // 주문ToolStripMenuItem
            // 
            this.주문ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주문확인ToolStripMenuItem});
            this.주문ToolStripMenuItem.Name = "주문ToolStripMenuItem";
            this.주문ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.주문ToolStripMenuItem.Text = "주문";
            // 
            // 주문확인ToolStripMenuItem
            // 
            this.주문확인ToolStripMenuItem.Name = "주문확인ToolStripMenuItem";
            this.주문확인ToolStripMenuItem.Size = new System.Drawing.Size(186, 34);
            this.주문확인ToolStripMenuItem.Text = "주문내역";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(414, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 97);
            this.button5.TabIndex = 6;
            this.button5.Text = "케이크";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(982, 492);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Pintbtn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "배스킨라빈스";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pintbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 재고ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재고확인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재고주문ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문확인ToolStripMenuItem;
        private System.Windows.Forms.Button button5;
    }
}

