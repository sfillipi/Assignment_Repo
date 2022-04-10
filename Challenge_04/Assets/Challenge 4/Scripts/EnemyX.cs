using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyX : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    public SpawnManagerX spawnManagerScript;

    public int enemiesDestroyed = 0;
    public GameObject lossText;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player Goal");
        spawnManagerScript = GameObject.Find("Spawn Manager").GetComponent<SpawnManagerX>();
        speed = 100 * spawnManagerScript.waveCount;

        lossText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
            enemiesDestroyed++;

            if (spawnManagerScript.enemyCount == enemiesDestroyed)
            {
                LossCondition();
            }
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
        }

    }

    public void LossCondition()
    {
        lossText.gameObject.SetActive(true);

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

}
