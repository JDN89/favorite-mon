using api.Models;
using PokeApiNet;

namespace api.Services;

public interface IPokemonService
{

     Task<GetPokemonByIDDto> GetPokemon(int id);
}