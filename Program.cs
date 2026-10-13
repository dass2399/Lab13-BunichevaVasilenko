// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader() {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("0_0");
//     Console.WriteLine("Дата формирования отчета: 10.12.2009");
// }

// void PrintFooter() {
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("X_X");
// }


// void PrintStudentCard(string name, int age, string group) {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, группа {group}");
// }

// PrintStudentCard("Егор", 18, "ИСП242");
// PrintStudentCard("Валерия", 17, "ЮСП252");


// double CalculateSholarship(double baseAmount, double bonusPercent) {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool IsEligibleForBonus(double averageGrade) {
//     return averageGrade >= 4.5;
// }

// double average = 4.7;
// double result;

// if (IsEligibleForBonus(average)) {
//     result = CalculateSholarship(2000, 15);
// } else {
//     result = CalculateSholarship(2000, 0);
// }

// Console.WriteLine(result);




// double CalculateAverageGrade(int[] grades) {
//     int sum = 0;
//     foreach (int grade in grades) {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }
// int count1 = 0;
// int CountFives(int[] grades) {
//     foreach (int grade in grades) {
//         if (grade == 5) {
//             count1++;
//         }
//     }
//     return count1;
// }

// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// int fives = CountFives(grades);
// Console.WriteLine(average);
// Console.WriteLine(fives);





//самостоятельные задания 
//задача А
// void PrintDivider() {
//     Console.WriteLine("-------------------");
// }

// Console.WriteLine("пппп");
// PrintDivider();
// Console.WriteLine("ffff");
// PrintDivider();

//Задача Б
// void PrintPerson(string name, int age) {
//     Console.WriteLine($"Имя: {name}, возраст: {age}");
// }

// PrintPerson("Вася", 15);
// PrintPerson("Вика", 65);
// PrintPerson("Люда", 95);

//Задача В
// int numb = 8;
// bool IsEven(int number) {
//     return number % 2 == 0;
// }

// if (IsEven(numb)) {
//     Console.WriteLine("Четное");
// }
// else {
//     Console.WriteLine("Нечетное");
// }

//Задача Г

// int[] grades = { 12, 34, 56, 2, 1 };
// int maxx = 0;
// int FindMax(int[] numbers) {
//     foreach (int grade in grades) {
//         if (grade > maxx) {
//             maxx = grade;
//         }
//     }
//     return maxx;
// }

// int maxGrade = FindMax(grades);
// Console.WriteLine(maxGrade);



// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
// if (string.IsNullOrEmpty(surname)) { 
// Console.WriteLine("Фамилия не введена. Завершение работы."); 
// return; 
// } 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
// var assigned = Enumerable.Range(1, 10) 
// .OrderBy(_ => rnd.Next()) 
// .Take(2) 
// .OrderBy(x => x) 
// .ToList(); 
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// double CalculateBmi(double weight, double heightMeters) {
//     return weight / (heightMeters *  heightMeters);
// }

// Console.WriteLine(CalculateBmi(2.1, 1.33));


// double CelsiusToFahrenheit(double celsius) {
//     return celsius * 9 / 5 + 32;
// }

// Console.WriteLine(CelsiusToFahrenheit(33.1));