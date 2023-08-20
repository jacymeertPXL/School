package be.pxl.h4.oefening_02;

public class pokedex {
    private Pokemon[] pokemons = new Pokemon[];

    public int pokedex(int aantalPokemon){
        for (Pokemon pokemon : pokemons){
            aantalPokemon++;
        }
        return aantalPokemon;
    }

    public Pokemon[] getPokemons() {
        return pokemons;
    }

    public boolean bevat(String naam){
        boolean bevat = true;
        for (Pokemon pokemon : pokemons) {
            if (naam.equals(pokemon.toString())) {
                bevat = true;
            } else {
                bevat = false;
            }
        }
        return bevat;
    }

    public void voegToe(){
    }

    @Override
    public String toString() {
        StringBuilder stringBuilder = new StringBuilder();
        for (Pokemon pokemon : pokemons) {
            stringBuilder.append(pokemon.getNaam()).append("(").append(pokemon.getType()).append(")").append("\n");
        }
        return stringBuilder.toString();
    }

}
