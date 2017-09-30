using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using HongliangSoft.Utilities.Gui;

/// Yuki Shimizu
namespace AutoClicker
{
  /// <summary>
  /// 
  /// </summary>
  public partial class Form1 : Form
  {
    private const int WM_ACTIVATEAPP = 0x001C;
    private static KeyboardHook keyHook;

    private const int MOUSEEVENTF_LEFTDOWN = 0x2;
    private const int MOUSEEVENTF_LEFTUP = 0x4;

    private const string BALLOON_TITLE = "AutoClicker";

    private DateTime setDatetime = new DateTime();
    //1:1回だけ　2:日時(平日)　3:日時
    private int scheduleMode = 1;

    private DateTime oneMinBefore = new DateTime();
    private DateTime fiveMinBefore = new DateTime();
    private DateTime thirtySecBefore = new DateTime();
    private DateTime tenSecBefore = new DateTime();

    int x_point = 0;
    int y_point = 0;

    Boolean flg = true;
    Util util = new Util();

    Thread thread = null;

    [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
    static extern void SetCursorPos(int X, int Y);

    [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
    static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

    public Form1()
    {
      InitializeComponent();
      thread = new Thread(new ThreadStart(GetMousePosition));
      thread.Start();
      timer2.Enabled = true;
    }

    /// <summary>
    /// 実行
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button1_Click(object sender, EventArgs e)
    {
      if (checkData())
      {
        if( on_RB.Checked ){
          DateTime now = DateTime.Now;
          string temp = time_TB.Text;

          //setDatetime = new DateTime(now.Year, now.Month, now.Day, util.getHourMin(temp)[0], util.getHourMin(temp)[1], 00);

          setDatetime = new DateTime(date_DTP.Value.Year, date_DTP.Value.Month, date_DTP.Value.Day, util.getHourMin(temp)[0], util.getHourMin(temp)[1], 00);

          oneMinBefore = setDatetime.AddMinutes(-1);
          fiveMinBefore = setDatetime.AddMinutes(-5);
          thirtySecBefore = setDatetime.AddSeconds(-30);
          tenSecBefore = setDatetime.AddSeconds(-10);

          allDisable();
          
          execute_b.Enabled = false;
          stop_B.Enabled = true;
          clear_B.Enabled = false;

          toolStripStatusLabel1.Text = time_TB.Text + " に実行予定です。";

          goToTaskTray();

          timer1.Enabled = true;

        }else if(off_RB.Checked){
          executeMacro();
        }
      }
      else
      {
        MessageBox.Show("正しい値を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    /// <summary>
    /// マクロ実行
    /// </summary>
    private void executeMacro() {
      int loopCount = util.convStrToInt(textBox1.Text);

      for (int loop = 0; loop < loopCount; loop++)
      {
        for (int r = 0; r < dataGridView1.RowCount - 1; r++)
        {
          if (dataGridView1[0, r].Value != null && dataGridView1[1, r].Value != null)
          {
            if (util.chechNumeric((dataGridView1[0, r].Value.ToString())) && util.chechNumeric((dataGridView1[1, r].Value.ToString())))
            {
              this.x_point = util.convStrToInt(dataGridView1[0, r].Value.ToString());
              this.y_point = util.convStrToInt(dataGridView1[1, r].Value.ToString());

              SetCursorPos(x_point, y_point);
              mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
              mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }
          }
        }

        if (loopCount > 1)
        {
          Thread.Sleep(510);
        }
      }

      if (scheduleMode == 1)
      {
        endOfMacro();
        toolStripStatusLabel1.Text = "";
        outToTaskTray();
      }
    }

    private Boolean checkData()
    {
      Boolean result = true;

      for (int r = 0; r < dataGridView1.RowCount - 1; r++)
      {
        if (dataGridView1[0, r].Value != null && dataGridView1[1, r].Value != null)
        {
          if (util.chechNumeric((dataGridView1[0, r].Value.ToString())) && util.chechNumeric((dataGridView1[1, r].Value.ToString())))
          { }
          else
          {
            return false;
          }
        }
        else
        {
          return false;
        }
      }
      return result;
    }

    public void GetMousePosition()
    {
      while (this.flg)
      {
        SetText();
        Thread.Sleep(100);
      }
    }

    public delegate void SetTextDelegate();

    public void SetText()
    {
      try
      {
        if (InvokeRequired)
        {
          Invoke(new SetTextDelegate(SetText));
          return;
        }

        x_tb.Text = Cursor.Position.X.ToString();
        y_tb.Text = Cursor.Position.Y.ToString();

      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }


    /// <summary>
    /// 終了時
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (thread != null)
      {
        this.flg = false;
        thread.Abort();
        thread = null;
      }

      timer1.Enabled = false;
      timer2.Enabled = false;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      keyHook = new KeyboardHook();
      keyHook.KeyboardHooked += new KeyboardHookedEventHandler(keyHookProc);
    }

    private void keyHookProc(object sender, KeyboardHookedEventArgs e)
    {
      if (e.UpDown == KeyboardUpDown.Down)
      {
        string keyCode = e.KeyCode.ToString("d");
        if (keyCode.Equals("19"))
        {
          if (!stop_B.Enabled)
          {
            dataGridView1.Rows.Add(x_tb.Text, y_tb.Text);
          }
        }
      }
    }

    /// <summary>
    /// クリア
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button1_Click_1(object sender, EventArgs e)
    {
      int rowCount = dataGridView1.RowCount;

      textBox1.Text = "1";
      toolStripStatusLabel1.Text = "";

      for (int r = 0; r <= rowCount; r++)
      {
        if (!dataGridView1.Rows[0].IsNewRow)
        {
          dataGridView1.Rows.RemoveAt(0);
        }
      }
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!numericCheck(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private Boolean numericCheck(Char ch) {
      if( (ch < '0' || '9' < ch) && ch != '\b' ){
        return false;
      }
      return true;
    }


    private void time_TB_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!timeCheck(e.KeyChar))
      {
        e.Handled = true;
      }
    }

    private Boolean timeCheck(Char ch)
    {
      if ((ch < '0' || '9' < ch) && ch != ':' && ch != '\b')
      {
        return false;
      }
      return true;
    }


    private void textBox_Leave(object sender, EventArgs e)
    {
      string tbName = ((TextBox)sender).Name.ToString();

      switch (tbName) { 
        case "textBox1":
          //ループ
          if( textBox1.Text.Equals("") || textBox1.Text == null ){
            textBox1.Text = "1";
          }
          break;
      }
    }

    /// <summary>
    /// タイマー1
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void timer1_Tick(object sender, EventArgs e)
    {
      DateTime now = DateTime.Now;

      if (stop_B.Enabled)
      {

        switch (scheduleMode) {
        
          case 1:
            //1回
            if (now.ToLongDateString() == setDatetime.ToLongDateString())
            {
              if (now.ToLongTimeString() == oneMinBefore.ToLongTimeString())
              {
                showBalloonTip(BALLOON_TITLE, "実行1分前です。");
              }
              else if (now.ToLongTimeString() == fiveMinBefore.ToLongTimeString())
              {
                showBalloonTip(BALLOON_TITLE, "実行5分前です。");
              }
              else if (now.ToLongTimeString() == thirtySecBefore.ToLongTimeString())
              {
                showBalloonTip(BALLOON_TITLE, "実行30秒前です。");
              }
              else if (now.ToLongTimeString() == tenSecBefore.ToLongTimeString())
              {
                showBalloonTip(BALLOON_TITLE, "実行10秒前です。");
              }

              if (now.ToLongTimeString() == setDatetime.ToLongTimeString())
              {
                //MessageBox.Show("YAY");
                executeMacro();
              }
            }
            break;
          case 2:
            //日時
            if (now.ToLongTimeString() == oneMinBefore.ToLongTimeString())
            {
              showBalloonTip(BALLOON_TITLE, "実行1分前です。");
            }
            else if (now.ToLongTimeString() == fiveMinBefore.ToLongTimeString())
            {
              showBalloonTip(BALLOON_TITLE, "実行5分前です。");
            }
            else if (now.ToLongTimeString() == thirtySecBefore.ToLongTimeString())
            {
              showBalloonTip(BALLOON_TITLE, "実行30秒前です。");
            }
            else if (now.ToLongTimeString() == tenSecBefore.ToLongTimeString())
            {
              showBalloonTip(BALLOON_TITLE, "実行10秒前です。");
            }

            if (now.ToLongTimeString() == setDatetime.ToLongTimeString())
            {
              //MessageBox.Show("YAY");
              executeMacro();
            }

            break;
          case 3:
            //日時(平日)
            if ((int)now.DayOfWeek > 0 && (int)now.DayOfWeek < 7)
            {
              if (now.ToLongTimeString() == oneMinBefore.ToLongTimeString())
              {
                showBalloonTip(BALLOON_TITLE, "実行1分前です。");
              }
              else if (now.ToLongTimeString() == fiveMinBefore.ToLongTimeString())
              {
                showBalloonTip(BALLOON_TITLE, "実行5分前です。");
              }
              else if (now.ToLongTimeString() == thirtySecBefore.ToLongTimeString())
              {
                showBalloonTip(BALLOON_TITLE, "実行30秒前です。");
              }
              else if (now.ToLongTimeString() == tenSecBefore.ToLongTimeString())
              {
                showBalloonTip(BALLOON_TITLE, "実行10秒前です。");
              }

              if (now.ToLongTimeString() == setDatetime.ToLongTimeString())
              {
                executeMacro();
              }
            }
            break;
        
        }
      }
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
      toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
    }

    private void on_RB_CheckedChanged(object sender, EventArgs e)
    {
      foreach (RadioButton rb in timer_P.Controls)
      {
        if(rb.Checked){
          if (rb.Text.Equals("On")) {
            time_TB.ReadOnly = false;
            date_DTP.Enabled = true;
            oneTime_RB.Enabled = true;
            daily_RB.Enabled = true;
            dailyWd_RB.Enabled = true;
          }
          else if (rb.Text.Equals("Off"))
          {
            time_TB.ReadOnly = true;
            date_DTP.Enabled = false;
            oneTime_RB.Enabled = true;
            daily_RB.Enabled = true;
            dailyWd_RB.Enabled = true;
          }
        }
      }
    }

    private void time_TB_Leave(object sender, EventArgs e)
    {
      if (!time_TB.Text.Equals(""))
      {
        if (!util.checkTimeFormat(time_TB.Text))
        {
          MessageBox.Show("正しいフォーマットで入力してください。[HH:MM]", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
          time_TB.Text = "00:00";
        }
      }
      else {
        time_TB.Text = "00:00";
      }
    }

    private void allDisable() {
      dataGridView1.Enabled = false;
      textBox1.Enabled = false;
      off_RB.Enabled = false;
      on_RB.Enabled = false;
      time_TB.Enabled = false;
      date_DTP.Enabled =false;
      oneTime_RB.Enabled = false;
      daily_RB.Enabled = false;
      dailyWd_RB.Enabled = false;
    }

    private void allEnable()
    {
      dataGridView1.Enabled = true;
      textBox1.Enabled = true;
      off_RB.Enabled = true;
      on_RB.Enabled = true;
      time_TB.Enabled = true;
      date_DTP.Enabled = true;
      oneTime_RB.Enabled = true;
      daily_RB.Enabled = true;
      dailyWd_RB.Enabled = true;
    }

    /// <summary>
    /// 停止ボタン
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void stop_B_Click(object sender, EventArgs e)
    {
      endOfMacro();
    }

    private void endOfMacro() {
      allEnable();
      execute_b.Enabled = true;
      stop_B.Enabled = false;
      clear_B.Enabled = true;
      timer1.Enabled = false;
      toolStripStatusLabel1.Text = "";
    }

    private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      outToTaskTray();    
    }

    private void Form1_SizeChanged(object sender, EventArgs e)
    {
      if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
      {
        goToTaskTray();
      }   
    }

    private void outToTaskTray() {
      // フォームを表示する  
      this.Visible = true;
      // 現在の状態が最小化の状態であれば通常の状態に戻す  
      if (this.WindowState == FormWindowState.Minimized)
      {
        this.WindowState = FormWindowState.Normal;
      }
      // フォームをアクティブにする  
      this.Activate();  
    }

    private void goToTaskTray()
    {
      // フォームが最小化の状態であればフォームを非表示にする  
      this.Hide();
      this.WindowState = FormWindowState.Normal;
      // トレイリストのアイコンを表示する  
      notifyIcon1.Visible = true;
    }

    private void showBalloonTip(string title, string message) {
        this.notifyIcon1.BalloonTipTitle = title;
        this.notifyIcon1.BalloonTipText = message;
        this.notifyIcon1.ShowBalloonTip(5000);
    }

    private void oneTime_RB_CheckedChanged(object sender, EventArgs e)
    {
      foreach (RadioButton rb in shcedule_P.Controls)
      {
        if (rb.Checked)
        {
          if (rb.Text.Equals("1回"))
          {
            date_DTP.Enabled = true;
            scheduleMode = 1;
          }
          else if (rb.Text.Equals("日時"))
          {
            date_DTP.Enabled = false;
            scheduleMode = 2;
          }
          else if (rb.Text.Equals("日時(平日)"))
          {
            date_DTP.Enabled = false;
            scheduleMode = 3;
          }
        }
      }
    }
  }
}
