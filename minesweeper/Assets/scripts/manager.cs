using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    [SerializeField]
    GameObject square;

    int x = 10;
    int y = 10;
    int SizeX;
    int SizeY;

    List<GameObject> squares = new List<GameObject>();
   


    void Start()
    {
        SizeX = 1000 / x;
        SizeY = 1000 / y;

        square.GetComponent<RectTransform>().sizeDelta = new Vector2(SizeX, SizeY);


        GameObject stvorec;
        



        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                stvorec = Instantiate(square, new Vector2(i * SizeX + SizeX / 2, j * SizeY + SizeY / 2), Quaternion.identity);
                stvorec.transform.SetParent(GameObject.Find("Canvas").transform);
                stvorec.name = (i*x + j).ToString();


            }

        }
    }

    void Update()
    {
        
    }
}
