using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMov : MonoBehaviour
{
    [SerializeField] private Vector2 velMov;

    private Vector2 Offset;

    private Material material;

    private Rigidbody2D jugador;


    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Offset = (jugador.velocity.x * -1f) * velMov * Time.deltaTime;
        material.mainTextureOffset += Offset;
    }
}
