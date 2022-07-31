int number = int.Parse(Console.ReadLine()??"");
if (number > 7){
    Console.WriteLine("число не соответствует дню недели");
}
else{
    if(number < 6){
        Console.WriteLine("нет");
    }
    else{
        Console.WriteLine("да");
    }
}

