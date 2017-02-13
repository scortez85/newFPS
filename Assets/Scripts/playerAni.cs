using UnityEngine;
using System.Collections;

public class playerAni : MonoBehaviour {

    Animator ani;
    hashID hashIDs;
	void Start () {
        ani = GetComponent<Animator>();
        hashIDs = GetComponent<hashID>();
	
	}
	
	// Update is called once per frame
	void Update () {
        float vert = Input.GetAxis("Vertical");
        float horiz = Input.GetAxis("Horizontal");

        if (vert != 0 || horiz != 0)
        {
            ani.SetFloat(hashIDs.speed, 5);
        }
        else ani.SetFloat(hashIDs.speed, 0);
	
	}
}
