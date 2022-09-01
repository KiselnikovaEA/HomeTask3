using System;

namespace HomeTasks_KisEA
{
    class Program       // Программа принимает на вход число N и выдаёт список кубов чисел от 1 до N
    {
        static void Main (string[] args)
        {
            string CubeNumbers()
            {
                Console.Write("Введите положительно целое число: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if(n>0)
                {
                    string res = string.Empty;

                    for(int i = 1; i < n+1; i++){
                                                res = res + i*i*i + " ";
                                                }
                    return res;

                }
                else return $"Введённое значение должно быть больше 0";
                   
            }
            
            try
            {
                Console.WriteLine(CubeNumbers());
            }
            catch
            {
                Console.WriteLine("Вводить число необходимо цифрами");
            }
        }
    }
}
