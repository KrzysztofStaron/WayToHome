using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class LoadLevel : MonoBehaviour
{
  [SerializeField] public int level;
  public GameObject AudioObj;
  public AudioSource aSrc;
  public AudioClip selectEffect;

    public void load()
    {
      DontDestroyOnLoad(AudioObj);
      Destroy(AudioObj,5f);
      aSrc.PlayOneShot(selectEffect);
      SceneManager.LoadScene(level);
    }
}
