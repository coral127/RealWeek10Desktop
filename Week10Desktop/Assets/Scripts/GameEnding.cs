using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackgronudImageCanvasGroup;
   
    bool m_IsPlayerAtExit;
    float m_Timer;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }
    void Update()
    {
        if (m_IsPlayerAtExit)
        { 
            Endlevel();
        }
    }
    void Endlevel()
    {
        m_Timer += Time.deltaTime;
        exitBackgronudImageCanvasGroup.alpha = m_Timer / fadeDuration;
        
        if(m_Timer > fadeDuration + displayImageDuration)
        {
            Application.Quit();
        }
    }
}
