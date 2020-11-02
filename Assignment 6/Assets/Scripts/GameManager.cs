using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace Assets.Scripts
{
    public class GameManager: Singleton<GameManager>
    {
        public int score;
        public bool gameOver = false;
        public bool won = false;
        public GameObject pauseMenu;
        public GameObject wonMenu;
        public GameObject lossMenu;
        public GameObject mainMenu;

        //var to keep track of current level
        private string CurrentLevelName = string.Empty;

/*        #region This code makes this class a singleton
        
        public static GameManager instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
                Debug.LogError("Trying to instantiate a second instance of singleton game manager");
            }
        }
        #endregion*/

        //methods to load and unload scenes
        public void LoadLevel(string levelName)
        {
            ResetGameState();

            AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
            if (ao == null)
            {
                Debug.LogError("[GameManager] Unable to load level " + levelName);
                return;
            }
            CurrentLevelName = levelName;
        }

        public void UnloadLevel(string levelName)
        {
            ResetGameState();
            AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
            if (ao == null)
            {
                Debug.LogError("[GameManager] Unable to unload level " + levelName);
                return;
            }
        }

        public void Pause()
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }

        public void Unpause()
        {
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.P))
            {
                Pause();
            }
            else if(gameOver)
            {
                if (won) { wonMenu.SetActive(true); }
                else if (!won) { lossMenu.SetActive(true); }
            }
        }

        public void UnloadCurrentLevel()
        {
            ResetGameState();
            AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);
            if (ao == null)
            {
                Debug.LogError("[GameManager] Unable to unload level " + CurrentLevelName);
                return;
            }
        }

        public void LoadNextLevel()
        {
            UnloadCurrentLevel();
            if (CurrentLevelName == "Level 1")
            {
                LoadLevel("Level 2");
            }
            else if (CurrentLevelName == "Level 2")
            {
                LoadLevel("Level 3");
            }
            else if (CurrentLevelName == "Level 3")
            {
                mainMenu.SetActive(true);
            }

        }

        public void ReloadLevel()
        {
            UnloadCurrentLevel();
            LoadLevel(CurrentLevelName);
        }

        public void ResetGameState()
        {
            gameOver = false;
            won = false;
        }
    }


}