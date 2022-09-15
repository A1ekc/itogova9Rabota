// Написать программу, которая из имеющегося массива строк сформирует массив строк длинна которых меньше или равна трём символам.

string massiv = Readint("Введите символы через запятую: ");
string number = string.Empty;//пустая строка

int count = 0;//для подсчёта количества
int length = massiv.Length;//показвает количество символов в строке


    for (int i = 0; i < length; i++)
    {
        if (massiv[i] != ',')//склеиваем число до запятой
        {
        number += massiv[i];
        count++;
        }
        else
        {
    
          if (count <= 3)
          {
           Console.Write(number + ",");
            count = 0;
            number = string.Empty;//обнуляю строку
          }
            //number = string.Empty;//обнуляю строку
        }
    }
        
string Readint(string messege)//метод
{
    Console.WriteLine(messege);
    return Convert.ToString(Console.ReadLine());
}
