using UnityEngine;
using System.Collections;
using Assets.Scripts.UI;
public class Main : MonoBehaviour {

    void Awake()
    {
        UIManager.Instance.Initialize();
    }
	void OnDestroy()
    {
        UIManager.Instance.Terminate(); 
    }
	void Start () {
        UIManager.Instance.ActivateUILayer(UILayerType.LOBBY);	
	}
	
	
	void Update () {
        UIManager.Instance.UpdateCustom();
	}
}
