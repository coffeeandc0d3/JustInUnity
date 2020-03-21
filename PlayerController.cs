using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;
    public Vector3 change;
    public Rigidbody myCubeBody;
    // Start is called before the first frame update
    void Start()
    {

        myCubeBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;

        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if (change != Vector3.zero)
        {
           
            if (Input.GetKey(KeyCode.Space) == true)
            {
                change.y += 2;

            } else
            {
                change.y -= 2;
            }

            myCubeBody.MovePosition(transform.position + change * moveSpeed * Time.deltaTime);

        }

    }
    bool mouseIsPressed()
    {
        if (Input.GetKey(KeyCode.Space) == true)
            {
            return true;
        } 
        else 
        return false;
    }
}
