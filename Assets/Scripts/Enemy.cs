using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject enemyDeathFX;
    [SerializeField] Transform parent;
    [SerializeField] int scorePerHit = 12;
    [SerializeField] int hits = 10;


    // Start is called before the first frame update
    void Start()
    {
        addAnotherCollision();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void addAnotherCollision()
    {
        Collider boxCollider = gameObject.GetComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }
    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        if (hits < 1)
        {
            KillEnemies();
        }
    }

    private void ProcessHit()
    {
        ScoreBorad.instance.ScoreHit(scorePerHit);
        hits = hits - 1;
    }

    private void KillEnemies()
    {
        GameObject fx = Instantiate(enemyDeathFX, gameObject.transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject);
    }
}
