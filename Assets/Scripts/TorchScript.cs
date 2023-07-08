using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour
{
    private bool Toggled;

    // Start is called before the first frame update
    void Start()
    {
        transform.Find("Light and Particles").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Toggled == true)
        {
            transform.Find("Light and Particles").gameObject.SetActive(true);
        }
        else
        {
            transform.Find("Light and Particles").gameObject.SetActive(false);
        }
    }

    public void ToggleLight()
    {
        Toggled = !Toggled;
    }
}
