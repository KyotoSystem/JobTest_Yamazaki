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
        /// <param name="Mnum">メモリ数値</param>
        public Memory(double mnum)
        {
            MNum = mnum;
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// メモリ数値
        /// </summary>
        public double MNum { get; set; }
        #endregion
    }
}
