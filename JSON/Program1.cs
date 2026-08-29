using Newtonsoft.Json;

var student = new
{
    name = "Rahul",
    age = 21,
    subjects = new[] { "C#", "SQL", "ASP.NET" }
};

string json = JsonConvert.SerializeObject(student, Formatting.Indented);

Console.WriteLine(json);
