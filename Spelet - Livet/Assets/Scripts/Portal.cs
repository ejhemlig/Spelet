using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Portal : MonoBehaviour
{
    public Material[] materials;
    
    void Start()
    {
        
    }

    void OnTriggerStay(Collider other) 
    {
        if (other.name != "Main Camera")
            return;

        //Kolla vinkeln på dörren så det blir rätt > eller <
        if (transform.position.x < other.transform.position.x)
        {
            foreach (var mat in materials) 
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
            }
        } 
        else
        {
            foreach (var mat in materials)
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
            }
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
