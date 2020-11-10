using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GripperCollider : MonoBehaviour
{
    bool hasTarget = false;
    public GameObject target;
    public Transform snapPositon;
    void Start()
    {
        snapPositon = GameObject.FindGameObjectWithTag(Tag.SNAPPOSITION).transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag(Tag.GRIPPER_OBJECT)&&!hasTarget&& collision.collider.gameObject.GetComponent<GripperObject>().isMatchGripper())
        {
                target = collision.collider.gameObject;
                hasTarget = true;
                target.transform.SetParent(snapPositon);
                target.GetComponent<Rigidbody>().useGravity = false;
           
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        hasTarget = false;
        target.transform.SetParent(null);
        target.GetComponent<Rigidbody>().useGravity = true;
        target = null;
      
    }
 
}
