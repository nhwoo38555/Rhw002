using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts.Scene;
namespace Assets.Scripts.UI
{
    public class UILayerGameSceneHandler : MonoBehaviour
    {
        public void HandleOnActivateLayer()
        {
            if (null != this._gotoGameButton)
            {
                this._gotoGameButton.onClick.AddListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton2)
            {
                this._gotoGameButton2.onClick.AddListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton3)
            {
                this._gotoGameButton3.onClick.AddListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton4)
            {
                this._gotoGameButton4.onClick.AddListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton5)
            {
                this._gotoGameButton5.onClick.AddListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton6)
            {
                this._gotoGameButton6.onClick.AddListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton7)
            {
                this._gotoGameButton7.onClick.AddListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton8)
            {
                this._gotoGameButton8.onClick.AddListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameBack)
            {
                this._gotoGameBack.onClick.AddListener(_HandleOnClickGotoback);
            }
        }
        public void HandleOnDeActivateLayer()
        {
            if (null != this._gotoGameButton)
            {
                this._gotoGameButton.onClick.RemoveListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton2)
            {
                this._gotoGameButton2.onClick.RemoveListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton3)
            {
                this._gotoGameButton3.onClick.RemoveListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton4)
            {
                this._gotoGameButton4.onClick.RemoveListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton5)
            {
                this._gotoGameButton5.onClick.RemoveListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton6)
            {
                this._gotoGameButton6.onClick.RemoveListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton7)
            {
                this._gotoGameButton7.onClick.RemoveListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameButton8)
            {
                this._gotoGameButton8.onClick.RemoveListener(_HandleOnClickGotoGame);
            }
            if (null != this._gotoGameBack)
            {
                this._gotoGameBack.onClick.RemoveListener(_HandleOnClickGotoback);
            }
        }
        public void _HandleOnClickGotoGame()
        {
            SceneManager.Instance.ChangeSceneRequest(SceneType.GAMESTAGE);
        }
        public void _HandleOnClickGotoback()
        {
            SceneManager.Instance.ChangeSceneRequest(SceneType.GAMELOBBY);
        }
        [SerializeField]
        private Button _gotoGameButton = null;
        [SerializeField]
        private Button _gotoGameButton2 = null;
        [SerializeField]
        private Button _gotoGameButton3 = null;
        [SerializeField]
        private Button _gotoGameButton4 = null;
        [SerializeField]
        private Button _gotoGameButton5 = null;
        [SerializeField]
        private Button _gotoGameButton6 = null;
        [SerializeField]
        private Button _gotoGameButton7 = null;
        [SerializeField]
        private Button _gotoGameButton8 = null;
        [SerializeField]
        private Button _gotoGameBack = null;

    }
}
