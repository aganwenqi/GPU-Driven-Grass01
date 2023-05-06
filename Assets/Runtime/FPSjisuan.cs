using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FPSjisuan : MonoBehaviour
{
    public TextMeshProUGUI FPS_Text;
    private float m_UpdateShowDeltaTime;//����֡�ʵ�ʱ����;  
    private int m_FrameUpdate = 0;//֡��;  
    private float m_FPS = 0;//֡��
    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        m_FrameUpdate++;
        m_UpdateShowDeltaTime += Time.deltaTime;
        if (m_UpdateShowDeltaTime >= 0.2)
        {
            m_FPS = m_FrameUpdate / m_UpdateShowDeltaTime;
            m_UpdateShowDeltaTime = 0;
            m_FrameUpdate = 0;
            FPS_Text.SetText(m_FPS.ToString());
        }
    }
}
