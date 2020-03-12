using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomLoggerInterface
{
    public partial class Form1 : Form
    {
        private readonly ILogger _logger;

        public Form1(ILogger loggi)
        {
            _logger = loggi;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _logger.Log("Loading Form1 " + DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _logger.Log("Button1 Clicked " + DateTime.Now);
        }
    }
}
