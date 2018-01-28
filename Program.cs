using System;
using System.Collections;
using System.Linq;
using System.IO;


namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //HangmanGame();
            //createFolder();
            createFile();
        }

        // Hangman Game
        static void HangmanGame()
        {
            Console.WriteLine("Hangman Game");
            try
            {
                string result = "samsung";
                char[] array1 = result.ToCharArray();
                char[] array2 = new char[result.Length];

                // cau hoi:
                System.Console.WriteLine("day la mot hang dien thoai.");
                //  gan mang ky tu thu 2 la cac dau -
                for(int i = 0; i<result.Length;i++)
                {
                    array2[i] = '*';
                }
                // in ra man hinh dap an la cac dau *
                for (int i =0;i<result.Length;i++)
                {
                    System.Console.Write(""+array2[i]);
                }
                System.Console.WriteLine();
                // nguoi choi doan chu:
                while(true)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("moi ban doan chu:");
                    string input1 = Console.ReadLine();
                    for(int i = 0; i<result.Length;i++)
                    {
                        if(String.Compare(input1,array1[i].ToString(),true)==0)
                        {
                            array2[i] = char.Parse(input1);
                        }
                        
                    }
                    for(int i = 0; i<result.Length;i++)
                    {
                        System.Console.Write(array2[i]);
                    }
                    if(array2.SequenceEqual(array1)==true)
                    {
                        System.Console.WriteLine(" :dap an cua ban chinh xac");
                        break;
                    }

                }
                      
            }
            catch (Exception ex)
            {
            
                System.Console.WriteLine(ex.Message);
            }
        }
        static void createFolder()
        {
            DirectoryInfo di = new DirectoryInfo(@"CSharp");
            try
            {
                if(di.Exists)
                {
                    System.Console.WriteLine("thu muc da ton tai");
                }
                di.Create();
                System.Console.WriteLine("tao thu muc thanh cong");
            }
            catch (Exception ex)
            {
            
                System.Console.WriteLine(ex.Message);
            }
        }

        // ham tao file
        static void createFile()
        {
            FileInfo file = new FileInfo(@"CSharp/test.txt");
            if(!file.Exists)
            {
                file.Create();
                System.Console.WriteLine("tao file thanh cong");
            }else
            {
                System.Console.WriteLine("file da ton tai");
            }
            StreamReader sr = new StreamReader(@"CSharp/test.txt");
            StreamWriter sw = new StreamWriter(@"CSharp/test.txt");
            // ghi du lieu vao file
            sw.WriteLine("djfadfdjfff");
            sw.WriteLine("ndkjfksdfh");
            sr.Close();
            sw.Close();

        }
    }
}
