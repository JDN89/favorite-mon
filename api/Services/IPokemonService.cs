using PokeApiNet;

namespace api.Services;

public interface IPokemonService
{

     Task<PokemonSprites> GetPokemon(int id);
}