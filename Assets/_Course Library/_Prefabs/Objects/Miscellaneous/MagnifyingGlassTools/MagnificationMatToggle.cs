using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnificationMatToggle : MonoBehaviour
{
    [SerializeField] Material clearMaterial;
    [SerializeField] Material magnifyMaterial;

    public void SetClearMaterial()
    {
        GetComponent<Renderer>().material = clearMaterial;
    }

    public void SetMagnifyMaterial()
    {
        GetComponent<Renderer>().material = magnifyMaterial;
    }

}
