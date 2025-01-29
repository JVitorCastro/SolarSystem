using Unity.VisualScripting;
using UnityEngine;

public class Sol : MonoBehaviour
{
    public GameObject FloatingTextPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowFloatingText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowFloatingText()
    {
        Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
    }
}
