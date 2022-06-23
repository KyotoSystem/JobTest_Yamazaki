using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntryTestCs.Contller;
using EntryTestCs.Enum;

namespace EntryTestCs
{
    /// <summary>
    /// テスト画面
    /// </summary>
    public partial class TestForm : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TestForm()
        {
            InitializeComponent();
            InitializeTable(this.MultiplicationTableView);
            DispLabel.Text = "0";
            WorkLabel.Text = "";
            btnMmemory.Enabled = false;
            btnMR.Enabled = false;
            btnMC.Enabled = false;
            InitializeSeekTable(this.seekView);

            seekView[12, 12].Value = "●";

            seekView[1, 1].Value = "★";

            

        }

        #region 九九表の実装
        /// <summary>
        /// 九九表セットボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        ///  TODO: ここに九九表を埋める コードを追加します
        ///  例)
        ///  MultiplicationTableView[1, 1].Value = 1;
        ///  MultiplicationTableView[9, 9].Value = 81;
        /// </remarks>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    int x = i * j;
                    MultiplicationTableView[i, j].Value = x;
                }
            }
        }
        #endregion

        #region 電卓の一部機能停止と開始
        public bool flag { get; set; }
        public void Stop()
        {
            //数値
            btnDot.Enabled = false;
            btnSign.Enabled = false;
            //演算子
            btnDivision.Enabled = false;
            btnMultiple.Enabled = false;
            btnAdd.Enabled = false;
            btnSub.Enabled = false;
            //機能
            btnPercent.Enabled = false;
            btnSquare.Enabled = false;
            btnInverse.Enabled = false;
            btnRoot.Enabled = false;
            flag = true;
        }

        public void Start()
        {
            //数値
            btnDot.Enabled = true;
            btnSign.Enabled = true;
            //演算子
            btnDivision.Enabled = true;
            btnMultiple.Enabled = true;
            btnAdd.Enabled = true;
            btnSub.Enabled = true;
            //機能
            btnPercent.Enabled = true;
            btnSquare.Enabled = true;
            btnInverse.Enabled = true;
            btnRoot.Enabled = true;
            flag = false;

        }
        #endregion
        #region 電卓の実装
        ///
        /// TODO: ここに電卓 コードを実装します
        /// ※このregion内にボタンのイベントが集約されてます。
        /// ※別クラスを作成、別ファイルに処理を実装してもかまいません。（自由に実装して下さい）
        /// ※結果はDispLabelとWorkLabelに表示して下さい。
        // 例)
        // WorkLabel.Text = "10×10=";
        // DispLabel.Text = "100";
        ///
        #region 演算ボタン
        public List<string> cal = new List<string> { };
        public string Operation { get; set; }
        public string Num { get; set; }
        /// <summary>
        /// ÷ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text != "")
            {
                cal = new List<string> { };
                WorkLabel.Text = "";
                cal.Add(DispLabel.Text);
                cal.Add(btnDivision.Text);
                WorkLabel.Text += cal[0] + "÷";
                Num = DispLabel.Text;
            }
            Operation = "Operation";
        }
        /// <summary>
        /// ×ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text != "")
            {
                cal = new List<string> { };
                WorkLabel.Text = "";
                cal.Add(DispLabel.Text);
                cal.Add(btnDivision.Text);
                WorkLabel.Text += cal[0] + "×";
                Num = DispLabel.Text;
            }
            Operation = "Operation";
        }
        /// <summary>
        /// －ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text != "")
            {
                cal = new List<string> { };
                WorkLabel.Text = "";
                cal.Add(DispLabel.Text);
                cal.Add(btnSub.Text);
                WorkLabel.Text += cal[0] + "-";
                Num = DispLabel.Text;
            }
            Operation = "Operation";
        }
        /// <summary>
        /// ＋ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text != "")
            {
                cal = new List<string> { };
                WorkLabel.Text = "";
                cal.Add(DispLabel.Text);
                cal.Add(btnAdd.Text);
                WorkLabel.Text += cal[0] + "+";
                Num = DispLabel.Text;
            }
            Operation = "Operation";
        }
        /// <summary>
        /// ＝ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                if (cal.Count != 0)
                {
                    if (cal.Count == 2)
                    {
                        cal.Add(DispLabel.Text);
                    }
                    else
                    {
                        cal[0] = CalculationContller.Ans.ToString();
                    }
                    CalculationContller calculation = new CalculationContller(cal);
                    calculation.GetCalculations();
                    if (cal.Contains("÷"))
                    {
                        if (double.IsInfinity(CalculationContller.Ans))
                        {
                            WorkLabel.Text = cal[0] + cal[1];
                            DispLabel.Text = "0で割り切ることはできません";
                            Stop();
                        }
                        else
                        {
                            WorkLabel.Text = cal[0] + cal[1] + cal[2] + "=";
                            DispLabel.Text = CalculationContller.Ans.ToString();
                            Num = DispLabel.Text;
                        }
                    }
                    else
                    {
                        WorkLabel.Text = cal[0] + cal[1] + cal[2] + "=";
                        DispLabel.Text = CalculationContller.Ans.ToString();
                        Num = DispLabel.Text;
                    }
                    Operation = "Equal";
                }
            }
            else
            {
                Start();
                WorkLabel.Text = "";
                DispLabel.Text = "0";
            }
        }
        #endregion
        #region 数値ボタン
        /// <summary>
        /// ０ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn0_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text != "0")
            {
                if (DispLabel.Text == "0で割り切ることはできません")
                {
                    DispLabel.Text = "";
                }
                if (Num == null)
                {
                    DispLabel.Text += "0";
                    Start();
                }
                else
                {
                    DispLabel.Text = "0";
                    if(Operation == "Equal")
                    {
                        WorkLabel.Text = "";
                    }
                    Num = null;
                }

            }
        }
        /// <summary>
        /// １ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0" || DispLabel.Text == "0で割り切ることはできません")
            {
                DispLabel.Text = "";
            }

            if (Num == null)
            {
                DispLabel.Text += "1";
                Start();
            }
            else
            {
                DispLabel.Text = "1";
                if (Operation == "Equal")
                {
                    WorkLabel.Text = "";
                }
                Num = null;
            }
        }
        /// <summary>
        /// ２ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0" || DispLabel.Text == "0で割り切ることはできません")
            {
                DispLabel.Text = "";
            }
            if (Num == null)
            {
                DispLabel.Text += "2";
                Start();
            }
            else
            {
                DispLabel.Text = "2";
                if (Operation == "Equal")
                {
                    WorkLabel.Text = "";
                }
                Num = null;
            }
        }
        /// <summary>
        /// ３ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0" || DispLabel.Text == "0で割り切ることはできません")
            {
                DispLabel.Text = "";
            }

            if (Num == null)
            {
                DispLabel.Text += "3";
                Start();
            }
            else
            {
                DispLabel.Text = "3";
                if (Operation == "Equal")
                {
                    WorkLabel.Text = "";
                }
                Num = null;
            }
        }
        /// <summary>
        /// ４ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn4_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0" || DispLabel.Text == "0で割り切ることはできません")
            {
                DispLabel.Text = "";
            }

            if (Num == null)
            {
                DispLabel.Text += "4";
                Start();
            }
            else
            {
                DispLabel.Text = "4";
                if (Operation == "Equal")
                {
                    WorkLabel.Text = "";
                }
                Num = null;
            }
        }
        /// <summary>
        /// ５ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn5_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0" || DispLabel.Text == "0で割り切ることはできません")
            {
                DispLabel.Text = "";
            }

            if (Num == null)
            {
                DispLabel.Text += "5";
                Start();
            }
            else
            {
                DispLabel.Text = "5";
                if (Operation == "Equal")
                {
                    WorkLabel.Text = "";
                }
                Num = null;
            }
        }
        /// <summary>
        /// ６ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn6_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0" || DispLabel.Text == "0で割り切ることはできません")
            {
                DispLabel.Text = "";
            }

            if (Num == null)
            {
                DispLabel.Text += "6";
                Start();
            }
            else
            {
                DispLabel.Text = "6";
                if (Operation == "Equal")
                {
                    WorkLabel.Text = "";
                }
                Num = null;
            }
        }
        /// <summary>
        /// ７ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn7_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0" || DispLabel.Text == "0で割り切ることはできません")
            {
                DispLabel.Text = "";
            }

            if (Num == null)
            {
                DispLabel.Text += "7";
                Start();
            }
            else
            {
                DispLabel.Text = "7";
                if (Operation == "Equal")
                {
                    WorkLabel.Text = "";
                }
                Num = null;
            }
        }
        /// <summary>
        /// ８ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn8_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0" || DispLabel.Text == "0で割り切ることはできません")
            {
                DispLabel.Text = "";
            }

            if (Num == null)
            {
                DispLabel.Text += "8";
                Start();
            }
            else
            {
                DispLabel.Text = "8";
                if (Operation == "Equal")
                {
                    WorkLabel.Text = "";
                }
                Num = null;
            }
        }
        /// <summary>
        /// ９ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn9_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0" || DispLabel.Text == "0で割り切ることはできません")
            {
                DispLabel.Text = "";
            }

            if (Num == null)
            {
                DispLabel.Text += "9";
                Start();
            }
            else
            {
                DispLabel.Text = "9";
                if (Operation == "Equal")
                {
                    WorkLabel.Text = "";
                }
                Num = null;
            }
        }
        /// <summary>
        /// ．ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text.Contains("."))
            {
                DispLabel.Text += "";
            }
            else if (DispLabel.Text != "")
            {

                DispLabel.Text += ".";
            }
        }
        /// <summary>
        /// ＋／－ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSign_Click(object sender, EventArgs e)
        {
            double num = double.Parse(DispLabel.Text);
            if (DispLabel.Text != "0")
            {
                if (DispLabel.Text.Contains("-"))
                {
                    double strnum = -num;
                    DispLabel.Text = strnum.ToString();
                }
                else
                {
                    double strnum = -num;
                    DispLabel.Text = strnum.ToString();
                }
            }
        }
        #endregion
        #region 機能ボタン
        /// <summary>
        /// ％ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (CalculationContller.Ans != 0)
            {
                cal = new List<string> { };
                FunctionContller function = new FunctionContller();
                function.Num = DispLabel.Text;
                function.Fun = "％";
                function.GetFunction();
                DispLabel.Text = FunctionContller.FunAns.ToString();
                WorkLabel.Text = DispLabel.Text;
                Num = DispLabel.Text;
            }
            else
            {
                DispLabel.Text = "0";
                WorkLabel.Text = "0";
            }
        }
        /// <summary>
        /// ＜－×ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndo_Click(object sender, EventArgs e)
        {
            cal = new List<string> { };
            DataClearContller dataClear = new DataClearContller();
            dataClear.Ope = Operation;
            if (Operation != "Equal")
            {
                if (Operation == "Operation" || Operation == null)
                {
                    dataClear.Num = DispLabel.Text;
                    dataClear.GetClear();
                    DispLabel.Text = DataClearContller.ClearNum;
                }
            }
            else if(Operation == "Equal")
            {
                WorkLabel.Text = "";
            }
            if(flag == true)
            {
                Start();
                WorkLabel.Text = "";
                DispLabel.Text = "0";
            }

        }
        /// <summary>
        /// １／Ｘボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInverse_Click(object sender, EventArgs e)
        {

            if (DispLabel.Text !="0")
            {
                cal = new List<string> { };
                FunctionContller function = new FunctionContller();
                function.Num = DispLabel.Text;
                function.Fun = "１/X";
                function.GetFunction();
                DispLabel.Text = FunctionContller.FunAns.ToString();
                if (Operation != "Inverse")
                {
                    WorkLabel.Text = "";
                }
                
                WorkLabel.Text = String.Format("１/({0})", function.Num);
                Num = DispLabel.Text;
            }
            else
            {
                DispLabel.Text = "0で割り切ることはできません";
                WorkLabel.Text = "１/(0)";
                Stop();
                
            }
            Operation = "Inverse";
        }
        /// <summary>
        /// Ｘ２ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSquare_Click(object sender, EventArgs e)
        {
            cal = new List<string> { };
            FunctionContller function = new FunctionContller();
            function.Num = DispLabel.Text;
            function.Fun = "X２";
            function.GetFunction();
            DispLabel.Text = FunctionContller.FunAns.ToString();
            if(Operation != "Square")
            {
                WorkLabel.Text = "";
            }
            WorkLabel.Text = "sqr("+ WorkLabel.Text + ")";
            Num = DispLabel.Text;
            Operation = "Square";

        }
        /// <summary>
        /// √xボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoot_Click(object sender, EventArgs e)
        {
            cal = new List<string> { };
            FunctionContller function = new FunctionContller();
            function.Num = DispLabel.Text;
            function.Fun = "√x";
            function.GetFunction();
            DispLabel.Text = FunctionContller.FunAns.ToString();
            if(Operation != "Root")
            {
                WorkLabel.Text = "";
            }
            WorkLabel.Text = "√(" + WorkLabel.Text + ")";
            Num = DispLabel.Text;
            Operation = "Root";
            
        }
        /// <summary>
        /// ＣＥボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCE_Click(object sender, EventArgs e)
        {
            if(Operation == "Operation" || Operation == null)
            {
                DispLabel.Text = "";
            }
            else
            {
                DispLabel.Text = "";
                WorkLabel.Text = "";
            }
            cal = new List<string> { };
            Start();
        }
        /// <summary>
        /// Ｃボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            cal = new List<string> { };
            WorkLabel.Text = "";
            DispLabel.Text = "0";
            Start();
        }
        #endregion
        #region メモリーボタン
        /// <summary>
        /// メモリー保存
        /// </summary>
        public string MemoryNum { get; set; }
        /// <summary>
        /// メモリー計算
        /// </summary>
        public string MemoryNums { get; set; }
        /// <summary>
        /// ＭＣボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMC_Click(object sender, EventArgs e)
        {
            MemoryNum = null;
            MemoryNums = null;
            btnMmemory.Enabled = false;
            btnMR.Enabled = false;
            btnMC.Enabled = false;
        }
        /// <summary>
        /// ＭＲボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMR_Click(object sender, EventArgs e)
        {
            DispLabel.Text = MemoryNum;
            MemoryNums = DispLabel.Text;
        }
        /// <summary>
        /// Ｍ＋ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMplus_Click(object sender, EventArgs e)
        {
            if (MemoryNums == null)
            {
                MemoryNum = DispLabel.Text;
                MemoryNums = DispLabel.Text;
                btnMmemory.Enabled = true;
                btnMR.Enabled = true;
                btnMC.Enabled = true;
            }
            else
            {
                MemoryContller memory = new MemoryContller();
                memory.MNum = MemoryNum;
                memory.MNums = MemoryNums;
                memory.Mstr = "M+";
                memory.GetMemory();
                MemoryNum = MemoryContller.MnumAnswer.ToString();
            }
        }
        /// <summary>
        /// Ｍ－ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMminus_Click(object sender, EventArgs e)
        {
            if (MemoryNums == null)
            {
                MemoryNum = DispLabel.Text;
                MemoryNums = DispLabel.Text;
                btnMmemory.Enabled = true;
                btnMR.Enabled = true;
                btnMC.Enabled = true;
            }
            else
            {
                MemoryContller memory = new MemoryContller();
                memory.MNum = MemoryNum;
                memory.MNums = MemoryNums;
                memory.Mstr = "M-";
                memory.GetMemory();
                MemoryNum = MemoryContller.MnumAnswer.ToString();
            }
        }
        /// <summary>
        /// ＭＳボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMS_Click(object sender, EventArgs e)
        {
            MemoryNum = DispLabel.Text;
            MemoryNums = DispLabel.Text;
            Num = MemoryNum;
            btnMmemory.Enabled = true;
            btnMR.Enabled = true;
            btnMC.Enabled = true;
        }
        /// <summary>
        /// Ｍメモリボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMmemory_Click(object sender, EventArgs e)
        {
            DispLabel.Text = MemoryNum;
            MemoryNums = DispLabel.Text;
            Num = MemoryNum;
        }
        #endregion
        #endregion

        /// <summary>
        /// 九九表の初期化
        /// </summary>
        /// <param name="grid"></param>
	    void InitializeTable(DataGridView grid)
        {
            grid.ColumnCount = 10;
            grid.ColumnHeadersHeight = 48; // 460
            grid.RowHeadersWidth = 62; // 620
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            grid.AllowUserToAddRows = false;
            grid.RowsDefaultCellStyle.SelectionBackColor = Color.White;

            for (int i = 0; i < grid.ColumnCount; i++)
            {
                grid.Rows.Add();
                grid.Rows[i].Height = (i == 0) ? 0 : 48;
                grid.Rows[i].HeaderCell.Value = String.Format("{0:D}", i);
            }
            for (int i = 0; i < grid.ColumnCount; i++)
            {
                grid.Columns[i].Width = (i == 0) ? 0 : 62;
                grid.Columns[i].HeaderText = String.Format("{0:D}", i);
            }
        }

        /// <summary>
        /// 表の初期化
        /// </summary>
        /// <param name="grid"></param>
	    void InitializeSeekTable(DataGridView grid)
        {
            grid.ColumnCount = 25;
            grid.ColumnHeadersHeight = 18; // 460
            grid.RowHeadersWidth = 24; // 620
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            grid.AllowUserToAddRows = false;
            grid.RowsDefaultCellStyle.SelectionBackColor = Color.White;

            for (int i = 0; i < grid.ColumnCount; i++)
            {
                grid.Rows.Add();
                grid.Rows[i].Height = (i == 0) ? 0 : 18;
            }
            for (int i = 0; i < grid.ColumnCount; i++)
            {
                grid.Columns[i].Width = (i == 0) ? 0 : 24;
            }


            seekView[5, 5].Value = "×";
            seekView[6, 5].Value = "×";
            seekView[7, 5].Value = "×";
            seekView[8, 5].Value = "×";
            seekView[9, 5].Value = "×";
            seekView[10, 5].Value = "×";
            seekView[5, 6].Value = "×";
            seekView[5, 7].Value = "×";
            seekView[5, 8].Value = "×";
            seekView[5, 9].Value = "×";
            seekView[5, 10].Value = "×";

            seekView[20, 20].Value = "×";
            seekView[19, 20].Value = "×";
            seekView[20, 19].Value = "×";
            seekView[20, 18].Value = "×";

            seekView[16, 16].Value = "×";
            seekView[17, 16].Value = "×";
            seekView[16, 17].Value = "×";
            seekView[16, 18].Value = "×";

        }

        PlayerContller player = new PlayerContller();

        private void btnUp_Click(object sender, EventArgs e)
        {
            player.GetPlayerMove(PlayerMoveType.Up);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            player.GetPlayerMove(PlayerMoveType.Down);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            player.GetPlayerMove(PlayerMoveType.Right);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            player.GetPlayerMove(PlayerMoveType.Left);
        }
    }
}
