using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AccountDataWindowBase : MonoBehaviour
{
    [SerializeField]
    private InputField _usernameField;

    [SerializeField]
    private InputField _passwordField;

    protected string _username;
    protected string _password;

    private void Start()
    {
        SubscriptionsElementsUI();
    }

    protected virtual void SubscriptionsElementsUI()
    {
        _usernameField.onValueChanged.AddListener(UpdateUsername);
        _passwordField.onValueChanged.AddListener(UpdatePassword);
    }

    private void UpdateUsername(string username)
    {
        _username = username;
    }

    private void UpdatePassword(string password)
    {
        _password = password;
    }

    protected void EnterInGameScene()
    {
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene(2);
    }
}
