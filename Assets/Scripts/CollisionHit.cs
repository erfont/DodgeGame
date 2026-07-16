using UnityEngine;

public class CollisionHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") GetComponent<MeshRenderer>().material.color = Color.red;   
    }
}
