using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model.ClearModel
{
    public class Secondnumber : Clear
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="snum">第二数値</param>
        public Secondnumber(string snum) : base(snum)
        {
            Snum = snum;
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// 第二数値
        /// </summary>
        public string Snum { get; set; }
        #endregion
    }
}
