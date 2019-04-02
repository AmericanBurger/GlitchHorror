using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drzwi : MonoBehaviour {
    public bool otwarte = false;
    public float speed = 10f;

    public Vector3 openAngles = new Vector3(0, 0, 0);
    private Vector3 closed = Vector3.zero;
    private Vector3 current = Vector3.zero;

    private void Start()
    {
        closed = transform.eulerAngles;
        current = closed;
    }

    private void Update()
    {
        if (otwarte)
        {
            current = Vector3.Lerp(current, openAngles, Time.deltaTime * speed);
        } else
        {
            current = Vector3.Lerp(current, closed, Time.deltaTime * speed);
        }
        transform.rotation = Quaternion.Euler(current);
    }
}
