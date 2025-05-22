using UnityEngine;
using UnityEngine.UI;

public class InputFieldController : MonoBehaviour
{
    public InputField[] inputFields; // 存储三个InputField
    public Text buttonText; // 存储Button下的Text组件
    public InputField inputField;
    public Button clearButton;
    private AudioSource audioSource;

    private int currentIndex = 0; // 记录当前正在操作的InputField索引

    void Start()
    {
        clearButton.onClick.AddListener(ClearInputField);
        audioSource = GetComponent<AudioSource>(); // 获取 AudioSource 组件
    }

    public void ClearInputField()
    {
        // 遍历inputFields数组,将每个InputField的文本清空
        foreach (InputField inputField in inputFields)
        {
            inputField.text = "";
        }

        // 将当前索引重置为0
        currentIndex = 0;
        inputFields[currentIndex].ActivateInputField();
        audioSource.Play(); // 播放声音
    }


    public void OnButtonClick()
    {
        // 将Button下的Text内容添加到当前InputField
        inputFields[currentIndex].text = buttonText.text;

        // 将焦点移动到下一个InputField
        currentIndex++;

        // 如果已经超出InputField数组长度,则从第一个开始
        if (currentIndex >= inputFields.Length)
            currentIndex = 0;

        // 设置焦点到下一个InputField
        inputFields[currentIndex].ActivateInputField();
        audioSource.Play(); // 播放声音
    }

    void Update()
    {
        // 检测是否有任意输入
        if (Input.anyKeyDown)
        {
            // 检测当前InputField是否有文字
            if (!string.IsNullOrEmpty(inputFields[currentIndex].text))
            {
                // 如果有文字,则将焦点移动到下一个InputField
                currentIndex++;

                // 如果已经超出InputField数组长度,则从第一个开始
                if (currentIndex >= inputFields.Length)
                    currentIndex = 0;

                // 设置焦点到下一个InputField
                inputFields[currentIndex].ActivateInputField();
                audioSource.Play(); // 播放声音
            }
        }
    }
}
