namespace MVC2024.Models
{
    public class SerieModelo
    {
        public int Id { get; set; }
        public string NomSerie { get; set; }
        public SerieModelo Serie { get; set; }
        public int SerieId { get; set; }
    }
}