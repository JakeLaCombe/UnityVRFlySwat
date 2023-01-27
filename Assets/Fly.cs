using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        float dx = this.transform.position.x - player.transform.position.x;
        float dy = this.transform.position.y - player.transform.position.y;
        this.transform.rotation = Quaternion.LookRotation(new Vector3(dx, dy, this.transform.position.z));

        rigidBody.velocity = this.transform.forward * -0.1f;        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        Debug.Log("Destroyed");
    }
}
