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
            Color random_color = new Color(Random.value, Random.value, Random.value); // Genera un color aleatorio
            GetComponent<Renderer>().material.color = random_color; // Cambia el color del objeto
            actual_frame_ = 0;
        }
    }
}
