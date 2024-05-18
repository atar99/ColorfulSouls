using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyukDusman : MonoBehaviour
{
    float hiz;
    string zorluk;

    // Start is called before the first frame update
    void Start()
    {
        zorluk = PlayerPrefs.GetString("Zorluk");
        if (zorluk == "Orta") hiz = 3f;
        if (zorluk == "Basit" || zorluk == "basit") hiz = 2.1f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.position += transform.up * hiz * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D Temas)
    {

        if (Temas.gameObject.tag == "Duvar" || Temas.gameObject.tag == "KirmiziDuvar" || Temas.gameObject.tag == "MaviDuvar")
        {
            if (zorluk == "Orta")
            {
                if (hiz <= 0)
                {
                    hiz = 3f;
                }

                else
                {
                    hiz = -3f;
                }
            }
            if (zorluk == "Basit" || zorluk == "basit")
            {
                if (hiz <= 0)
                {
                    hiz = 2.1f;
                }

                else
                {
                    hiz = -2.1f;
                }
            }

        }


    }
}
