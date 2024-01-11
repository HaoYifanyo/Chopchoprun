using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeMove : MonoBehaviour
{
    public randomTime randomTime;

    public float treeSpeed = 0.02f;
    public float treeJump = 10f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (randomTime.controlIndex == 1f)
        {
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");

            gameObject.transform.position = new Vector3(transform.position.x + (h * treeSpeed), transform.position.y, transform.position.z + (v * treeSpeed));

            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.GetComponent<Rigidbody>().AddForce(0, treeJump, 0);
            }

        }
    }
}