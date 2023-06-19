Console.WriteLine("Введiть кiлькiсть елементiв  масиву");

int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите {0}-й элемент", i + 1);
    a[i] = int.Parse(Console.ReadLine());
}
string zadan = string.Join(" ", a);
Console.WriteLine("заданый масив " + zadan);
Console.WriteLine("Введiть елемент який потрiбно знайти");

int k = int.Parse(Console.ReadLine());
bool found = false;
for (int i = 0; i < n; i++)
{
    if (a[i] == k)
    {
        found = true;
        Console.WriteLine("позицiя шуканого елемента " + i);
    }

}
if (!found)
{
    Console.WriteLine("елемент не знайден");
}
//начал делать второй пункт задания
int[] a1 = new int[n];
string zadanrev = "";
for (int t = 0; t < n; t++)
{
    // zadanrev = a[t] + " " +zadanrev;(єто реверс вывода в строке  не делая реворса в масиве не каком,на екране выведиться реверс ну в реальности ет мы просто так наш масив в строку записали) )
    a1[t] = a[n - t - 1];
    zadanrev = zadanrev + " " + a1[t];
}
Console.WriteLine("реверс заданого масыва");
Console.WriteLine(zadanrev);