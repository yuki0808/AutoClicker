namespace AutoClicker
{
  partial class Form1
  {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.execute_b = new System.Windows.Forms.Button();
      this.y_tb = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.x_tb = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Xpoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ypoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.clear_B = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.timer_gb = new System.Windows.Forms.GroupBox();
      this.shcedule_P = new System.Windows.Forms.Panel();
      this.dailyWd_RB = new System.Windows.Forms.RadioButton();
      this.daily_RB = new System.Windows.Forms.RadioButton();
      this.oneTime_RB = new System.Windows.Forms.RadioButton();
      this.date_DTP = new System.Windows.Forms.DateTimePicker();
      this.timer_P = new System.Windows.Forms.Panel();
      this.on_RB = new System.Windows.Forms.RadioButton();
      this.off_RB = new System.Windows.Forms.RadioButton();
      this.label1 = new System.Windows.Forms.Label();
      this.time_TB = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.loop_gb = new System.Windows.Forms.GroupBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.stop_B = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.keyboardHook1 = new HongliangSoft.Utilities.Gui.KeyboardHook();
      this.label3 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.timer_gb.SuspendLayout();
      this.shcedule_P.SuspendLayout();
      this.timer_P.SuspendLayout();
      this.loop_gb.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // execute_b
      // 
      this.execute_b.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.execute_b.Location = new System.Drawing.Point(49, 444);
      this.execute_b.Name = "execute_b";
      this.execute_b.Size = new System.Drawing.Size(70, 23);
      this.execute_b.TabIndex = 1;
      this.execute_b.Text = "実行";
      this.execute_b.UseVisualStyleBackColor = true;
      this.execute_b.Click += new System.EventHandler(this.button1_Click);
      // 
      // y_tb
      // 
      this.y_tb.Location = new System.Drawing.Point(194, 22);
      this.y_tb.Name = "y_tb";
      this.y_tb.ReadOnly = true;
      this.y_tb.Size = new System.Drawing.Size(84, 19);
      this.y_tb.TabIndex = 8;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(160, 25);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(18, 12);
      this.label5.TabIndex = 6;
      this.label5.Text = "Y :";
      // 
      // x_tb
      // 
      this.x_tb.Location = new System.Drawing.Point(63, 22);
      this.x_tb.Name = "x_tb";
      this.x_tb.ReadOnly = true;
      this.x_tb.Size = new System.Drawing.Size(84, 19);
      this.x_tb.TabIndex = 9;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(11, 25);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(18, 12);
      this.label6.TabIndex = 7;
      this.label6.Text = "X :";
      // 
      // dataGridView1
      // 
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xpoint,
            this.Ypoint});
      this.dataGridView1.Location = new System.Drawing.Point(12, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 21;
      this.dataGridView1.Size = new System.Drawing.Size(301, 146);
      this.dataGridView1.TabIndex = 10;
      // 
      // Xpoint
      // 
      this.Xpoint.HeaderText = "X";
      this.Xpoint.Name = "Xpoint";
      // 
      // Ypoint
      // 
      this.Ypoint.HeaderText = "Y";
      this.Ypoint.Name = "Ypoint";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.y_tb);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.x_tb);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Location = new System.Drawing.Point(12, 176);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(300, 50);
      this.groupBox1.TabIndex = 11;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "座標位置";
      // 
      // clear_B
      // 
      this.clear_B.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.clear_B.Location = new System.Drawing.Point(201, 444);
      this.clear_B.Name = "clear_B";
      this.clear_B.Size = new System.Drawing.Size(70, 23);
      this.clear_B.TabIndex = 12;
      this.clear_B.Text = "クリア";
      this.clear_B.UseVisualStyleBackColor = true;
      this.clear_B.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.timer_gb);
      this.groupBox2.Controls.Add(this.loop_gb);
      this.groupBox2.Location = new System.Drawing.Point(13, 232);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(298, 206);
      this.groupBox2.TabIndex = 13;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "オプション";
      // 
      // timer_gb
      // 
      this.timer_gb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.timer_gb.Controls.Add(this.shcedule_P);
      this.timer_gb.Controls.Add(this.date_DTP);
      this.timer_gb.Controls.Add(this.timer_P);
      this.timer_gb.Controls.Add(this.label1);
      this.timer_gb.Controls.Add(this.time_TB);
      this.timer_gb.Controls.Add(this.label2);
      this.timer_gb.Controls.Add(this.label7);
      this.timer_gb.Location = new System.Drawing.Point(15, 62);
      this.timer_gb.Name = "timer_gb";
      this.timer_gb.Size = new System.Drawing.Size(270, 136);
      this.timer_gb.TabIndex = 6;
      this.timer_gb.TabStop = false;
      this.timer_gb.Text = "タイマー";
      // 
      // shcedule_P
      // 
      this.shcedule_P.Controls.Add(this.dailyWd_RB);
      this.shcedule_P.Controls.Add(this.daily_RB);
      this.shcedule_P.Controls.Add(this.oneTime_RB);
      this.shcedule_P.Location = new System.Drawing.Point(28, 42);
      this.shcedule_P.Name = "shcedule_P";
      this.shcedule_P.Size = new System.Drawing.Size(193, 26);
      this.shcedule_P.TabIndex = 8;
      // 
      // dailyWd_RB
      // 
      this.dailyWd_RB.AutoSize = true;
      this.dailyWd_RB.Enabled = false;
      this.dailyWd_RB.Location = new System.Drawing.Point(108, 3);
      this.dailyWd_RB.Name = "dailyWd_RB";
      this.dailyWd_RB.Size = new System.Drawing.Size(79, 16);
      this.dailyWd_RB.TabIndex = 0;
      this.dailyWd_RB.Text = "日時(平日)";
      this.dailyWd_RB.UseVisualStyleBackColor = true;
      // 
      // daily_RB
      // 
      this.daily_RB.AutoSize = true;
      this.daily_RB.Enabled = false;
      this.daily_RB.Location = new System.Drawing.Point(56, 3);
      this.daily_RB.Name = "daily_RB";
      this.daily_RB.Size = new System.Drawing.Size(47, 16);
      this.daily_RB.TabIndex = 0;
      this.daily_RB.Text = "日時";
      this.daily_RB.UseVisualStyleBackColor = true;
      // 
      // oneTime_RB
      // 
      this.oneTime_RB.AutoSize = true;
      this.oneTime_RB.Checked = true;
      this.oneTime_RB.Enabled = false;
      this.oneTime_RB.Location = new System.Drawing.Point(9, 4);
      this.oneTime_RB.Name = "oneTime_RB";
      this.oneTime_RB.Size = new System.Drawing.Size(41, 16);
      this.oneTime_RB.TabIndex = 0;
      this.oneTime_RB.TabStop = true;
      this.oneTime_RB.Text = "1回";
      this.oneTime_RB.UseVisualStyleBackColor = true;
      this.oneTime_RB.CheckedChanged += new System.EventHandler(this.oneTime_RB_CheckedChanged);
      // 
      // date_DTP
      // 
      this.date_DTP.Enabled = false;
      this.date_DTP.Location = new System.Drawing.Point(101, 74);
      this.date_DTP.Name = "date_DTP";
      this.date_DTP.Size = new System.Drawing.Size(138, 19);
      this.date_DTP.TabIndex = 7;
      // 
      // timer_P
      // 
      this.timer_P.Controls.Add(this.on_RB);
      this.timer_P.Controls.Add(this.off_RB);
      this.timer_P.Location = new System.Drawing.Point(28, 12);
      this.timer_P.Name = "timer_P";
      this.timer_P.Size = new System.Drawing.Size(120, 23);
      this.timer_P.TabIndex = 6;
      // 
      // on_RB
      // 
      this.on_RB.AutoSize = true;
      this.on_RB.Location = new System.Drawing.Point(10, 3);
      this.on_RB.Name = "on_RB";
      this.on_RB.Size = new System.Drawing.Size(37, 16);
      this.on_RB.TabIndex = 5;
      this.on_RB.Text = "On";
      this.on_RB.UseVisualStyleBackColor = true;
      this.on_RB.CheckedChanged += new System.EventHandler(this.on_RB_CheckedChanged);
      // 
      // off_RB
      // 
      this.off_RB.AutoSize = true;
      this.off_RB.Checked = true;
      this.off_RB.Location = new System.Drawing.Point(65, 3);
      this.off_RB.Name = "off_RB";
      this.off_RB.Size = new System.Drawing.Size(39, 16);
      this.off_RB.TabIndex = 5;
      this.off_RB.TabStop = true;
      this.off_RB.Text = "Off";
      this.off_RB.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(191, 102);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 12);
      this.label1.TabIndex = 4;
      this.label1.Text = "（hh:mm）";
      // 
      // time_TB
      // 
      this.time_TB.Location = new System.Drawing.Point(101, 99);
      this.time_TB.Name = "time_TB";
      this.time_TB.ReadOnly = true;
      this.time_TB.Size = new System.Drawing.Size(84, 19);
      this.time_TB.TabIndex = 3;
      this.time_TB.Text = "00:00";
      this.time_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.time_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.time_TB_KeyPress);
      this.time_TB.Leave += new System.EventHandler(this.time_TB_Leave);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(36, 79);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 12);
      this.label2.TabIndex = 2;
      this.label2.Text = "日付：";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(36, 102);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(59, 12);
      this.label7.TabIndex = 2;
      this.label7.Text = "起動時間：";
      // 
      // loop_gb
      // 
      this.loop_gb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.loop_gb.Controls.Add(this.textBox1);
      this.loop_gb.Controls.Add(this.label4);
      this.loop_gb.Location = new System.Drawing.Point(15, 18);
      this.loop_gb.Name = "loop_gb";
      this.loop_gb.Size = new System.Drawing.Size(270, 40);
      this.loop_gb.TabIndex = 5;
      this.loop_gb.TabStop = false;
      this.loop_gb.Text = "ループ";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(101, 14);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(84, 19);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "1";
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
      this.textBox1.Leave += new System.EventHandler(this.textBox_Leave);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(191, 18);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(17, 12);
      this.label4.TabIndex = 4;
      this.label4.Text = "回";
      // 
      // timer1
      // 
      this.timer1.Interval = 500;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // stop_B
      // 
      this.stop_B.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.stop_B.Enabled = false;
      this.stop_B.Location = new System.Drawing.Point(125, 444);
      this.stop_B.Name = "stop_B";
      this.stop_B.Size = new System.Drawing.Size(70, 23);
      this.stop_B.TabIndex = 1;
      this.stop_B.Text = "停止";
      this.stop_B.UseVisualStyleBackColor = true;
      this.stop_B.Click += new System.EventHandler(this.stop_B_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
      this.statusStrip1.Location = new System.Drawing.Point(0, 474);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(327, 22);
      this.statusStrip1.TabIndex = 14;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
      // 
      // toolStripStatusLabel2
      // 
      this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
      this.toolStripStatusLabel2.Size = new System.Drawing.Size(312, 17);
      this.toolStripStatusLabel2.Spring = true;
      this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // timer2
      // 
      this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Text = "notifyIcon1";
      this.notifyIcon1.Visible = true;
      this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(20, 20);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 12);
      this.label3.TabIndex = 15;
      this.label3.Text = "label3";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(201, 161);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(110, 12);
      this.label8.TabIndex = 16;
      this.label8.Text = "※[Pause]キーで記録";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(327, 496);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.clear_B);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.stop_B);
      this.Controls.Add(this.execute_b);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "AutoClicker  Ver.1.0.4  by YS";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.timer_gb.ResumeLayout(false);
      this.timer_gb.PerformLayout();
      this.shcedule_P.ResumeLayout(false);
      this.shcedule_P.PerformLayout();
      this.timer_P.ResumeLayout(false);
      this.timer_P.PerformLayout();
      this.loop_gb.ResumeLayout(false);
      this.loop_gb.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button execute_b;
    private System.Windows.Forms.TextBox y_tb;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox x_tb;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Xpoint;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ypoint;
    private System.Windows.Forms.Button clear_B;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox time_TB;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.GroupBox timer_gb;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox loop_gb;
    private System.Windows.Forms.RadioButton off_RB;
    private System.Windows.Forms.RadioButton on_RB;
    private System.Windows.Forms.Panel timer_P;
    private System.Windows.Forms.Button stop_B;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    private System.Windows.Forms.Timer timer2;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
    private HongliangSoft.Utilities.Gui.KeyboardHook keyboardHook1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker date_DTP;
    private System.Windows.Forms.Panel shcedule_P;
    private System.Windows.Forms.RadioButton daily_RB;
    private System.Windows.Forms.RadioButton oneTime_RB;
    private System.Windows.Forms.RadioButton dailyWd_RB;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label8;
  }
}

