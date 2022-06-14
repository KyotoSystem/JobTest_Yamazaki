using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryTestCs.Model.ClearModel
{
    public class Answer : Clear
    {
        #region コンストラクター
        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="anum">答え</param>
        public Answer(string anum) : base(anum)
        {
            Anum = anum;
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// 答え
        /// </summary>
        public string Anum { get; set; }
        #endregion
    }
}
