using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMatScript : MonoBehaviour
{

    //public Material[] myMaterials = new Material[20];
    public Material mat;
    public Texture[] myTextures = new Texture[20];
    
    private Renderer rend;


    // Start is called before the first frame update
    void Start()
    {

        rend = GetComponent<Renderer>();
        mat = rend.material;

        //rend.sharedMaterial = myMaterials[1];

    }


    // Update is called once per frame
    void Update()
    {
        Color color = Color.white;
        //rend.sharedMaterial = myMaterials[Rand()];
        mat.mainTexture = myTextures[Rand()];
        //mat.color = myTextures[Rand()]; // change emmissive colorS

        mat.SetColor("_EmissionColor", color);
    }

    int Rand()
    {
        int randomNumber = Random.Range(0, 20);
        return randomNumber;
    }

    //Next thing to do is make an image in open cv that is less than 512, so it looks bigger on the cube
    //graphics culling 
    //make a sphere, wont have to worry about visual angle when in middle of sphere




    //install unity package for vs
    //change texture not mateiral
    //do geometry for visual angle, flat backing not sphere (or big sphere)
    //look into tiling
    //look into textuering a sphere, find asset textured like a sphere, cresecent 
    

  
}
