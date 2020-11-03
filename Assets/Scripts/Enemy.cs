using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
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
        print("Particles collided with enemy"+gameObject.name);
        Destroy(gameObject);
    }
}
