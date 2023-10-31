using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private float horitzontalInput;

    private float xRange = 15f;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horitzontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horitzontalInput * Time.deltaTime * speed);

        PlayerInBounds();



    }


    private void PlayerInBounds()
    {
        Vector3 pos = transform .position;

        if (pos.x < -xRange)
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);

        }

        if (pos.x > xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);

        }


    }
}
