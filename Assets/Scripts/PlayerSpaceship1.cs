using UnityEngine;
using TMPro;

public class PlayerSpaceship1 : MonoBehaviour
{
    private string nick2;
    public TMP_Text textMeshPro;

    Rigidbody spaceship;

    float verticalMove;
    float horizontalMove;
    float mouseInputX;
    float mouseInputY;
    float rollInput;

    [SerializeField]
    float speedMult = 1;
    [SerializeField]
    float speedMultAngle = 0.5f;
    [SerializeField]
    float speedRollMultAngle = 0.05f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMeshPro.text = this.nick2;
        Cursor.lockState = CursorLockMode.Locked;
        spaceship = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalMove = Input.GetAxis("Vertical");
        horizontalMove = Input.GetAxis("Horizontal");
        rollInput = Input.GetAxis("Roll");

        mouseInputX = Input.GetAxis("Mouse X");
        mouseInputY = Input.GetAxis("Mouse Y");
    }

    void FixedUpdate()
    {
        spaceship.AddForce(spaceship.transform.TransformDirection(Vector3.forward) * verticalMove * speedMult, ForceMode.VelocityChange);
        spaceship.AddForce(spaceship.transform.TransformDirection(Vector3.right) * horizontalMove * speedMult, ForceMode.VelocityChange);
        spaceship.AddTorque(spaceship.transform.right * speedMultAngle * mouseInputY * -1, ForceMode.VelocityChange);
        spaceship.AddTorque(spaceship.transform.up * speedMultAngle * mouseInputX, ForceMode.VelocityChange);
        spaceship.AddTorque(spaceship.transform.forward * speedRollMultAngle * rollInput, ForceMode.VelocityChange);
    }


    void OnEnable()
    {
        this.nick2 = PlayerPrefs.GetString("nick2");
        Debug.Log(this.nick2);
    }
}
