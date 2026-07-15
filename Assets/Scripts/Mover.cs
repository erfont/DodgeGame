using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float xValue = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, 0, 0);
      
    }
}
