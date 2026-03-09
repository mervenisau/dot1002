int[] inventory = { 200, 450, 700 };
int sum = 0;

foreach (int items in inventory)
{
    sum += items;
    Console.WriteLine(sum);
}