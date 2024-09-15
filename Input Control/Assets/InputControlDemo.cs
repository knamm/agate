using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlDemo : MonoBehaviour
{
    [SerializeField] private Transform _cubeTransform;
    // Start is called before the first frame update
    void Start()
    {
        _cubeTransform.localPosition = new Vector3(3, 5, 7);
        _cubeTransform.localEulerAngles = new Vector3(30, 60, 270);
        _cubeTransform.localScale = new Vector3(1, 5, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E Pressed");
        }

        if (Input.GetButtonDown("Pukul"))
        {
            Debug.Log("Pukul");
        }
    }
}
