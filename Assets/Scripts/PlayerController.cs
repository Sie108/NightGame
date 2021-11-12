using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 90.0f;
    public float xRange = 10;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Keeps player in the boudries of the game
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetTrigger("slice");
        }
        // Allows the character to move left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetTrigger("idle");
        }

        //Flips the character
        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = 17;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = -17;
        }
        transform.localScale = characterScale;
    }
}