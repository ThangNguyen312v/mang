using System;
namespace mang{
    class Program{
        static void Main(string[] Args){
            int size;
            int[] mang;
            do{
                Console.WriteLine("Nhap vao kich co");
                size = Int32.Parse(Console.ReadLine());
                if(size > 20)
                Console.WriteLine("khong duoc vuot 20");
            }while (size > 20);

            mang = new int[size];
            for(int i = 0; i < mang.Length; i++){
                Console.WriteLine("Nhap vao phan tu" + (i + 1)+ " : ");
                mang[i] = Int32.Parse(Console.ReadLine());

            }
            Console.WriteLine("Danh sach cua mang: ");
            for(int j = 0; j < mang.Length; j++){
                Console.WriteLine(mang[j] + "\t");
            }
            int max = mang[0];
            int index = 1;
            for(int j = 0; j < mang.Length; j++){
                if(mang[j] > max){
                    max = mang[j];
                    index = j + 1;
                }
            }
              Console.WriteLine("gia tri lon nhat trong mang la: " + max + "vi tri: " + index);
        }
    }
}
