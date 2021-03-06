using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

private float timeBtwAttack;
public float startTimeBtwAttack;

public Transform attackPos;
public LayerMask whatIsEnemies;
public float attackRange;
public Animator anim;
public int damage;

void Start(){
    anim = GetComponent <Animator>();
}
void Update() {
    

    if(timeBtwAttack <= 0){
    // then you can attack
    if (Input.GetKey(KeyCode.Space)){
            Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
            for (int i = 0; i < enemiesToDamage.Length; i++){
                enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);   
            }
        }

        timeBtwAttack = startTimeBtwAttack;
        } else {
        timeBtwAttack -= Time.deltaTime;
        }
    }

    void OnDrawGizmosSelected(){

        Gizmos.color = Color.red;
    }
}