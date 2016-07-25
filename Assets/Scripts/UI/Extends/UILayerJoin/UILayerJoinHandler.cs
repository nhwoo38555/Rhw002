using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
            UIManager.Instance.DeactivateUiLayer(UILayerType.JOIN);
            UIManager.Instance.ActivateUILayer(UILayerType.LOBBY);
        }

        [SerializeField]
        private Button _gotoLobbyButton = null;

    }

}