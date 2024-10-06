using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPosition : MonoBehaviour
{
    public int frames_at_change_ = 240;
    private int actual_frame_ = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log($"{name} Position: {transform.position}");
        // Debug.Log($"{name} Position: {GetComponent<Transform>().position}");
    }

    // Update is called once per frame
    void Update()
    {   
        if (actual_frame_++ == frames_at_change_) {
            Debug.Log($"{name} Position: {transform.position}");
            actual_frame_ = 0;
        }
    }
}
