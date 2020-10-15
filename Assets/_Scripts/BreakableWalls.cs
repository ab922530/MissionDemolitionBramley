using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWalls : MonoBehaviour
{
    public GameObject wall;
    public bool wallBool = false;
    public int wallHP = 2;
    void OnCollisionEnter(Collision col)
    {
        print("collision detected");
        Material mat = GetComponent<Renderer>().material;
        Color c = mat.color;
        if (col.gameObject.tag == "Projectile")
        {
            wallBool = true;
            if(wallBool)
            {
                if (wallHP == 2)
                {
                    print("collision detected");

                    c.g = 256;
                    c.b = 0;
                    c.r = 0;
                    mat.color = c;
                    wallHP--;
                    wallBool = false;
                }
                if(wallHP == 1 && wallBool == true)
                {
                    c.g = 0;
                    c.b = 0;
                    c.r = 256;
                    mat.color = c;
                    wallHP--;
                    wallBool = false;
                }
                if (wallHP == 0 && wallBool == true)
                {
                    Destroy(wall);
                }
            }
            
        }
       

    }
    // Start is called before the first frame update
    void Start()
    {
        Material mat = GetComponent<Renderer>().material;
        Color c = mat.color;
        c.g = 0;
        c.b = 256;
        c.r = 0;
        mat.color = c;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
