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

static void tentoten()
    {
        int[] arr = new int[100];
        Random rnd = new Random();
        int postiveCounter = 0;
        int negativeCounter = 0;
        int equalszero = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(-10, 11);
            Console.Write(arr[i] + " ");
            
            if (arr[i] > 0)
            {
                postiveCounter++;
            }
            else if (arr[i] < 0)
            {
                negativeCounter++;
            }
            else
            {
                equalszero++;
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Positive Numbers showed up " + postiveCounter + " times");
        Console.WriteLine("Negative Numbers showed up " + negativeCounter + " times");
        Console.WriteLine("zero showed up " + equalszero + " times");
    }

    static void diddysList()
    {
        bool found = false;
        int[] diddysList = new int[30];
        Random epstein = new Random();
        for (int i = 0; i < diddysList.Length; i++)
        {
            found = false;
            diddysList[i] = epstein.Next(0, 50);
            for (int j = 0; j < i && !found; j++)
            {
                if (diddysList[i] == diddysList[j])
                {
                    found = true;
                    Console.WriteLine("Nigger not good");
                }
            }
        }
        for (int i = 0; i < diddysList.Length;i++)
        {
            Console.Write(diddysList[i] + " ");
        }

                static void maharach()
        {
            int[] numbers = new int[5];
            numbers[0] = 5;
            numbers[2] = 7;
            numbers[4] = 6;

        }

        static int[] copyarr(int[] arr)
        {
            int[] newArry = new int[arr.Length];
            for (int i = 0; i < newArry.Length; i++)
            {
                newArry[1] = arr[i];
            }
            return newArry;
        }
        static void arr()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = copyarr (arr1);
            int i = 0;
        }

        static void stupidshitidksomeshitwithnumbersandarraysidk()
        {
            int[] grades = new int[10];
            int i = 0;
            int sum = 0;
            double avg = 0;
            int counter = 0;
            Random rand = new Random();

            Console.WriteLine("the grades are: ");
            for (i = 0; i < grades.Length; i++)
            {
                grades[i] = rand.Next(0, 101);
                Console.Write(grades[i] + " ");
            }


            Console.WriteLine();
            for (i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 55)
                {
                    counter++;
                }
                sum += grades[i];
            }

            avg = (double)sum / grades.Length;
            Console.WriteLine("the avg is " + avg + " and the number of grades that passed: " + counter);
        }

        static void taskarray()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
                Console.WriteLine(arr2[i]);
            }
        }

        static void printarray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) ;
            {
                Console.WriteLine(arr[1] + " ");
            }
        }

        static void PrintHistogram(int[] arr) // idk whats wrong with this
        {
            Console.WriteLine("There are" + arr.Length + "numbers in the array: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + ": ");
                for (int j = 0; i < arr[i]; j++)
                {

                    Console.WriteLine("*");
                    Console.WriteLine();
                }
            }
        }

        static bool IsSymetricArray(int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            bool isSymetric = true;

            while (left < right && isSymetric)
            {
                if (arr[left] != arr[right])
                    isSymetric = false;

                left++;
                right--;
            }
            
            return isSymetric;
        }

        static void lettersshit()
        {
            int letterIndex = 0;
            int firstIndex = 97;
            char[] chars = { 'a', 'b', 'c', 'd', 'a'};
            int[] counter = new int[26];
            for(int i = 0; i < chars.Length; i++)
            {
                letterIndex = chars[i] - firstIndex;
                counter[letterIndex]++;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write("The letter " + counter[i] + " shows" + counter[chars[i] - firstIndex] + " times");
            }
        }

        static void task13()
        {
            int[] arr = { 1, 2, 6, 2, 4 };
            bool goingUp = true;
            for (int i = 0; i < arr.Length && goingUp; i++)
            {
                if (i + 1 != arr.Length)
                {
                    if (arr[i] >= arr[i + 1])
                    {
                        goingUp = false;
                    }
                }
            }
            if (goingUp)
            {
                Console.WriteLine("the arr is going up");
            }
            else
            {
                Console.WriteLine("the arr is not going up");
            }
        }
        static void task14()
        {
            bool same = true;
            int[] arr = { 1, 5, 9, 1, 5, 9 };
            if (arr.Length % 2 == 0)
            {
                int len = arr.Length / 2;
                for (int i = 0; i < len && same; i++)
                {
                    for (int j = len; j < arr.Length && same; j++)
                    {
                        if (arr[i] != arr[j])
                        {
                            same = false;
                        }
                    }
                }
            }
            else
            {
                same = false;
            }
            if (same)
            {
                Console.WriteLine("half");
            }
            else
            {
                Console.WriteLine("not half");
            }
        }

        static void task15()
        {
            int[] a = { 3, 7, 12, 19, 25, 31, 42, 56, 68, 90 };
            int[] b = { 3, 14, 22, 37, 12, 30, 63, 78, 64, 100 };
            int[] c = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > b[i])
                {
                    c[i] = a[i];
                }
                else if (a[i] < b[i])
                {
                    c[i] = b[i];
                }
                else
                {
                    c[i] = 0;
                }
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i] + " ");
            }
        }
        static void task16()
        {
            int[] arr = { 1, 6, 6, 6, 1, 6, 1 };
            int famNum = 0;
            int maxCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                }

                if (counter > maxCount)
                {
                    maxCount = counter;
                    famNum = arr[i];
                }
            }
            Console.WriteLine("the fam num is " + famNum + " showing up " + maxCount + " times");
        }

        static void task4()
        {
            char[] letter = { 't', 'e', 'n', 'g', 'k', 'l', 'd', 'f', 'v', 'x' };
            int[] counter = new int[26];
            for (int i = 0; i< counter.Length; i++)
            {
                counter[letter[i] + 97]++;
            }
            for (int i =0; i < counter.Length; i++)
            {
                Console.WriteLine(counter[i + 97] + " is" + counter);
            }
        }

        static void nummbercontaining1()
        {
            int max = 0;
            int[] arr = new int[30];
            Random rand = new Random();
            int digit = 0;
            int counter = 0;

            Console.Write("Enter a number: ");
            digit = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10, 100);
                Console.Write(arr[i] + " ");

                if (arr[i] % 10 == digit || arr[i] / 10 == digit)
                {
                    counter++;

                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("The number " + digit + " Showed up " + counter + " Times");
            Console.WriteLine("The max number that showed up that had the digit " + digit + " was " + max);
        }

        static void stupid10numberarrayshit()
        {
            int[] arr1 = new int[10];
            Random rand = new Random();
            int counter = 0;

            for (int i = 0; i < arr1.Length;i++)
            {
                arr1[i] = rand.Next(0, 10);
                Console.Write(arr1[i] + " ");
            }
        }

        static void votes()
        {
            string winner = " ";
            int maxVotes = 0;

            int counterVotes = 0;
            int choice = 0;
            string[] names = {"epstein", "bibi", "trump", "diddy", "omer", "alsu", "display flex"
            , "my knee grow", "notion", "калькулятор"};
            int[] counter = new int[names.Length];
            bool exit = false;
            while (!exit)
            {
                do
                {
                    Console.WriteLine("enter a num beetween 1 to 10 to vote for:");
                    Console.WriteLine("1 - epstein 2 - bibi 3 - trump");
                    Console.WriteLine("4 - diddy 5 - omer 6 - alsu");
                    Console.WriteLine("7 - display flex 8 - my knee grow");
                    Console.WriteLine("9 - notion 10 - калькулятор 0 - for exit");
                    choice = int.Parse(Console.ReadLine());
                    if (choice < 0 || choice > 10)
                    {
                        exit = true;
                    }
                    else
                    {
                        counter[choice - 1]++;
                        counterVotes++;
                    }
                    {
                        Console.WriteLine("its out of range try again");
                        Console.WriteLine("----------------------------------------");
                    }
                }
                while (choice < 0 || choice > 10);
                if (choice == 0)


                    Console.WriteLine("thanks for voting");
            }
            for (int i = 0; i < names.Length; i++)
            {
                if (counter[i] > maxVotes)
                {
                    maxVotes = counter[i];
                    winner = names[i];
                }
            }
            Console.WriteLine("the winner is " + winner + " who got " + maxVotes + " votes");
        }


        static void igloo()
        {
            int indexFound = 0;
            int[] arr = { 42, 67, 89, 16, 53, 24, 91, 3, 68, 77, 12, 59, 34, 85, 20 };
            Console.WriteLine("enter num: ");
            int num = int.Parse(Console.ReadLine());
            bool inside = false;
            int counter = 0;

            for (int i = 0; i < arr.Length && !inside; i++)
            {
                if (arr[i] == num)
                {
                    inside = true;
                    indexFound = i;
                }
            }
            if (inside)
            {
                for (int i = 0; i < indexFound; i++)
                {
                    if (arr[i] < num)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("the num " + num + " is inside and there are " + counter + " numbers smaller than him before him");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < num)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("the num " + num + " is not inside and there are " + counter + " smaller nums then him");
            }

        }

        static void task1()
        {
            int tmp = 0;
            int counter = 0;
            Random rand = new Random();
            int[] arr = new int[30];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10, 101);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("enter a digit");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                tmp = arr[i];
                while (tmp > 0)
                {
                    if (tmp % 10 == num)
                    {
                        counter++;
                    }
                    tmp /= 10;

                }
            }
            Console.WriteLine("the num " + num + " shows " + counter + " times");

        }
        static void task6()
        {
            int j = 0;
            Random rnd = new Random();
            int[] before = new int[30];
            int[] after = new int[30];
            for (int i = 0; i < before.Length; i++)
            {
                before[i] = rnd.Next(0, 6);
                Console.Write(before[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < before.Length; i++)
            {

                if (before[i] != 0)
                {
                    after[j] = before[i];
                    j++;
                }
            }
            for (int i = 0; i < after.Length; i++)
            {
                Console.Write(after[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < after.Length; i++)
            {
                if (after[i] == 0)
                {
                    after[i] = 1;
                }
                Console.Write(after[i] + " ");
            }
        }
