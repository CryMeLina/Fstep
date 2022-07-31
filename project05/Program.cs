int number = int.Parse(Console.ReadLine()??"");
string stringnumber = number.ToString();
if (stringnumber.Length < 4){
    Console.WriteLine(stringnumber[2]);
}
else{
    Console.WriteLine("ошибка, число четырехзначное или более");
}
// Ну это простенькая