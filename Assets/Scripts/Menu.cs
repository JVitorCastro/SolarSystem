using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject painelMenu;
    [SerializeField] private GameObject painelNickName;
    [SerializeField] private GameObject painelNickName2;
    private string nick1, nick2;

    public void Player1()
    {
        painelMenu.SetActive(false);
        painelNickName2.SetActive(false);
        painelNickName.SetActive(true);
    }

    public void Player2() 
    {
        painelMenu.SetActive(false);
        painelNickName.SetActive(false);
        painelNickName2.SetActive(true);
    }

    public void Jogar()
    {
        SceneManager.LoadScene(0);
    }

    public void ReadInputString(string s1)
    {
        this.nick1 = s1;
        Debug.Log("nick1: " + nick1);

    }

    public void ReadInputString2(string s2)
    {
        this.nick2 = s2;
        Debug.Log("nick2: " + nick2);
    }

    void OnDisable()
    {
        PlayerPrefs.SetString("nick1", this.nick1);
        PlayerPrefs.SetString("nick2", this.nick2);
    }

}
