using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGroups : MonoBehaviour
{
    private GameObject[] spheres;
    private GameObject cube;

    private GameObject old_nearest_sphere = null;

    // Start is called before the first frame update
    void Start()
    {   
        // In sphere we want to find the ones with the tag "sphere_group_2"
        spheres = GameObject.FindGameObjectsWithTag("sphere_group_2");
        cube = GameObject.FindWithTag("red_cube");
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

        if (old_nearest_sphere != null)
        {
            old_nearest_sphere.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
        
        nearest_sphere.transform.localScale = new Vector3(1.0f, 2.0f, 1.0f);
        old_nearest_sphere = nearest_sphere;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            furthest_sphere.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
