using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    float cntdnw = 30.0f;
    public Text disvar;

    void Update()
    {
        if (cntdnw > 0)
        {
            cntdnw -= Time.deltaTime;
        }
        double b = System.Math.Round(cntdnw, 2);
        disvar.text = b.ToString();
        if (cntdnw < 0)
        {
            SceneManager.LoadScene("GameOver2.1");
        }
    }
}