using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model.PlayerModel
{
    class Player
    {
        #region メンバ変数
        /// <summary>
        /// X座標
        /// </summary>
        private int X_Coordinate = 0;
        /// <summary>
        /// Y座標
        /// </summary>
        private int Y_Coordinate = 0;
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
        #endregion

        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="_x">X座標</param>
        /// <param name="_y">Y座標</param>
        public Player(int _x , int _y)
        {
            X_Coordinate = _x;
            Y_Coordinate = _y;
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
        #endregion

    }
}
