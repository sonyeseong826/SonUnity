using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class GyroController : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;
    public Vector3 v3;
    public Text t;

    void Start()
    {
        // ���̷ν����� Ȱ��ȭ
        gyroEnabled = EnableGyro();
    }

    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            return true;
        }
        return false;
    }

    void Update()
    {
        if (gyroEnabled)
        {
            Quaternion deviceRotation = gyro.attitude;
            
            
            gameObject.transform.rotation = new Quaternion(deviceRotation.y, -deviceRotation.z, -deviceRotation.x, deviceRotation.w);
            v3 = transform.eulerAngles;

            t.text = "����" + v3;

        }
    }

}
