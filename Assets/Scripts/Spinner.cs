using UnityEngine;

public class Spinner : MonoBehaviour
{
     [SerializeField] float xAngle, yAngle, zAngle;
    // float [SerializeField] yAngle;
    // float [SerializeField] zAngle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
