using UnityEngine;
using System.Collections;
using Assets.Scripts.UI;
using Assets.Scripts.Scene;
public class Main : MonoBehaviour {

    void Awake()
    {
        SceneManager.Instance.Initialize();
        UIManager.Instance.Initialize();
    }
	void OnDestroy()
    {
        UIManager.Instance.Terminate();
        SceneManager.Instance.Terminate();
    }
	void Start () {
        SceneManager.Instance.ChangeSceneRequest(SceneType.LOBBY);
    }
	
	
	void Update () {
        SceneManager.Instance.UpDateCustomPre();
        SceneManager.Instance.UpDateCustom();
       
        UIManager.Instance.UpdateCustom();
        SceneManager.Instance.UpDateCustomPost();
    }
}
