namespace hw6t
{
    internal class Store
    {
        public Item[] items;
        public int count;
        public DBConnection db;

        public Store()
        {
            this.items = new Item[0];
            this.count = 0;
            this.db = new DBConnection();
        }

        public void AddItem(Item item)
        {
            db.AddItemToDB(item);
            Console.WriteLine("1 new item added!");
        }

        public override string ToString()
        {
            return db.ReadItemTable();
        }
    }
}