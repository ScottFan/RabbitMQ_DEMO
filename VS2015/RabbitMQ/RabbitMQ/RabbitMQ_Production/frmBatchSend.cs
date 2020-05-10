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
    public partial class frmBatchSend : Form
    {
        BackgroundWorker _bgWorker = new BackgroundWorker();
        private ConnectionFactory _factory = new ConnectionFactory();
        private IConnection _connection;
        private IModel _channel;

        private string _msg;

        public string Msg
        {
            get
            {
                return _msg;
            }

            set
            {
                _msg = value;
            }
        }

        public frmBatchSend(ConnectionFactory factory, IConnection connection,IModel channel)
        {
            InitializeComponent();
            _factory = factory;
            _connection = connection;
            _channel = channel;
        }

        private void frmBatchSend_Load(object sender, EventArgs e)
        {
            txtContent.Text = _msg;
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Action act = delegate () {
                btnStart.Enabled = false;
            };
            if (_bgWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            int nStart = 0;
            int nEnd = 0;
            nEnd = Convert.ToInt32(txtMsgNum.Text);
            List<Task> taskList = new List<Task>();
            TaskFactory taskFactory = Task.Factory;
            for (; nStart < nEnd; nStart++)
            {
                if (_bgWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                taskList.Add(taskFactory.StartNew((pCount) =>
                {
                    try
                    {
                        if (txtContent.Text != "")
                        {
                            var properties = _channel.CreateBasicProperties();
                            properties.DeliveryMode = 1;
                            properties.Persistent = true;
                            _channel.BasicPublish("", "scott", properties, Encoding.UTF8.GetBytes(pCount+"."+txtContent.Text));
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                },nStart));
            }
            Task.WaitAll(taskList.ToArray());
            taskList.Clear();
        }
        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Enabled = true;
            _bgWorker.RunWorkerCompleted -= bgWorker_RunWorkerCompleted;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            _bgWorker.RunWorkerCompleted += bgWorker_RunWorkerCompleted;
            _bgWorker.RunWorkerAsync();
        }
    }
}
