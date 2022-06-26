using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntryTestCs.Model.PlayerModel;
using EntryTestCs.Model.EnemyModel;
using EntryTestCs.Enum;

namespace EntryTestCs.Contller
{
    /// <summary>
    /// 操作者座標更新デリゲート
    /// </summary>
    class SetPlayerLocalDelegate : EventArgs
    {
        private readonly Player _PlayerData;
        public Player Player { get { return _PlayerData; } }

        public SetPlayerLocalDelegate(Player player)
        {
            _PlayerData = player;
        }
    }


    /// <summary>
    /// 敵座標更新デリゲート
    /// </summary>
    class EnemyLocalDelegate : EventArgs
    {
        private readonly Enemy _EnemyData;
        public Enemy Enemy { get { return _EnemyData; } }

        public EnemyLocalDelegate(Enemy enemy)
        {
            _EnemyData = enemy;
        }
    }

    class SeekContller
    {
        #region デリゲート、イベント関連
        /// <summary>
        /// 操作者座標更新イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="player"></param>
        public delegate void SetPlayerLocalDelegate(object sender, Player player);
        /// <summary>
        /// 操作者座標更新イベント
        /// </summary>
        public event SetPlayerLocalDelegate Set_PlayerLocal = null;
        /// <summary>
        /// 敵座標更新イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="enemy"></param>
        public delegate void EnemyLocalDelegate(object sender, Enemy enemy);
        /// <summary>
        /// 敵座標更新イベント
        /// </summary>
        public event EnemyLocalDelegate Set_EnemyLocal = null;
        #endregion

        #region メンバ変数
        /// <summary>
        /// 最大X座標
        /// </summary>
        private int Max_X_Coordinate;
        /// <summary>
        /// 最大Y座標
        /// </summary>
        private int Max_Y_Coordinate;
        /// <summary>
        /// 最小X座標
        /// </summary>
        private int Min_X_Coordinate;
        /// <summary>
        /// 最小Y座標
        /// </summary>
        private int Min_Y_Coordinate;

        /// <summary>
        /// プレイヤーのX座標
        /// </summary>
        private int _PlayerX;

        /// <summary>
        /// プレイヤーのY座標
        /// </summary>
        private int _PlayerY;

        /// <summary>
        /// エネミーのX座標
        /// </summary>
        private int _EnemyX;

        /// <summary>
        /// エネミーのY座標
        /// </summary>
        private int _EnemyY;

        /// <summary>
        /// プレイヤー操作データ
        /// </summary>
        private Player _PlayerData;

        /// <summary>
        /// エネミーデータ
        /// </summary>
        private Enemy _EnemyData;
        #endregion

        #region　コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        public SeekContller()
        {
            InitialPosition();
        }
        #endregion

        #region メソッド
        /// <summary>
        /// 初期位置
        /// </summary>
        public void InitialPosition()
        {
            _PlayerData = new Player(12, 12, 12, 12);
            _EnemyData = new Enemy(1, 1 , 1, 1);
            Max_X_Coordinate = 23;
            Max_Y_Coordinate = 23;
            Min_X_Coordinate = 2;
            Min_Y_Coordinate = 2;
            _PlayerX = 12;
            _PlayerY = 12;
            _EnemyX = 1;
            _EnemyY = 1;

            if (Set_PlayerLocal != null)
            {
                Set_PlayerLocal(this, _PlayerData);
            }
            if (Set_EnemyLocal != null)
            {
                Set_EnemyLocal(this, _EnemyData);
            }
        }

        /// <summary>
        /// 操作情報取得
        /// </summary>
        /// <param name="movetype"></param>
        public void GetPlayerMove(PlayerMoveType movetype)
        {
            switch (movetype)
            {
                case PlayerMoveType.Up:
                    if (_PlayerData._Y >= Min_Y_Coordinate)
                    {
                        _PlayerData._Y--;
                        
                    }
                    else
                    {
                        _PlayerData._Y = 24;
                       
                    }
                    GetPlayerClear(PlayerMoveType.Up);
                    break;
                case PlayerMoveType.Down:
                    if (_PlayerData._Y <= Max_Y_Coordinate)
                    {
                        _PlayerData._Y++;
                        
                    }
                    else
                    {
                        _PlayerData._Y = 1;
                        
                    }
                    GetPlayerClear(PlayerMoveType.Down);
                    break;
                case PlayerMoveType.Right:
                    if (_PlayerData._X <= Max_X_Coordinate)
                    {
                        _PlayerData._X++;
                    }
                    else
                    {
                        _PlayerData._X = 1;
                    }
                    GetPlayerClear(PlayerMoveType.Right);
                    break;
                case PlayerMoveType.Left:
                    if (_PlayerData._X >= Min_X_Coordinate)
                    {
                        _PlayerData._X--;
                    }
                    else
                    {
                        _PlayerData._X = 24;
                    }
                    GetPlayerClear(PlayerMoveType.Left);
                    break;
            }

            if (Set_PlayerLocal != null)
            {
                Set_PlayerLocal(this, _PlayerData);
            }
        }
        /// <summary>
        /// 削除する操作情報
        /// </summary>
        /// <param name="movetype"></param>
        public void GetPlayerClear(PlayerMoveType movetype)
        {
            switch (movetype)
            {
                case PlayerMoveType.Up:
                    if (_PlayerY >= Min_Y_Coordinate)
                    {
                        _PlayerData._YClear = _PlayerY--;
                        _PlayerX = _PlayerData._X;
                        _PlayerData._XClear = _PlayerX;
                        
                        
                    }
                    else
                    {   _PlayerData._YClear = _PlayerY--;
                        _PlayerX = _PlayerData._X;
                        _PlayerData._XClear = _PlayerX;
                        _PlayerY = 24;
                    }
                    break;
                case PlayerMoveType.Down:
                    if (_PlayerY <= Max_Y_Coordinate)
                    {
                        _PlayerData._YClear = _PlayerY++;
                        _PlayerX = _PlayerData._X;
                        _PlayerData._XClear = _PlayerX;
                    }
                    else
                    {
                        _PlayerData._YClear = _PlayerY++;
                        _PlayerX = _PlayerData._X;
                        _PlayerData._XClear = _PlayerX;
                        _PlayerY = 1;
                    }
                    break;
                case PlayerMoveType.Right:
                    if (_PlayerX <= Max_X_Coordinate)
                    {
                        _PlayerData._XClear = _PlayerX++;
                        _PlayerY = _PlayerData._Y;
                        _PlayerData._YClear = _PlayerY;
                    }
                    else
                    {
                        _PlayerData._XClear = _PlayerX++;
                        _PlayerY = _PlayerData._Y;
                        _PlayerData._YClear = _PlayerY;
                        _PlayerX = 1;
                    }
                    break;
                case PlayerMoveType.Left:
                    if (_PlayerX >= Min_X_Coordinate)
                    {
                        _PlayerData._XClear = _PlayerX--;
                        _PlayerY = _PlayerData._Y;
                        _PlayerData._YClear = _PlayerY;
                    }
                    else
                    {
                        _PlayerData._XClear = _PlayerX--;
                        _PlayerY = _PlayerData._Y;
                        _PlayerData._YClear = _PlayerY;
                        _PlayerX = 24;
                    }
                    break;
            }
            #endregion
        }
    }
}
