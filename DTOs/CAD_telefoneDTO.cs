namespace ENPS.DTOs
{
    public class CAD_telefoneDTO
    {
        public long Id { get; set; }
        public bool Ativo { get; set; }
        public bool Princial { get; set; }
        public int CodigoPais { get; set; }
        public int CodigoEstado { get; set; }
        public int Numero { get; set; }
        public string NumeroFormatado { get { return $"{CodigoPais:00}{CodigoEstado:00}{Numero:000000000)}"; } }
    }
}