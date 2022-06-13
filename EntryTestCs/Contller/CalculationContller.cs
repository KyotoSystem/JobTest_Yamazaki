using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntryTestCs.Model;
namespace EntryTestCs.Contller
{
    public class CalculationContller
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="cal">計算式</param>
        public  CalculationContller(List<string> cal)
        {
            Cal =cal;
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// 計算式
        /// </summary>
        public   List<string> Cal { get; set; }
        /// <summary>
        /// 答え
        /// </summary>
        public static double Ans { get; set; }

        #endregion

        #region メソッド
        public  Calculation GetCalculations()
        {
            Calculation calculation = null;
            double num = 0;
            double nums = 0;
            double ans = 0;
            num = double.Parse(Cal[0]);
            nums = double.Parse(Cal[2]);
            calculation =  OperationType(num, nums);
            ans = Ans;
            return calculation;
            

        }
        /// <summary>
        /// インスタンスを作成
        /// </summary>
        /// <param name="num">第一数値</param>
        /// <param name="nums">第二数値</param>
        /// <returns></returns>
        private  Calculation OperationType(double num , double nums)
        {
            Calculation calculation = null;
            switch (Cal[1])
            {
                case "÷":
                    calculation = new Division(num,nums);
                    break;
                case "×":
                    calculation = new Multiple(num, nums);
                    break;
                case "＋":
                    calculation = new Add(num, nums);
                    break;
                case "－":
                    calculation = new Sub(num, nums);
                    break;
            }
            GetAnswer(calculation);
            return calculation;

        }
        /// <summary>
        /// 和差積商の答えを取得
        /// </summary>
        /// <param name="calculation">計算</param>
         public static void GetAnswer(Calculation calculation)
        {
            //割り算の場合
            if(calculation is Division division)
            {
                GetAnswer(division);
            }
            //掛け算の場合
            else if (calculation is Multiple multiple)
            {
                GetAnswer(multiple);
            }
            //足し算の場合
            else if (calculation is Add add)
            {
                GetAnswer(add);
            }
            //引き算の場合
            else if (calculation is Sub sub)
            {
                GetAnswer(sub);
            }
        }
        /// <summary>
        /// 商の答えを取得
        /// </summary>
        /// <param name="division">割り算</param>
        public static void GetAnswer(Division division)
        {
            division.GetAns();
            Ans = division.Ans;
        }
        /// <summary>
        /// 積の答えを取得
        /// </summary>
        /// <param name="multiple">掛け算</param>
        public static void GetAnswer(Multiple multiple)
        {
            multiple.GetAns();
            Ans = multiple.Ans;
        }
        /// <summary>
        /// 和の答えを取得
        /// </summary>
        /// <param name="add">足し算</param>
        public static void GetAnswer(Add add)
        {
            add.GetAns();
            Ans = add.Ans;
        }
        /// <summary>
        /// 差の答えを取得
        /// </summary>
        /// <param name="sub">引き算</param>
        public static void GetAnswer(Sub sub)
        {
            sub.GetAns();
            Ans = sub.Ans;
        }

        #endregion
    }
}
