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
        /// <param name="mpnum">第一メモリー数値</param>
        /// <param name="mpnums">第二メモリー数値</param>
        public Mplus(double mpnum , double mpnums) : base(mpnum , mpnums) { }
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
            return MpNum = MNum + MNums;
        }
        #endregion
    }
}
