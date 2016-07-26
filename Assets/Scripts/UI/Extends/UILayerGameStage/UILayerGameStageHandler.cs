using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts.Scene;

namespace Assets.Scripts.UI { 
public class UILayerGameStageHandler : MonoBehaviour {
        public void HandleOnActivateLayer()
        {
            if (null != this._gotoGameScene)
            {
                this._gotoGameScene.onClick.AddListener(_HandleOnClickGotoScene);
                
            }
        }
        public void HandleOnDeActivateLayer()
        {
            if (null != this._gotoGameScene)
            {
                this._gotoGameScene.onClick.RemoveListener(_HandleOnClickGotoScene);
            }
        }
        public void _HandleOnClickGotoScene()
        {
            SceneManager.Instance.ChangeSceneRequest(SceneType.GAMESCENE);
        }
       
        [SerializeField]
        private Button _gotoGameScene = null;
    }
}
