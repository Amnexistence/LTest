using UnityEngine;
using System.Collections;
 
public class FPCamera_script : MonoBehaviour {
    public GameObject ray; // Перетащить в капсулу на переднем плане
	public GameObject cursor;
         Vector3 rot = new Vector3 (0, 0, 0); // Сначала определите переменную rot типа Vectory3 (0,0,0)
       public float speed; // Это чувствительность мыши
    void Start() {
	Cursor.visible = false;
    }
 
    void Update() {
        float MouseX = Input.GetAxis("Mouse X")*speed;       
        float MouseY = Input.GetAxis("Mouse Y")*speed;
        rot.x = rot.x - MouseY;
        rot.y = rot.y + MouseX;  
                 rot.z = 0; // Заблокировать ось z угла движения камеры, чтобы предотвратить наклон влево и вправо
                 transform.eulerAngles = rot; // После того, как все направления установлены,ВЭБ-камераУгол = вращение
        ray.transform.eulerAngles = new Vector3(rot.x + 96, rot.y, 0);  // Угол персонажа можно изменить только с помощью MouseX, то есть заблокировать rot.y
		cursor.transform.eulerAngles = new Vector3(rot.x + 96, rot.y, 0);
		
	if (Input.GetKey("escape"))
		{
			Application.Quit();
		}
	}
}