using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntryTestCs.Model.PlayerModel;
using EntryTestCs.Enum;

namespace EntryTestCs.Contller
{

    class PlayerContller
    {
        #region デリゲート、イベント関連
        public delegate void LocalDelegate(object sender, Player player);
        public event LocalDelegate _Local = null;
        #endregion

        #region メンバ変数
        /// <summary>
        /// X座標
        /// </summary>
        public int _X_Coordinate = 0;

        /// <summary>
        /// Y座標
        /// </summary>
        public int _Y_Coordinate = 0;

        /// <summary>
        /// 現在地
        /// </summary>
        public List<int> C_local;

        /// <summary>
        /// Player操作データ
        /// </summary>
        public Player _PlayerData;
        #endregion

        #region メソッド

        /// <summary>
        /// 現在座標の取得
        /// </summary>
        /// <param name="local">現在地</param>
        public void GetPlayerlocal(List<int> local)
        {
            C_local = local;
        }

        /// <summary>
        /// 操作情報取得
        /// </summary>
        /// <param name="movetype"></param>
    　　public  void GetPlayerMove(PlayerMoveType movetype)
        {
            
            switch (movetype)
            {
                case PlayerMoveType.Up:
                    _PlayerData._Y = _Y_Coordinate++;
                    break;
                case PlayerMoveType.Down:
                    _PlayerData._Y = _Y_Coordinate--;
                    break;
                case PlayerMoveType.Right:
                    _PlayerData._X = _X_Coordinate--;
                    break;
                case PlayerMoveType.Left:
                    _PlayerData._X = _X_Coordinate++;
                    break;
            }
        }
        #endregion
    }
}
