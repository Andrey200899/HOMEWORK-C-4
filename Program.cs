// Задача № 29
/* int[] array =new int[8];
Mass(array);
Console.WriteLine($"Массив : {String.Join(" ", array)}");
int [] Mass(int[] array){
    for (int i=0 ; i<array.Length;i++){
        array[i]=new 
        Random().Next(0,100000000);
    }
    return array;
}*/

// Задача № 27
//Console.WriteLine("Введите число");
//int i = Convert.ToInt32(Console.ReadLine());
//int sum = 0;

//while (i > 0)
//{
//int num = i % 10;
//i = i / 10;
//sum = sum + num;
//}
//Console.WriteLine("Cумма всех цифр в числе равна: " + sum);

// Задача №25
Console.WriteLine("Введите число A :");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B :");
int b =Convert.ToInt32(Console.ReadLine());
 int number =a;
 for ( int i=1;i<b;i++){
    number =number*a;
 }
 Console.WriteLine("A в степени B равно: " + number);
