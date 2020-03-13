using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
        public Text gameOver;
        


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();


        }
        private void Start()
        {
            gameOver = FindObjectOfType(typeof(Text)) as Text;

            gameOver.text = "GameOver";
            gameOver.gameObject.SetActive(false);
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.LeftControl);
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(h, crouch, m_Jump);
            m_Jump = false;
        }

      
        private void OnCollisionEnter2D(Collision2D collision)
        {
                if (collision.gameObject.CompareTag("armadilha"))
                {

                    gameOver.gameObject.SetActive(true);
                  
                    Debug.Log("ok");
                    Destroy(gameObject);
                    

                }
        }

    }
}
