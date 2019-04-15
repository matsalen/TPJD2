using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    [HideInInspector] public bool ViradoDireita = true;
    public float h;
    public float forcaAceleracao = 5f;
    public Rigidbody2D r;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        r = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");

        r.velocity = new Vector2(h * forcaAceleracao, r.velocity.y);

        anim.SetFloat("Speed", h);

        if (ViradoDireita)
        {

        }
        
    }

    private void Flip()
    {
        ViradoDireita = !ViradoDireita;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }
}
