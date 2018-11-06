using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : ScriptableObject {


    public string charName;
    public string charDescription;

    public Sprite charMapSprite;
    public Sprite charCombatSprite;
    public Sprite charConverSprite;
   
    //Class of the character.
    public CClass c_class;

    //Current stats of the player.
    public CStats currentStats;


    






    //Character Actions during the turn

    //Es unb menu dinamico, aparecen opciones segun la situación actual del personaje.

    //Básicos
    public void Mover() {
    
    }

    public void Objetos() {
        //Ordenar, tirar, y usar objetos.
    }

    public void Esperar() {
        //Finalizar el turno del personaje.
    }

    public void Atacar() {

    }

    public void Curar() { //Unidades con bastones

    }

    public void Puerta() { //Ladrón / Asesino

    }

    public void Cofre() { //Ladrón / Asesino

    }

    public void Tocar() { //Trobador

    }

    public void Bailar() { //Bailarina

    }



    public void Tomar() { //Solo los lores.

    }


    //SUPPORTING ACTIONS
    public void Rescatar() {

    }

    public void Soltar() {

    }

    public void Recibir() {

    }

    public void Dar() {

    }


    //OBJECT ACTIONS
    public void Intercambiar() {

    }

    public void Mercader() {

    }

   



}
