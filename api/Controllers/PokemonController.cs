using System.Runtime.CompilerServices;
using api.Services;
using Microsoft.AspNetCore.Mvc;
using PokeApiNet;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class PokemonController: ControllerBase
{
    private readonly IPokemonService _pokeService;
    
    /* private readonly PokeApiClient _pokeApiClient;

    public PokemonController(PokeApiClient pokeApiClient)
    {
        _pokeApiClient = pokeApiClient;
    }
    */

    public PokemonController(IPokemonService pokeService)
    {
        _pokeService = pokeService;
    }

    [HttpGet]
    public async Task<PokemonSprites> GetPokemon()
    {
        return await _pokeService.GetPokemon(4);
        // return await pokeClient.GetResourceAsync<Pokemon>(pokemonId);

    }
    
}