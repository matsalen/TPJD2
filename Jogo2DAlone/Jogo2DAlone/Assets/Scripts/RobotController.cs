using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    [HideInInspector] public bool ViradoDireita = true;
    public float h;
    public float forcaAceleracao = 5f;
    public float ForcaPulo = 350f;
    public float RaioSolo = 0.2f;
    public bool NoSolo = false;
    public Rigidbody2D r;
    public Animator anim;
    public LayerMask ESolo;
    public Transform VerificaSolo;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        r = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        NoSolo = Physics2D.OverlapCircle(VerificaSolo.position, RaioSolo, ESolo);
        anim.SetBool("Chao", NoSolo);
        anim.SetFloat("SpeedVert", Mathf.Abs(r.velocity.y));
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");

        r.velocity = new Vector2(h * forcaAceleracao, r.velocity.y);

        anim.SetFloat("Speed", Mathf.Abs(r.velocity.x));

        if (ViradoDireita && h < 0)
        {
            Flip();
        }
        else if (!ViradoDireita && h > 0)
        {
            Flip();
        }
        if (NoSolo & Input.GetButtonDown("Jump"))
        {
            r.AddForce(new Vector2(0, ForcaPulo));
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
