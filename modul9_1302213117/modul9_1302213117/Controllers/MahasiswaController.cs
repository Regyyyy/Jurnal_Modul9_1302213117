using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul9_1302213117.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {

        static List<Mahasiswa> dataUsers = new List<Mahasiswa>
        {
            new Mahasiswa("Iqro Banyuanto","1302213061", new List<string>() {"KPL","BD","PBO"},2019),
            new Mahasiswa("Rahma Sakti Rahardian","1302210095", new List<string>() {"KPL","BD","PBO"},2019),
            new Mahasiswa("Regy Renanda Rahman","1302213117", new List<string>() {"KPL","BD","PBO"},2019)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataUsers;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa newMhs)
        {
            dataUsers.Add(newMhs);
        }

        [HttpGet("(id)")]
        public Mahasiswa Get(int id)
        {
            return dataUsers[id];
        }

        [HttpDelete("(id)")]
        public void Delete(int id)
        {
            dataUsers.RemoveAt(id);
        }
    }
}
