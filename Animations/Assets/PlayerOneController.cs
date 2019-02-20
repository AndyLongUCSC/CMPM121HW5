using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneController : MonoBehaviour
{
    public float speed = 5f;
    public float rotateSpeed = 90f;

    public Animator animator;

    private Rigidbody rb;

    float axis;
    float axis2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    private void Update()
    {
        axis = Input.GetAxis("Vertical");
        axis2 = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        rb.velocity = transform.forward * speed * axis * Time.deltaTime;

        transform.Rotate(Vector3.up * rotateSpeed * axis2 * Time.deltaTime);

        animator.SetFloat("Velocity", rb.velocity.z);
        animator.SetFloat("HVelocity", rb.velocity.x);
    }
}
