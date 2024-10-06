using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorProperties : MonoBehaviour
{
    public Vector3 first_vector = new Vector3(1.0f, 2.0f, 2.0f);
    public Vector3 second_vector = new Vector3(1.0f, 1.0f, 1.0f);
    public float first_vector_magnitude;
    public float second_vector_magnitude;
    public float angle;
    public float distance;
    public string higher_vector;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. La magnitud de cada uno de ellos.
        first_vector_magnitude = first_vector.magnitude;
        second_vector_magnitude = second_vector.magnitude;
        Debug.Log($"First vector magnitude: {first_vector_magnitude}");
        Debug.Log($"Second vector magnitude: {second_vector_magnitude}");
        // 2. El ángulo que forman
        angle = Vector3.Angle(first_vector, second_vector);
        Debug.Log($"Angle between vectors: {angle}");
        // 3. La distancia entre ambos.
        distance = Vector3.Distance(first_vector, second_vector);
        Debug.Log($"Distance between vectors: {distance}");
        // 4. Un mensaje indicando qué vector está a una altura mayor.
        higher_vector = first_vector.y >= second_vector.y ? "First vector is higher" : "Second vector is higher";
        Debug.Log(higher_vector);
    }
}
