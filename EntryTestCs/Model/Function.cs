using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model
{
    public class Function
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="num">数値</param>
        public Function(double num)
        {
            Num = num;
           
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// 数値
        /// </summary>
        public double Num { get; set; }
        #endregion
    }
}
