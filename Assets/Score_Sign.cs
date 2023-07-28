using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score_Sign : MonoBehaviour
{
    private ScoreCollector scoreCollector;
    private TextMeshPro text;

    // Start is called before the first frame update
    void Start()
    {
        scoreCollector = GameObject.FindGameObjectWithTag("EventListener").GetComponent<ScoreCollector>();
        text = gameObject.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText("Score: " + scoreCollector.ReturnScore());
    }
}
