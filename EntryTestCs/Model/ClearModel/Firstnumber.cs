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

        #region メソッド
        /// <summary>
        /// 一文字削除後の数値を取得
        /// </summary>
        /// <returns>第一数値</returns>
        public virtual string GetFum()
        {
            if(Num.Length != 1)
            {
                Fnum = Num.Substring(0, Num.Length - 1);
            }
            else
            {
                Fnum = "0";
            }
            return Fnum;
        }
        #endregion


    }
}
