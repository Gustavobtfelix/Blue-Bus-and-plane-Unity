using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    //private Vector3 posicaoCamera = new Vector3(24.69f, 0.5f, 4.9f);
    private Vector3 posicaoCamera = new Vector3(0.00607702881f,5.65134192f,-17.5532608f);

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + posicaoCamera;
    }
}