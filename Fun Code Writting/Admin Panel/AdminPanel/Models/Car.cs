namespace AdminPanel.Models
{
    public class Car
    {
        public string url;
        public string name;
        public int price;
        public string hours;

        public Car(string urlP, string nameP, int priceP)
        {
            this.url = urlP;
            this.name = nameP;
            this.price = priceP;
        }

        public Car()
        {

        }
    }
}
