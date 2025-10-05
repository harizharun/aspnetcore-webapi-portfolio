namespace UserManagementApi.Models
{
    public class User
    {
       public int id {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string EmailConfirmed { get; set; }
       public string Age {  get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

    }
}
