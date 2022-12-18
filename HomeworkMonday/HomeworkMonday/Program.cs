using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace HomeworkMonday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task No1
            // - Verilmiş string dəyərindəki bütün sözlərin arasında bir boşluq qalacaq vəziyyətə salan metod.
            // (Metoda "  Men   rusca    bilmirem" dəyəri göndərilərsə onu "Men rusca bilmirem" halına gətirməlidir.
            //string sentecne = "     My     name is           Rashad";

            // Console.WriteLine(OneSpace(sentecne)               );


            //TaskNo2
            // Verilmiş string dəyərdəki sözlərin sayını tapan metod(boşluqlarla ayrılmış bütün ifadələr)
            //{ Salam Millet bu gunki mevzu Metodlardir}

            //string sentese = "How are you guys?";
            //int count = 0;
            //if (sentese==null || sentese=="")
            //{
            //    Console.WriteLine( count );
            //}
            //else
            //{
            //    string[] array = sentese.Split(' ');
            //    count = array.Length;
            //    Console.WriteLine(count);
            //}


            //Task3
            //Parameter olaraq integer array variable-ı (reference) və bir integer value qəbul edən və
            //həmin integer value-nu integer array-ə yəni element kimi əlavə edən metod.

            //int[] numbers = { 4, 5, 6, 7, };
            //int num = 3;

            //Console.WriteLine(NewArr(ref numbers, ref  num));

            //Taks No4
            //- Gonderilmis fullname arrayinden yeni bir names arrayi duzeldib geri qaytaran metod.
            //Fullname arrayinin icindeki butun value-lar ad+" "+soyad formatindadir.
            //Misalcun "Hikmet Abbasov".
            //Misalcun gelen arraydeki deyerler {"Hikmet Abbasov","Abdulla Qulamov","Cemile Hikmetova"}
            //olarsa return olunan arraydeki deyerler {"Hikmet","Abdulla","Cemile"} olmalidir

            

            


        }

        //Task No1
        static string OneSpace(string sentense)
        {

            return sentense.Replace("  ", "");
        }


        //TaskNo3

        static void NewArr(ref int[] nums,  ref int num)  // ({4,5,6,7,}, 3)
        {
            int a = 0;
            int[] newArr = new int[nums.Length + 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i==a)
                {
                    newArr[i] = nums[i];
                    a++;
                }
                else
                {
                    newArr[a++] = num;
                }

            }

            nums = newArr;
            
            


        }

        //Task No4


        static string OnlyNames(string[] fullname)//string[] names = { "Hikmet Abbasov", "Abdulla Qasimov",
                                                                     //     "Cemile Hikmetova" };
        {
            for (int i = 0; i < fullname.Length; i++)
            {
                int name = fullname[i].IndexOf("  ");
                int surname = fullname[i].Length - name;
            }
            
        }









    }
}
