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




double CalculateAverageGrade(int[] grades) {
    int sum = 0;
    foreach (int grade in grades) {
        sum += grade;
    }
    return (double)sum / grades.Length;
}
int count1 = 0;
int CountFives(int[] grades) {
    foreach (int grade in grades) {
        if (grade == 5) {
            count1++;
        }
    }
    return count1;
}

int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
int fives = CountFives(grades);
Console.WriteLine(average);
Console.WriteLine(fives);

