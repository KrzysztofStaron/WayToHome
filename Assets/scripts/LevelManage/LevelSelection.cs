using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public Button[] lvlButtons;
    public GameObject[] padlocks;
    public int AtLevel=1;

    void Start()
    {
      if (saveSystem.loadData()!=null) {
        PlayerData data = saveSystem.loadData();
        AtLevel=data.level;
      }else{
        AtLevel=1;
      }
        for (int i = 0; i < 15; i++)
        {
            if (i + 1 > AtLevel)
            {
                padlocks[i].SetActive(true);
                lvlButtons[i].interactable = false;
            }
        }
    }

}
