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
        public ICAD_empresaRepo iCAD_empresaRepo
        {
            get
            {
                return _iCAD_empresaRepo ?? new CAD_empresaRepo(_dataContext);
            }
        }

        private ICAD_enderecoRepo _iCAD_enderecoRepo;
        public ICAD_enderecoRepo iCAD_enderecoRepo
        {
            get
            {
                if (_iCAD_enderecoRepo == null)
                {
                    _iCAD_enderecoRepo = iCAD_enderecoRepo;
                }
                return _iCAD_enderecoRepo;
            }
        }

        private ICAD_pessoaRepo _iCAD_pessoaRepo;
        public ICAD_pessoaRepo iCAD_pessoaRepo
        {
            get
            {
                if (_iCAD_pessoaRepo == null)
                {
                    _iCAD_pessoaRepo = iCAD_pessoaRepo;
                }
                return _iCAD_pessoaRepo;
            }
        }

        private ICAD_redeSocialRepo _iCAD_redeSocialRepo;
        public ICAD_redeSocialRepo iCAD_redeSocialRepo
        {
            get
            {
                if (_iCAD_redeSocialRepo == null)
                {
                    _iCAD_redeSocialRepo = iCAD_redeSocialRepo;
                }
                return _iCAD_redeSocialRepo;
            }
        }

        private ICAD_telefoneRepo _iCAD_telefoneRepo;
        public ICAD_telefoneRepo iCAD_telefoneRepo
        {
            get
            {
                if (_iCAD_telefoneRepo == null)
                {
                    _iCAD_telefoneRepo = iCAD_telefoneRepo;
                }
                return _iCAD_telefoneRepo;
            }
        }


        private ICAD_usuarioRepo _iCAD_usuarioRepo;
        public ICAD_usuarioRepo iCAD_usuarioRepo
        {
            get
            {
                if (_iCAD_usuarioRepo == null)
                {
                    _iCAD_usuarioRepo = iCAD_usuarioRepo;
                }
                return _iCAD_usuarioRepo;
            }
        }

        private ICOF_cidadeRepo _iCOF_cidadeRepo;
        public ICOF_cidadeRepo iCOF_cidadeRepo
        {
            get
            {
                if (_iCOF_cidadeRepo == null)
                {
                    _iCOF_cidadeRepo = iCOF_cidadeRepo;
                }
                return _iCOF_cidadeRepo;
            }
        }

        private ICOF_estadoRepo _iCOF_estadoRepo;
        public ICOF_estadoRepo iCOF_estadoRepo
        {
            get
            {
                if (_iCOF_estadoRepo == null)
                {
                    _iCOF_estadoRepo = iCOF_estadoRepo;
                }
                return _iCOF_estadoRepo;
            }
        }

        private ICOF_paisRepo _iCOF_paisRepo;
        public ICOF_paisRepo iCOF_paisRepo
        {
            get
            {
                if (_iCOF_paisRepo == null)
                {
                    _iCOF_paisRepo = iCOF_paisRepo;
                }
                return _iCOF_paisRepo;
            }
        }

        private INPS_pesquisaRepo _iNPS_pesquisaRepo;
        public INPS_pesquisaRepo iNPS_pesquisaRepo
        {
            get
            {
                if (_iNPS_pesquisaRepo == null)
                {
                    _iNPS_pesquisaRepo = iNPS_pesquisaRepo;
                }
                return _iNPS_pesquisaRepo;
            }
        }

        private INPS_votacaoRepo _iNPS_votacaoRepo;
        public INPS_votacaoRepo iNPS_votacaoRepo
        {
            get
            {
                if (_iNPS_votacaoRepo == null)
                {
                    _iNPS_votacaoRepo = iNPS_votacaoRepo;
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