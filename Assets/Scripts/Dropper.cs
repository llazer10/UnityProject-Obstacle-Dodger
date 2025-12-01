using UnityEngine;
using UnityEngine.InputSystem;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timer = 3f;

    MeshRenderer MeshRenderer;
    Rigidbody Rigidbody;

    void Start()
    {
        MeshRenderer = GetComponent<MeshRenderer>();
        MeshRenderer.enabled = false;

        Rigidbody = GetComponent<Rigidbody>();
        Rigidbody.useGravity = false;

    }

    void Update()
    {
        if(Time.time > timer)
        {
            MeshRenderer.enabled = true;
            Rigidbody.useGravity = true;
        }
    }
}
