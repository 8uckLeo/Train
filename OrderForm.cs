using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace train
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        private DataGridViewRow Row;
        public event Action updataTicket;
        public OrderForm(DataGridViewRow row)
        {
            InitializeComponent();
            this.Row = row;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
           this.lblTrainNo.Text = Row.Cells["TrainNo"].Value.ToString();
           this.lblRunTime.Text = Convert.ToDateTime(Row.Cells["RunTime"].Value).ToString("yyyy/MM/dd HH:mm");
           this.lblStartStation.Text = Row.Cells["StartStation"].Value.ToString();
           this.lblEndStation.Text = Row.Cells["EndStation"].Value.ToString();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string name = this.txtName.Text.Trim();
            string phone = this.txtPhone.Text.Trim();
            string cardID = this.txtCardID.Text.Trim();
            string trainID = Row.Cells["TrainId"].Value.ToString();

            string sql = @"insert into Persons(Name, CardID, TelePhone, TrainID, CreateTime) values(@Name, @CardID, @TelePhone, @TrainID, CURRENT_TIMESTAMP)";
           
            MySqlParameter[] paras =
            {
                new MySqlParameter("@Name",name),
                new MySqlParameter("@CardID",cardID),
                new MySqlParameter("@TelePhone",phone),
                new MySqlParameter("@TrainId",trainID),
            };

            int result = DBHelper.ExecuteNonQuery(sql, paras);

            if (result > 0)
            {
                MessageBox.Show("購票成功");
                if(updataTicket != null)
                    updataTicket();
                this.Close();
            }
            else
            {
                MessageBox.Show("購票失敗");
            }


        }
    }
}
