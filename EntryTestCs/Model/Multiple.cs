﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model
{
    public class Multiple :Calculation
    {
        #region　コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="num">第一数値</param>
        /// <param name="nums">第二数値</param>
        public Multiple(double num, double nums) : base(num,nums) { }
        #endregion

        #region プロパティ
        ///<summary>
        ///答え
        /// </summary>
        public double Ans { get; set; }
        #endregion
        #region メソッド
        /// <summary>
        /// 答えを取得
        /// </summary>
        /// <returns>答え</returns>
        public virtual double GetAns()
        {
            return Ans = Num * Nums;
        }
        #endregion
    }
}
