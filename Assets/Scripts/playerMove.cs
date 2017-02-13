using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(CharacterController))]
public class playerMove : MonoBehaviour { 
    public Vector3 targetDir;
    public float moveSpeed = 5f;
    public float turnSpeed = .05f;        
    void Update() 
    {
        
        Vector3 inputDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 v = inputDir.normalized;
        v.x = Mathf.Round(v.x);
        v.z = Mathf.Round(v.z);
        if (v.sqrMagnitude > 0.1f)
            targetDir = v.normalized;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetDir), Time.time * turnSpeed);

        if (Input.GetAxis("Vertical")!=0 || Input.GetAxis("Horizontal")!=0)
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
    }

   

}
