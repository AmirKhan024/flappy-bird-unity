using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parellex : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float animationspeed=0.05f;

    void Awake(){
        meshRenderer=GetComponent<MeshRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset+=new Vector2(animationspeed*Time.deltaTime,0);
    }
}
