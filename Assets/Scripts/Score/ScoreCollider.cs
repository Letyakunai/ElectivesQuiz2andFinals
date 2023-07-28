using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollider : MonoBehaviour
{

    private ScoreCollector scoreCollector;

    [SerializeField]
    private int Score;

    // Start is called before the first frame update
    void Start()
    {
        scoreCollector = GameObject.FindGameObjectWithTag("EventListener").GetComponent<ScoreCollector>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("This was Hit.");
        if(other.gameObject.tag == "Axe")
        scoreCollector.UpdateScore(Score);
    }

}
