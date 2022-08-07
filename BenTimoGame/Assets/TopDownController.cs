using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour

{

private Rigidbody rb;
private Animator anim;
public float MovementSpeed;
private Vector2 MovementInput;

private void Awake()
{
    rb = GetComponent<Rigidbody>();
    anim = GetComponent<Animator>();
}
private void Update()
{
    Move();
    Animate();
}
private void Move()
{
    float Horizontal = Input.GetAxisRaw("Horizontal");
    float Vertical = Input.GetAxisRaw("Vertical");

    if (Horizontal == 0 && Vertical == 0){
        rb.velocity = new Vector2(0,0);
        return;    }

        MovementInput = new Vector2(Horizontal, Vertical);
        rb.velocity = MovementInput * MovementSpeed * Time.fixedDeltaTime;
}

private void Animate()
{
    anim.SetFloat("MovementX", MovementInput.x);
    anim.SetFloat("MovementY", MovementInput.y);
}
}
