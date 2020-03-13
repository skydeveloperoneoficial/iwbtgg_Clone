using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerBehaviourEnd : MonoBehaviour
{
    public Text Voceganhou;
    
    //public Button button;
    // Start is called before the first frame update
    void Start()
    {

        Voceganhou = FindObjectOfType(typeof(Text)) as Text;
        
        Voceganhou.text = "Voce ganhou";
        Voceganhou.gameObject.SetActive(false);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
        
            Voceganhou.gameObject.SetActive(true);
            

        }
    }
}
