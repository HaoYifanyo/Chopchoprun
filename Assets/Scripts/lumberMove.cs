using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lumberMove : MonoBehaviour
{
    public randomTime randomTime;

    public float lumberSpeed = 0.02f;
    public float lumberJump = 10f;
    public float lumberRotateSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (randomTime.controlIndex == 0f)
        {

            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");

            gameObject.transform.position = new Vector3(transform.position.x + (h * lumberSpeed), transform.position.y, transform.position.z + (v * lumberSpeed));

            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.GetComponent<Rigidbody>().AddForce(0, lumberJump, 0);
            }

            // rotate to the moving direction
            Vector3 movement = new Vector3(h, 0, v);
            if (movement.magnitude > 0)
            {
                Quaternion targetRotation = Quaternion.LookRotation(-movement.normalized);
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, lumberRotateSpeed * Time.deltaTime);
            }
        }
    }
}
