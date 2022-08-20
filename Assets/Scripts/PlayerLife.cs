using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{

    bool isDead = false;
    [SerializeField] AudioSource deathAudioSource;

    void Update()
    {
        if (transform.position.y < -1f && !isDead)
        {
            Die();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
            Die();
        }
    }

    void Die()
    {
        deathAudioSource.Play();
        Invoke(nameof(ReloadLevel), 2f);
        isDead = true;
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
