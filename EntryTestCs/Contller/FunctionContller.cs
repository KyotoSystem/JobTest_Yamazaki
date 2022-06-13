using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntryTestCs.Model;

namespace EntryTestCs.Contller
{
    class FunctionContller
    {

        #region プロパティ
        /// <summary>
        /// 数値
        /// </summary>
        public string Num { get; set; }
        /// <summary>
        /// 機能
        /// </summary>
        public string Fun { get; set; }

        /// <summary>
        /// 答え
        /// </summary>
        public static double FunAns { get; set; }
        #endregion

        #region メソッド
        public Function GetFunction()
        {
            Function function = null;
            double num = 0;
            num = double.Parse(Num);
            function = FunctionType(num);
            return function;
        }
        /// <summary>
        /// 機能インスタンス作成
        /// </summary>
        /// <param name="num">数値</param>
        /// <returns></returns>
        private Function FunctionType(double num)
        {
            Function function = null;
            switch (Fun)
            {
                case "％":
                    function = new Percent(num);
                    break;
                case "１/X":
                    function = new Inverse(num);
                    break;
                case "X２":
                    function = new Square(num);
                    break;
                case "√x":
                    function = new Root(num);
                    break;
            }
            GetFunctionAnswer(function);
            return function;
        }
        /// <summary>
        /// 各種機能の答えを取得
        /// </summary>
        /// <param name="function">機能</param>
        public static void GetFunctionAnswer(Function function)
        {
            //％の場合
            if(function is Percent percent)
            {
                GetPercentAnswer(percent);
                
            }
            //１/Xの場合
            else if(function is Inverse inverse)
            {
                GetInverseAnswer(inverse);

            }
            //X２の場合
            else if(function is Square square)
            {
                GetSquareAnswer(square);

            }
            //√xの場合
            else if(function is Root root)
            {
                GetRootAnswer(root);
            }
        }

        /// <summary>
        /// ％の答えを取得
        /// </summary>
        /// <param name="percent">％</param>
        public static void GetPercentAnswer(Percent percent)
        {
            percent.GetPercentAns();
            FunAns = percent.PercentAns;
        }
        /// <summary>
        /// １/Xの答えを取得
        /// </summary>
        /// <param name="inverse">１/X</param>
        public static void GetInverseAnswer(Inverse inverse)
        {
            inverse.GetInverseAns();
            FunAns = inverse.InverseAns;
        }
        /// <summary>
        /// X２の答えを取得
        /// </summary>
        /// <param name="square">X２</param>
        public static void GetSquareAnswer(Square square)
        {
            square.GetSquareAns();
            FunAns = square.SquareAns;
        }
        /// <summary>
        /// √xの答えを取得
        /// </summary>
        /// <param name="root">√x</param>
        public static void GetRootAnswer(Root root)
        {
            root.GetRootAns();
            FunAns = root.RootAns;
        }
        #endregion
    }
}
