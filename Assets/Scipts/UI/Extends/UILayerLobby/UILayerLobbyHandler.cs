using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    class UILayerLobbyHandler : MonoBehaviour
    {
        public void HandleOnActivateLayer()
        {
            if (null != this._gotoGameButton)
            {
                this._gotoGameButton.onClick.AddListener(_HandleOnClickGotoGame);
                this._gotoJoinButton.onClick.AddListener(_HandleOnClickGotoJoin);
            }
        }
        public void HandleOnDeActivateLayer()
        {
            if(null!= this._gotoGameButton)
            {
                this._gotoGameButton.onClick.RemoveListener(_HandleOnClickGotoGame);
                this._gotoJoinButton.onClick.RemoveListener(_HandleOnClickGotoJoin);
            }
        }
        public void _HandleOnClickGotoGame()
        {
            UIManager.Instance.DeactivateUiLayer(UILayerType.LOBBY);
            UIManager.Instance.ActivateUILayer(UILayerType.GAME);
            if(null!= this._idInputField)
            {
                PlayerPrefs.SetString("ID", this._idInputField.text);
            }
            if (null != this._passwordInputField)
            {
                PlayerPrefs.SetString("", this._passwordInputField.text);
            }
        }
        public void _HandleOnClickGotoJoin()
        {
            UIManager.Instance.DeactivateUiLayer(UILayerType.LOBBY);
            UIManager.Instance.ActivateUILayer(UILayerType.JOIN);
           
        }
        [SerializeField]
        private Button _gotoGameButton = null;
        [SerializeField]
        private Button _gotoJoinButton = null;
        [SerializeField]
        private InputField _idInputField = null;
        [SerializeField]
        private InputField _passwordInputField = null;

    }
}