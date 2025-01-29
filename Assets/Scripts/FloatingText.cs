using UnityEngine;

public class FloatingText : MonoBehaviour
{
    private Transform mainCam;
    private Transform unity;
    private Transform worldSpace;

    public Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCam = Camera.main.transform;
        unity = transform.parent;
        worldSpace = GameObject.FindAnyObjectByType<Canvas>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - mainCam.transform.position);
        transform.position = unity.position + offset;
    }
}
