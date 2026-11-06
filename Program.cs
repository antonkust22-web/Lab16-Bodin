// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Сколько студентов в группе");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];
// int sum = 0;


// for (int i = 0; i < grades.Length; i++)
// {
//     Console.WriteLine($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
//     sum = sum + grades[i];
// }

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// double average = (double)sum / studentsCount;
// Console.WriteLine($"Средний балл {average}");

int[] points = { 4, 7, 2, 10, 5 };

for (int i = 0; i < points.Length; i++)
{
    if (points[i] < 10)
    {
        points[i] = points[i] + 1;
    } 
    
}

foreach (int point in points)
{
    Console.WriteLine(point);
}