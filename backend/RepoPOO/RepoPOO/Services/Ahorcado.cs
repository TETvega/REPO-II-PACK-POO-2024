using Newtonsoft.Json;
using RepoPOO.Dto;
using RepoPOO.Dto.common;
using RepoPOO.Services.Interface;

namespace RepoPOO.Services
{
    public class Ahorcado :IAhorcado
    {
        private readonly string _JSON_FILE;

        public Ahorcado()
        {
            _JSON_FILE = "SeedData/repositorio.json";
        }
        public async Task<ResponseDto<palabraDTO>> GetRandomWordAsync()
        {
            var tasks = await ReadTasksFromFileAsync(); // cargando el listado de todas las categorias
            var random =  new Random().Next(1,3);
            
            var task = tasks.FirstOrDefault(task => task.id == random);
            var libroarray = task.libro.ToArray().Count();
            var randomPosition = new Random().Next(1, libroarray);
            //randomPosition = 3;
            palabraDTO taskresult = new palabraDTO
            {
                categoria = task.categoria,
                id = task.id,
                libro = task.libro,
                random = randomPosition,

            };
            return new ResponseDto<palabraDTO>
            {
                StatusCode = 200,
                Status = true,
                Message = "Palabra extraida con exito",
                Data = taskresult,

            };
        }

        private async Task<List<palabraDTO>> ReadTasksFromFileAsync()
        {
            // no se utiliza por que aqui se resuelve si el archivo no existe la URL
            if (!File.Exists(_JSON_FILE))
            {
                return new List<palabraDTO>();
            }

            var json = await File.ReadAllTextAsync(_JSON_FILE);
            /// si el json no tiene el la structura de un listado de categorias nos dara un error 
            /// 
            var tasks = JsonConvert.DeserializeObject<List<palabraDTO>>(json);

            var dtos = tasks.Select(task => new palabraDTO
            {
                id = task.id,
                categoria = task.categoria,
                libro = task.libro,
            }).ToList();
            return dtos;
        }
    }
}
