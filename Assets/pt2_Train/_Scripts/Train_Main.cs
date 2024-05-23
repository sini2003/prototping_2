using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train_Main : MonoBehaviour
{
    public float Train_Speed = 0.01f;
    float Train_Brake = 9.8f;
    float Train_NowSpeed;

    //bool InRail = false;

    public GameObject Train;

    Vector3 Train_Vec = Vector3.zero;
    
    // Start is called before the first frame update
    void Start()
    {
        Train_Vec = Train.transform.position;
        Train_NowSpeed = Train_Speed / Train_Brake;
    }

    // Update is called once per frame
    void Update()
    {
        Train_Vec.x += Train_NowSpeed;
        Train.transform.position = Train_Vec;

    }
}
