using UnityEngine;
using UnityEngine.UI;

public class MenuPanel : PanelBase
{
    [SerializeField] private Button startGameBtn;
    [SerializeField] private InputField userNameField;
    [SerializeField] private InputField rowsField;
    [SerializeField] private InputField columnsField;

    private bool IsUserNameCorrect => userNameField.text.Length > 2;
    private bool IsRowsCorrect => int.TryParse(rowsField.text, out var rows) && rows is > 1 and < 6;
    private bool IsColumnsCorrect => int.TryParse(columnsField.text, out var columns) && columns is > 1 and < 6;
    private bool CanStartGame => IsUserNameCorrect && IsRowsCorrect && IsColumnsCorrect;

    protected override void ReleaseReferences()
    {
        startGameBtn.onClick.RemoveAllListeners();
        userNameField.onValueChanged.RemoveAllListeners();
        rowsField.onValueChanged.RemoveAllListeners();
        columnsField.onValueChanged.RemoveAllListeners();

        startGameBtn = null;
        userNameField = null;
        rowsField = null;
        columnsField = null;
    }

    public override void Initialize()
    {
        startGameBtn.onClick.AddListener(StartGame);
        userNameField.onValueChanged.AddListener(OnChangeUserName);
        rowsField.onValueChanged.AddListener(OnChangeRows);
        columnsField.onValueChanged.AddListener(OnChangeColumns);
    }

    private void StartGame()
    {
        PlayerPrefs.SetString(GameConstants.UserNameKey, userNameField.text);
        PlayerPrefs.SetString(GameConstants.RowsKey, rowsField.text);
        PlayerPrefs.SetString(GameConstants.ColumnsKey, columnsField.text);
        
        //todo: start game logic and impl
    }

    private void OnChangeColumns(string inColumns) => UpdateStartGameButtonInteractivity();
    private void OnChangeRows(string inRows) => UpdateStartGameButtonInteractivity();
    private void OnChangeUserName(string inUserName) => UpdateStartGameButtonInteractivity();
    private void UpdateStartGameButtonInteractivity() => startGameBtn.interactable = CanStartGame;
}