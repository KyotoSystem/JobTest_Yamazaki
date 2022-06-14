using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace EntryTestCs.Model.CalculationModel
{
     public  class Calculation
    {
        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="num">第一数値</param>
        /// /// <param name="nums">第二数値</param>
        public Calculation(double num, double nums)
        {
            Num = num;
            Nums = nums;
            
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// 第一数値
        /// </summary>
        public double Num { get; set; }
        /// <summary>
        /// 第二数値
        /// </summary>
        public double Nums { get; set; }
        #endregion


    }
}
