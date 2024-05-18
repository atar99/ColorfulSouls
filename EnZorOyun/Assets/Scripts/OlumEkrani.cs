using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OlumEkrani : MonoBehaviour
{

public void AnaMenu()
    {
        SceneManager.LoadScene("AnaMenu");
    }

    public void TekrarDene()
    {
       // Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void BolumSecimi()
    {
        SceneManager.LoadScene("BolumSecimi");
    }

}
