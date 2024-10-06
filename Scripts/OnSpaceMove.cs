using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSpaceMove : MonoBehaviour
{
    private Vector3 cube_move;
    private Vector3 cylinder_move;
    private Vector3 sphere_move;
    private GameObject red_cube;
    private GameObject yellow_cylinder;
    private GameObject blue_sphere;
    // Start is called before the first frame update
    void Start()
    {
        cube_move = new Vector3(0.0f, 0.0f, 2.0f);
        cylinder_move = new Vector3(0.0f, 0.0f, 4.0f);
        sphere_move = new Vector3(0.0f, 0.0f, 2.0f);

        red_cube = GameObject.FindWithTag("red_cube");
        yellow_cylinder = GameObject.FindWithTag("yellow_cylinder");
        blue_sphere = GameObject.FindWithTag("blue_sphere");
        // blue_spehere = GameObject.Find('Sphere');
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {   
            red_cube.transform.position += cube_move;
            yellow_cylinder.transform.position += cylinder_move;
            blue_sphere.transform.position += sphere_move;

            // Cada vez que se presiona la tecla el movimiento se cambia de signo, para que se retornen a su posición original.
            cube_move *= -1;
            cylinder_move *= -1;
            sphere_move *= -1;
        }
    }
}
