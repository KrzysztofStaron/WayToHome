using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateClouds : MonoBehaviour
{
    public GameObject cloud;
    public Vector2 border;
    public float time;
    public float currentTime;

    void Update()
    {
      if (currentTime<=0)
      {
        GameObject newCloud = Instantiate(cloud,new Vector2(transform.position.x,Random.Range(border.x, border.y)),Quaternion.identity);
        newCloud.transform.parent=transform;
        GameObject newCloud2 = Instantiate(cloud,new Vector2(transform.position.x,Random.Range(border.x, border.y)),Quaternion.identity);
        newCloud2.transform.parent=transform;
        currentTime=time;
      }
      currentTime-=Time.fixedDeltaTime;
    }
}
