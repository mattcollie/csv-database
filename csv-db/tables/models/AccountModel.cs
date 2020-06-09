namespace csv_db.tables.interfaces
{
    public class AccountModel : IModel
    {
        public string Id { get; set; }
        public string Username { get; set; } 
        public string Password { get; set; }
        public int Balance { get; set; }
        public string CreditCard { get; set; }
    }
}