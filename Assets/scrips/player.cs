using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
   // public float ho, ver;
    private Rigidbody rig;
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.interpolation = RigidbodyInterpolation.Interpolate;
    }

    // Update is called once per frame
    void Update()
    {
     
       
    }
    private void FixedUpdate()
    {
        float ho = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 movi = new Vector3(ho, 0.0f, ver);
       // Vector3 ii = new Vector3(rig.position.x, rig.position.y, rig.position.z);
        rig.MovePosition(rig.position + movi * vel*Time.fixedDeltaTime );
    }
}
