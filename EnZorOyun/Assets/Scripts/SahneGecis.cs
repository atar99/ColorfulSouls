using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis : MonoBehaviour
{
  public int EnSonBolum;
   public void FixedUpdate()
    {
        EnSonBolum = PlayerPrefs.GetInt("SonBolum");
    }
    public void AnaMenu()
    {
        SceneManager.LoadScene("AnaMenu");
    }
    public void BolumSecimi()
    {
        SceneManager.LoadScene("BolumSecimi");
    }
    public void SonrakiBolum()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void TekrarDene()
    {
        // Application.LoadLevel(Application.loadedLevel);Eski
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void DevamEt()
    {
        if (PlayerPrefs.HasKey("SonBolum") == false)
        {
            PlayerPrefs.SetInt("SonBolum",3);
        }
        EnSonBolum = PlayerPrefs.GetInt("SonBolum");
        SceneManager.LoadScene(EnSonBolum);
    }
}

  
