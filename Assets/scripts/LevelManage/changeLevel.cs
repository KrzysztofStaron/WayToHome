using UnityEngine;
﻿using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class changeLevel : MonoBehaviour
{
    public LayerMask playerLayer;
    public Player player;
    public AudioSource audioS;
    public AudioClip changeEffect;
    public GameObject PlayAudioObj;

    void Update(){
      if (Input.GetKeyDown(KeyCode.R)) {
        player.level=1;
        Debug.Log("Restart Levels");
        player.savePlayer();
      }else if (Input.GetKeyDown(KeyCode.U)) {
        player.level=15;
        Debug.Log("Unlock all levels");
        player.savePlayer();
      }
    }

    void FixedUpdate()
    {
      if (Physics2D.OverlapCircle(transform.position,0.2f,playerLayer)) {
          DontDestroyOnLoad(PlayAudioObj);
          Destroy(PlayAudioObj,5f);
          audioS.PlayOneShot(changeEffect);
        PlayerData data = saveSystem.loadData();
        if (data.level<=SceneManager.GetActiveScene().buildIndex+1) {
          player.level=SceneManager.GetActiveScene().buildIndex+1;
          player.savePlayer();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
      }
    }

}
