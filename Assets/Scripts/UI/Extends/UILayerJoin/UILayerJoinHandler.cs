using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts.Scene;

namespace Assets.Scripts.UI
{
    public class UILayerJoinHandler : MonoBehaviour
    {
        public void HandleOnActivateLayer()
        {
            if (null != this._gotoLobbyButton)
            {
                this._gotoLobbyButton.onClick.AddListener(_HandleOnClickGotoLobby);

            }
        }
        public void HandleOnDeActivateLayer()
        {
            if (null != this._gotoLobbyButton)
            {
                this._gotoLobbyButton.onClick.RemoveListener(_HandleOnClickGotoLobby);

            }
        }
        public void _HandleOnClickGotoLobby()
        {
            SceneManager.Instance.ChangeSceneRequest(SceneType.LOBBY);
        }

        [SerializeField]
        private Button _gotoLobbyButton = null;

    }

}