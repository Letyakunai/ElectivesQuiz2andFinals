using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Scripts : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private int Count = 1; //The number of targets. Default 1.

    // Update is called once per frame
    void Update()
    {
        CountCheck();
        if (Count < 1) { Count = 1; }
        if (Count > 5) { Count = 5; }
    }

    //Function to Add on the Count
    public void AddCount()
    {
        Count++;
    }

    //Function to Reduce on the Count
    public void ReduceCount()
    {
        Count--;
    }

    private void CountCheck()
    {
        switch (Count)
        {
            case 1:
                transform.Find("Target 2").gameObject.SetActive(false);
                transform.Find("Target 3").gameObject.SetActive(false);
                break;
            case 2:
                transform.Find("Target 2").gameObject.SetActive(true);
                transform.Find("Target 3").gameObject.SetActive(false);
                break;
            case 3:
                transform.Find("Target 2").gameObject.SetActive(true);
                transform.Find("Target 3").gameObject.SetActive(true);
                break;
            default:
                transform.Find("Target 2").gameObject.SetActive(false);
                transform.Find("Target 3").gameObject.SetActive(false);
                break;
        }
    }

}
