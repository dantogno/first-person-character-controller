using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material blueMaterial;
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        // change color to blue
        meshRenderer.material.color = Color.blue;

        // get color
        meshRenderer.material.GetColor("_Color");
        // set color
        meshRenderer.material.SetColor("_Color", Color.blue);

        Debug.Log(meshRenderer.material.name);
        Debug.Log(meshRenderer.material.shader.name);

        meshRenderer.material = blueMaterial;

        Material material = new Material(blueMaterial);
        Debug.Log(material.GetColor(0));
        meshRenderer.material = material;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
