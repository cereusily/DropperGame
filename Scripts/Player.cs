using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Rotates camera
        Time.timeScale += Time.fixedDeltaTime * 0.01f;
        transform.rotation *= Quaternion.Euler(0, 0, Time.deltaTime * 7f);

        // Gets movement from keys
        rb.velocity += transform.rotation * (Input.GetAxisRaw("Horizontal") * Vector3.right * 40f).normalized * Time.deltaTime * speed;
        rb.velocity += transform.rotation * (Input.GetAxisRaw("Vertical") * Vector3.up * 40f).normalized * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Resets time scale back to 1 (slows player down again per start of game)
        Time.timeScale = 1f;

        // If player collides with any object, reload game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
