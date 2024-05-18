using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public float bekleme;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bekleme_intro());
    }

    IEnumerator bekleme_intro()
    {
        yield return new WaitForSeconds(bekleme);

        SceneManager.LoadScene("AnaMenu");
    }
}
