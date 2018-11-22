﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EntityData.StructLib;

public class CharacterBaseMov3D : MonoBehaviour {

    Rigidbody rigBod;
    Vector3 movement;

    CharTransformData respawnData;

    public float speed = 5f;
    public float angSpeed = 25f;
    public float jumpForce = 10f;

    public bool grounded = false;
    List<Collider> groundCollection;
    //List<GroundData> groundCollection;

    // Use this for initialization
    void Start () {
        groundCollection = new List<Collider>();
        rigBod = GetComponent<Rigidbody>();
        respawnData.position = transform.position;
        respawnData.rotation = transform.rotation;
	}

	void Update () {
        if (grounded && Input.GetKeyDown(KeyCode.Space)) {
            //Set velocity Y to zero for consistent jump height
            rigBod.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
        if (rigBod.velocity.x != 0 || rigBod.velocity.z != 0){
            Vector3 temp = rigBod.velocity;
            temp.x = Mathf.MoveTowards(temp.x, 0, 2f * Time.deltaTime);
            temp.z = Mathf.MoveTowards(temp.z, 0, 2f * Time.deltaTime);
            rigBod.velocity = temp;
            Debug.Log(rigBod.velocity);
        }
        //Epsilon: infinito a 0
        //Movetowards: vector 3 para floats
	}

	void FixedUpdate () {
        movement = transform.forward * Input.GetAxis("Vertical");
        rigBod.MovePosition(rigBod.position + (movement * speed * Time.fixedDeltaTime));
        Quaternion rotation = Quaternion.Euler(Vector3.up * Input.GetAxis("Horizontal") * angSpeed * Time.fixedDeltaTime);
        rigBod.MoveRotation(rotation * rigBod.rotation);
	}

    void Respawn () {
        rigBod.velocity = Vector3.zero;
        Reposition (respawnData);
        CamBehaviour.main.Reposition(respawnData.position + CamBehaviour.main.data.followDistance);
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

	void OnCollisionStay(Collision collision) {
        if (!groundCollection.Contains(collision.collider)) {
            foreach (ContactPoint contact in collision.contacts) {
                Debug.DrawRay(contact.point, contact.normal, Color.yellow, 0.25f);
                float inclination;
                if ((inclination = Vector3.Dot(contact.normal, Vector3.up)) > 0.85f) {
                    grounded = true;
                    groundCollection.Add(collision.collider);
                }
                    if (collision.collider.CompareTag("MovingPlatform")) {
                        transform.SetParent(collision.transform);
                    break; 
                    }

            }
        }
    }

    void OnCollisionExit(Collision collision) {
        if (groundCollection.Contains(collision.collider)) {
            groundCollection.Remove(collision.collider);

            /*if (collision.collider.CompareTag("MovingPlatform")){
                transform.SetParent (null);
            }*/
        }
        if (groundCollection.Count == 0) {
            grounded = false;
        }

        if (collision.collider.CompareTag("MovingPlatform"))
        {
            transform.SetParent(null);
            Vector3 exitMomentum = collision.collider.GetComponent<PlatformBehaviour>().currentMomentum;
            rigBod.AddForce(exitMomentum, ForceMode.VelocityChange);
        }
    }

    void OnTriggerExit (Collider other) {
        if (other.CompareTag("GameArea")) {
            Respawn();
        }
	}

	void OnDrawGizmos () {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward);
	}
}

//Pasar grounded al animatior para animacion de salto
//Modificar velocity solo donde no se afecte