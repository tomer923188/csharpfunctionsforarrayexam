    static void avg()
    {
        int counter = 0;
        int sum = 0;
        int[] arr = new int[30];
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(0, 31);
            sum += arr[i];
            Console.Write(arr[i] + " ");
        }
        int avg = sum / arr.Length;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != avg)
            {
                counter++;
            }
        }
        Console.WriteLine(counter + " numbers are not the avg");
        Console.WriteLine(avg + " is the avg");
    }

    static void zogieizogisum()
    {
             int sumEven = 0;
        int sumOdd = 0;
        int[] arr = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(0, 11);
        }
        for (int i = 0 ; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumEven += arr[i];
            }
            else
            {
                sumOdd += arr[i];
            }
        }
        if (sumOdd == sumEven)
        {
            Console.WriteLine("zogi sum is the same as eizogi");
        }
        else
        {
            Console.WriteLine("the sum is not the same blud");
        }   
    }
