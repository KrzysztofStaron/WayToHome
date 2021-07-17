using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 pos;

    void Start(){
      player=transform.parent;
    }

    void Update()
    {
      transform.position =new Vector3(player.position.x,player.position.y,transform.position.z)+pos;
    }
}
