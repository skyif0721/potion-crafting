using UnityEngine;
using UnityEngine.UI;

public class InputFieldController : MonoBehaviour
{
    public InputField[] inputFields; // �洢����InputField
    public Text buttonText; // �洢Button�µ�Text���
    public InputField inputField;
    public Button clearButton;
    private AudioSource audioSource;

    private int currentIndex = 0; // ��¼��ǰ���ڲ�����InputField����

    void Start()
    {
        clearButton.onClick.AddListener(ClearInputField);
        audioSource = GetComponent<AudioSource>(); // ��ȡ AudioSource ���
    }

    public void ClearInputField()
    {
        // ����inputFields����,��ÿ��InputField���ı����
        foreach (InputField inputField in inputFields)
        {
            inputField.text = "";
        }

        // ����ǰ��������Ϊ0
        currentIndex = 0;
        inputFields[currentIndex].ActivateInputField();
        audioSource.Play(); // ��������
    }


    public void OnButtonClick()
    {
        // ��Button�µ�Text������ӵ���ǰInputField
        inputFields[currentIndex].text = buttonText.text;

        // �������ƶ�����һ��InputField
        currentIndex++;

        // ����Ѿ�����InputField���鳤��,��ӵ�һ����ʼ
        if (currentIndex >= inputFields.Length)
            currentIndex = 0;

        // ���ý��㵽��һ��InputField
        inputFields[currentIndex].ActivateInputField();
        audioSource.Play(); // ��������
    }

    void Update()
    {
        // ����Ƿ�����������
        if (Input.anyKeyDown)
        {
            // ��⵱ǰInputField�Ƿ�������
            if (!string.IsNullOrEmpty(inputFields[currentIndex].text))
            {
                // ���������,�򽫽����ƶ�����һ��InputField
                currentIndex++;

                // ����Ѿ�����InputField���鳤��,��ӵ�һ����ʼ
                if (currentIndex >= inputFields.Length)
                    currentIndex = 0;

                // ���ý��㵽��һ��InputField
                inputFields[currentIndex].ActivateInputField();
                audioSource.Play(); // ��������
            }
        }
    }
}
