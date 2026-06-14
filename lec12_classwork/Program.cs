using System.Runtime.ConstrainedExecution;

namespace lec12_classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../data.txt";
            string[] lines = File.ReadAllLines(path);

            Student[] students = new Student[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');

                students[i] = new Student(
                    firstName: parts[0].Trim(),
                    lastName: parts[1].Trim(),
                    age: int.Parse(parts[2].Trim()),
                    email: parts[3].Trim(),
                    phone: parts[4].Trim(),
                    point: int.Parse(parts[5].Trim())
                );
            }

            Student.SetStudentArray(students);
            Student container = new Student();

            // every student (IEnumerable)
            foreach (Student s in container)
                Console.WriteLine(s);
            Console.WriteLine();

            // lowest point
            Console.WriteLine($"min point: {Student.FindMinPoint(students)}\n");

            // oldest
            Console.WriteLine($"oldest: {Student.FindOldest(students)}\n");

            // average point
            Console.WriteLine($"average: {Student.AveragePoint(students)}\n");

            // sort (Bubble Sort)
            Student[] sorted = Student.SortByPoint(students);
            for (int i = 0; i < sorted.Length; i++)
                Console.WriteLine($"  {i + 1}. {sorted[i]}");
        }
    }
}
