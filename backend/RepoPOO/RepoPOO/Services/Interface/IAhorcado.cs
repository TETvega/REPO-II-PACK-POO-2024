using RepoPOO.Dto;
using RepoPOO.Dto.common;

namespace RepoPOO.Services.Interface
{
    public interface IAhorcado
    {
        Task<ResponseDto<palabraDTO>> GetRandomWordAsync();
    }
}
