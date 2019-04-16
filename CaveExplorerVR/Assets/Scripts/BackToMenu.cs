using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {

    [SerializeField] private Collider playerCollider;


    private void OnTriggerEnter(Collider collision)
    {
        if (playerCollider.Equals(collision))
        {
            print("hit");
            //LoadScene("MenuScene");
            SceneManager.LoadSceneAsync("MainMenu");
        }
    }

    // Can't guarantee build order won't change, so use strings for loading
    void LoadScene(string sceneName)
    {
        print("loading scene");
        DebugUIBuilder.instance.Hide();
        StartCoroutine(ShowOverlayAndLoad(sceneName));
    }

    IEnumerator ShowOverlayAndLoad(string sceneName)
    {
        //text.transform.position = vrRig.centerEyeAnchor.position + Vector3.ProjectOnPlane(vrRig.centerEyeAnchor.forward, Vector3.up).normalized * 3f;
        //overlay.enabled = true;
        //text.enabled = true;
        // Waiting to prevent "pop" to new scene
        yield return new WaitForSeconds(0.5f);
        // Load Scene and wait til complete
        AsyncOperation asyncLoad = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        yield return null;
    }
}
