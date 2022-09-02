using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawn : MonoBehaviour
{

    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Resources.Load("Prefabs/Circle"));
        InvokeRepeating("Spawn", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn() {
        GameObject go = Instantiate(Resources.Load("Prefabs/Circle")) as GameObject;
        int num = GetComponent<ColorPicker>().SetSprite();
        go.GetComponent<SpriteRenderer>().sprite = sprites[num];
    }
}
