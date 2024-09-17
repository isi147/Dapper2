namespace ConsoleApp27;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int GroupId { get; set; }

    public override string ToString()
    {
        return $"Id {Id}\nFirstName{FirstName}\nLastName\nGroupId{GroupId}";
    }

}
