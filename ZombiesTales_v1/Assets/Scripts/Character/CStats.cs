using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewStat", menuName = "Character/Stat")]
public class CStats : ScriptableObject{

    //Vida
    public int PV;
    public int movimiento; //Cantidad de casillas que puede moverse.

    //Tipos de daño.
    //----------------------------------------------------------------//
    public int Fuerza; // La fuerza es la cantidad de daño físico que se puede hacer.
    public int Magia; // La magia es la cantidad de daño no físico que se puede infligir a una unidad.

    public int Defensa; // Reducir el daño causado por las armas.
    public int ResistenciaMagica; // Reducir el daño causados por las magias.


    /* DAÑO
     * 
            TOTAL DAÑO FISICO  = Fuerza + [(Poder del arma + Bono del triangulo de arma) x2 si es efectivo clase ] + Bono de apoyo.
            TOTAL DAÑO MÁGICO  = Magia  + [(Poder del arma + Bono del triangulo de arma) x2 si es efectivo clase ] + Bono de apoyo.

            DAÑO FISICO QUE PUEDES CAUSAR AL ENEMIGO = TOTAL DAÑO FISICO - (Defensa Enemigo + Bonos de terreno + Bono de apoyo) x3 si CRITICO.
            DAÑO MÁGICO QUE PUEDES CAUSAR AL ENEMIGO = TOTAL DAÑO MÁGICO - (Resistencia Enemigo + Bonos de terreno + Bono de apoyo) x3 si CRITICO.

            % PROBABILIDAD DE CRÍTICO = (Habilidad/2) + Critico del arma + Bono de apoyo + Bono de clase + Bono de rango S.

            % PROBABILIDAD DE HACER UN CRITICO AL ENEMIGO = PROBABILIDAD DE CRITICO - Evasión de criticos enemigo.

         
     */


    /// -----------------------------------------------------------------------------------------------------------------
    public int Habilidad; // % de precisión en los golpes
    public int Velociad; //Velocidad de la unidad
    public int Suerte; // Suerte de la unidad
    public int Constitucion;

    /* 
                  
     % PRECISIÓN TOTAL AL GOLPEAR =  (Hab. x2) + (Suerte) + Golpe del arma + Bono del triángulo de armas + Bono de rango S + Bonos del estratega + Bono de apoyo.
     % DE EVASIÓN = (Velocidad de ataque x2) + Suerte + Bonos de terreno + Bonos de estratega + Bonos de apoyo.

     % PRECISIÓN TOTAL AL GOLPEAR AL ENEMIGO = % PRECISIÓN TOTAL AL GOLPEAR - % DE EVASIÓN del enemigo.

     VELOCIDAD DE ATAQUE = Velocidad - (Peso de arma - Constitución)
     GOLPES DOBLES = Si (VELOCIDAD DE ATAQUE - VELOCIDAD DE ATAQUE ENEMIGO) > 4 HARAS DOBLE ATAKE, SI EL ARMA ES valor/brave >= 4.

     PORCENTAJE DE PRECISIÓN DE LOS BASTONES = (Magia x5) + 30 + Habilidad.
     PORCENTAJE DE EVASIÓN CONTRA BASTONES = (Resistencia x5) + (Cuadros de distancia del enemigo x2).
     PROBABILIDAD DE EVADIR UN CRITICO: Suerte + Bonos de evasión critico del estratega + Bono apoyo;


        //////////////////////////// BONOS ////////////////////////
        ///

        Rango de arma S: + 5 en golpe y posibilidades de hacer critico.
        Terreno: Dependen del terreno en el que se combate.
        Bonos de estratega:  Si la undiad tiene la misma afinidad que el estratega obtiene entre 0 y 9 extra en % de golpear y evasión.
        Bonos de evasión de critico del estratega: 0 a 9% a todas las unidades.
        Objetos: Dan bonos para ciertas cosas.

        Bono de clases: espadachines y berserkers +15% de hacer critico.
        Armas efectivas: X2 en su poder en armas efectivas antes ciertas clases.
        Triangulo de armas: En golpe: +30, +15, +0, -15, -30. En daño: +2, +1, +0, -1, -2. 
        Bono de apoyo: Conversaciones de apoyo.

        TRIANGULO DE ARMAS:

        Espadas > Hachas > Lanzas > Espadas
        Luz > Oscuridad > Magia de la naturaleza > Luz

        Bonos de daño: Si es fuerte contra otra, la fuerte +1 la debil -1;
        Bonos de golpe: Si es fuerte contra la otra, la fuerte +15% de probabilidad de golpeo. y la debil -15%.

        ARMAS QUE ROMPEN EL TRIANGULO***
        - Antilanza, Antiespadas, Machacaesbirros, Antihachas.
                   
        //// RANGOS DE ARMA
        ///

    Rango E, D, C, B, A, S.

    30-40-50-60(Si no está promocionada es el maximo.) - 70 (Promocionado, sólo en un arma).
    
    Son necesarios para usar armas de mayor nivel. 
    Los puntos se obtienen al atacar, dependiendo del arma.
    MATAR = X2
    Se ganan puntos aunque no hagas daño.
    Obtienes puntos al promocionar dependiendo de la clase.
    No se ganan puntos si el arma se rompe o si atacas con espada magica a distancia.



    ///ESTADOS DE PERSONAJES
    ///

    Envenenado: Recibe entre 1 y 3 puntos de daño al inicio de cada turno.
    Dormido: No puede habalr ni moverse, pero puede esquivar.
    Loco: Ataca a cualquier aliado o enemigo, pero solo al que le hagan mas daño.
    Silenciado: No puede usar magias o bastones.

    nota_ Todos duran 5 turnos y toda unidad en un trono se  puede recuperar de estos estados. No es popsible mas de un estado a la vez. 


    /////// OTRAS NOTAS
    ///

    Rescatar unidades: Solo unidades con tu misma o menor constitución. Al rescatar, se reduce la habilidad y velocidad del que rescata a la mitad.
    Espadas magicas...

    Robar (Ladrones): Si la velocidad del ladrón es mayor o igual a la del enemigo puedes robar sus objetos, armas no. Solo 1 cada vez y necesitas espacio en el inventario.
    Asesinos (Matar de un golpe): Procentaje es la mitad de su critico. No contra bosses.



    RANDOMS: 2 RANDOM NUMERS PARA LA PROBABILIDAD DE GOLPEAR
    1 RANDOM DESPUES PARA EL CRITICO.
    */

}
