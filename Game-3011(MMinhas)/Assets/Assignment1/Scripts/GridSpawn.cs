using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GridSpawn : MonoBehaviour
{
    
    public int w = 32; // width
    public int h = 32; // height

    public Element Covering;
    public Element ElementToSpawn;
   
    public Element[,] elements;
    public Element[,] coveringElements;

    public static GridSpawn gridInstance; 



    // Start is called before the first frame update
    void Start()
    {

    coveringElements = new Element[w, h];
    
    for (int x = 0; x < w; x++)
    {
        for (int y = 0; y < h; y++)
        {
            coveringElements[x, y] = Instantiate(Covering, new Vector2(x, y), Quaternion.identity);
            Covering.index = new Vector2Int(x, y);
            coveringElements[x, y].materialCounter = 0;
    
        }
    
    
    }

        elements = new Element[w,h];

        for (int x = 0; x < w; x++) 
        {
            for(int y = 0; y < h; y++)
            {
                elements[x, y] = Instantiate(ElementToSpawn, new Vector2(x,y), Quaternion.identity); 
                ElementToSpawn.index = new Vector2Int(x,y);
                elements[x, y].materialCounter = 1; 
                
            }
        }


        //SpawnMaterial();
        //SpawnMaterial2();
    }

    void SpawnMaterial() 
    { 
    var RandomX = 1;
    var RandomY = 10;
        for(int x  =  RandomX - 2; x < RandomX + 3; x++)
        {
            for(int y = RandomY -2; y < RandomY +3; y++)
            {
                elements[x, y].materialCounter = 2; 
            }

            
        }
    }

    

    // Update is called once per frame
    void Update()
    {

      

    }
}
