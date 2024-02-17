namespace LibruaryApi.ModelsAll.Models
{
    public class BookModel
    {
        public int book_id { get; set; }
        public string book_name { get; set; }
        public string about { get; set;}
        public int price { get; set; }
        public int department_id { get; set; }
        public int shelf_id { get; set; }
        public int shelf_floor_id { get; set; }
        public int shelf_floor_serios_id { get; set; }
    }
}
