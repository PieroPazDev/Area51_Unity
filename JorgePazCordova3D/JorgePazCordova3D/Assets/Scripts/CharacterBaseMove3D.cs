using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBaseMove3D : MonoBehaviour {

    Rigidbody rigBod;
    Vector3 movement;
    Vector3 respawnPos;

    public float speed = 2f;
    public float jumpForce = 10f;
    public float angSpeed = 125f;

	void Start () {
        rigBod = GetComponent<Rigidbody>();
        respawnPos = transform.position;
	}

	private void Update()
	{
        if (Input.GetKeyDown(KeyCode.Space)){
            rigBod.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
	}

	void FixedUpdate (){
        movement = transform.forward * Input.GetAxis("Vertical");
        rigBod.MovePosition(rigBod.position + (movement * speed * Time.fixedDeltaTime));
        Quaternion rotation =  Quaternion.Euler(Vector3.up * Input.GetAxis("Horizontal") * angSpeed * Time.fixedDeltaTime);
        rigBod.MoveRotation(rotation * rigBod.rotation);

	}

    void Respawn(){
        rigBod.velocity = Vector3.zero;
        rigBod.MovePosition(respawnPos);
    }

	private void OnTriggerExit(Collider other){
        if (other.CompareTag("PlayArea")){
            Respawn();
        }
	}
	private void OnDrawGizmos()
	{
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward);
	}
}
