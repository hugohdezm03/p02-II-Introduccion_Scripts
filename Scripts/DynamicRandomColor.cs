using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicRandomColor : MonoBehaviour
{
    public int frames_at_change_ = 120;
    private int actual_frame_ = 0;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (actual_frame_++ == frames_at_change_) {
            int position = Random.Range(0, 3); // Genera un número aleatorio entre 0 y 2
            Vector4 actual_color = GetComponent<Renderer>().material.color; // Obtiene el color actual del objeto
            actual_color[position] = Random.value; // Cambia el valor de la posición aleatoria
            GetComponent<Renderer>().material.color = actual_color; // Cambia el color del objeto
            actual_frame_ = 0;
        }
    }
}
