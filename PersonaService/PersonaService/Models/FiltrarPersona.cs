namespace PersonaService.Models
{
    public class FiltrarPersona
    {
        public int nIdPers {  get; set; }
        public string cApePersona {  get; set; }
        public DateTime dFechaNacPersona { get; set; }
        public string nIdGenero {  get; set; }
        public string cDocumento { get; set; }
        public string cDireccionPersonal { get; set; }
        public string nIdZone {  get; set; }
        public string cDireccionTrabajo { get; set; }
        public string cCorreoPersona { get; set; }
        public string nIdEstadoCivil {  get; set; }
        public byte[] vFotoPersona {  get; set; }
    }
}
