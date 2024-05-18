using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seri2JoystickKontrolu : MonoBehaviour
{
    public int speed;

    float vertical, horizontal;
    public Joystick jy;
    public Rigidbody2D Oyuncu;

    private void Update()
    {
        vertical = jy.Vertical;
        horizontal = jy.Horizontal;
        if (vertical != 0 || horizontal != 0)
        {
            //OYUNCUNUN DÖNMESINI SAĞLAMA   transform.up = new Vector3(horizontal * speed, vertical * speed,0);
           // transform.Translate(new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime, Space.World);
           // Oyuncu.velocity = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
            Oyuncu.AddForce(new Vector3(horizontal, vertical, 0) *speed* Time.deltaTime);
        }

    }
}
