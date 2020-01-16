﻿using UnityEngine;
using System.Collections;

public class stickcontrol : MonoBehaviour {

	void OnEnable()  

	{    
		EasyJoystick.On_JoystickMove += OnJoystickMove;  
	}  
	//  此函数是摇杆移动中所要处理的事
	void OnJoystickMove(MovingJoystick move)  
	{    
		if (move.joystickName != "New joystick")       //  在这里的名字new joystick 就是上面所说的很重要的名字，在上面图片中joystickName的你修改了什么名字，这里就要写你修改的好的名字（不然脚本不起作用）。
		{  
			return;  
		}  

		float PositionX = move.joystickAxis.x;       //   获取摇杆偏移摇杆中心的x坐标
		float PositionY = move.joystickAxis.y;      //    获取摇杆偏移摇杆中心的y坐标

		if (PositionY != 0 || PositionX != 0)  
		{                //  设置控制角色或物体方块的朝向（当前坐标+摇杆偏移量）
			transform.LookAt(new Vector3(transform.position.x + PositionX, transform.position.y, transform.position.z + PositionY));  
			//  移动角色或物体的位置（按其所朝向的位置移动）
			transform.Translate(Vector3.forward * Time.deltaTime * 25);  
		}  
	} 
}  
