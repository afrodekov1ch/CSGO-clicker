using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class ClickEffect : MonoBehaviour
{
    public GameObject effect;
    [SerializeField] private Camera mainCam;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = new Vector3(mainCam.ScreenToWorldPoint(Input.mousePosition).x, mainCam.ScreenToWorldPoint(Input.mousePosition).y, 0);
            Instantiate(effect, pos, Quaternion.identity);

        }
    }
}
