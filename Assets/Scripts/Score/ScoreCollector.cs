using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollector : MonoBehaviour
{

    [SerializeField]
    private int Score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int ReturnScore()
    {
        return Score;
    }

    public void UpdateScore(int ScoreType)
    {
        Score += ScoreType;
    }

}