//
// Copyright (C) 2015 crosire & contributors
// License: https://github.com/crosire/scripthookvdotnet#license
//

using RDR2.Math;
using RDR2.Native;

namespace RDR2
{
	/*public struct RaycastResult
	{
		internal RaycastResult(int handle)
		{
			int hitSomething;
			int entityHandle;
			var hitCoords = new OutputArgument();
			var surfaceNormal = new OutputArgument();
			unsafe
			{
				Result = Function.Call<int>(Hash._GET_RAYCAST_RESULT, handle, &hitSomething, hitCoords, surfaceNormal, &entityHandle);
			}

			HitEntity = Entity.FromHandle(entityHandle);
			DitHitAnything = hitSomething != 0;
			HitCoords = hitCoords.GetResult<Vector3>();
			SurfaceNormal = surfaceNormal.GetResult<Vector3>();
		}

		public int Result
		{
			get;
		}

		public bool DitHitEntity
		{
			get => HitEntity != null;
		}

		public bool DitHitAnything
		{
			get;
		}

		public Entity HitEntity
		{
			get;
		}

		public Vector3 HitCoords
		{
			get;
		}

		public Vector3 SurfaceNormal
		{
			get;
		}
	}*/
}
