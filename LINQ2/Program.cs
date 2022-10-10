class Student
{
    public string First { get; set; }
    public string Last { get; set; }
    public int ID { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public List<int> Scores;
}
class Teacher
{
    public string First { get; set; }
    public string Last { get; set; }
    public int ID { get; set; }
    public string City { get; set; }
}


class DataTransformations
{
    static void Main()
    {
        // Create the first data source.
        List<Student> students = new List<Student>()
        {
            new Student { First="Svetlana",
                Last="Omelchenko",
                ID=111,
                Street="123 Main Street",
                City="Seattle",
                Scores= new List<int> { 97, 92, 81, 60 } },
            new Student { First="Claire",
                Last="O’Donnell",
                ID=112,
                Street="124 Main Street",
                City="Redmond",
                Scores= new List<int> { 75, 84, 91, 39 } },
            new Student { First="Sven",
                Last="Mortensen",
                ID=113,
                Street="125 Main Street",
                City="Lake City",
                Scores= new List<int> { 88, 94, 65, 91 } },
        };
        var tmp = from student in students where student.Scores.Average() > 80 select student;
        foreach (var student in tmp)
        {
            Console.WriteLine(student.First);
        }


        ////Skriv en query som skriver ut alla elevers förnamn i ascending order.
        //IEnumerable<string> nameAscending = from student in students
        //                                    orderby
        //           student.First ascending
        //                                    select student.First;
        //foreach (string name in nameAscending)
        //{
        //    Console.WriteLine(name);
        //}
        //students.OrderBy(x => x.First).ToList().ForEach(x => Console.WriteLine(x.First));
        ////Skriv en query som skriver ut alla elevers förnamn i descending order.
        //IEnumerable<string> nameDescending = from student in students
        //                                     orderby student.First
        //            descending
        //                                     select student.First;
        //foreach (string name in nameDescending)
        //{
        //    Console.WriteLine(name);
        //}

        ////Skriv en query som skriver ut alla studenter med ett betyg under 50.
        //var studentsWithScoreUnder50 = from student in students where student.Scores.Any(x => x < 50) select student.Last;
        //foreach (var s in studentsWithScoreUnder50)
        //{
        //    Console.WriteLine(s);
        //}
        //var students2WithScoreUnder50 = from student in students where student.Scores.Min() < 50 select student.Last;
        //foreach (var s in students2WithScoreUnder50)
        //{
        //    Console.WriteLine(s);
        //}
        //students.Where(student => student.Scores.Any(x => x < 50)).ToList().ForEach(x => Console.WriteLine(x.Last));
        ////Skriv en query som skriver ut alla studenter med ett efternamn som börjar på “O”.
        //IEnumerable<string> studentsSatrtingWithO = from student in students where student.Last[0] == 'O' select student.Last;
        //foreach (string s in studentsSatrtingWithO)
        //{
        //    Console.WriteLine(s);
        //}
        //students.Where(x => x.Last[0] == 'O').ToList().ForEach(student => Console.WriteLine(student.Last));
        // Create the second data source.
        List < Teacher > teachers = new List<Teacher>()
        {
            new Teacher { First="Ann", Last="Beebe", ID=945, City="Seattle" },
            new Teacher { First="Alex", Last="Robinson", ID=956, City="Redmond" },
            new Teacher { First="Michiyo", Last="Sato", ID=972, City="Tacoma" }
        };

        // Create the query.
        var peopleInSeattle = (from student in students
                               where student.City == "Seattle"
                               select student.Last)
                    .Concat(from teacher in teachers
                            where teacher.City == "Seattle"
                            select teacher.Last);

        Console.WriteLine("The following students and teachers live in Seattle:");
        // Execute the query.
        foreach (var person in peopleInSeattle)
        {
            Console.WriteLine(person);
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
/* Output:
    The following students and teachers live in Seattle:
    Omelchenko
    Beebe
 */