using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    private float speed = 500;
    public float xRange = 900;
    private Animator anim;
    private Vector3 characterScale;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Keeps player in the boudries of the game

    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("slice");
        }
        // Allows the character to move left and right
//        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetTrigger("idle");
        }

//        Flips the character
        characterScale = transform.localScale;
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
        
            public void Flip(float num)
        {
            characterScale.x = num;
            transform.localScale = characterScale;
        }
        
        public void Movement(float move)
        
        {
            horizontalInput = move;
        }
        
        public void Attack(float attack)
        {
            anim.SetTrigger("slice");
        }
        
}