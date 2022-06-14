using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model.ClearModel
{
    public class Firstnumber : Clear
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="fnum">第一数値</param>
        public Firstnumber(string fnum) : base(fnum)
        {
            Fnum = fnum;
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// 第一数値
        /// </summary>
        public string Fnum { get; set; }
        #endregion


    }
}
