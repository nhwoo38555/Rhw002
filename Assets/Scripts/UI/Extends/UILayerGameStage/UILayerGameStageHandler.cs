using UnityEngine;
using System.Collections;
using UnityEngine.UI;
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
            UIManager.Instance.DeactivateUiLayer(UILayerType.GAMESTAGE);
            UIManager.Instance.ActivateUILayer(UILayerType.GAMESCENE);
           
        }
        public void _HandleOnClickGotoLobby()
        {
            UIManager.Instance.DeactivateUiLayer(UILayerType.GAMESTAGE);
            UIManager.Instance.ActivateUILayer(UILayerType.LOBBY);

        }
        [SerializeField]
        private Button _gotoGameScene = null;
    }
}
