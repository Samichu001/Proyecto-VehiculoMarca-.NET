namespace MVC2024.Models
{
    public class VehiculoExtraModelo
    {
        public int ID { get; set; }
        public int extraID { get; set; }
        public ExtraModelo extra { get; set; }
        public int vehiculoID { get; set; }
        public VehiculoModelo vehiculo { get; set; }
    }
}
