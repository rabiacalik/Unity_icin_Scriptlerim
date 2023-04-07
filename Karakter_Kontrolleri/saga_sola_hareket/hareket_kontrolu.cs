using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket_kontrolu : MonoBehaviour
{
    private Animator r_animator;
    private SpriteRenderer r_spriteRenderer;

    public float hiz = 5f;
    public float yon;

    void Start()
    {
        r_animator = GetComponent<Animator>();
        r_spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        yon = Input.GetAxis("Horizontal"); //sag sol yonlerini aldýk
        if (yon > 0)
        {
            r_spriteRenderer.flipX = true;
            //r_animator.SetBool("durmak", false);
        }
        else if (yon < 0)
        {
            r_spriteRenderer.flipX = false;
           // r_animator.SetBool("durmak", false);
        }
        // r_animator.SetBool("durmak", true);
        r_animator.SetFloat("durmak", Mathf.Abs(yon));
        transform.position += new Vector3(yon * hiz * Time.deltaTime, 0f, 0f); // yol = hiz * zaman
    }
}
