﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntryTestCs.Enum;

namespace EntryTestCs.Model.PlayerModel
{
    class Player
    {
        #region メンバ変数
        /// <summary>
        /// X座標
        /// </summary>
        private int X_Coordinate = 12;
        /// <summary>
        /// Y座標
        /// </summary>
        private int Y_Coordinate = 12;
        /// <summary>
        /// 削除X座標
        /// </summary>
        private int X_Clear = 12;
        /// <summary>
        /// 削除Y座標
        /// </summary>
        private int Y_Clear = 12;

        #endregion

        #region プロパティ
        /// <summary>
        /// X座標
        /// </summary>
        public int _X { set { X_Coordinate = value; } get { return X_Coordinate; } }
        /// <summary>
        /// Y座標
        /// </summary>
        public int _Y { set { Y_Coordinate = value; } get { return Y_Coordinate; } }
        /// <summary>
        /// 削除X座標
        /// </summary>
        public int _XClear { set { X_Clear = value; } }
        /// <summary>
        /// 削除Y座標
        /// </summary>
        public int _YClear { set { Y_Clear = value; } }
        #endregion

        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="_x">X座標</param>
        /// <param name="_y">Y座標</param>
        public Player(int _x , int _y, int _xclear , int _yclear)
        {
            X_Coordinate = _x;
            Y_Coordinate = _y;
            X_Clear = _xclear;
            Y_Clear = _yclear;
        }
        #endregion

        #region メソッド
        /// <summary>
        /// X座標を取得
        /// </summary>
        /// <returns>X座標</returns>
        public int GetX_Coordinate()
        {
            return X_Coordinate;
        }

        /// <summary>
        /// Y座標を取得
        /// </summary>
        /// <returns>Y座標</returns>
        public int GetY_Coordinate()
        {
            return Y_Coordinate;
        }

        /// <summary>
        /// 削除するX座標を取得
        /// </summary>
        /// <returns>X座標</returns>
        public int GetX_Clear()
        {
            return X_Clear;
        }

        /// <summary>
        /// 削除するY座標を取得
        /// </summary>
        /// <returns>Y座標</returns>
        public int GetY_Cleare()
        {
            return Y_Clear;
        }
        #endregion

    }
}
