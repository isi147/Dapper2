using ConsoleApp27;
using Dapper;
using System.Data.SqlClient;

var connectionString = "Data Source=STHQ0126-01;Initial Catalog=StepDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;";

using var connection = new SqlConnection(connectionString);

//var sqlCommand = "INSERT INTO Students(FirstName,LastName,GroupId) VALUES('Waxta','Baba',2)";
//var sqlCommand = "INSERT INTO Students(FirstName,LastName,GroupId) VALUES(@FirstName,@LastName,@GroupId)";

//Console.Write("Name:");
//string? name = Console.ReadLine();
//Console.Write("Surname:");
//string? surname = Console.ReadLine();
//Console.Write("GroupId:");
//string? groupId = Console.ReadLine();



//var paramaters = new
//{
//    FirstName = name,
//    LastName = surname,
//    GroupId = groupId
//};

//connection.Execute(sqlCommand, paramaters);




//var sqlCommand = "UPDATE Students SET FirstName = 'Kamil' WHERE Id = 1";
//connection.Execute(sqlCommand);



//var sqlCommand = "DELETE Students WHERE Id = 3";
//connection.Execute(sqlCommand);


//var sqlCommand = "UPDATE Students SET GroupId = 1 WHERE Id = 1";
//connection.Execute(sqlCommand);



//var sqlCommand = "SELECT *FROM Students";

//var students = connection.Query<Student>(sqlCommand).ToList();

//students.ForEach(student => { Console.WriteLine(student); });

//Student 
//    //elave etme
//    //student silme 
//    //getById
//    //getAll
//    //update


//var sqlCommand = "EXEC DeletStudent 6";


//connection.ExecuteScalar(sqlCommand);



//var sqlCommand = @"SELECT Students.FirstName,Students.LastName,Students.Score,Groups.GroupName
//    FROM Students 
//    INNER JOIN Groups ON Students.GroupId = Groups.Id";

//var studentsInfo = connection.Query<StudentGroups>(sqlCommand).ToList();

//studentsInfo.ForEach(student => { Console.WriteLine(student); });



//var sqlCommand = @"SELECT Students.FirstName,Students.LastName,Students.Score,Groups.GroupName
//    FROM Students 
//    INNER JOIN Groups ON Students.GroupId = Groups.Id WHERE Groups.GroupName = 'RNQ-94'";

////var student = connection.QueryFirst<StudentGroups>(sqlCommand);
////var student = connection.QueryFirstOrDefault<StudentGroups>(sqlCommand);
//var student = connection.QuerySingleOrDefault<StudentGroups>(sqlCommand);

//Console.WriteLine(student);