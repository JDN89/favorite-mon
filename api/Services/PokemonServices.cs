using PokeApiNet;

namespace api.Services;

// resource : https://github.dev/Schinwinkwinsky/Pokedex/blob/master/src/Pokedex.Maui/MauiProgram.cs
// https://www.nuget.org/packages/PokeApiNet

public class PokemonServices:IPokemonService
{
    public async Task<PokemonSprites> GetPokemon(int id)
    {
        using var client = new PokeApiClient();
        var pokemon = await client.GetResourceAsync<Pokemon>(id);

        return pokemon.Sprites;
    }
    
}