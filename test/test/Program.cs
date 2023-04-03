// See https://aka.ms/new-console-template for more information

int a;
void calc(void);
int main(void)
{
    calc();
    printf(&quot; The value is %d\n&quot;, a);
return 0;
}
void calc(void)
{
    int a = 100000;
    do
    {
        a-= 100;
    } while (a &gt;= 0 );
}
Console.WriteLine("Hello, World!");
