using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public float velocidad = 2f;

    // Use this for initialization 

    void Start()

    {

    }

    // Update is called once per frame 
        void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    }

}