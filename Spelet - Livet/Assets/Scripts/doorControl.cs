using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorControl : MonoBehaviour
{
    public float speed;
    public float angle;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        angle = transform.eulerAngles.y;
        //Tilldelar angle det värde, vad det än var, den hade vid uppstarten av programmet
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Round(transform.eulerAngles.y) != angle)
        {
            transform.Rotate(direction * speed);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            angle = 90;
            direction = Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            angle = 0;
            direction = -Vector3.up;
        }
    }
}
