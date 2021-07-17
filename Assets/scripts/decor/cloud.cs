using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    public float speed;
    public float destroyOnX;
    public Rigidbody2D rb;

    void Start()
    {
      rb.velocity=new Vector2(speed+Random.Range(0, 3)*0.1f, 0);
      float CloudScale=0.5f+Random.Range(0, 5)*0.1f;
      transform.localScale=new Vector3(CloudScale,CloudScale,1);
    }

    void Update(){
      if (transform.position.x>=destroyOnX) {
        Destroy(this.gameObject);
      }
    }
}
