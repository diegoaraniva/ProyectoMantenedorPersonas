namespace PersonaService.Models
{
    public class AgregaPersona
    {
        public bool bActualiza { get; set; }
        public int nIdPersona { get; set; }
        public string cNomPersona { get; set; }
        public string cApePersona { get; set; }
        public DateTime dFechaNacPersona { get; set; }
        public int nIdGenero { get; set; }
        public string cDocumento { get; set; }
        public string cDireccionPersonal { get; set; }
        public int nIdZone { get; set; }
        public string cDireccionTrabajo { get; set; }
        public string cCorreoPersona { get; set; }
        public int nIdEstadoCivil { get; set; }
        public byte[] vFotoPersona { get; set; }
    }
}
