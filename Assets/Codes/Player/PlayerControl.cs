using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum PlayerState
{
    walk,
    idle,
    attack,
    interact,
    stagger,
    gameover,
}
public class PlayerControl : MonoBehaviour
{
    public GameObject RestartMenu;

    public PlayerState currentState;
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animator;
    public FloatValue currentHealth;
    public Notification healthSignal;
    //public VectorValue startingPoint;
    //public Inventory playerInventory;
    //public SpriteRenderer receivedItem;
    //public GameObject attacksfx;


    string currentscene;
    Vector3 startPosition;

 
    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        // animator.SetFloat("moveX", 0);
        //animator.SetFloat("moveY", -1);
        startPosition = transform.position;



    }

    // Update is called once per frame
    void Update()
    {
        //checks if player is in an interaction
        if (currentState == PlayerState.interact)
        {
            return;
        }
        //check if game is unpaused

        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("attack") && currentState != PlayerState.attack && currentState != PlayerState.stagger)
        {
            StartCoroutine(AttackCo());
        }
        else if (currentState == PlayerState.walk || currentState == PlayerState.idle)
        {
            UpdateAnimationAndMove();
        }

       

    }

    private IEnumerator AttackCo()
    {
        //attacksfx.SetActive(true);
        animator.SetBool("attacking", true);
        currentState = PlayerState.attack;
        yield return null;
        animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.3f);
        //attacksfx.SetActive(false);
        if (currentState != PlayerState.interact)
        {
            currentState = PlayerState.walk;
        }
    }

    private IEnumerator GameOver()
    {
        RestartMenu.SetActive(true);
        currentState = PlayerState.gameover;
        yield return null;

    }

    void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
            currentState = PlayerState.walk;
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);

        }
        else
        {
            animator.SetBool("moving", false);
        }
    }

    void FixedUpdate()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();
        }
    }
    //Debug.Log(change);
    void MoveCharacter()
    {
        //walksfx.SetActive(true);
        change.Normalize();
        myRigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
        //walksfx.SetActive(false);
    }

    public void Knock(float knockTime, float damage)
    {

        currentHealth.RuntimeValue -= damage;
        healthSignal.Raise();
        if (currentHealth.RuntimeValue > 0)
        {
            
            StartCoroutine(KnockCo(knockTime));
           
        }
        else
        {
            
            StartCoroutine(GameOver());
            currentHealth.RuntimeValue = currentHealth.initialValue;
            this.gameObject.SetActive(false);

        }
        

    }

    private IEnumerator KnockCo(float knockTime)
    {
        if (myRigidbody != null)
        {
            yield return new WaitForSeconds(knockTime);
            myRigidbody.velocity = Vector2.zero;
            currentState = PlayerState.idle;
            myRigidbody.velocity = Vector2.zero;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "Exit")
        {
            if (SceneManager.GetActiveScene().name == "Puzzle1")
            {
                SceneManager.LoadScene("Puzzle2");
            }
            if (SceneManager.GetActiveScene().name == "Puzzle2")
            {
                SceneManager.LoadScene("Piuzzle 3");
            }
            if (SceneManager.GetActiveScene().name == "Piuzzle 3")
            {
                SceneManager.LoadScene("Puzzle4");
            }
            if (SceneManager.GetActiveScene().name == "Puzzle4")
            {
                SceneManager.LoadScene("DiamondRoom");
            }
        }
       
            
       
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentscene = SceneManager.GetActiveScene().name;
        if(collision.tag == "gap")
        {
            Debug.Log("Player touched " + collision.name);
            transform.position = startPosition;

        }

        if (collision.gameObject.tag == "platformGap")
        {
            Debug.Log("Player touched " + collision.name);
            transform.position = startPosition;
        }
    }
   
    
   
}
