
namespace train
{
    partial class MainForm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboend = new System.Windows.Forms.ComboBox();
            this.cbostart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.dgvticket = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.TrainID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvticket)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboend);
            this.groupBox1.Controls.Add(this.cbostart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnsend);
            this.groupBox1.Location = new System.Drawing.Point(29, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "篩選條件";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(595, 35);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(157, 27);
            this.dtpData.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "日期 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "目的地 : ";
            // 
            // cboend
            // 
            this.cboend.FormattingEnabled = true;
            this.cboend.Items.AddRange(new object[] {
            "中壢",
            "台北",
            "屏東",
            "後龍",
            "新竹"});
            this.cboend.Location = new System.Drawing.Point(362, 35);
            this.cboend.Name = "cboend";
            this.cboend.Size = new System.Drawing.Size(121, 24);
            this.cboend.TabIndex = 1;
            // 
            // cbostart
            // 
            this.cbostart.FormattingEnabled = true;
            this.cbostart.Items.AddRange(new object[] {
            "沙鹿",
            "後龍",
            "中壢",
            "台南",
            "屏東"});
            this.cbostart.Location = new System.Drawing.Point(117, 37);
            this.cbostart.Name = "cbostart";
            this.cbostart.Size = new System.Drawing.Size(121, 24);
            this.cbostart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "出發地 : ";
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(811, 35);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 30);
            this.btnsend.TabIndex = 1;
            this.btnsend.Text = "查詢";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // dgvticket
            // 
            this.dgvticket.AllowUserToAddRows = false;
            this.dgvticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvticket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrainID,
            this.TrainNo,
            this.RunTime,
            this.StartStation,
            this.EndStation,
            this.Price,
            this.TicketNumber});
            this.dgvticket.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvticket.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvticket.Location = new System.Drawing.Point(29, 113);
            this.dgvticket.Name = "dgvticket";
            this.dgvticket.RowHeadersWidth = 51;
            this.dgvticket.RowTemplate.Height = 24;
            this.dgvticket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvticket.Size = new System.Drawing.Size(927, 398);
            this.dgvticket.TabIndex = 2;
            this.dgvticket.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvticket_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBuy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // tsmiBuy
            // 
            this.tsmiBuy.Name = "tsmiBuy";
            this.tsmiBuy.Size = new System.Drawing.Size(98, 22);
            this.tsmiBuy.Text = "購買";
            this.tsmiBuy.Click += new System.EventHandler(this.tsmiBuy_Click);
            // 
            // TrainID
            // 
            this.TrainID.DataPropertyName = "TrainID";
            this.TrainID.HeaderText = "編號";
            this.TrainID.MinimumWidth = 6;
            this.TrainID.Name = "TrainID";
            this.TrainID.ReadOnly = true;
            // 
            // TrainNo
            // 
            this.TrainNo.DataPropertyName = "TrainNo";
            this.TrainNo.HeaderText = "車次";
            this.TrainNo.MinimumWidth = 6;
            this.TrainNo.Name = "TrainNo";
            this.TrainNo.ReadOnly = true;
            this.TrainNo.Width = 125;
            // 
            // RunTime
            // 
            this.RunTime.DataPropertyName = "RunTime";
            this.RunTime.HeaderText = "出發時間";
            this.RunTime.MinimumWidth = 6;
            this.RunTime.Name = "RunTime";
            this.RunTime.ReadOnly = true;
            this.RunTime.Width = 150;
            // 
            // StartStation
            // 
            this.StartStation.DataPropertyName = "StartStation";
            this.StartStation.HeaderText = "出發地";
            this.StartStation.MinimumWidth = 6;
            this.StartStation.Name = "StartStation";
            this.StartStation.ReadOnly = true;
            this.StartStation.Width = 125;
            // 
            // EndStation
            // 
            this.EndStation.DataPropertyName = "EndStation";
            this.EndStation.HeaderText = "目的地";
            this.EndStation.MinimumWidth = 6;
            this.EndStation.Name = "EndStation";
            this.EndStation.ReadOnly = true;
            this.EndStation.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "票價";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // TicketNumber
            // 
            this.TicketNumber.DataPropertyName = "TicketNumber";
            this.TicketNumber.HeaderText = "剩餘票數";
            this.TicketNumber.MinimumWidth = 6;
            this.TicketNumber.Name = "TicketNumber";
            this.TicketNumber.ReadOnly = true;
            this.TicketNumber.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 542);
            this.Controls.Add(this.dgvticket);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "售票窗口系統";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvticket)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboend;
        private System.Windows.Forms.ComboBox cbostart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvticket;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketNumber;
    }
}

