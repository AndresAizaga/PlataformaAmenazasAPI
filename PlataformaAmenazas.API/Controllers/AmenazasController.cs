using Microsoft.AspNetCore.Mvc;
using PlataformaAmenazas.API.Controllers.DTO;
using PlataformaAmenazas.API.Infraestructure;
using PlataformaAmenazas.API.Infraestructure.Repository;
using System.Text;
using System.Threading;

namespace PlataformaAmenazas.API.Controllers
{
    [ApiController]
    [Route("PlataformaAmenazas")]
    public class AmenazasController : ControllerBase
    {
        private readonly ILogger<AmenazasController> _logger;
        private readonly PlataformaContext db; 

        public AmenazasController(PlataformaContext _db)
        {
            this.db = _db;
        }

        [HttpGet]
        [Route("AmenazasMasActivas")]
        public IActionResult GetAmenazas()
        {
            var repo = new AmenazasRepository(db);
            var result = repo.GetAllAmenazas();

            var summary = result
            .OrderByDescending(t => t.cantidad)
            .Take(6)
            .Select(x => new AmenazasDTO { amenaza = x.amenaza, cantidad = x.cantidad })
            .ToList();

            return Ok(summary.OrderBy(x => x.amenaza));
        }

        [HttpGet]
        [Route("AmenazasMasActivas/{cant}")]
        public IActionResult GetAmenazas(int cant)
        {
            var repo = new AmenazasRepository(db);
            var result = repo.GetAllAmenazas();

            var summary = result
            .OrderByDescending(t => t.cantidad)
            .Take(cant)
            .ToList();

            return Ok(summary.OrderBy(x => x.amenaza));
        }

        [HttpGet]
        [Route("VulnerabilidadesMasActivas")]
        public IActionResult GetVulnerabilidades()
        {
            var repo = new AmenazasRepository(db);
            var result = repo.GetAllVulnerabilidades();

            var summary = result
            .OrderByDescending(t => t.cantidad)
            .Take(6)
            .Select(x => new VulnerabilidadesDTO { vulnerabilidad = x.vulnerabilidad, cantidad = x.cantidad })
            .ToList();

            return Ok(summary.OrderBy(x => x.vulnerabilidad));
        }

        [HttpGet]
        [Route("VulnerabilidadesMasActivas/{cant}")]
        public IActionResult GetVulnerabilidades(int cant)
        {
            var repo = new AmenazasRepository(db);
            var result = repo.GetAllVulnerabilidades();

            var summary = result
            .OrderByDescending(t => t.cantidad)
            .Take(cant)
            .ToList();

            return Ok(summary.OrderBy(x => x.vulnerabilidad));
        }

        [HttpGet]
        [Route("IntrusionesIdentificadas")]
        public IActionResult IntrusionesIdentificadas()
        {
            var repo = new AmenazasRepository(db);
            var result = repo.GetAllIntrusiones();

            var summary = result
            .OrderBy(t => t.intrusion)
            //.Select(x => new IntrusionesDTO { intrusion = x.intrusion, cantidad = x.cantidad })
            .Take(6)
            .ToList();

            return Ok(summary);
        }

        [HttpGet]
        [Route("AtaquesRecibidos")]
        public IActionResult AtaquesRecibidos()
        {
            var repo = new AmenazasRepository(db);
            var result = repo.GetAllAtaques();

            var summary = result
            .OrderBy(t => t.ataque)
            //.Select(x => new AtaquesDTO { ataque = x.ataque, cantidad = x.cantidad })
            .Take(6)
            .ToList();

            return Ok(summary);
        }

        [HttpGet]
        [Route("ActualizarAPIsOpenCTI")]
        public IActionResult ActualizarAPIsOpenCTI()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("APIs actualizadas exitosamente");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/threats");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/incidents");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/geo");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/traffic");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/vulnerabilities");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/reports");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/behavior");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/access");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/intrusions");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/events");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/logs");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/suspicious_activity");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/malicious_activity");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/network_traffic");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/threat_detection");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/vuln_analysis");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/app_security");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/network_security");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/continuous_monitoring");
            stringBuilder.AppendLine("https://api.integrations.v1.opencti.io/risk_analysis");
            return Ok(stringBuilder.ToString());
        }
    }
}
