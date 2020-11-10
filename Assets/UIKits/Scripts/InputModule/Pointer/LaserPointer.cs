/***
 * Author: Yunhan Li
 * Any issue please contact yunhn.lee@gmail.com
 ***/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace VRUiKits.Utils
{
    public class LaserPointer : MonoBehaviour
    {

        LineRenderer lr;
        //public GameObject PointerSpherePrefab;
        GameObject PointerSphere;
        #region MonoBehaviour Callbacks
        void Awake()
        {
            lr = GetComponent<LineRenderer>();
            lr.widthMultiplier = 0.005f;
            lr.enabled = false;
           PointerSphere =Instantiate(Resources.Load<GameObject>(PathData.PRE_LASERPOINTER)) ;
            PointerSphere.gameObject.SetActive(false);
            // PointerSphere=Instantiate()
        }

        void LateUpdate()
        {
            if(lr.enabled) lr.SetPosition(0, transform.position);
            RaycastHit hit;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            if (Physics.Raycast(transform.position, fwd, out hit,5))
            {
                    lr.enabled = true;
                    PointerSphere.gameObject.SetActive(true);
                    lr.SetPosition(1, hit.point);
                    if (PointerSphere != null)
                        PointerSphere.transform.position = hit.point;
            }
            else
            {
                // lr.SetPosition(1, transform.forward * 10);
                
                lr.SetPosition(1, transform.forward *5);
              if (PointerSphere != null)
                   PointerSphere.transform.position = lr.GetPosition(1);
                lr.enabled = false;
                PointerSphere.gameObject.SetActive(false);
            }

        }

        void OnDisable()
        {
            if (null != lr)
            {
                // Reset position for smooth transtation when enbale laser pointer
                lr.SetPosition(0, Vector3.zero);
                lr.SetPosition(1, Vector3.zero);
               // lr.enabled = false;
            }
        }
        #endregion
    }
}
