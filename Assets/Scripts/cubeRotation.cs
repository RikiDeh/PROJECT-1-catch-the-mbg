using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRotation : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        // Rotate the cube around its Y-axis
        transform.eulerAngles = Vector3.forward * rotationSpeed * Time.time;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
          if (collision.gameObject.CompareTag("player"))
          {
              Destroy(this.gameObject);
          }
          else if (collision.gameObject.CompareTag("Lantai"))
          {
              Destroy(this.gameObject);
          }
    }
}
