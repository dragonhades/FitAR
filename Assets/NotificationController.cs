using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationController : MonoBehaviour
{
    float m_timer = 10;
    
    private void OnCollisionStay(Collision collision)
    {
        m_timer -= Time.deltaTime;
        if(m_timer == 0)
        {
            gameObject.SetActive(false);
        }
        GetComponent<TMPro.TextMeshPro>().text = ""+(int)m_timer;
    }
}
