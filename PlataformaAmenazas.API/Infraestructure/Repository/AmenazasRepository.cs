using PlataformaAmenazas.API.Domain.Entities;

namespace PlataformaAmenazas.API.Infraestructure.Repository
{
    public class AmenazasRepository
    {
        private PlataformaContext _context;

        public AmenazasRepository( PlataformaContext context )
        {
            _context = context;
        }

        public List<Amenazas> GetAllAmenazas()
        {
            return this._context.Amenazas.ToList();
        }
        public List<Ataques> GetAllAtaques()
        {
            return this._context.Ataques.ToList();
        }
        public List<Vulnerabilidades> GetAllVulnerabilidades()
        {
            return this._context.Vulnerabilidades.ToList();
        }
        public List<Intrusiones> GetAllIntrusiones()
        {
            return this._context.Intrusiones.ToList();
        }
    }
}
