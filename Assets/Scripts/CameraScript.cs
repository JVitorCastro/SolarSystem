using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Camera4;
    public GameObject Camera5;
    public GameObject Camera6;
    public GameObject Camera7;
    public GameObject Camera8;
    public GameObject Camera9;
    public GameObject Camera10;
    public GameObject Camera11;
    public GameObject Camera12;
    public GameObject Camera13;


    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            CameraOne ();
        }

        if (Input.GetKeyDown("2"))
        {
            CameraTwo ();
        }

        if (Input.GetKeyDown("3"))
        {
            CameraThree ();
        }
        if (Input.GetKeyDown("4"))
        {
            CameraFour ();
        }
        if (Input.GetKeyDown("5"))
        {
            CameraFive ();
        }
        if (Input.GetKeyDown("6"))
        {
            CameraSix ();
        }
        if (Input.GetKeyDown("7"))
        {
            CameraSeven ();
        }
        if (Input.GetKeyDown("8"))
        {
            CameraEight ();
        }
        if (Input.GetKeyDown("9"))
        {
            CameraNine ();
        }
        if (Input.GetKeyDown(","))
        {
            CameraTen ();
        }
        if (Input.GetKeyDown("."))
        {
            CameraEleven ();
        }
        if (Input.GetKeyDown(";"))
        {
            CameraTwelve ();
        }
        if (Input.GetKeyDown("-"))
        {
            CameraThirteen ();
        }
        if (Input.GetKeyDown("]"))
        {
            DoubleCamera ();
        }
    }

    void CameraOne()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
        Camera9.SetActive(false);
        Camera10.SetActive(false);
        Camera11.SetActive(false);
        Camera12.SetActive(false);
        Camera13.SetActive(false);

    }

    void CameraTwo()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
        Camera9.SetActive(false);
        Camera10.SetActive(false);
        Camera11.SetActive(false);
        Camera12.SetActive(false);
        Camera13.SetActive(false);
    }

    void CameraThree()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(true);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
        Camera9.SetActive(false);
        Camera10.SetActive(false);
        Camera11.SetActive(false);
        Camera12.SetActive(false);
        Camera13.SetActive(false);
    }

    void CameraFour()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(true);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
        Camera9.SetActive(false);
        Camera10.SetActive(false);
        Camera11.SetActive(false);
        Camera12.SetActive(false);
        Camera13.SetActive(false);
    }
    void CameraFive()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(true);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
        Camera9.SetActive(false);
        Camera10.SetActive(false);
        Camera11.SetActive(false);
        Camera12.SetActive(false);
        Camera13.SetActive(false);
    }
    void CameraSix()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(true);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
        Camera9.SetActive(false);
        Camera10.SetActive(false);
        Camera11.SetActive(false);
        Camera12.SetActive(false);
        Camera13.SetActive(false);
    }
    void CameraSeven()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(true);
        Camera8.SetActive(false);
        Camera9.SetActive(false);
        Camera10.SetActive(false);
        Camera11.SetActive(false);
        Camera12.SetActive(false);
        Camera13.SetActive(false);
    }
    void CameraEight()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(true);
        Camera9.SetActive(false);
        Camera10.SetActive(false);
        Camera11.SetActive(false);
        Camera12.SetActive(false);
        Camera13.SetActive(false);
    }
    void CameraNine()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
        Camera9.SetActive(true);
        Camera10.SetActive(false);
        Camera11.SetActive(false);
        Camera12.SetActive(false);
        Camera13.SetActive(false);
    }
    void CameraTen()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
        Camera9.SetActive(false);
        Camera10.SetActive(true);
        Camera11.SetActive(false);
        Camera12.SetActive(false);
        Camera13.SetActive(false);
    }
    void CameraEleven()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
        Camera9.SetActive(false);
        Camera10.SetActive(false);
        Camera11.SetActive(true);
        Camera12.SetActive(false);
        Camera13.SetActive(false);
    }
    void CameraTwelve()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
        Camera9.SetActive(false);
        Camera10.SetActive(false);
        Camera11.SetActive(false);
        Camera12.SetActive(true);
        Camera13.SetActive(false);
    }
    void CameraThirteen()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
        Camera9.SetActive(false);
        Camera10.SetActive(false);
        Camera11.SetActive(false);
        Camera12.SetActive(false);
        Camera13.SetActive(true);
    }
    void DoubleCamera()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(true);
        Camera5.SetActive(true);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
        Camera9.SetActive(false);
        Camera10.SetActive(false);
        Camera11.SetActive(false);
        Camera12.SetActive(false);
        Camera13.SetActive(false);
    }
}