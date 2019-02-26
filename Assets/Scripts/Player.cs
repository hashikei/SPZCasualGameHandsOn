using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float jump = 5f;

    private Rigidbody rb;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = Vector3.up * jump;
        }
    }

    void OnCollisionEnter(Collision collision) {
        var meshRenderer = GetComponent<MeshRenderer>();
        var color = meshRenderer.material.color;
        color.r = Random.Range(0f, 1f);
        color.g = Random.Range(0f, 1f);
        color.b = Random.Range(0f, 1f);
        meshRenderer.material.color = color;
    }
}
