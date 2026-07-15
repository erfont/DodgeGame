using UnityEngine;

public class CollisionHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) => GetComponent<MeshRenderer>().material.color = Color.red;
}
