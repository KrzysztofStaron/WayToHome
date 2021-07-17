using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeSystem : MonoBehaviour
{
    public Animator anim;
    public float checkRadius;
    public LayerMask playerLayer;
    public bool active;
    public bool end;
    void FixedUpdate()
    {
      active=Physics2D.OverlapCircle(transform.position,checkRadius,playerLayer);
      if (active && end) {
          anim.SetTrigger("active");
      }
    }
}
