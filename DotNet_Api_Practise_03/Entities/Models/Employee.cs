namespace DotNet_Api_Practise_03.Entities.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email {  get; set; }
        public required string Phone { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
