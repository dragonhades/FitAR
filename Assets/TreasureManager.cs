using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureManager : MonoBehaviour
{
    public TMPro.TextMeshPro TargetText;
    private Vector3 m_initPosition;

    private void Start()
    {
        m_initPosition = transform.position;
    }

    private void Update()
    {
        if(transform.position != m_initPosition) TargetText.text = "YOU FOUND IT!";
    }
}
