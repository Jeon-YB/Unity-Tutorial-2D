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

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {count}");

        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");

        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.GetChild(count -1).name}");
    }

}