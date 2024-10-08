using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modificacion : MonoBehaviour
{

    private GameObject[] spheres;
    private GameObject cube;
    private GameObject cylinder;

    // Start is called before the first frame update
    void Start()
    {   
        // In sphere we want to find the ones with the tag "sphere_group_2"
        spheres = GameObject.FindGameObjectsWithTag("sphere_group_2");
        cube = GameObject.FindWithTag("red_cube");
        cylinder = GameObject.FindWithTag("yellow_cylinder");

    }

    // Update is called once per frame
    void Update()
    {
        GameObject nearest_sphere = spheres[0];
        GameObject furthest_sphere = spheres[0];

        foreach (GameObject sphere in spheres)
        {
            if (Vector3.Distance(sphere.transform.position, cube.transform.position) < Vector3.Distance(nearest_sphere.transform.position, cube.transform.position))
            {
                nearest_sphere = sphere;
            }
            if (Vector3.Distance(sphere.transform.position, cube.transform.position) > Vector3.Distance(furthest_sphere.transform.position, cube.transform.position))
            {
                furthest_sphere = sphere;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int position = Random.Range(0, 3); // Genera un número aleatorio entre 0 y 2
            Vector4 actual_color = nearest_sphere.GetComponent<Renderer>().material.color; // Obtiene el color actual del objeto
            actual_color[position] = Random.value; // Cambia el valor de la posición aleatoria
            nearest_sphere.GetComponent<Renderer>().material.color = actual_color;

            Vector3 cylinder_position = cylinder.transform.position;
            cylinder.transform.position = nearest_sphere.transform.position;
            nearest_sphere.transform.position = cylinder_position;
        }
    }
}