// Количество положительных чисел
int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
int result = 0;
foreach (int number in numbers)
{
    if (number > 0)
    {
        result++;
    }
}
Console.WriteLine($"Число элементов больше нуля: {result} ");


// Инверсия массива
int[] numberss = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

int n = numberss.Length; 
int k = n / 2;          
int temp;               
for (int i = 0; i < k; i++)
{
    temp = numberss[i];
    numberss[i] = numbers[n - i - 1];
    numberss[n - i - 1] = temp;
}
foreach (int i in numberss)
{
    Console.Write($"{i} \t");
}

//Программа сортировки массива
int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

int tempp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            tempp = nums[i];
            nums[i] = nums[j];
            nums[j] = tempp;
        }
    }
}

Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}

