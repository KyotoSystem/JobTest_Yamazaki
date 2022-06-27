using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model
{
    public class Seek
    {
        #region メンバ変数
        /// <summary>
        /// X座標
        /// </summary>
        private int _X = 0;
        /// <summary>
        /// Y座標
        /// </summary>
        private int _Y = 0;
        #endregion

        #region プロパティ
        /// <summary>
        /// X座標
        /// </summary>
        public int _XCoordinate { set { _X = value; } get { return _X; } }
        /// <summary>
        /// Y座標
        /// </summary>
        public int _YCoordinate { set { _Y = value; } get { return _Y; } }
        #endregion

        #region コンストラクター
        public Seek(int _x , int _y)
        {
            _X = _x;
            _Y = _y;
        }
        #endregion

    }
}
