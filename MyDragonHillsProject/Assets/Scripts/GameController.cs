using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static bool GameIsPaused = false;

    [SerializeField]
    private GameObject m_Dragon;
    private float startXPos;
    private float prevDiff;

    [SerializeField]
    private Text m_Score;

    public static int ShowFPS;
    [SerializeField]
    private Text m_FpsText;
    private float deltaTime;

    [SerializeField]
    private Text m_Diamonds;

    [SerializeField]
    private float m_Timeout = 15f;
    [SerializeField]
    private GameObject m_TimeoutPanel;
    [SerializeField]
    private GameObject m_GamePanel;
    private float endTime;
    [SerializeField]
    private Text m_TimeLeft;


    void Start () {

        ResumeGame();

        startXPos = m_Dragon.transform.position.x;
        prevDiff = 0;

        ShowFPS = PlayerPrefs.GetInt("ShowFPS");
        if (ShowFPS == 1)
        {
            m_FpsText.gameObject.SetActive(true);
        }
        else
        {
            m_FpsText.gameObject.SetActive(false);
        }

        endTime = Time.time + m_Timeout;
	}

	void Update () {

        if (endTime < Time.time)
        {
            m_TimeoutPanel.SetActive(true);
            m_GamePanel.SetActive(false);
            PauseGame();
        }
        else
        {
            m_TimeLeft.text = "Time Left: " + ((endTime - Time.time)).ToString("0.00");

            if (ShowFPS == 1 && !GameIsPaused)
            {
                calcFPS();
            }

            if (prevDiff < m_Dragon.transform.position.x - startXPos)
            {
                prevDiff = m_Dragon.transform.position.x - startXPos;
                m_Score.text = "Score: " + ((int)prevDiff * 10).ToString();
                if (PlayerPrefs.GetInt("HighestScore") < (int)prevDiff * 10)
                {
                    PlayerPrefs.SetInt("HighestScore", (int)prevDiff * 10);
                }
            }

            ShowDiamonds();
        }
	}

    public void PauseGame()
    {
        if (!GameIsPaused)
        {
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }

    public void ResumeGame()
    {
        if (GameIsPaused)
        {
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ResumeGame();
    }

    public void QuitMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        ResumeGame();
        PlayerPrefs.Save();
    }

    private void calcFPS()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        m_FpsText.text = Mathf.Ceil(fps).ToString();
    }

    public static void IncDiamonds()
    {
        PlayerPrefs.SetInt("Diamonds", PlayerPrefs.GetInt("Diamonds") + 1);
    }

    public void ShowDiamonds()
    {
        m_Diamonds.text = ":" + PlayerPrefs.GetInt("Diamonds").ToString();
    }
}
