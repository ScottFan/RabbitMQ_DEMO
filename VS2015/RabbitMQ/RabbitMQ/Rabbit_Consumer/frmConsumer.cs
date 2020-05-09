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

namespace Rabbit_Consumer
{
    public partial class frmConsumer : Form
    {
        ConnectionFactory factory = new ConnectionFactory();
        IConnection connection;
        IModel channel;
        EventingBasicConsumer consumer;
        public frmConsumer()
        {
            InitializeComponent();
        }

        private void frmConsumer_Load(object sender, EventArgs e)
        {
            txtIp.Text = "192.168.197.132";
            txtPort.Text = "5672";
            txtLoginID.Text = "scott";
            txtPwd.Text = "123456";
            txtQueueName.Text = "scott";
            btnReceiving.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text.Equals("连接"))
            {
                factory.HostName = txtIp.Text;//主机名，Rabbit会拿这个IP生成一个endpoint，这个很熟悉吧，就是socket绑定的那个终结点。
                int port = 5672;
                int.TryParse(txtPort.Text, out port);
                factory.Port = port;
                factory.UserName = txtLoginID.Text;//默认用户名,用户可以在服务端自定义创建，有相关命令行
                factory.Password = txtPwd.Text;//默认密码
                factory.RequestedHeartbeat = 60;

                connection = factory.CreateConnection();
                channel = connection.CreateModel();
                if (connection.IsOpen && channel.IsOpen)
                {
                    btnConnect.Text = "断开连接";
                    btnConnect.BackColor = Color.Green;
                    btnReceiving.Enabled = true;
                }
                else
                {
                    btnConnect.Text = "连接";
                    btnConnect.BackColor = Color.Red;
                    btnReceiving.Enabled = false;
                }
            }
            else
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
                if (!connection.IsOpen && !channel.IsOpen) btnConnect.Text = "连接";
            }
        }

        private void btnReceiving_Click(object sender, EventArgs e)
        {
            btnReceiving.Enabled = false;
            try
            {
                channel.QueueDeclare(txtQueueName.Text, true, false, false, null);
                channel.BasicQos(0, 1, false);
                consumer = new EventingBasicConsumer(channel);//消费者
                consumer.Received += (model, ea) =>
                {

                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    Action act = delegate () {
                        lstMsg.Items.Add(message);
                    };
                    this.Invoke(act);
                    
                };
                channel.BasicConsume("scott", true, consumer);//消费消息
            }
            catch
            { }
            finally
            {
                
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            consumer.OnCancel();
            btnReceiving.Enabled = true;
        }
    }
}
