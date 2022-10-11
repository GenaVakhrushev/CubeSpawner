using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Vector3 startPos;

    public float Speed = 5;
    public float HideDistance = 10;

    private void FixedUpdate()
    {
        if (Vector3.Distance(startPos, transform.position) >= HideDistance)
        {
            gameObject.SetActive(false);
        }

        transform.Translate(transform.forward * Speed * Time.deltaTime, Space.Self);
    }

    public void SetToStartPosition(Vector3 startPos)
    {
        this.startPos = startPos;
        transform.position = startPos;
    }
}
