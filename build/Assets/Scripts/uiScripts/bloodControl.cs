using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bloodControl : MonoBehaviour
{
	// Start is called before the first frame update
	
	private Camera camera;
	//NPC����
	private string name = "��";

	//���Ƕ���
	GameObject hero;
	//NPCģ�͸߶�
	float npcHeight;
	//��ɫѪ����ͼ
	public Texture2D blood_red;
	//��ɫѪ����ͼ
	public Texture2D blood_black;
	//Ĭ��NPCѪֵ
	public int HP = 100;

	void Start()
	{
		//����Tag�õ����Ƕ���
		
		//�õ����������
		camera = Camera.main;

		//ע��1
		//�õ�ģ��ԭʼ�߶�
		float size_y = 0.9f;
		//�õ�ģ�����ű���
		float scal_y = transform.localScale.y;
		//���ǵĳ˻����Ǹ߶�
		npcHeight = (size_y * scal_y);
	}
	void Update()
	{
		//����NPCһֱ�泯����
	}

	void OnGUI()
	{
		//�õ�NPCͷ����3D�����е�����
		//Ĭ��NPC������ڽŵ��£������������npcHeight��ģ�͵ĸ߶ȼ���
		Vector3 worldPosition = new Vector3(transform.position.x, transform.position.y + npcHeight, transform.position.z);
		//����NPCͷ����3D���껻�������2D��Ļ�е�����
		Vector2 position = camera.WorldToScreenPoint(worldPosition);
		//�õ���ʵNPCͷ����2D����
		position = new Vector2(position.x, Screen.height - position.y);
		//ע��2
		//�����Ѫ���Ŀ��
		Vector2 bloodSize = GUI.skin.label.CalcSize(new GUIContent(blood_red));

		//ͨ��Ѫֵ�����ɫѪ����ʾ����
		int blood_width = blood_red.width * HP / 100;
		//�Ȼ��ƺ�ɫѪ��
		GUI.DrawTexture(new Rect(position.x - (bloodSize.x / 2), position.y - bloodSize.y, bloodSize.x, bloodSize.y), blood_black);
		//�ڻ��ƺ�ɫѪ��
		GUI.DrawTexture(new Rect(position.x - (bloodSize.x / 2), position.y - bloodSize.y, blood_width, bloodSize.y), blood_red);

		//ע��3
		//����NPC���ƵĿ��
		Vector2 nameSize = GUI.skin.label.CalcSize(new GUIContent(name));
		//������ʾ��ɫΪ��ɫ
		GUI.color = Color.yellow;
		//����NPC����
		GUI.Label(new Rect(position.x - (nameSize.x / 2), position.y - nameSize.y - bloodSize.y, nameSize.x, nameSize.y), name);

	}
	void onHid()
	{
		HP -= 34;
		if (HP <= 0)
		{
			ScoreCount.score += 1;
			Object.Destroy(this.gameObject);
			
		}
		

	}

}
