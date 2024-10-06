using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onKeyColorChange : MonoBehaviour
{
    private Material red_cube_material;
    private Material yellow_cylinder_material;
    // Start is called before the first frame update
    void Start()
    {
        red_cube_material = GameObject.FindWithTag("red_cube").GetComponent<Renderer>().material;
        yellow_cylinder_material = GameObject.FindWithTag("yellow_cylinder").GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Change Cylinder color
            yellow_cylinder_material.color = new Color(Random.value, Random.value, Random.value);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Change Cube color
            red_cube_material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
