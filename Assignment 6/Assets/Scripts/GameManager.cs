using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class GameManager: Singleton<GameManager>
    {
        public int score;
        public bool gameOver = false;
        public GameObject pauseMenu;

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
            gameOver = false;
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
        }

        public void UnloadCurrentLevel()
        {
            AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);
            if (ao == null)
            {
                Debug.LogError("[GameManager] Unable to unload level " + CurrentLevelName);
                return;
            }
        }

    }


}