namespace CircularButton
{
    partial class UserControl2
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.myButton1 = new CircularButton.MyButton();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.myButton1.Location = new System.Drawing.Point(148, 55);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(200, 200);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "myButton1";
            this.myButton1.形狀 = CircularButton.MyButton.Fillstyle.Ellipse;
            this.myButton1.顏色 = System.Drawing.Color.Empty;
            this.myButton1.點擊顏色 = System.Drawing.Color.Empty;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myButton1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(516, 395);
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton myButton1;
    }
}
