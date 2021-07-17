using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public int level;

  void Start(){
    if (saveSystem.loadData()==null) {
      savePlayer();
    }
  }

  public void savePlayer(){
    saveSystem.SavePlayer(this);
  }
}
