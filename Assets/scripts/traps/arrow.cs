using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform hitCheck;
    public LayerMask groundLayer,playerLayer;
    public GameObject brokeParticle;
    public float speed;
    public float AdAngle=0;

    void Start()
    {
      rb.AddForce(transform.up * speed, ForceMode2D.Impulse);
    }

    void FixedUpdate(){
      if (Physics2D.OverlapCircle(hitCheck.position, 0.1f, groundLayer) || Physics2D.OverlapCircle(hitCheck.position, 0.2f, playerLayer)) {
        GameObject newParticle = Instantiate(brokeParticle,hitCheck.position, Quaternion.Euler(0, 0, transform.rotation.z+AdAngle));
        newParticle.transform.parent=transform.parent;
        Destroy(newParticle,4f);
        Destroy(this.gameObject);
      }
    }
}
