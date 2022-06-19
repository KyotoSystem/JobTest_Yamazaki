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


        public static void GetMplusAnswer(Mplus mplus)
        {
            mplus.GetMpNum();
            MnumAnswer = mplus.MpNum;

        }

        public static void GetMminusAnswer(Mminus mminus)
        {
            mminus.GetMmNum();
            MnumAnswer = mminus.MmNum;
        }
        #endregion
    }
}
