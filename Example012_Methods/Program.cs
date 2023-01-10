//type 1
void Method()
{
    Console.WriteLine("Автор ...");
}
Method();

//type 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
         Console.WriteLine(msg);  
         count++;
    }
}
//Method21("Текст сообщения", 4);
//OR
Method21(count: 4, msg: "Текст сообщения");

//type 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//type 4

/*int Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);
*/

int Method4(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
            Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

//string s="qwerty"
            012
//