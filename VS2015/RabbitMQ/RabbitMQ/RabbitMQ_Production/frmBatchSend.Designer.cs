namespace RabbitMQ_Production
{
    partial class frmBatchSend
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblMsgNum = new System.Windows.Forms.Label();
            this.txtMsgNum = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMsgNum);
            this.groupBox1.Controls.Add(this.lblMsgNum);
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Controls.Add(this.lblContent);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送设置";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(18, 37);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(80, 18);
            this.lblContent.TabIndex = 0;
            this.lblContent.Text = "消息内容";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(21, 58);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(485, 118);
            this.txtContent.TabIndex = 1;
            // 
            // lblMsgNum
            // 
            this.lblMsgNum.AutoSize = true;
            this.lblMsgNum.Location = new System.Drawing.Point(18, 195);
            this.lblMsgNum.Name = "lblMsgNum";
            this.lblMsgNum.Size = new System.Drawing.Size(80, 18);
            this.lblMsgNum.TabIndex = 2;
            this.lblMsgNum.Text = "发送次数";
            // 
            // txtMsgNum
            // 
            this.txtMsgNum.Location = new System.Drawing.Point(104, 190);
            this.txtMsgNum.Name = "txtMsgNum";
            this.txtMsgNum.Size = new System.Drawing.Size(100, 28);
            this.txtMsgNum.TabIndex = 3;
            this.txtMsgNum.Text = "1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(409, 277);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(126, 41);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmBatchSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 330);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBatchSend";
            this.Text = "批量发送";
            this.Load += new System.EventHandler(this.frmBatchSend_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMsgNum;
        private System.Windows.Forms.Label lblMsgNum;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button btnStart;
    }
}