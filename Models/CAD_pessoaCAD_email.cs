using System.ComponentModel.DataAnnotations;

namespace ENPS.Models
{
    public class CAD_pessoaCAD_email
    {
        public int CAD_pessoaId { get; set; }
        public CAD_pessoa cAD_pessoa { get; set; }
        public int CAD_emailId { get; set; }
        public CAD_email CAD_email { get; set;}
    }
}