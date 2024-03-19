

class Student {

    public string name { get; set; }
    public string lastName{get;set;}

   public Student (string name, string lastName)
    {
        this.name = name;
        this.lastName = lastName;
    }


    public void print() {
        Console.WriteLine($"Name: {name}, LastName: {lastName}");

    }
}

class OOP_First_Topsc_Classes {


    public static void Main(string[] args)
    {

        Student student = new Student("name", "LastName");

        student.print();


    
    
    }


}