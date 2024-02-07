using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer_ : MonoBehaviour
{
    public float delayInSeconds = 5f;
    public float maxBarSeconds = 5f;
    public float minusSeconds = 1f;
    public Image timeBar;

    private void Start()
    {
        StartCoroutine(ShowImageAfterDelay());
    }
    private IEnumerator ShowImageAfterDelay()
    {
        while (delayInSeconds > 0f)
        {
            Debug.Log("Timer: " + delayInSeconds.ToString("F1"));
            yield return new WaitForSeconds(1f);
            delayInSeconds -= minusSeconds;
            timeBar.fillAmount = delayInSeconds / maxBarSeconds;
        }
        Restart();
    }

    public void Restart()
    {

        SceneManager.LoadScene("Restart");
    }
}