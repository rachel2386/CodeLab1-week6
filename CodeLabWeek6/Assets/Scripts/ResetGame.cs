using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetGame : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D myRB;
    public Text StateText;
    
    private void Start()
    {
        StateText = GameObject.Find("Text").GetComponent<Text>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("r"))
            SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag.Equals("Trap"))
        {
            StateText.text = "Game Over :(";
            Destroy(this.gameObject);
        }
        
        if (other.gameObject.tag.Equals("Goal"))
        {
            StateText.text = "You Win!";
            Destroy(other.gameObject);
            Destroy(GetComponent<PlayerMovement>());
            Destroy(myRB);
        }
        
    }
}
