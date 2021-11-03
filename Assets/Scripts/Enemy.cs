using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int health;
    private Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
       if(health <= 0) {
           Destroy(gameObject);

        }
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        Vector3 characterScale = transform.localScale;
    }
         public void TakeDamage(int damage){
             health -= damage;
             Debug.Log("damage TAKEN!!");
    }
}
