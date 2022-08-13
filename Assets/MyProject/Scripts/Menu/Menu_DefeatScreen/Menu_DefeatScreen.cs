using UnityEngine;

namespace Menu.Menu_DefeatScreen
{
    public class Menu_DefeatScreen : MonoBehaviour
    {
        [SerializeField] private GameObject _menu_DefeatScreen;

        private void Awake()
        {
            if (_menu_DefeatScreen == null) { _menu_DefeatScreen = gameObject; }

            GlobalEventManager.Event_PlayerDied += Activate_Menu_Defeat;

            Deactivate_Menu_Defeat();
        }


        public void Activate_Menu_Defeat() { _menu_DefeatScreen.SetActive(true); }
        public void Deactivate_Menu_Defeat() { _menu_DefeatScreen.SetActive(false); }

    }
}