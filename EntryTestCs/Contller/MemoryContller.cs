using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntryTestCs.Model.MemoryModel;

namespace EntryTestCs.Contller
{
    public class MemoryContller
    {
        #region プロパティ
        public string MNum { get; set; }
        public string Mstr { get; set; }  
        public static double MnumAnswer { get; set; }
        #endregion

        #region メソッド
        public Memory GetMemory()
        {
            Memory memory = null;
            double mnum;
            mnum = double.Parse(MNum);
            memory = MemoryType(mnum);
            return memory;
        }

        /// <summary>
        /// メモリインスタンス作成
        /// </summary>
        /// <param name="mnum">メモリ</param>
        /// <returns></returns>
        public Memory MemoryType(double mnum)
        {
            Memory memory = null;
            switch (Mstr)
            {
                case "M+":
                    memory = new Mplus(mnum);
                    break;
                case "M-":
                    memory = new Mminus(mnum);
                    break;
            }
            GetMemoryAnswer(memory);
            return memory;

        }

        /// <summary>
        /// メモリ計算の答え取得
        /// </summary>
        /// <param name="memory">メモリ計算</param>
        public static void GetMemoryAnswer(Memory memory)
        {
            if(memory is Mplus mplus)
            {

                GetMplusAnswer(mplus);

            }else if(memory is Mminus mminus)
            {

                GetMminusAnswer(mminus);

            }
        }

        /// <summary>
        /// M+の答えを取得
        /// </summary>
        /// <param name="mplus">M+</param>
        public static void GetMplusAnswer(Mplus mplus)
        {
            mplus.GetMpNum();
            MnumAnswer = mplus.MpNum;

        }

        /// <summary>
        /// M-の答えを取得
        /// </summary>
        /// <param name="mminus">M-</param>
        public static void GetMminusAnswer(Mminus mminus)
        {
            mminus.GetMmNum();
            MnumAnswer = mminus.MmNum;
        }
        #endregion
    }
}
