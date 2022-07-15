using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject PipesHolder;
    public GameObject[] Pipes;

    public Text connectedpipes; 
    
    [SerializeField]
    int totalPipes = 0;
    [SerializeField]
    int correctedPipes = 0;

    // Start is called before the first frame update
    void Start()
    {
        totalPipes = PipesHolder.transform.childCount;

        Pipes = new GameObject[totalPipes];

        for (int i = 0; i < Pipes.Length; i++)
        {
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }
    }

    private void Update()
    {
        connectedpipes.text = correctedPipes.ToString();
    }


    public void correctMove()
    {
        correctedPipes += 1;

        Debug.Log("You've Hacked it!");
        

        if (correctedPipes == totalPipes)
        {
            Debug.Log("You win!");
            SceneManager.LoadScene("Sucess4");
        }
    }

    public void wrongMove()
    {
        Debug.Log("Wrong Move");
        correctedPipes -= 1;
    }

}
