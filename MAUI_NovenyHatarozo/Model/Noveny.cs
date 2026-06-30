namespace MAUI_NovenyHatarozo.Model
{
    public class Noveny
    {
        public required string Nev { get; set; }

        /// <summary>
        /// literben kifejezett vízigény, pl. 1.5 liter
        /// </summary>
        public double Vizigeny { get; set; }
        public string? Kep { get; set; }
        public bool Orokzold { get; set; }
    }
}
