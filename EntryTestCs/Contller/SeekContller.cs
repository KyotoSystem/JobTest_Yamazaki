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
        /// プレイヤの現在地
        /// </summary>
        private List<int>_PLocal;

        /// <summary>
        /// エネミーの現在地
        /// </summary>
        private List<int> _ELocal;

        /// <summary>
        /// 障害物１
        /// </summary>
        private List<int>_Obs1;

        /// <summary>
        /// 障害物２
        /// </summary>
        private List<int> _Obs2;

        /// <summary>
        /// 障害物３
        /// </summary>
        private List<int> _Obs3;

        /// <summary>
        /// 障害物４
        /// </summary>
        private List<int> _Obs4;

        /// <summary>
        /// 障害物５
        /// </summary>
        private List<int> _Obs5;

        /// <summary>
        /// 障害物６
        /// </summary>
        private List<int> _Obs6;

        /// <summary>
        /// 障害物７
        /// </summary>
        private List<int> _Obs7;

        /// <summary>
        /// 障害物８
        /// </summary>
        private List<int> _Obs8;

        /// <summary>
        /// 障害物９
        /// </summary>
        private List<int> _Obs9;

        /// <summary>
        /// 障害物１０
        /// </summary>
        private List<int> _Obs10;

        /// <summary>
        /// 障害物１１
        /// </summary>
        private List<int> _Obs11;

        /// <summary>
        /// 障害物１２
        /// </summary>
        private List<int> _Obs12;

        /// <summary>
        /// 障害物１３
        /// </summary>
        private List<int> _Obs13;

        /// <summary>
        /// 障害物１４
        /// </summary>
        private List<int> _Obs14;

        /// <summary>
        /// 障害物１５
        /// </summary>
        private List<int> _Obs15;

        /// <summary>
        /// 障害物１６
        /// </summary>
        private List<int> _Obs16;

        /// <summary>
        /// 障害物１７
        /// </summary>
        private List<int> _Obs17;

        /// <summary>
        /// 障害物１８        
        /// </summary>
        private List<int> _Obs18;

        /// <summary>
        /// 障害物１９
        /// </summary>
        private List<int> _Obs19;

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
            _PLocal = new List<int> { _PlayerData._X, _PlayerData._Y };
            _ELocal = new List<int> { _EnemyData._X, _EnemyData._Y };
            _Obs1 = new List<int> { 5, 5 };
            _Obs2 = new List<int> { 6, 5 };
            _Obs3 = new List<int> { 7, 5 };
            _Obs4 = new List<int> { 8, 5 };
            _Obs5 = new List<int> { 9, 5 };
            _Obs6 = new List<int> { 10, 5 };
            _Obs7 = new List<int> { 5, 6 };
            _Obs8 = new List<int> { 5, 7 };
            _Obs9 = new List<int> { 5, 8 };

            _Obs10 = new List<int> { 5, 9 };
            _Obs11 = new List<int> { 5, 10 };
            _Obs12 = new List<int> { 20, 20 };
            _Obs13 = new List<int> { 19, 20 };
            _Obs14 = new List<int> { 20, 19 };
            _Obs15 = new List<int> { 20, 18 };

            _Obs16 = new List<int> { 16, 16 };
            _Obs17 = new List<int> { 17, 16 };
            _Obs18 = new List<int> { 16, 17 };
            _Obs19 = new List<int> { 16, 18 };
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
        public void GetPlayerMove(MoveType type)
        {
            

            switch (type)
            {
                case MoveType.Up:
                    if (_PlayerData._Y >= Min_Y_Coordinate)
                    {
                        
                            _PlayerData._Y--;
                        
                    }
                    else
                    {
                        _PlayerData._Y = 24;
                       
                    }
                    GetPlayerClear(MoveType.Up);
                    GetEnemyMove(MoveType.Up);
                    break;
                case MoveType.Down:
                    if (_PlayerData._Y <= Max_Y_Coordinate)
                    {
                        _PlayerData._Y++;
                        
                    }
                    else
                    {
                        _PlayerData._Y = 1;
                        
                    }
                    GetPlayerClear(MoveType.Down);
                    GetEnemyMove(MoveType.Down);
                    break;
                case MoveType.Right:
                    if (_PlayerData._X <= Max_X_Coordinate)
                    {
                        _PlayerData._X++;
                    }
                    else
                    {
                        _PlayerData._X = 1;
                    }
                    GetPlayerClear(MoveType.Right);
                    GetEnemyMove(MoveType.Right);
                    break;
                case MoveType.Left:
                    if (_PlayerData._X >= Min_X_Coordinate)
                    {
                        _PlayerData._X--;
                    }
                    else
                    {
                        _PlayerData._X = 24;
                    }
                    GetPlayerClear(MoveType.Left);
                    GetEnemyMove(MoveType.Left);
                    break;
            }

            _PLocal = new List<int> { _PlayerData._X, _PlayerData._Y };
            if (_Obs1 != _PLocal)
            {
                if (Set_PlayerLocal != null)
                {

                    Set_PlayerLocal(this, _PlayerData);
                }
            }

        }
        /// <summary>
        /// 削除する操作情報
        /// </summary>
        /// <param name="movetype"></param>
        public void GetPlayerClear(MoveType type)
        {
            switch (type)
            {
                case MoveType.Up:
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
                case MoveType.Down:
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
                case MoveType.Right:
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
                case MoveType.Left:
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
            
        }

        /// <summary>
        /// 敵情報取得
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void GetEnemyMove(MoveType type)
        {
            switch (type)
            {
                case MoveType.Up:
                    if(_EnemyData._Y >= Min_Y_Coordinate)
                    {
                        _EnemyData._Y--;
                    }
                    else
                    {
                        _EnemyData._Y = 24;
                    }
                    GetEnemyClear(MoveType.Up);
                    break;
                case MoveType.Down:
                    if(_EnemyData._Y <= Max_Y_Coordinate)
                    {
                        _EnemyData._Y++;
                    }
                    else
                    {
                        _EnemyData._Y = 1;
                    }
                    GetEnemyClear(MoveType.Down);
                    break;
                case MoveType.Right:
                    if(_EnemyData._X <= Max_X_Coordinate)
                    {
                        _EnemyData._X++;
                    }
                    else
                    {
                        _EnemyData._X = 1;
                    }
                    GetEnemyClear(MoveType.Right);
                    break;
                case MoveType.Left:
                    if(_EnemyData._X >= Min_X_Coordinate)
                    {
                        _EnemyData._X--;
                    }
                    else
                    {
                        _EnemyData._X = 24;
                    }
                    GetEnemyClear(MoveType.Left);
                    break;
            }
            
            if(Set_EnemyLocal != null)
            {
                Set_EnemyLocal(this,_EnemyData);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        public void GetEnemyClear(MoveType type)
        {
            switch (type)
            {
                case MoveType.Up:
                    if (_EnemyY >= Min_Y_Coordinate)
                    {
                        _EnemyData._YClear = _EnemyY--;
                        _EnemyX = _EnemyData._X;
                        _EnemyData._XClear = _EnemyX;


                    }
                    else
                    {
                        _EnemyData._YClear = _EnemyY--;
                        _EnemyX = _EnemyData._X;
                        _EnemyData._XClear = _EnemyX;
                        _EnemyY = 24;
                    }
                    break;
                case MoveType.Down:
                    if (_EnemyY <= Max_Y_Coordinate)
                    {
                        _EnemyData._YClear = _EnemyY++;
                        _EnemyX = _EnemyData._X;
                        _EnemyData._XClear = _EnemyX;
                    }
                    else
                    {
                        _EnemyData._YClear = _EnemyY++;
                        _EnemyX = _EnemyData._X;
                        _EnemyData._XClear = _EnemyX;
                        _EnemyY = 1;
                    }
                    break;
                case MoveType.Right:
                    if (_EnemyX <= Max_X_Coordinate)
                    {
                        _EnemyData._XClear = _EnemyX++;
                        _EnemyY = _EnemyData._Y;
                        _EnemyData._YClear = _EnemyY;
                    }
                    else
                    {
                        _EnemyData._XClear = _EnemyX++;
                        _EnemyY = _EnemyData._Y;
                        _EnemyData._YClear = _EnemyY;
                        _EnemyX = 1;
                    }
                    break;
                case MoveType.Left:
                    if (_EnemyX >= Min_X_Coordinate)
                    {
                        _EnemyData._XClear = _EnemyX--;
                        _EnemyY = _EnemyData._Y;
                        _EnemyData._YClear = _EnemyY;
                    }
                    else
                    {
                        _EnemyData._XClear = _EnemyX--;
                        _EnemyY = _EnemyData._Y;
                        _EnemyData._YClear = _EnemyY;
                        _EnemyX = 24;
                    }
                    break;
            }
        }
        #endregion
    }
}
