using ENPS.DTOs;
using FluentValidation;

namespace ENPS.Validadores
{
    public class CAD_usuarioValidador : AbstractValidator<CAD_usuarioDTO>
    {
        public CAD_usuarioValidador()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().WithMessage(x => $"{nameof(CAD_usuarioDTO.Nome)} inválido.");
            RuleFor(x => x.Senha).NotNull().NotEmpty().WithMessage(x =>  $"{nameof(CAD_usuarioDTO.Senha)} inválida.");
        }
    }
}