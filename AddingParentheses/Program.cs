using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingParentheses
{
    internal class Program
    {
        static int m_nCount = 0;
        static string m_strEquation = "";

        static void Main(string[] args)
        {
            ReadData();

        }

        private static bool ReadData()
        {
            try
            {
                string strCount = Console.ReadLine();
                bool bResult = Int32.TryParse(strCount, out m_nCount);
                if (!bResult)
                {
                    Console.WriteLine("올바른 숫자 값을 입력하세요.");
                    return false;
                }


            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                Debug.Assert(false);

                return false;
            }

            return true;
        }
    }
}
