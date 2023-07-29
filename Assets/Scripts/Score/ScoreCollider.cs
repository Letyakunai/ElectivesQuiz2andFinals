using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollider : MonoBehaviour
{

    private ScoreCollector scoreCollector;

    [SerializeField]
    private int Score;

    public AudioSource HitSfx;

    // Start is called before the first frame update
    void Start()
    {
        scoreCollector = GameObject.FindGameObjectWithTag("EventListener").GetComponent<ScoreCollector>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Axe")
        {
        Debug.Log("This was Hit.");
        scoreCollector.UpdateScore(Score);
        HitSfx.Play();
        }
    }

}
