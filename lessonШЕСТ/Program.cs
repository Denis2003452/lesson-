namespace lessonШЕСТ
{
    internal class Program
    {
        static void Main()
        {
            
        }
    }
   public class Person
    {
        public string Name { get; }     
                      
       
        public int Age { get; }

        public int Salary;

        public Person (string name, int age, int salary )
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        
    }
    public class Scientist : Person
    {
       
        public Scientist(string name, int age, int salary, string academicdegree) : base(name, age, salary)
        {
            AcademicDegree = academicdegree;
        }

        public string AcademicDegree { get; }
        
            

        public void WriteCharacteristics(Scientist person)
        {
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Salary);
            Console.WriteLine(person.AcademicDegree);
        }
        
    }
}