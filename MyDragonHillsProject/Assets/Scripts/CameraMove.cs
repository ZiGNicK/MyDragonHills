using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    [SerializeField]
    private Transform currentDragonTransform;

    private Vector3 startdiff;
    private Vector3 tempV3;

    // Use this for initialization
    void Start () {

        //prevDragonTransform.x = currentDragonTransform.position.x;
        //prevDragonTransform.y = currentDragonTransform.position.y;
        startdiff = transform.position - currentDragonTransform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {

        //tempV3 = new Vector3(currentDragonTransform.position.x - prevDragonTransform.x,
        //                        currentDragonTransform.position.y - prevDragonTransform.y, 0);

        //transform.position = transform.position + tempV3;

        Vector3 diff = currentDragonTransform.position - transform.position;
        //diff.Normalize();

        tempV3 = new Vector3(currentDragonTransform.position.x + startdiff.x, transform.position.y, transform.position.z);

        transform.position = tempV3;
        //float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

    }
}
