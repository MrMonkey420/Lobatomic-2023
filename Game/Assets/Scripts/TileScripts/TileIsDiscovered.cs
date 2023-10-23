using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileIsDiscovered : MonoBehaviour
{
    public Sprite undisoveredTile, disoveredTile;
    public bool isDiscovered = false;

    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = undisoveredTile;
    }

    public void TileIsDisovered()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = disoveredTile;
        isDiscovered = true;
    }
}