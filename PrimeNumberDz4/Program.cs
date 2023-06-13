int chislo = int.Parse(Console.ReadLine());
//if (chislo < 2)
//{
  //  Console.WriteLine("Not a prime number");
//}    (ця перевірка не потрібна оскільки якщо число менше <2 то цикл while не запуститься і число к не зміниться , а отже число не прайм
int div = 1;
int k = 0;
while (div < chislo)
{
    if (chislo % div == 0)
    {
        k++;
    }
    div++;
    if (k == 2)
    {
        break;
    }
}
if (k == 1)
{
    Console.WriteLine("PrimeNumber");
}
else
{
    Console.WriteLine("Not a prime number");
}
