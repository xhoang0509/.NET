using System;
using System.IO;
namespace TapTin
{
    class Program
    {

        static void ChuyenVanBan(string fileNameInput, string fileNameOutput)
        {
            StreamReader sr = new StreamReader(fileNameInput);
            StreamWriter  sw= new StreamWriter(fileNameOutput);
            string st = "";
            int count = 0;
            while ((st = sr.ReadLine()) != null)
            {
                count  += st.Length;
                st = st.ToUpper();
                sw.WriteLine(st);

            }
            sw.Write(count);
            sr.Close();
            sw.Close();
        }
        static void Main(string[] args)
        {

            ChuyenVanBan("input.txt", "output.txt");
        }
    }
}
