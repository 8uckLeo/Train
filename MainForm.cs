using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace train
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            serach();
        }
        public void serach()
        {
            //获取用户输入条件
            string start = this.cbostart.Text;
            string end = this.cboend.Text;
            string date = this.dtpData.Value.ToString("yyyy-MM-dd");


            string sql = @"SELECT trainid, trainno, runtime, startstation, endstation, price, ticketnumber
                            FROM train
                            WHERE DATE(runtime) = @date";

            //string sql = "select * from train";
            if (!string.IsNullOrEmpty(start))
            {
                sql += " AND StartStation = @StartStation";
            }

            if (!string.IsNullOrEmpty(end))
            {
                sql += " AND EndStation = @EndStation";
            }

            MySqlParameter[] paras ={
                new MySqlParameter("@date", date),
                new MySqlParameter("@StartStation", start),
                new MySqlParameter("@EndStation", end)
            };
            //this.dgvticket.DataSource = DBHelper.GetDataTable(sql);
            this.dgvticket.DataSource = DBHelper.GetDataTable(sql, paras);
        }
        /// <summary>
        /// 滑鼠點擊事件(左鍵、右鍵)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvticket_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(e.RowIndex >= 0)//沒選中是 -1 
                {
                    this.dgvticket.ClearSelection();//清除選中
                    this.dgvticket.Rows[e.RowIndex].Selected = true;//手動選中
                }
            }
        }

        private void tsmiBuy_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvticket.SelectedRows[0];
            OrderForm of = new OrderForm(row);
            of.updataTicket += updataTicket;
            of.Show();
            
            
        }

        private void updataTicket()
        {
            serach();
        }
    }
}
