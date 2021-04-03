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
        public string NumeroFormatado { get { return $"{CodigoPais.ToString().PadLeft(2, '0')}{CodigoEstado.ToString().PadLeft(2, '0')}{Numero.ToString().PadLeft(9, '0')}"; } }
    }
}