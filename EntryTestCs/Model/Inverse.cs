using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model
{
    public class Inverse : Function
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="num">数値</param>
        public Inverse(double num) : base(num) { }
        #endregion

        #region プロパティ
        /// <summary>
        /// １/X
        /// </summary>
        public double InverseAns { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// １/Xの答えを取得
        /// </summary>
        /// <returns>１/Xの答え</returns>
        public virtual double GetInverseAns()
        {
            return InverseAns = 1 / Num;
        }
        #endregion

    }
}
