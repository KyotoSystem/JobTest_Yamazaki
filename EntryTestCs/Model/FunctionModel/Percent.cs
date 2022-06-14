using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model.FunctionModel
{
    public class Percent :Function
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="num">数値</param>
        public Percent(double num) : base(num) { }
        #endregion

        #region プロパティ
        /// <summary>
        /// %
        /// </summary>
        public double PercentAns { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// %の答えを取得
        /// </summary>
        /// <returns>%の答え</returns>
        public virtual double GetPercentAns()
        {
            return PercentAns = Num / 100;
        }
        #endregion
    }
}
