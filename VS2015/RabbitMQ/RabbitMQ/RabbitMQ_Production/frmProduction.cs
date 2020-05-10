using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitMQ_Production
{
    public partial class frmProduction : Form
    {
        ConnectionFactory factory = new ConnectionFactory();
        IConnection connection;
        IModel channel;
        public frmProduction()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text.Equals("连接"))
            {
                factory.HostName = txtIp.Text;//Rabbit server所在地址
                int port = 5672;//默认端口
                int.TryParse(txtPort.Text, out port);
                factory.Port = port;
                factory.UserName = txtLoginID.Text;//登录用户，同登录Rabbit web管理工具
                factory.Password = txtPwd.Text;//登录密码，同登录Rabbit web管理工具
                factory.RequestedHeartbeat = 60;

                connection = factory.CreateConnection();
                channel = connection.CreateModel();
                if (connection.IsOpen && channel.IsOpen)
                {
                    btnConnect.Text = "断开连接";
                    btnConnect.BackColor = Color.Green;
                    //channel.QueueDeclare(txtQueueName.Text, false, false, false, null);//创建一个名称为txtQueueName.Text的消息队列，非持久化的队列
                    channel.QueueDeclare(txtQueueName.Text, true, false, false, null);//创建一个名称为txtQueueName.Text的消息队列，持久化的队列

                }
                else
                {
                    btnConnect.Text = "连接";
                    btnConnect.BackColor = Color.Red;
                }
            }
            else
            {
                if (channel.IsOpen)
                {
                    channel.Close();
                    channel.Dispose();
                }
                if(connection.IsOpen)
                {
                    connection.Close();
                    connection.Dispose();
                }
                if (!connection.IsOpen && !channel.IsOpen) btnConnect.Text = "连接";
            }
        }

        private void frmProduction_Load(object sender, EventArgs e)
        {
            txtIp.Text = "192.168.197.132";
            txtPort.Text = "5672";
            txtLoginID.Text = "scott";
            txtPwd.Text = "123456";
            txtQueueName.Text = "scott";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtMessage.Text != "")
            {
                var properties = channel.CreateBasicProperties();
                properties.DeliveryMode = 1;
                properties.Persistent = true;
                channel.BasicPublish("", "scott", properties, Encoding.UTF8.GetBytes(txtMessage.Text));
            }
        }

        private void frmProduction_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (channel.IsOpen)
            {
                channel.Close();
                channel.Dispose();
            }
            if (connection.IsOpen)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        private void btnBatchSend_Click(object sender, EventArgs e)
        {
            frmBatchSend _frmBatch = new RabbitMQ_Production.frmBatchSend(factory, connection, channel);
            _frmBatch.ShowDialog();
        }
    }
}
