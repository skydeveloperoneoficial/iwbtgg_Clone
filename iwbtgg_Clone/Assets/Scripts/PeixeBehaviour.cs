using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;
using UnityEngine.UI;

public class PeixeBehaviour : MonoBehaviour
{
    public  float  speed;
    private Vector3 pos;
    public bool MoveFish;
    public  Text gameOver;
    public bool enableGravity= false;
   [SerializeField] private  float timeToDestroy;
    public SpriteRenderer spriteRenderer;
    //private Rigidbody2D rb;
    private Platformer2DUserControl robot;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = FindObjectOfType(typeof(Text)) as Text;
        robot = FindObjectOfType(typeof(Platformer2DUserControl)) as Platformer2DUserControl;
        gameOver.text = "GameOver";
        gameOver.gameObject.SetActive(false);
        MoveFish = false;
       spriteRenderer = FindObjectOfType(typeof(SpriteRenderer))as SpriteRenderer;
      
    }

    // Update is called once per frame
    void Update()
    {

        if(MoveFish)
        transform.Translate(Vector3.up * speed * Time.deltaTime);

    }
    private void FixedUpdate()
    {
        if (enableGravity)
            //rb.gravityScale = 1;
            GetComponent<Rigidbody2D>().gravityScale = 1;
        
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            gameOver.gameObject.SetActive(true);
            
            robot.gameObject.SetActive(false);
            Destroy(gameObject, timeToDestroy);

        }
        else
        {
            
            enableGravity = true;
            


        }
        
    }




}
