using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float xMin = -11;
    [SerializeField] float xMax = 11;
    [SerializeField] float yMin = 0;
    [SerializeField] float yMax = 15;
    public Vector3 offset = new Vector3(0, 2, -10);

    private void LateUpdate()
    {

        float x = Mathf.Clamp(target.position.x, xMin, xMax);
        float y = Mathf.Clamp(target.position.y, yMin, yMax); ;
        transform.position = new Vector3(x, y, transform.position.z);
    }

}
