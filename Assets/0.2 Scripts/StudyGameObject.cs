using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreatePinkBean();
    }
    public void CreatePinkBean()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "PinkBean";

        Transform objTf = obj.transform;
        int count = objTf.childCount;

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {count}");

        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).name}");

        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(count -1).name}");
    }

}