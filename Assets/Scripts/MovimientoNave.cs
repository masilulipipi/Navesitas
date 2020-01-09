using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour {

    public float VelocidadMovimientoNave = 1.0f;
    public float padding = 1.0f;

    private void Update()
    {
        float verticalImput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, verticalImput * VelocidadMovimientoNave * Time.deltaTime,  0);


        float horizontalimput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalimput * VelocidadMovimientoNave * Time.deltaTime, 0, 0);


        // los limites
        float newx = Mathf.Clamp(transform.position.x, -10 + padding, 10 - padding);
        float newy = Mathf.Clamp(transform.position.y,- 10 + padding, 10 - padding);
        transform.position = new Vector3(newx, newy, transform.position.z);
    }
}
