using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Filo;
public class TMSRopeControl : MonoBehaviour
{
  
    public Cable cable;
    public HingeJoint joint;
   public float speed = 30f;
  
   public float ropeLengh = 10f;
   
    void Start()
    {
        //joint = GetComponent<HingeJoint>();
       // cable =GameObject.Find("Cable_TMSRope").GetComponent<Cable>();
        cable.links[0].storedCable = ropeLengh;
        DataModel.Instance.TmsTotalLengh = ropeLengh;
    }


    public void RopeCtl(RopeDir ropeDir)
    {
        JointMotor motor = joint.motor;
        float a = cable.links[0].storedCable;
        DataModel.Instance.TmsCurrentLengh = a;
        switch (ropeDir)
        {
            case RopeDir.Reduce:
                if (a < 0.1f)
                {
                    cable.links[0].storedCable = 0.100f;
                    motor.targetVelocity = 0f;
                }
                else
                {
                    motor.targetVelocity = -speed;
                }

                MsgMng.Instance.Send(MessageName.MSG_ROPE_REDUCE, new MessageData((int)RopeDir.Reduce));
                break;
            case RopeDir.Add:
                if (a>= ropeLengh)
                {
                    cable.links[0].storedCable = ropeLengh;
                    motor.targetVelocity = 0f;
                }
                else
                {
                    motor.targetVelocity = speed;
                }
                MsgMng.Instance.Send(MessageName.MSG_ROPE_ADD, new MessageData((int)RopeDir.Add));
                break;
            case RopeDir.Default:
                motor.targetVelocity = 0f;
                break;
        }
        joint.motor = motor;
    }
}
public enum RopeDir
{
    Default,
    Reduce,//减少/下降/放开绳索/Y
    Add//增加/上升/收缩绳索/X
}
