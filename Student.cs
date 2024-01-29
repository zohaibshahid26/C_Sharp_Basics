
class Student
{
    private string name;
    private int age;
    private int grade;
    private string comment;
    public Student()
    {
        name = "John Doe";
        age = 0;
        grade = 0;
        comment = "No comment";
    }
 
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = Name;
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = Age;
        }
    }
    public int Grade
    {
        get
        {
            return grade;
        }
        set
        {
            grade = Grade;
        }
    }
    public string Comment
    {
        get
        {
            return comment;
        }
        set
        {
            comment = Comment;
        }
    }
  

    public override string ToString()
    {
        return $"{Name} is {Age} years old. {Name} is in grade {Grade}. {Name}'s teacher says \"{Comment}\"";
    }
}
