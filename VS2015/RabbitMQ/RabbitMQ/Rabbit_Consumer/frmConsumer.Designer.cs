﻿namespace Rabbit_Consumer
{
    partial class frmConsumer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReceiving = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQueueName = new System.Windows.Forms.TextBox();
            this.lblQueueName = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.lblLoginID = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblIpAddr = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReceiving
            // 
            this.btnReceiving.Location = new System.Drawing.Point(417, 405);
            this.btnReceiving.Name = "btnReceiving";
            this.btnReceiving.Size = new System.Drawing.Size(123, 40);
            this.btnReceiving.TabIndex = 7;
            this.btnReceiving.Text = "开始接收";
            this.btnReceiving.UseVisualStyleBackColor = true;
            this.btnReceiving.Click += new System.EventHandler(this.btnReceiving_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMsg);
            this.groupBox2.Location = new System.Drawing.Point(12, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 169);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "消息";
            // 
            // lstMsg
            // 
            this.lstMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.ItemHeight = 18;
            this.lstMsg.Location = new System.Drawing.Point(6, 27);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(521, 128);
            this.lstMsg.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQueueName);
            this.groupBox1.Controls.Add(this.lblQueueName);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.lblPwd);
            this.groupBox1.Controls.Add(this.txtLoginID);
            this.groupBox1.Controls.Add(this.lblLoginID);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.lblIpAddr);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 192);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rabbit Server 信息";
            // 
            // txtQueueName
            // 
            this.txtQueueName.Location = new System.Drawing.Point(124, 148);
            this.txtQueueName.Name = "txtQueueName";
            this.txtQueueName.Size = new System.Drawing.Size(383, 28);
            this.txtQueueName.TabIndex = 10;
            // 
            // lblQueueName
            // 
            this.lblQueueName.AutoSize = true;
            this.lblQueueName.Location = new System.Drawing.Point(20, 151);
            this.lblQueueName.Name = "lblQueueName";
            this.lblQueueName.Size = new System.Drawing.Size(89, 18);
            this.lblQueueName.TabIndex = 9;
            this.lblQueueName.Text = "队列名称:";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(367, 94);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(140, 28);
            this.txtPwd.TabIndex = 8;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(308, 98);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 18);
            this.lblPwd.TabIndex = 7;
            this.lblPwd.Text = "密码:";
            // 
            // txtLoginID
            // 
            this.txtLoginID.Location = new System.Drawing.Point(124, 95);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(155, 28);
            this.txtLoginID.TabIndex = 6;
            // 
            // lblLoginID
            // 
            this.lblLoginID.AutoSize = true;
            this.lblLoginID.Location = new System.Drawing.Point(20, 98);
            this.lblLoginID.Name = "lblLoginID";
            this.lblLoginID.Size = new System.Drawing.Size(71, 18);
            this.lblLoginID.TabIndex = 5;
            this.lblLoginID.Text = "用户名:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(367, 45);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(140, 28);
            this.txtPort.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(308, 49);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(53, 18);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(124, 46);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(155, 28);
            this.txtIp.TabIndex = 1;
            // 
            // lblIpAddr
            // 
            this.lblIpAddr.AutoSize = true;
            this.lblIpAddr.Location = new System.Drawing.Point(20, 49);
            this.lblIpAddr.Name = "lblIpAddr";
            this.lblIpAddr.Size = new System.Drawing.Size(35, 18);
            this.lblIpAddr.TabIndex = 0;
            this.lblIpAddr.Text = "IP:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(273, 405);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(123, 40);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // frmConsumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 455);
            this.Controls.Add(this.btnReceiving);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmConsumer";
            this.Text = "消费者";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsumer_FormClosing);
            this.Load += new System.EventHandler(this.frmConsumer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReceiving;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQueueName;
        private System.Windows.Forms.Label lblQueueName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.Label lblLoginID;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblIpAddr;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox lstMsg;
    }
}

