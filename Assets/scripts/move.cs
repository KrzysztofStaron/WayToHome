using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class move : MonoBehaviour
{
  public float speed, jumpHeight;
  public float checkRadius;

  public bool grounded;
  bool canJump;

  public Joystick moveJoystick;
  public Rigidbody2D rb;
  public LayerMask killLayer;
  public LayerMask groundLayer;
  public Transform groundCheck;

  public AudioSource audioS;
  public AudioClip jumpEffect;

  void Update()
  {
    float horizontalMove=Input.GetAxis("Horizontal");
    if (Input.GetKeyDown(KeyCode.Space)) {
      jump();
    }
    if (moveJoystick.Horizontal!=0) {
      rb.velocity = new Vector2(moveJoystick.Horizontal*speed,rb.velocity.y);
    }else if(horizontalMove!=0){
      rb.velocity = new Vector2(horizontalMove*speed,rb.velocity.y);
    }
  }

  public void jump(){
    if (canJump) {
      canJump=false;
      audioS.PlayOneShot(jumpEffect);
      rb.velocity = new Vector2(rb.velocity.x,jumpHeight*2);
    }
  }

  void FixedUpdate(){
    if (Physics2D.OverlapCircle(transform.position,checkRadius,killLayer)) {
      GetComponent<respawn>().Die();
      rb.velocity= new Vector2(0,0);
      rb.angularVelocity=0;
    }
    grounded = Physics2D.OverlapCircle(groundCheck.position,0.2f,groundLayer);
    if (grounded) {
      canJump=true;
    }
  }


}
