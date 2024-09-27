using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshDisable : MonoBehaviour
{
    MeshRenderer m_Renderer;

    private void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
    }

    public void DisableMesh()
    {
        m_Renderer.enabled = false;
    }


}
