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
        int max=0;
        int t=0;
        int s = 0;

            Console.WriteLine("Enter lenght of array ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x ");  
            int x= Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            int[] placeholder = new int[n];
            for (int i = 0; i < n; i++)
            {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    if (min>=numbers[i])
                    {
                        min = numbers[i];   
                    }
                        else if(numbers[i] >= max)
                        { 
                            max = numbers[i]; 
                        }
                            else if(numbers [i]>x)
                            {
                                t++;
                                
                    
                            }
                                else if (numbers[i] < x)
                                {
                                    s++;
                                }

                sum += numbers[i];
            }
                // first exercise
                for (int i = 0; i < n; i++)
                {
                Console.WriteLine($"[ {numbers[i]} ]");
                }
           
            // second exercise
            for (int i = 0; i < n; i++)
            {
                if(i % 2 == 0)
                {
                 Console.WriteLine($"[ {numbers[i]} ]");
                }
            }
          
            // third exercise   
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"[ {numbers[i]} ]");
                }
            }

            // fourth exercise

            for (int i = 0; i < n; i++)
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
            Console.WriteLine("there are "+odd_counter  +" odd numbers and " +even_counter+" even numbers");
            //fifth exercise
            average = sum / n;
            Console.WriteLine("the minimum is " + min + " the maximum is "+max+" and the average is " + average);
            // sixth exercise
            int[] greater_than_x = new int[t];
            int[] smaller_than_x = new int[s];
            for(int i = 0; i < n; i++)
            {
                if(numbers[i] > x)
                {
                    greater_than_x[i] = numbers[i];
                }
                else if (numbers[i] < x)
                {
                    smaller_than_x[i] = numbers[i];
                }
            }
            Console.WriteLine("numbers greater than x are: ");
            for(int i = 0; i < t; i++)
            {
                Console.WriteLine(greater_than_x[i]);
            }
            Console.WriteLine("numbers smaller than x are: ");  
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine(smaller_than_x[i]);
            }
        }
    }

}
