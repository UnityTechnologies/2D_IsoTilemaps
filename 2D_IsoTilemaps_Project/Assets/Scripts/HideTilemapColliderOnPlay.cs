using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HideTilemapColliderOnPlay : MonoBehaviour
{

    private TilemapRenderer tilemapRenderer;

    void Start()
    {
        tilemapRenderer = GetComponent<TilemapRenderer>();
        tilemapRenderer.enabled = false;
    }
}
