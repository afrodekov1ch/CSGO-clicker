using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Camera mainCam;
    public AudioSource ad;

    private void Update()
    {
        Vector3 pos = new Vector3(mainCam.ScreenToWorldPoint(Input.mousePosition).x, mainCam.ScreenToWorldPoint(Input.mousePosition).y, 0);
        transform.position = pos;
        if (Input.GetMouseButtonDown(0))
        {
            ad.Play();
        }
    }
}
