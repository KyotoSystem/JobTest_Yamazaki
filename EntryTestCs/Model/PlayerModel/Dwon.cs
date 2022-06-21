using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model.PlayerModel
{
    public class Dwon : Player
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="x">X座標</param>
        /// <param name="y">Y座標</param>
        public Dwon(int x, int y): base(x, y) { }
        #endregion

        #region プロパティ
        /// <summary>
        /// X座標
        /// </summary>
        public int DwonX { get; set; }
        /// <summary>
        /// Y座標
        /// </summary>
        public int DwonY { get; set; }
        #endregion

        #region メソッド
        /// <summary>
        /// X座標を取得
        /// </summary>
        /// <returns>X座標</returns>
        public int GetDwon()
        {
            return DwonX = X--;
        }
        #endregion
    }
}
