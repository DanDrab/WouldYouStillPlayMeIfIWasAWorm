using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HovnovejScript : MonoBehaviour
{
    [SerializeField] GameObject go;
    void Start()
    {
    }


    public void DisableToCoVidim()
    {
        go.SetActive(false);
        Debug.Log("went through");
    }

    public void EnableToCoVidim()
    {
        go.SetActive(true);
        Debug.Log("went through");
    }
}
