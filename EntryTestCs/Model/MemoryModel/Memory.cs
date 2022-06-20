using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model.MemoryModel
{
    public class Memory
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="mnum">第一メモリ数値</param>
        /// <param name="mnums">第二メモリ数値</param>
        public Memory(double mnum , double mnums)
        {
            MNum = mnum;
            MNums = mnums;
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// 第一メモリ数値
        /// </summary>
        public double MNum { get; set; }
        /// <summary>
        /// 第二メモリ数値
        /// </summary>
        public double MNums { get; set; }
        #endregion
    }
}
