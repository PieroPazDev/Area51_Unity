using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehaviour : MonoBehaviour {

    //[System.Serializable]
    public struct TargetData {
        public Transform target;
        public Vector3 focusDistance;
        public Vector3 followDistance;
        public float minFollowDistance;

        public void SetFromVariables(Transform target, Vector3 focus, Vector3 follow, float minSpeed){
            this.target = target;
            focusDistance = focus;
            followDistance = follow;
            minFollowDistance = minSpeed;
        }
    }

    public Transform target;
    public Vector3 focusDistance;
    Vector3 focusPoint { get { return target.position + GetRelativePos(target, focusDistance); } }
    public Vector3 followDistance;
    Vector3 followPoint { get { return target.position + GetRelativePos(target, followDistance); } }
    public float minFollowSpeed = 1f;
    public float followDistanceDelta { get { return Vector3.Distance (transform.position, followDistance); }}

    public TargetData defaultData;

    void Start () {

    }

    void LateUpdate () {
        transform.position = Vector3.MoveTowards(transform.position , followPoint, (minFollowSpeed + followDistanceDelta) * Time.deltaTime);
        transform.LookAt (focusPoint);
    }

    Vector3 GetRelativePos (Transform relativeTarget, Vector3 distance){
        Vector3 relativePos;
        relativePos = relativeTarget.right * distance.x;
        relativePos += relativeTarget.up * distance.y;
        relativePos += relativeTarget.forward * distance.z;

        return relativePos;
    }

    public void Reposition(Vector3 updatedPosition){
        transform.position = updatedPosition;
    }

    private void OnDrawGizmos () {
        Gizmos.color = Color.green;
        Gizmos.DrawLine (followPoint, focusPoint);
        Gizmos.DrawSphere (focusPoint, 0.25f);
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere (followPoint, 0.25f);
    }
}
