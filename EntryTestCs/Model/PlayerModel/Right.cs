using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model.PlayerModel
{
    public class Right : Player
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="x">X座標</param>
        /// <param name="y">Y座標</param>
        public Right(int x , int y) : base(x, y) { }
        #endregion

        #region プロパティ
        /// <summary>
        /// X座標
        /// </summary>
        public int RightX { get; set; }
        /// <summary>
        /// Y座標
        /// </summary>
        public int RightY { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// Y座標を取得
        /// </summary>
        /// <returns>Y座標</returns>
        public int GetRight()
        {
            return RightY = Y--;
        }
        #endregion
    }
}
