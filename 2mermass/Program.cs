class Top
{
    
    static void A_ck(int[,] mat)
    {
        Random rand = new Random();
        for (int i = 0; i != 25; i++)
        {
            for (int b = 0; b != 5; b++)
            {
                mat[i, b] = rand.Next(1, 6);
            }
        }
        double e = 0;
        double[] aaa = new double[5];
        double min = 5;
        double max = 0;
        double mines = 500;
        double max_es = - 1000;
        for (int i = 0; i != 5; i++)
        {
            e = 0;
            for (int b = 0; b != 25; b++)
            {
                e += mat[b, i];
                if (mat[b, i] > max)
                {
                    max = mat[b, i];
                }
                if (mat[b, i] < min)
                {
                    min = mat[b, i];
                }

            }
            e /= 25;
            Console.WriteLine($"{i + 1}предмет ср оценка{e}");
            Console.WriteLine($"Максимальная оценка{max}");
            Console.WriteLine($"Минимальная оценка {min}");
            Console.WriteLine();
            
        }
        Console.WriteLine();
        for (int i = 0; i != 25; i++)
        {
            e = 0;
            for (int b = 0; b != 5; b++)
            {
                e += mat[i,b];
                if (mat[i, b] > max_es)
                {
                    max_es = mat[i, b];
                }
                if (mat[i, b] < mines)
                {
                    mines = mat[i, b];
                }
            }
            e /= 5;
            Console.WriteLine($"У {i + 1} ученика ср оценка{e}");
            Console.WriteLine($"Максимальный балл {max_es}");
            Console.WriteLine($"Минимальный балл {mines}");
        }
        
    }

    static void Main()
    {
        int[,] prosto = new int[25, 5];
        A_ck(prosto);

    }
}
