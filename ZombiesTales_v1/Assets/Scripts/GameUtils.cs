using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class  GameUtils  {


    
    public enum Genders { MALE = 0, FEMALE = 1 }

    public enum Weapons {
        OBJECT_STICK = 0,
        WEAPON_SWORD = 1, WEAPON_AXE = 2, WEAPON_LANCE = 3, WEAPON_BOW = 4,
        MAGIC_ANIMA = 5, MAGIC_LIGHT = 6, MAGIC_DARK = 7
    }


    public class MapPosition
    {

        public int posX;
        public int posY;

        public MapPosition(int x, int y)
        {

            this.posX = x;
            this.posY = y;

        }

        public void print()
        {
            Debug.Log("Pos(" + posX + "," + posY + ")");
        }

    }


    public static void GetNearSlots(MapPosition pos, int steps)
    {

        List<MapPosition> auxMap = new List<MapPosition>();

        int x = pos.posX;
        int y = pos.posY;


        //First step
        for (int z = 1; z <= steps; z++)
        {
            auxMap.Add(new MapPosition(x - z, y));
            auxMap.Add(new MapPosition(x + z, y));
            auxMap.Add(new MapPosition(x, y + z));
            auxMap.Add(new MapPosition(x, y - z));
        }

        //Second step
        if (steps > 1)
        {

            for (int z = 1; z <= steps; z++)
            {
                for (int v = 1; v < z; v++)
                {
                    MapPosition p1 = new MapPosition(x + (z - v), y + v);
                    MapPosition p1inverso = new MapPosition(-p1.posX, -p1.posY);

                    MapPosition p2 = new MapPosition(x - (z - v), y + v);
                    MapPosition p2inverso = new MapPosition(-p2.posX, -p2.posY);

                    auxMap.Add(p1);
                    auxMap.Add(p2);
                    auxMap.Add(p1inverso);
                    auxMap.Add(p2inverso);

                }
            }

        


        }

        MapPosition[] nearSlots = auxMap.ToArray();

        for (int z = 0; z < nearSlots.Length; z++)
        {
            nearSlots[z].print();
        }

    }
}

