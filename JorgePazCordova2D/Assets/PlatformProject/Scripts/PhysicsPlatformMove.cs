using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;

public class PhysicsPlatformMove : MonoBehaviour
{
    public Vector2 speed;
    public Animator animator;
    public List<AxisPair> axes;
    public Rigidbody2D rb2D;
    public Collider2D col2D;
    public float gravity = 8;
    public float jumpForce = 7f;
    public bool grounded;

    Vector3 movement;
    Vector2 distanceLeft;
    Vector2 distanceRight;
    const float margin = 0.01f;
    const float minDistance = 0.05f;
    public Vector2 pointLeft { get { return rb2D.position + distanceLeft; } }
    public Vector2 pointRight { get { return rb2D.position + distanceRight; }}

	private void Reset() {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.gravityScale = 0;
        rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;

	}

	// Use this for initialization
	void Start() {
        distanceLeft.x = - (col2D.bounds.extents.x - margin);
        distanceLeft.y = - col2D.bounds.extents.y;
        distanceRight.x =  col2D.bounds.extents.x - margin;
        distanceRight.y = - col2D.bounds.extents.y;
    }

    // Update is called once per frame
    void Update(){
        movement = Vector3.zero;
        for (int i = 0; i < axes.Count; i++){
            if (Input.GetKey(axes[i].keyCode)){
                movement += axes[i].direction;
           }
        }

        if (grounded && Input.GetKeyDown(KeyCode.Space)){
            speed.y = jumpForce;
        }
     }
    void FixedUpdate (){
        if(!grounded){
            speed.y -= gravity * Time.fixedDeltaTime;   
        }

        GroundCheck();

        animator.SetBool("Moving", (movement.x != 0) && grounded);

        SpriteRenderer rend = GetComponent<SpriteRenderer>();
        if (movement.x > 0 && rend.flipX) { rend.flipX = false; }
        else if (movement.x < 0 && !rend.flipX) { rend.flipX = true; } 

        movement = movement.normalized * speed.x * Time.fixedDeltaTime;
        movement.y = speed.y * Time.fixedDeltaTime;
        rb2D.MovePosition(transform.position + movement);   
    }

	private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawRay (pointLeft, Vector3.down * minDistance);
        Gizmos.DrawRay (pointRight, Vector3.down * minDistance);
	}

    void GroundCheck (){
        Vector2[] points = { pointLeft, pointRight };
        RaycastHit2D[] hit2D = new RaycastHit2D[points.Length];
        grounded = false;
        for (int i = 0; i < points.Length; i++) {
            hit2D[i] = Physics2D.Raycast(points[i], Vector3.down, minDistance);
            if (hit2D[i]) {
                //Debug.Log(hit2D[i].collider.name);
                if (speed.y < 0) { 
                    transform.position = (transform.position + (Vector3.down * minDistance));
                    //Debug.Log(speed);
                    speed.y = 0;
                }
                grounded = true;
                break;
            }
        }
    }
}
