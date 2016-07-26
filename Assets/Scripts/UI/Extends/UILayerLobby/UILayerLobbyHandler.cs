using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts.Scene;
namespace Assets.Scripts.UI
{
    class UILayerLobbyHandler : MonoBehaviour
    {
        public void HandleOnActivateLayer()
        {
            if (null != this._gotoGameButton)
            {
                this._gotoGameButton.onClick.AddListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoJoinButton)
            {
                this._gotoJoinButton.onClick.AddListener(_HandleOnClickGotoJoin);
            }
        }
        public void HandleOnDeActivateLayer()
        {
            if(null!= this._gotoGameButton)
            {
                this._gotoGameButton.onClick.RemoveListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoJoinButton)
            {
                this._gotoJoinButton.onClick.RemoveListener(_HandleOnClickGotoJoin);
            }
        }
        public void _HandleOnClickGotoGame()
        {
            SceneManager.Instance.ChangeSceneRequest(SceneType.GAME);

            if (null!= this._idInputField)
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
            SceneManager.Instance.ChangeSceneRequest(SceneType.JOIN);
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