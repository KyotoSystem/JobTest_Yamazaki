using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model.MemoryModel
{
    public class Mminus : Memory
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="mmnum">第一メモリー数値</param>
        /// <param name="mmnums">第二メモリー数値</param>
        public Mminus(double mmnum , double mmnums ) : base(mmnum , mmnums) { }
        #endregion

        #region プロパティ
        /// <summary>
        /// メモリー数値(差)
        /// </summary>
        public double MmNum { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// メモリー数値(差)の取得
        /// </summary>
        /// <returns>メモリー数値(差)</returns>
        public virtual double GetMmNum()
        {
            return MmNum = MNum - MNums;
        }
        #endregion
    }
}
