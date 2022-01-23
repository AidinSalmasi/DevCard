namespace DevCard_MVC.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Service(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
