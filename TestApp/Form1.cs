using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.ViewModels;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private CustomerViewModel m_dataContext;
        public Form1()
        {
            InitializeComponent();
            m_dataContext = new CustomerViewModel();
            dgCustomers.DataSource = m_dataContext.Customers;
        }
    }
}
