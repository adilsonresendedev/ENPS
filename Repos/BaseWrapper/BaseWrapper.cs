using System.Threading.Tasks;
using ENPS.Data;
using ENPS.Repositorios.CAD_empresaRepos;
using ENPS.Repositorios.CAD_enderecoRepos;
using ENPS.Repositorios.CAD_pessoaRepos;
using ENPS.Repositorios.CAD_redeSocialRepos;
using ENPS.Repositorios.CAD_telefoneRepos;
using ENPS.Repositorios.CAD_usuarioRepos;
using ENPS.Repositorios.COF_cidadeRepos;
using ENPS.Repositorios.COF_estadoRepos;
using ENPS.Repositorios.INPS_pesquisaRepositorio;
using ENPS.Repositorios.NPS_pesquisaRepos;
using ENPS.Repositorios.NPS_votacaoRepos;

namespace ENPS.Repos.BaseWrapper
{
    public class BaseWrapper : IBaseWrapper
    {
        private DataContext _dataContext;
        private ICAD_empresaRepo _iCAD_empresaRepo;
        public ICAD_empresaRepo ICAD_empresaRepo
        {
            get
            {
                return _iCAD_empresaRepo ?? new CAD_empresaRepo(_dataContext);
            }
        }

        private ICAD_enderecoRepo _iCAD_enderecoRepo;
        public ICAD_enderecoRepo ICAD_enderecoRepo
        {
            get
            {
                return _iCAD_enderecoRepo ?? new CAD_enderecoRepo(_dataContext);
            }
        }

        private ICAD_pessoaRepo _iCAD_pessoaRepo;
        public ICAD_pessoaRepo ICAD_pessoaRepo
        {
            get
            {
                if (_iCAD_pessoaRepo == null)
                {
                    _iCAD_pessoaRepo = ICAD_pessoaRepo;
                }
                return _iCAD_pessoaRepo;
            }
        }

        private ICAD_redeSocialRepo _iCAD_redeSocialRepo;
        public ICAD_redeSocialRepo ICAD_redeSocialRepo
        {
            get
            {
                if (_iCAD_redeSocialRepo == null)
                {
                    _iCAD_redeSocialRepo = ICAD_redeSocialRepo;
                }
                return _iCAD_redeSocialRepo;
            }
        }

        private ICAD_telefoneRepo _iCAD_telefoneRepo;
        public ICAD_telefoneRepo ICAD_telefoneRepo
        {
            get
            {
                if (_iCAD_telefoneRepo == null)
                {
                    _iCAD_telefoneRepo = ICAD_telefoneRepo;
                }
                return _iCAD_telefoneRepo;
            }
        }


        private ICAD_usuarioRepo _iCAD_usuarioRepo;
        public ICAD_usuarioRepo ICAD_usuarioRepo
        {
            get
            {
                return _iCAD_usuarioRepo ?? new CAD_usuarioRepo(_dataContext);
            }
        }

        private ICOF_cidadeRepo _iCOF_cidadeRepo;
        public ICOF_cidadeRepo ICOF_cidadeRepo
        {
            get
            {
                if (_iCOF_cidadeRepo == null)
                {
                    _iCOF_cidadeRepo = ICOF_cidadeRepo;
                }
                return _iCOF_cidadeRepo;
            }
        }

        private ICOF_estadoRepo _iCOF_estadoRepo;
        public ICOF_estadoRepo ICOF_estadoRepo
        {
            get
            {
                if (_iCOF_estadoRepo == null)
                {
                    _iCOF_estadoRepo = ICOF_estadoRepo;
                }
                return _iCOF_estadoRepo;
            }
        }

        private ICOF_paisRepo _iCOF_paisRepo;
        public ICOF_paisRepo ICOF_paisRepo
        {
            get
            {
                if (_iCOF_paisRepo == null)
                {
                    _iCOF_paisRepo = ICOF_paisRepo;
                }
                return _iCOF_paisRepo;
            }
        }

        private INPS_pesquisaRepo _iNPS_pesquisaRepo;
        public INPS_pesquisaRepo INPS_pesquisaRepo
        {
            get
            {
                if (_iNPS_pesquisaRepo == null)
                {
                    _iNPS_pesquisaRepo = INPS_pesquisaRepo;
                }
                return _iNPS_pesquisaRepo;
            }
        }

        private INPS_votacaoRepo _iNPS_votacaoRepo;
        public INPS_votacaoRepo INPS_votacaoRepo
        {
            get
            {
                if (_iNPS_votacaoRepo == null)
                {
                    _iNPS_votacaoRepo = INPS_votacaoRepo;
                }
                return _iNPS_votacaoRepo;
            }
        }

        public Task Save()
        {
            throw new System.NotImplementedException();
        }
    }
}