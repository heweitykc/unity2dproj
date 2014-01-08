using UnityEngine;
using System.Collections;

public class TestLoadScript : MonoBehaviour {
	public GameObject  [] Objects;
	int load_index =0;

	void Start () {
		StartCoroutine(loadObject());
	}
	IEnumerator loadObject()
	{
	    foreach(GameObject obj in Objects)
	    {
	        obj.active = true;
	        load_index ++;
	        //这里可以理解为通知主线程刷新UI
	        yield return 0;
	    }
	    //全部便利完毕返回
	    yield return 0;
	}

	void OnGUI ()
	{
	    //显示加载的进度
		GUILayout.Box("当前加载的对象ID是： " + load_index);
	}
}
