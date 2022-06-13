using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntryTestCs.Contller;

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
            }

            DispLabel.Text = "";

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
                cal.Add(btnMultiple.Text);
                WorkLabel.Text += cal[0] + "×";
            }

            DispLabel.Text = "";
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
                WorkLabel.Text += cal[0] + "－";
            }

            DispLabel.Text = "";
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
                WorkLabel.Text += cal[0] + "＋";
            }

            DispLabel.Text = "";
        }
        /// <summary>
        /// ＝ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (cal.Count == 2)
            {
                cal.Add(DispLabel.Text);
                WorkLabel.Text = cal[0] + cal[1] + cal[2] + "=";
            }
            else
            {
                cal[0] = CalculationContller.Ans.ToString();
                WorkLabel.Text = cal[0] + cal[1] + cal[2] + "=";
            }

            CalculationContller calculation = new CalculationContller(cal);
            calculation.GetCalculations();
            DispLabel.Text = CalculationContller.Ans.ToString();


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
                DispLabel.Text += "0";
            }
        }
        /// <summary>
        /// １ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0")
            {
                DispLabel.Text = "";
            }
            DispLabel.Text += "1";
        }
        /// <summary>
        /// ２ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0")
            {
                DispLabel.Text = "";
            }
            DispLabel.Text += "2";
        }
        /// <summary>
        /// ３ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0")
            {
                DispLabel.Text = "";
            }

            DispLabel.Text += "3";
        }
        /// <summary>
        /// ４ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn4_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0")
            {
                DispLabel.Text = "";
            }

            DispLabel.Text += "4";
        }
        /// <summary>
        /// ５ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn5_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0")
            {
                DispLabel.Text = "";
            }

            DispLabel.Text += "5";
        }
        /// <summary>
        /// ６ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn6_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0")
            {
                DispLabel.Text = "";
            }

            DispLabel.Text += "6";
        }
        /// <summary>
        /// ７ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn7_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0")
            {
                DispLabel.Text = "";
            }

            DispLabel.Text += "7";
        }
        /// <summary>
        /// ８ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn8_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0")
            {
                DispLabel.Text = "";
            }

            DispLabel.Text += "8";
        }
        /// <summary>
        /// ９ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn9_Click(object sender, EventArgs e)
        {
            if (DispLabel.Text == "0")
            {
                DispLabel.Text = "";
            }

            DispLabel.Text += "9";
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
                FunctionContller function = new FunctionContller();
                function.Num = DispLabel.Text;
                function.Fun = "％";
                function.GetFunction();
                DispLabel.Text = FunctionContller.FunAns.ToString();
                WorkLabel.Text = DispLabel.Text;
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
                FunctionContller function = new FunctionContller();
                function.Num = DispLabel.Text;
                function.Fun = "１/X";
                function.GetFunction();
                DispLabel.Text = FunctionContller.FunAns.ToString();
                WorkLabel.Text = String.Format("１/({0})", function.Num);
            }
            else
            {
                DispLabel.Text = "0で割り切ることはできません";
                WorkLabel.Text = "１/(0)";
                
            }
        }
        /// <summary>
        /// Ｘ２ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSquare_Click(object sender, EventArgs e)
        {
            FunctionContller function = new FunctionContller();
            function.Num = DispLabel.Text;
            function.Fun = "X２";
            function.GetFunction();
            DispLabel.Text = FunctionContller.FunAns.ToString();
            WorkLabel.Text = String.Format("sqr({0})", function.Num);
        }
        /// <summary>
        /// √xボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoot_Click(object sender, EventArgs e)
        {
            FunctionContller function = new FunctionContller();
            function.Num = DispLabel.Text;
            function.Fun = "√x";
            function.GetFunction();
            DispLabel.Text = FunctionContller.FunAns.ToString();
            WorkLabel.Text = String.Format("√({0})", function.Num);
        }
        /// <summary>
        /// ＣＥボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCE_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Ｃボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region メモリーボタン
        /// <summary>
        /// ＭＣボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMC_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ＭＲボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMR_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Ｍ＋ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMplus_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Ｍ－ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMminus_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ＭＳボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMS_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Ｍメモリボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMmemory_Click(object sender, EventArgs e)
        {

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
    }
}
