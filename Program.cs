
namespace ConsoleMatrixToSpiralApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Create matrix for spiral");
            int a = 0;
            int b = 0;
            //bool check_a = false;
            //bool check_b = false;

            for (bool check_a = false; check_a == false;)
            {
                Console.Write("Enter count <int> of matrix line:");
                string? read_a = Console.ReadLine();
                if (int.TryParse(read_a, out int lines))
                {
                    
                    for (bool check_b = false; check_b == false;)
                    {
                        Console.Write($"Count of matrix line is:[{lines}], enter count <int> in line:");
                        string? read_b = Console.ReadLine();
                        if (int.TryParse(read_b, out int count))
                            {
                                a = lines;
                                b = count;
                                check_b = true; 
                            }
                        else Console.WriteLine(" give me true natural number pls");
                    
                    }
                    check_a = true;
                
                }
                else Console.WriteLine(" give me true natural number pls");                  
               
            }
            if (a > 0||b > 0)
            {
                int[,] matrix = new int[a, b];
                int tic = 1;
                for (int i = 0; i < a; i++)
                {                   
                                 
                    for (int j = 0; j < b; j++)
                    {
                       matrix[i, j] = tic++; // заполняем строку массива
                    }
                    
                }
                int check_matrix = matrix.Length;
                int way = 1;
                int[] result = new int[check_matrix];
                int add_result = 0;

                int downStop = a - 1; //вниз
                int rightStop = b - 1; //вправо
                int upStop = 0; //вверх
                int leftStop = 0; //влево

                //for (int circle = 1,)
                while (check_matrix > 0)
                {
                    switch (way)
                    {
                        case 1: 
                            for(int i = upStop; i < downStop + 1; i++)
                            {
                                //if (check_matrix[i,] != 0)
                                result[add_result++] = matrix[i, leftStop];
                                check_matrix--;
                            }
                            leftStop += 1;
                            
                            way = 2;
                            break;
                        case 2:
                            for (int i = leftStop; i < rightStop + 1; i++)
                            {
                                //if (check_matrix[i,] != 0)
                                result[add_result++] = matrix[downStop, i];
                                check_matrix--;
                            }
                            downStop -= 1;                            
                            way = 3;
                            break;
                        case 3:
                            for (int i = downStop; i > upStop - 1; i--)
                            {
                                //if (check_matrix[i,] != 0)
                                result[add_result++] = matrix[i, rightStop];
                                check_matrix--;
                            }
                            rightStop -= 1;                            
                            way = 4;
                            break;
                        case 4:
                            for (int i = rightStop; i > leftStop - 1; i--)
                            {
                                //if (check_matrix[i,] != 0)
                                result[add_result++] = matrix[upStop, i];
                                check_matrix--;
                            }
                            upStop += 1;
                            way = 1;
                            break;

                    }
                }
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write($"{result[i]} ");
                }
                
            }
            

        }
    }
}