using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallManager : MonoBehaviour
{
    public int ballCount;
    public Text ballText;

    void Update()
    {
        
        Debug.Log("Balls Collected: " + ballCount);
        ballText.text = ballCount.ToString();
    }
}