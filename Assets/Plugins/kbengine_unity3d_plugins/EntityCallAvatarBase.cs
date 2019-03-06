/*
	Generated by KBEngine!
	Please do not modify this file!
	
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/Avatar.def
	public class EntityBaseEntityCall_AvatarBase : EntityCall
	{
		public EntityBaseEntityCall_AvatarBase() : base()
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_BASE;
		}

	}

	public class EntityCellEntityCall_AvatarBase : EntityCall
	{
		public EntityCellEntityCall_AvatarBase() : base()
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_CELL;
		}

		public void dialog(Int32 arg1, UInt32 arg2)
		{
			Bundle pBundle = newCall("dialog");
			if(pBundle == null)
				return;

			bundle.writeInt32(arg1);
			bundle.writeUint32(arg2);
			sendCall(null);
		}

		public void jump()
		{
			Bundle pBundle = newCall("jump");
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void relive(Byte arg1)
		{
			Bundle pBundle = newCall("relive");
			if(pBundle == null)
				return;

			bundle.writeUint8(arg1);
			sendCall(null);
		}

		public void requestPull()
		{
			Bundle pBundle = newCall("requestPull");
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void useTargetSkill(Int32 arg1, Int32 arg2)
		{
			Bundle pBundle = newCall("useTargetSkill");
			if(pBundle == null)
				return;

			bundle.writeInt32(arg1);
			bundle.writeInt32(arg2);
			sendCall(null);
		}

	}
	}
