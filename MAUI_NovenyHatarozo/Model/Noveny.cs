using System.ComponentModel.DataAnnotations;

namespace MAUI_NovenyHatarozo.Model
{
    public partial class Noveny
    {
        [Key]
        public int Id { get; set; }
        
        public required string Nev { get; set; }
        //[ObservableProperty]
        //required string nev;

        /// <summary>
        /// literben kifejezett vízigény, pl. 1.5 liter
        /// </summary>
        public double Vizigeny { get; set; }
        public string? Kep { get; set; }
        public bool Orokzold { get; set; }
    }
}
