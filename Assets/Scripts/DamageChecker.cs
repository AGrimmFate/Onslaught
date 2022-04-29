using UnityEngine;

public class DamageChecker : MonoBehaviour
{

    public HealthAndDamage Health;


    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Basic Damage")
        {
            Health.TakeDamage(2);
        }
        if (collisionInfo.collider.tag == "Weak Damage")
        {
            Health.TakeDamage(1);
        }
        if (collisionInfo.collider.tag == "Strong Damage")
        {
            Health.TakeDamage(4);
        }
        if (collisionInfo.collider.tag == "Stabby Stabby")
        {
            Health.TakeDamage(4);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Basic Damage")
        {
            Health.TakeDamage(2);
        }
        if (other.tag == "Weak Damage")
        {
            Health.TakeDamage(1);
        }
        if (other.tag == "Strong Damage")
        {
            Health.TakeDamage(4);
        }
        if (other.tag == "Stabby Stabby")
        {
            Health.TakeDamage(4);
        }
    }
}