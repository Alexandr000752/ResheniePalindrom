Console.WriteLine("Введите пятизначное число");
string numberA = Console.ReadLine();
int numA = int.Parse(numberA);

int C =  numA;
int proverka = 0;
while (C > 0)
{
    proverka++;
     C =  C/10;
}

if (proverka == 5)
{
    Console.WriteLine("Вы ввели пятизначное число");
        int A1 = numA/10000;
        int A2 = numA/1000- A1*10;
        int A3 = numA/100 - A1*100 - A2*10;
        int A4 = numA/10 - A1*1000 - A2*100 - A3*10;
        int A5 = numA - A1*10000 - A2*1000 - A3*100 - A4*10;
        if (A1 == A5)
        {
            if (A2 == A4)
            {
                Console.WriteLine("Число является палидромом");
            }
            else
            {
                Console.WriteLine("Число не является палидромом");
            }
        }

        else
        {
            Console.WriteLine("Число не является палидромом");
        }

}
else
{
    Console.WriteLine("Вы ввели не пяти значное число");
}
