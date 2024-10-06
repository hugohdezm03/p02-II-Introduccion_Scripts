using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintDistances : MonoBehaviour
{
    public int frames_at_change_ = 240;
    private int actual_frame_ = 0;
    private GameObject red_cube;
    private GameObject yellow_cylinder;
    // Start is called before the first frame update
    void Start()
    {
        red_cube = GameObject.FindWithTag("red_cube");
        yellow_cylinder = GameObject.FindWithTag("yellow_cylinder");

        // Debug.Log($"Distance Blue Sphere - Red Cube: {Vector3.Distance(transform.position, red_cube.transform.position)}");
        // Debug.Log($"Distance Blue Sphere - Yellow Cylinder: {Vector3.Distance(transform.position, yellow_cylinder.transform.position)}");
    }

    // Update is called once per frame
    void Update()
    {
        if (actual_frame_++ == frames_at_change_) {
            Debug.Log($"Distance Blue Sphere - Red Cube: {Vector3.Distance(transform.position, red_cube.transform.position)}");
            Debug.Log($"Distance Blue Sphere - Yellow Cylinder: {Vector3.Distance(transform.position, yellow_cylinder.transform.position)}");
            actual_frame_ = 0;
        }
    }
}
