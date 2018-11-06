using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CharClass", menuName = "Character/CharClass")]
public class CClass : ScriptableObject{


    public string className;
    public string classDescription;

    public GameUtils.Genders gender;
    public GameUtils.Weapons[] usableWeapons;

    public bool isPromotion;

    //Primer numero masculino, segundo femenino.

    public CStats MinBasicStats;

    public CStats maxBasicStats;
    public CStats maximunStats;


}
