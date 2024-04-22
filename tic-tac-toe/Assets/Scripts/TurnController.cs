using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject grid;
    public Sprite[] images;
    void Start() {
        spriteRenderer.sprite = null;
    }
    private void OnMouseDown()
    {
        if(spriteRenderer.sprite == null) {
            int index = grid.GetComponent<GameScript>().PlayerTurn();
            spriteRenderer.sprite = images[index];
        }

    }
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        grid = GameObject.Find("Grid");
    }

}
