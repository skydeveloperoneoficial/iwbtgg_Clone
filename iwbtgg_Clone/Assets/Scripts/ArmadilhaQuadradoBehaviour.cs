using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets._2D;
public class ArmadilhaQuadradoBehaviour : MonoBehaviour
{

    public Rigidbody2D rb;
    public bool enableGravity;
    //public Text gameOver;
    //private Platformer2DUserControl robot;
    // Use this for initialization
    void Start()
    {
        rb = FindObjectOfType(typeof(Rigidbody2D)) as Rigidbody2D;
        //gameOver = FindObjectOfType(typeof(Text)) as Text;
        //robot = FindObjectOfType(typeof(Platformer2DUserControl)) as Platformer2DUserControl;

        enableGravity = false;
        //gameOver.text = "GameOver";
        //gameOver.gameObject.SetActive(false);
       
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if(enableGravity)
        rb.gravityScale = 7;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            enableGravity = true;
            //gameOver.gameObject.SetActive(true);
            //robot.gameObject.SetActive(false);
            
        }

    }

}
