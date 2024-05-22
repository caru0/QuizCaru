using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aLAN : MonoBehaviour
{
    [Header("Componentes")]
    public Rigidbody2D corpoaLAN;
    public BoxCollider2D colisoraLAN;

    [Header("Movimentação")]
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        corpoaLAN.velocity = new Vector2(0, velocidade);
    }
}
