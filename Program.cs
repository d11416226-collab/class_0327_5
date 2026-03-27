namespace class_0327_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Student.StdCount());

            Student joe = new Student(1234, "AAA", 92, 88);
            Console.WriteLine(Student.StdCount());
           
            Student mary = new Student(1234, "AAA", 92, 88);
            Console.WriteLine(Student.StdCount());


            Console.WriteLine(joe.GetStudent());
        }
    }
}
