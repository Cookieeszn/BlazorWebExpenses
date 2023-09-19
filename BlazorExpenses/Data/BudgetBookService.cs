namespace BlazorExpenses.Data
{
    public class BudgetBookService
	{
        private static List<Entry> dummyDB = new List<Entry>();

        public async Task<bool> AddEntry(Entry newEntry)
        {
            dummyDB.Add(newEntry);
            return true;
        }

        public async Task<List<Entry>> GetAllEntries()
        {
            return dummyDB;
        }
    }
}
