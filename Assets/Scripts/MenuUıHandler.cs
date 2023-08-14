using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuUıHandler : MonoBehaviour
{
    public TMP_InputField nameField;
    public TextMeshProUGUI highScoreText;
    public static string tempBestScoreName;

    private void Awake()
    {
        CManager.Instance.LoadThis();
        tempBestScoreName = CManager.Instance.nameText;
        nameField.text = CManager.Instance.nameText;
        highScoreText.text = "Best Score : " + CManager.Instance.nameText + " : " + CManager.Instance.highScore;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        SetName();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    void SetName()
    {
        CManager.Instance.nameText = nameField.text;
    }
}
