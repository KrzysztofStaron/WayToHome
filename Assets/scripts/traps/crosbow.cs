using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosbow : MonoBehaviour
{
  public GameObject arrow;
  public Transform shotPoint;
  public float time;
  public float currentTime;

  void Update()
  {
    if (currentTime<=0)
    {
      GameObject newArrow = Instantiate(arrow,shotPoint.position,transform.rotation);
      newArrow.transform.parent=transform;
      currentTime=time;
    }
    currentTime-=Time.fixedDeltaTime;
  }
}
