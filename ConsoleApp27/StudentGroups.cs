namespace ConsoleApp27;

public class StudentGroups
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public float Score { get; set; }
    public string GroupName { get; set; }

    public override string ToString()
    {
        return $"First Name: {FirstName}  - Last Name: {LastName}  - Score: {Score} -Group Name: {GroupName}\n";
    }
}
