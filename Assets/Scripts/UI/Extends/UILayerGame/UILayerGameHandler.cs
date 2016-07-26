using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts.Scene;

namespace Assets.Scripts.UI
{
    public class UILayerGameHandler : MonoBehaviour
    {

        public void HandleOnActivateLayer()
        {
            if (null != this._gotoLobbyButton)
            {
                this._gotoLobbyButton.onClick.AddListener(_HandleOnClickGotoLobby);
            }
            if (null != this._gotoGameLobbyButton)
            {
                this._gotoGameLobbyButton.onClick.AddListener(_HandleOnClickGotoGameLobby);
            }
            if (null != this._gotoGameLobbyButton2)
            {
                this._gotoGameLobbyButton2.onClick.AddListener(_HandleOnClickGotoGameLobby);
            }
            if (null != this._gotoGameLobbyButton3)
            {
                this._gotoGameLobbyButton3.onClick.AddListener(_HandleOnClickGotoGameLobby);
            }
            if (null != this._gotoGameLobbyButton4)
            {
                this._gotoGameLobbyButton4.onClick.AddListener(_HandleOnClickGotoGameLobby);
            }
            if (null != this._gotoGameLobbyButton5)
            {
                this._gotoGameLobbyButton5.onClick.AddListener(_HandleOnClickGotoGameLobby);
            }
            if (null != this._gotoGameLobbyButton6)
            {
                this._gotoGameLobbyButton6.onClick.AddListener(_HandleOnClickGotoGameLobby);
            }
        }
        public void HandleOnDeActivateLayer()
        {
            if (null != this._gotoLobbyButton)
            {
                this._gotoLobbyButton.onClick.RemoveListener(_HandleOnClickGotoLobby);
            }
            if (null != this._gotoGameLobbyButton)
            {
                this._gotoGameLobbyButton.onClick.RemoveListener(_HandleOnClickGotoGameLobby);
            }
            if (null != this._gotoGameLobbyButton2)
            {
                this._gotoGameLobbyButton2.onClick.RemoveListener(_HandleOnClickGotoGameLobby);
            }
            if (null != this._gotoGameLobbyButton3)
            {
                this._gotoGameLobbyButton3.onClick.RemoveListener(_HandleOnClickGotoGameLobby);
            }
            if (null != this._gotoGameLobbyButton4)
            {
                this._gotoGameLobbyButton4.onClick.RemoveListener(_HandleOnClickGotoGameLobby);
            }
            if (null != this._gotoGameLobbyButton5)
            {
                this._gotoGameLobbyButton5.onClick.RemoveListener(_HandleOnClickGotoGameLobby);
            }
            if (null != this._gotoGameLobbyButton6)
            {
                this._gotoGameLobbyButton6.onClick.RemoveListener(_HandleOnClickGotoGameLobby);
            }
        }
        public void _HandleOnClickGotoLobby()
        {
            SceneManager.Instance.ChangeSceneRequest(SceneType.LOBBY);
        }
        public void _HandleOnClickGotoGameLobby()
        {
            SceneManager.Instance.ChangeSceneRequest(SceneType.GAMELOBBY);
        }
        
        [SerializeField]
        private Button _gotoLobbyButton = null;
        [SerializeField]
        private Button _gotoGameLobbyButton = null;
        [SerializeField]
        private Button _gotoGameLobbyButton2 = null;
        [SerializeField]
        private Button _gotoGameLobbyButton3 = null;
        [SerializeField]
        private Button _gotoGameLobbyButton4 = null;
        [SerializeField]
        private Button _gotoGameLobbyButton5 = null;
        [SerializeField]
        private Button _gotoGameLobbyButton6 = null;
    }

}