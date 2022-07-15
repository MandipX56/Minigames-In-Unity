using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Element : MonoBehaviour
{
    public Vector2Int index;

    public int materialCounter; 
    public int PlayerScore = 0;

    
    public int ScanClicks = 4;

    //Is it empty
    public bool empty;
    // Is it covered
    public bool isCovered;
    //return GetComponent<SpriteRenderer>().sprite.texture.name == "default";


    // Different Textures
    public Sprite[] Textures;
    public Sprite emptyTexture;
    public Sprite coveredTexture;


    
    public List<GameObject> neighbours = new List<GameObject>(); 
    CircleCollider2D circleCollider;
    

    // Use this for initialization
    void Start ()
    {
        // Randomly decide if it's empty or not
        //empty = Random.value < 0.15;
        loadTexture();
        circleCollider = GetComponent<CircleCollider2D>(); 
        ElemntScan();
        // Register Grid
        //int x = (int)transform.position.x;
        //int y = (int)transform.position.y;

       

    }

    // Update is called once per frame
    void Update()
    {
        //OnMouseDown();

        if (Input.GetMouseButtonDown(0))
        {
            ExtractClicks -= 1;
            Debug.Log(ExtractClicks);
        }

        if(ExtractClicks == 0)
        {
            SceneManager.LoadScene("GameOver1");
            SceneManager.UnloadSceneAsync("Game1");
        }

    }


    void ElemntScan()
    {
        Element[] tiles = FindObjectsOfType<Element>();
        foreach (Element tile in tiles)
        {
            if (tile.gameObject.GetInstanceID() != gameObject.GetInstanceID())
            {
                if (circleCollider.bounds.Intersects(tile.gameObject.GetComponent<Collider2D>().bounds))
                {
                    neighbours.Add(tile.gameObject);
                }
            }

        }
    }

        public void loadTexture()
    {
        if(materialCounter == 1)
        { 
        var index = Random.Range(0, Textures.Length); 
        gameObject.GetComponent<SpriteRenderer>().sprite = Textures[index];
        //gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "default"; 
        }

        if (materialCounter == 0)
        {
            GetComponent<SpriteRenderer>().sprite = coveredTexture;
        }

    }


    public int ExtractClicks = 6;
    private void OnMouseDown()
    {
        
        Vector2 mousePos = Input.mousePosition;
            float x = mousePos.x;
            float y = mousePos.y;

        

        
        foreach (GameObject tile in neighbours)
            {
                Destroy(tile.gameObject);
            
            }

        //if (materialCounter == 0)
        //{
        //    Destroy(gameObject);
        //}

        //if (materialCounter == 0)
        //{
        //    if (mousePos.x <= x + 5 || mousePos.x <= x - 5 || mousePos.y <= y + 5 || mousePos.y <= y - 5)
        //    {
        //        Destroy(gameObject);
        //    }
        //
        //}
       // if (Input.GetMouseButtonDown(0))
       // {
       // }

    }



    // (OLD FUNCTION) Load another texture
    //public void loadTexture(int adjacentCount)
    //{
    //    if (empty) 
    //        GetComponent<SpriteRenderer>().sprite = emptyTexture;
    //    else
    //        GetComponent<SpriteRenderer>().sprite = Textures[adjacentCount];
    //}

    //void OnMouseUpAsButton()
    //{
    //
    //    // It's empty
    //    if (isCovered)
    //    {
    //        //uncover all 
    //        //Grid.uncoverEmpty(); 
    //        //loadTexture(0);
    //        isCovered = false;
    //        //game over
    //        print("You've Blown Up!");
    //
    //    }
    //   //else
    //   //{
    //   //    //show adjacent empty number
    //   //    int x = (int)transform.position.x;
    //   //    int y = (int)transform.position.y;
    //   //    loadTexture(Grid.adjacentMines(x, y));
    //   //}
    //}



}