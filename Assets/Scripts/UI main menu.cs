using UnityEngine;
using UnityEngine.UI;

public class UImainmenu : MonoBehaviour
{
    [SerializeField] Button _newGame;
    // Start is called before the first frame update
    void Start()
    {
        _newGame.onClick.AddListener(StartNewGame);
    }

    // Update is called once per frame
    private void StartNewGame()
    {
        ScenesScript.Instance.LoadNewGame();
    }
}
