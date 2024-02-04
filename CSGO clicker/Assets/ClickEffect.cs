using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class ClickEffect : MonoBehaviour
{
    public GameObject effect;
    [SerializeField] private Camera mainCam;

    public void Shoot()
    {
        Vector3 pos = new Vector3(mainCam.ScreenToWorldPoint(Input.mousePosition).x, mainCam.ScreenToWorldPoint(Input.mousePosition).y, 0);
        Instantiate(effect, pos, Quaternion.identity);
    }
}
