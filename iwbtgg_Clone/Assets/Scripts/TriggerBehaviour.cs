using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets._2D;
public class TriggerBehaviour : MonoBehaviour
{
    private PeixeBehaviour peixeBehaviour;
    
    
    // Use this for initialization
    void Start()
    {
        peixeBehaviour = FindObjectOfType(typeof(PeixeBehaviour)) as PeixeBehaviour;
        peixeBehaviour.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            peixeBehaviour.MoveFish = true;
            peixeBehaviour.gameObject.SetActive(true);
            
            
        }
    }
    
}
