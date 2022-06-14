using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntryTestCs.Model.ClearModel;
namespace EntryTestCs.Contller
{
    public class DataClearContller
    {
        #region プロパティ
        /// <summary>
        /// 数値
        /// </summary>
        public string Num { get; set; }
        /// <summary>
        /// 演算フラグ
        /// </summary>
        public string Ope { get; set; }
        /// <summary>
        /// クリア後の数値
        /// </summary>
        public static string ClearNum { get; set; }
        #endregion

        #region メソッド
        public Clear GetClear()
        {
            Clear clear = null;
            string ope = Ope;
            string num = Num;
            clear = ClearType(ope , num);
            return clear;
        }

        public Clear ClearType(string ope ,string num)
        {
            Clear clear = null;
            switch (ope)
            {
                case "Operation":
                    clear = new Secondnumber(num);
                    break;
                case "Equal":
                    break;
                default:
                    clear = new Firstnumber(num);
                    break;
            }
            GetClearNumber(clear);
            return clear;
        }

        public static void GetClearNumber(Clear clear)
        {
            if(clear is Secondnumber secondnumber)
            {
                GetSecondnumber(secondnumber);

            }else if(clear is Firstnumber firstnumber)
            {
                Getfirstnumber(firstnumber);
            }
        }

        public static void GetSecondnumber(Secondnumber secondnumber)
        {
            secondnumber.GetSum();
            ClearNum = secondnumber.Snum;
            
        }

        public static void Getfirstnumber(Firstnumber firstnumber)
        {
            firstnumber.GetFum();
            ClearNum = firstnumber.Fnum;

        }
        #endregion
    }
}
