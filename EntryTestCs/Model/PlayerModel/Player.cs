using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model.PlayerModel
{
    public class Player
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="x">X座標</param>
        /// <param name="y">Y座標</param>
        public Player(int x , int y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// X座標
        /// </summary>
    　　public int X { get; set; }
        /// <summary>
        /// Y座標
        /// </summary>
        public int Y { get; set; }
        #endregion
    }
}
