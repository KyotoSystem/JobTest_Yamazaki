﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model.PlayerModel
{
    public class Left : Player
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="x">X座標</param>
        /// <param name="y">Y座標</param>
        public Left(int x, int y) : base(x, y) { }
        #endregion

        #region プロパティ
        /// <summary>
        /// X座標
        /// </summary>
        public int LeftX { get; set; }
        /// <summary>
        /// Y座標
        /// </summary>
        public int LeftY { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// Y座標を取得
        /// </summary>
        /// <returns>Y座標</returns>
        public int GetLeft()
        {
            return LeftY = Y++;
        }
        #endregion

    }
}
