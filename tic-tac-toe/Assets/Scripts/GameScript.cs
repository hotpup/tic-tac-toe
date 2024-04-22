using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    int spriteIndex = 0;

    public int PlayerTurn() {
        spriteIndex++;
        return spriteIndex % 2;
    }
}
