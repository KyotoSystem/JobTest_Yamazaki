using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model.MemoryModel
{
    public class Mplus : Memory
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="mpnum">メモリー数値</param>
        public Mplus(double mpnum) : base(mpnum) { }
　　　　#endregion

        #region プロパティ
        /// <summary>
        /// メモリー数値(和)
        /// </summary>
        public double MpNum { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// メモリー数値(和)の取得
        /// </summary>
        /// <returns>メモリー数値(和)</returns>
        public virtual double GetMpNum()
        {
            return MpNum = MNum + MNum;
        }
        #endregion
    }
}
