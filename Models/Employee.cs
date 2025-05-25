namespace Basics.Models

{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }=String.Empty;
        public string Lastname { get; set; }=String.Empty;
        public string Fullname => $"{Firstname} {Lastname.ToUpper()}";
        public int Age { get; set; }
    }
}