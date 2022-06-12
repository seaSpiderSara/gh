using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private Vector3 _velocity = Vector3.zero;
    private PlayerController _player;

    //frame borders
    //public float limitLeft, limitRight, limitTop, limitBottom;

    private void Start()
    {
        if(target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
            _player = target.GetComponent<PlayerController>();
        }
    }

   
     private void LateUpdate()
    {
        Transform currentTarget = target;
        Vector3 desiredPostion = currentTarget.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPostion, ref _velocity, smoothSpeed);

       // transform.position = new Vector3(Mathf.Clamp(smoothedPosition.x, limitLeft, limitRight), Mathf.Clamp(smoothedPosition.y, limitBottom, limitTop), smoothedPosition.z);
    }
}
