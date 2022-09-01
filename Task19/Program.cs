using System;

namespace HomeTasks_KisEA
{
    class Program           // Программа проверяет палиндромность пятизначного числа
    {
        static void Main (string[] args)
        {
            
            string Palindrom()
            {
                Console.Write("Введите неотрицательное пятизначное число: ");
                int num = Convert.ToInt32(Console.ReadLine());
            
                if ((int)(Math.Log10(num)) != 4) return "Вы ввели не пятизначное число";
                else{
                    string str = num.ToString();
                    int flag = 0;
                    int[] array = new int[str.Length];

                    for (int i = 0; i < str.Length; i++){
                                                            array[i] = int.Parse(str[i].ToString());
                                                        }
                    for (int i = 0; i < array.Length/2; i ++){
                                                                if (array[i] == array[array.Length - i - 1]) i++;
                                                                else {
                                                                        flag = 1;
                                                                        break;
                                                                    }
                                                            } 
                    if (flag == 1) return $"Число {num} не является палиндромом";
                    else return $"Число {num} является палиндромом";
                }
            }
            try{
                    Console.WriteLine(Palindrom());
                }
            catch{
                    Console.WriteLine("Вводить необходимо именно цифры");
                }   

        }

            


    }
}
