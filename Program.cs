namespace array_test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int odd_counter = 0;
            int even_counter = 0;
            int sum = 0;
            double average = 0;
            int min = 100000000;
            int max = 0;
            int t = 0;
            int s = 0;
            int inside_ab_counter = 0;
            int outside_ab_counter = 0;
            int inside_cd_counter = 0;
            int outside_cd_counter = 0;
           
            Console.WriteLine("Enter lenght of array ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Enter interval limits"); 
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second interval limits");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            // input array elements 
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            // calculate min, max and sum
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min >= numbers[i])
                {
                    min = numbers[i];
                }
                else if (numbers[i] >= max)
                {
                    max = numbers[i];
                }
                sum += numbers[i];
            }
            // setting lengths of greater than x and smaller than x arrays
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > x)
                {
                    t++;

                }
                else if (numbers[i] <= x)
                {
                    s++;
                }
            }
            // first exercise
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"[ {numbers[i]} ]");
            }

            // second exercise
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {

                }
                else
                {
                    Console.WriteLine($"[ {numbers[i]} ]");
                }
            }

            // third exercise   
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"[ {numbers[i]} ]");
                }
            }

            // fourth exercise

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even_counter++;
                }
                else
                {
                    odd_counter++;
                }
            }
            Console.WriteLine("there are " + odd_counter + " odd numbers and " + even_counter + " even numbers");
            //fifth exercise
            average = sum / n;
            Console.WriteLine("the minimum is " + min + " the maximum is " + max + " and the average is " + average);
            // sixth exercise
            int[] greater_than_x = new int[t];
            int[] smaller_than_x = new int[s];
            int t2 = 0;
            int s2 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > x)
                {
                    greater_than_x[t2] = numbers[i];
                    t2++;
                }
                else if (numbers[i] <= x)
                {
                    smaller_than_x[s2] = numbers[i];
                    s2++;
                }
            }
            //seventh,eighth,ninth,and tenth exercise
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<=b && numbers[i]>=a)
                {
                    inside_ab_counter++;                 
                }
                else if(numbers[i]<a || numbers[i]>b)   
                {
                    outside_ab_counter++;
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] <= d && numbers[i] >= c)
                {
                    inside_ab_counter++;
                }
                else if (numbers[i] < c || numbers[i] > d)
                {
                    outside_ab_counter++;
                }
            }
            Console.WriteLine("numbers smaller than or equal to x are: ");
            for (int i = 0; i < smaller_than_x.Length; i++)
            {
                Console.WriteLine($"[ {smaller_than_x[i]} ]");
            }

            Console.WriteLine("numbers greater than x are: ");
            for (int i = 0; i < greater_than_x.Length; i++)
            {
                Console.WriteLine($"[ {greater_than_x[i]} ]");
            }
            Console.WriteLine("there are " + inside_ab_counter + " numbers inside the second interval and " + outside_ab_counter + " numbers outside the first interval");
            Console.WriteLine("there are " + inside_cd_counter + " numbers inside the second interval and " + outside_cd_counter + " numbers outside the second interval");


        }
    }

}
