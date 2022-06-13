using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model
{
    public class Root : Function
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="num">数値</param>
        public Root(double num) : base(num) { }
        #endregion

        #region プロパティ
        /// <summary>
        /// √x
        /// </summary>
        public double RootAns { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// √xの答えを取得
        /// </summary>
        /// <returns>√xの答え</returns>
        public virtual double GetRootAns()
        {
            return RootAns = Math.Sqrt(Num);
        }
        #endregion
    }
}
