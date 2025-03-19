public class EmployeeWriter {
    public required string DirPath { get; set; }

    public void Write(Employee employee) {
        Directory.CreateDirectory(this.DirPath);

        Directory.SetCurrentDirectory(this.DirPath);

        string fileName = $"{employee.Id}.txt";
        string content = @$"Selected Employee:
ID: {employee.Id}
Full Name: {employee.FullName}
Anual Salary: {employee.AnualSalary}
";
        File.WriteAllText(fileName, content);
        Directory.SetCurrentDirectory("..");
    }

    public void WriteAll(List<Employee> employees) {
        foreach (Employee employee in employees) {
            this.Write(employee);
        }
    }




}