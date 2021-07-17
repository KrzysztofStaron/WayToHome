using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class pauseController : MonoBehaviour
{
  public GameObject pause;
  public GameObject menu;
  public AudioSource aSrc;
  public AudioClip PauseEffect;

    void Start()
    {
      pause.gameObject.SetActive(true);
      menu.gameObject.SetActive(false);
    }

    public void pauseGame()
    {
      aSrc.PlayOneShot(PauseEffect);
      Time.timeScale = 0f;
      menu.gameObject.SetActive(true);
      pause.gameObject.SetActive(false);
    }

    public void startGame()
    {
      Time.timeScale = 1f;
      aSrc.PlayOneShot(PauseEffect);
      menu.gameObject.SetActive(false);
      pause.gameObject.SetActive(true);
    }

    public void goToMenu(){
      Time.timeScale = 1f;
      SceneManager.LoadScene(0);
    }
}
