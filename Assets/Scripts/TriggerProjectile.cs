using System.Numerics;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject[] projectiles;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            foreach (var projectile in projectiles)
            {
                projectile.SetActive(true);
            }
                
        }
    }
}