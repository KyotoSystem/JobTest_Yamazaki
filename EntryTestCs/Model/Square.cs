using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model
{
    public class Square : Function
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="num">数値</param>
        public Square(double num) : base(num) { }
        #endregion

        #region プロパティ
        /// <summary>
        /// X２
        /// </summary>
        public double SquareAns { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// X２の答えを取得
        /// </summary>
        /// <returns>X２の答え</returns>
        public virtual double GetSquareAns()
        {
            return SquareAns = Math.Pow(Num, 2);
        }
        #endregion
    }
}
