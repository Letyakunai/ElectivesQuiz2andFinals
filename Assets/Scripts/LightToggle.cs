using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour
{

    private bool Toggled;

    // Start is called before the first frame update
    void Start()
    {
        transform.Find("Light").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Toggled == true)
        {
            transform.Find("Light").gameObject.SetActive(true);
        }
        else
        {
            transform.Find("Light").gameObject.SetActive(false);
        }
    }

    public void ToggleLight()
    {
        Toggled = !Toggled;
    }
}
