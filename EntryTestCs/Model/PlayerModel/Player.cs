using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntryTestCs.Enum;

namespace EntryTestCs.Model.PlayerModel
{
    class Player
    {
        #region Enum定数
        /// <summary>
        /// 移動文字列を取得
        /// </summary>
        /// <param name="movetype"></param>
        /// <returns></returns>
        public string GetMoveType(PlayerMoveType movetype)
        {
            string[] move = {"","↑","↓","→","←" };

            return move[(int)movetype];
        }
        #endregion

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

        #endregion

    }
}
