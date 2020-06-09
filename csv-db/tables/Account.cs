using csv_db.tables.interfaces;

namespace csv_db.tables
{
    public class Account : TableBase<AccountModel>
    {
        internal string TABLE_NAME = "Accounts";
    }
}