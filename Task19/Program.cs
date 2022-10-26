using System;

namespace HomeTasks_KisEA
{
    class Program           // Программа проверяет палиндромность пятизначного числа
    {
        static void Main (string[] args)
        {
            
            int Palindrom(int num)
            {

            
                if ((int)(Math.Log10(num)) != 4) return -1;
                else{
                    string str = num.ToString();
                    int flag = 0;
                    int[] array = new int[str.Length];

                    for (int i = 0; i < str.Length; i++){
                                                            array[i] = int.Parse(str[i].ToString());
                                                        }
                    for (int i = 0; i < array.Length/2; i ++){
                                                                if (array[i] != array[array.Length - i - 1])
                                                                {
                                                                    flag = 1;
                                                                    break;                                                                    
                                                                }
                                                                        
                                                            } 
                    return flag;

                }
            }
            try{
                    Console.Write("Введите неотрицательное пятизначное число: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (Palindrom(number) == 1) Console.WriteLine($"Число {number} не является палиндромом");
                    else if (Palindrom(number) == -1) Console.WriteLine("Вы ввели не пятизначное число");
                    else Console.WriteLine($"Число {number} является палиндромом");
                }
            catch{
                    Console.WriteLine("Вводить необходимо именно цифры");
                }   

        }

            


    }
}
