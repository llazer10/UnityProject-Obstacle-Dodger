using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float xRotationSpeed = 0f;
    [SerializeField] float yRotationSpeed = 1f;
    [SerializeField] float zRotationSpeed = 0f;

    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(xRotationSpeed * Time.deltaTime,yRotationSpeed * Time.deltaTime,zRotationSpeed * Time.deltaTime);
    }
}
