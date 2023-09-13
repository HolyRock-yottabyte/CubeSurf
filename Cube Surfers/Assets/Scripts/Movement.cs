using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float forwardMoveSpeed;
    [SerializeField]
    private float sideMoveSpeed;

    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal") * sideMoveSpeed * Time.deltaTime;
        this.transform.Translate(horizontalAxis, 0, forwardMoveSpeed * Time.deltaTime);
    }

}
