string a = Console.ReadLine()??"";
string b = Console.ReadLine()??"";
string c = Console.ReadLine()??"";
int a1 = int.Parse(a);
int b1 = int.Parse(b);
int c1 = int.Parse(c);
if(a1>b1 & a1>c1){
    Console.WriteLine(b1);
}
else if (b1>a1 & b1>c1){
    Console.WriteLine(b1);
}
else if (c1>b1 & c1>a1){
    Console.WriteLine(c1);
}