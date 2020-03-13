using UnityEngine;
using System.Collections;

public class QuandradoUpBehaviour : MonoBehaviour
{
    public bool invertGravity,enableGravity;
    private Rigidbody2D rd;

    // Use this for initialization
    void Start()
    {
        rd =  GetComponent<Rigidbody2D>();
        invertGravity = true;
    }
    private void FixedUpdate()
    {

       
        InvertGravity();

    }

    // Update is called once per frame
    void Update()
    {

    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            invertGravity = true;
            


        }
    }
    void InvertGravity()
    {
        if (invertGravity)
            rd.gravityScale = -001;
    }
   
}
