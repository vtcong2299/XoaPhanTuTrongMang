using System;
using System.Linq;

namespace XoaPhanTuTrongMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int numArray;
            int i;  
            int num;
            int []newArray;          
            while(true)
            {
                Console.Write("Nhap vao so luong phan tu cua mang: ");
                if(int.TryParse(Console.ReadLine(),out numArray))
                {
                    break;
                }
                continue;
            }
            int [] array= new int [numArray];
            for (i=0; i<numArray; i++)
            {
                while(true)
                {
                    Console.Write("Nhap vao phan tu thu {0}: ", i);
                    if (int.TryParse(Console.ReadLine(),out array[i]))
                    {
                        break;
                    }
                    continue;
                }
            }            
            while(true)
            {
                Console.Write("Nhap gia tri phan tu muon xoa: ");
                if(int.TryParse(Console.ReadLine(),out num))
                {
                    break;
                }
                continue;
            }     
            int count= KiemTraMang(array,num);       
            newArray = XoaPhanTu(array,num);
            if (count==array.Length)
            {
                Console.Write("Khong co phan tu do trong mang");
            }
            else
            {
                Console.Write("Mang sau khi xoa la: ");
                foreach(int number in newArray)
                {
                    Console.Write("{0,5}", number);
                }
            }
           
        }
        static int KiemTraMang(int [] array, int num)
        {
            int count =0;
            for (int i =0; i<array.Length; i++)
            {
                if (array[i]!=num)
                {
                    count++;
                }
            }
            return count;
        }
        // //Cách 1: sử dụng LINQ
        // static int[] XoaPhanTu(int [] array, int num)        
        // {
        //     /*Dòng lệnh array.Where(val => val != num).ToArray(); 
        //     trong C# sử dụng LINQ để lọc các phần tử của mảng array 
        //     sao cho chỉ giữ lại các phần tử khác với giá trị num*/
            
        //     int [] newArray = array.Where(val => val!=num).ToArray();
        //     return newArray;
        // }

        //Cách 2: sử dụng Array.Copy
        static int[] XoaPhanTu(int [] array, int num)        
        {
             
            for (int i =0; i<array.Length; i++)
            {
                if (array[i]==num)
                {
                    int index = i;
                    int []newArray = new int [array.Length-1];
                    Array.Copy(array,0,newArray,0,index);
                    Array.Copy(array,index+1,newArray,index,array.Length-index-1);
                    array=newArray;
                }
            }
            return array;
        }
        
    }
}