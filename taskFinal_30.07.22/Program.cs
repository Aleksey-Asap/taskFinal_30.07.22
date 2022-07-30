
string[] mass = { "Привет Мир", "-2", "Алексей", "10" };
string[] temp = new string[mass.Length];
int count = 0;

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i].Length <= 3)
    {
        temp[i] = mass[i];
        count++;
    }
}

string [] massResult = new string[count];
int num = 0;
for (int i = 0; i < temp.Length; i++)
{
    if (temp[i] != null)
    {
        massResult[num] = temp[i];
        num++;
    }
}

void Print(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

Print(mass);
Console.WriteLine();
Print(massResult);

