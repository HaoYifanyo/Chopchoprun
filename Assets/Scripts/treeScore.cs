using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeScore : MonoBehaviour
{
    // Start is called before the first frame update
    public randomTime randomtime;
    float escaping = 0f;
    public score score;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(escaping == 0f)
        {
            score.treescore = randomtime.scoretime/10;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "lumber")
        {
            escaping = 1;
        }
    }

}
