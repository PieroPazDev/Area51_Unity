using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EntityData.StructLib;
using VectorLib;

public class CharacterBaseMov3D : MonoBehaviour {

    Rigidbody rigBod;
    Vector3 movement;

    CharTransformData respawnData;

    public float speed = 5f;
    public float angSpeed = 25f;
    public float jumpForce = 10f;

    public bool grounded = false;
    public bool inputEnabled = true;
    List<Collider> groundCollection;
    Activator currentActivator;

    //List<GroundData> groundCollection;

    Animator playerAnimator;


    // Use this for initialization
    void Start () {
        groundCollection = new List<Collider>();
        rigBod = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        respawnData.position = transform.position;
        respawnData.rotation = transform.rotation;
	}

	void Update () {
        if (inputEnabled){
            if (grounded && Input.GetKeyDown(KeyCode.Space))
            {
                //Set velocity Y to zero for consistent jump height
                rigBod.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            }
            else if (currentActivator && Input.GetKeyDown(KeyCode.E))
            {
                currentActivator.Use();
                playerAnimator.SetTrigger("Pickup");
                inputEnabled = false;
            }

            if (rigBod.velocity.x != 0 || rigBod.velocity.z != 0)
            {
                Vector3 temp = rigBod.velocity;
                temp.x = Mathf.MoveTowards(temp.x, 0, 2f * Time.deltaTime);
                temp.z = Mathf.MoveTowards(temp.z, 0, 2f * Time.deltaTime);
                rigBod.velocity = temp;
                Debug.Log(rigBod.velocity);
            }
            //Epsilon: infinito a 0
            //Movetowards: vector 3 para floats
        }
	}

	void FixedUpdate () {
        float verticalMagnitude = 0, angularMagnitude = 0;

        if (inputEnabled){
            verticalMagnitude = Input.GetAxis("Vertical");
            angularMagnitude = Input.GetAxis("Horizontal");
        }
        movement = transform.forward * verticalMagnitude;
        playerAnimator.SetFloat("MoveSpeed", verticalMagnitude);
        rigBod.MovePosition(rigBod.position + (movement * speed * Time.fixedDeltaTime));
        Quaternion rotation = Quaternion.Euler(Vector3.up * angularMagnitude * angSpeed * Time.fixedDeltaTime);
        //Quaternion rotation = Quaternion.Euler(Vector3.up * Input.GetAxis("Horizontal") * angSpeed * Time.fixedDeltaTime);
        //cambiar horizontal por mouse x o y para mover con el mouse
        rigBod.MoveRotation(rotation * rigBod.rotation);
	}

    public void Respawn () {
        rigBod.velocity = Vector3.zero;
        Reposition (respawnData);
        CamBehaviour.main.Reposition(respawnData.position + CamBehaviour.main.data.followDistance);
    }

    public void EnableInput () {
        inputEnabled = true;
    }

    public void Reposition (CharTransformData transformData) {
        rigBod.MovePosition (respawnData.position);
        rigBod.MoveRotation (respawnData.rotation);
    }

    public void SetRespawn (CharTransformData transformData) {
        respawnData = transformData;
    }

	/*float GetMaxInclination () {
    groundCollection.Sort((x, y) => y.incNormalized.CompareTo(x.incNormalized));
    return groundCollection.Count != 0 ? groundCollection[0].incNormalized : 0;
    }*/

	void OnCollisionStay (Collision collision) {
        if (!groundCollection.Contains(collision.collider)) {
            foreach (ContactPoint contact in collision.contacts) {
                Debug.DrawRay(contact.point, contact.normal, Color.yellow, 0.25f);
                float inclination;
                if ((inclination = Vector3.Dot(contact.normal, Vector3.up)) > 0.85f) {
                    grounded = true;
                    playerAnimator.SetBool("Grounded", grounded);
                    groundCollection.Add(collision.collider);
                    if (collision.collider.CompareTag("MovingPlatform")) {
                        transform.SetParent(collision.transform);
                    }
                    break;
                }
            }
        }
    }

	void OnCollisionExit(Collision collision) {
        if (groundCollection.Contains(collision.collider)) {
            groundCollection.Remove(collision.collider);
        if (collision.collider.CompareTag("MovingPlatform")) {
                transform.SetParent(null);
                Vector3 exitMomentum = collision.collider.GetComponent<PlatformBehaviour>().currentMomentum;
                exitMomentum = VectorExt.OneByOneProduct(exitMomentum, VectorExt.zeroY);
                rigBod.AddForce(exitMomentum, ForceMode.VelocityChange);
            }

            /*if (collision.collider.CompareTag("MovingPlatform")){
                transform.SetParent (null);
            }*/
        }
        if (groundCollection.Count == 0) {
            grounded = false;
            playerAnimator.SetBool("Grounded", grounded);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Activator")) {
            currentActivator = other.GetComponent<Activator>();
        }
    }

    void OnTriggerExit (Collider other) {
        if (other.CompareTag("GameArea")) {
            inputEnabled = false;
            //Respawn();
            GameControl.instance.StartRespawnProcess();
        } else if (other.CompareTag("Activator")) {
            currentActivator = null;
        }
    }

    void OnDrawGizmos () {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position + Vector3.up , transform.forward);
	}
}

//Pasar grounded al animatior para animacion de salto
//Modificar velocity solo donde no se afecte