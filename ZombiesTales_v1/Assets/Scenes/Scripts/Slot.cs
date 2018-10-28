using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {

    public MapPosition positionInMap;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public class MapPosition {

        public int posX;
        public int posY;

        public MapPosition(int x, int y) {

            this.posX = x;
            this.posY = y;

        }
        
    }
}



