using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Animator anim;

    public float intervalDeAtaque;
    private float proximoAtoque;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && Time.time > proximoAtoque)
        {
            Atacando();
        }
    }

    void Atacando()
    {
        anim.SetTrigger("attackq");
        proximoAtoque = Time.time + intervalDeAtaque;   
    }
}
