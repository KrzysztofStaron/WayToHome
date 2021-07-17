using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class respawn : MonoBehaviour
{
  public AudioSource audioS;
  public AudioClip deathEffect;
  public Transform spawnPoint;

  public void Die(){
    audioS.PlayOneShot(deathEffect);
    if (spawnPoint==null) {
      transform.position=new Vector3(0,0,transform.position.z);
    }else{
      transform.position=spawnPoint.position;
    }
  }
}
