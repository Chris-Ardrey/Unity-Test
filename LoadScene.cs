using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Unity.FPS.UI
{
    public class LoadScene : MonoBehaviour
    {
        public string SceneName = "";

        void Update()
        {
            
        }

        public void LoadTargetScene()
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
