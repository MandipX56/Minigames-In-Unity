using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    // The Grid 
    public static int w = 32; // width
    public static int h = 32; // height
    public static Element[,] elements = new Element[w, h];

   //public static void uncoverEmpty()
   //{
   //    foreach (Element elem in elements)
   //        if (elem.empty)
   //            elem.loadTexture(0);
   //}

    public static bool emptyAt(int x, int y)
    {
        // in range then check for empty.
        if (x >= 0 && y >= 0 && x < w && y < h)
            return elements[x, y].empty;
        return false;
    }

    // Count adjacent emptys for an element
    public static int adjacentMines(int x, int y)
    {
        int count = 0;

        if (emptyAt(x, y + 1)) ++count; // top
        if (emptyAt(x + 1, y + 1)) ++count; // top-right
        if (emptyAt(x + 1, y)) ++count; // right
        if (emptyAt(x + 1, y - 1)) ++count; // bottom-right
        if (emptyAt(x, y - 1)) ++count; // bottom
        if (emptyAt(x - 1, y - 1)) ++count; // bottom-left
        if (emptyAt(x - 1, y)) ++count; // left
        if (emptyAt(x - 1, y + 1)) ++count; // top-left

        return count;
    }

}


