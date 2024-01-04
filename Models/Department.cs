namespace Phase2EndProject.Models
{
    public class Department
    {
        public int DeptCode { get; set; }

        public string DeptName { get; set; } = null!;
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
