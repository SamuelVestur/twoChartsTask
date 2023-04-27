using System.ComponentModel.DataAnnotations;

namespace twoChartsTask.Models
{

    //Nastavenie GET A SET (accessor metódy) 
    // Každá jedna inštancia tejto triedy predstavuje informácie o jendom predanom automobile 
    public class salesEntity
    {
        [Key]
        public int cars_id { get; set; }

        public string car_brand { get; set; }

        public string car_model { get; set;}

        public string car_bodyType { get; set;}

        public string car_color { get; set;}

        public DateTime car_dateOfSale { get; set;}

        public int car_price { get; set;}

        public string car_country { get; set;}

    }
}
