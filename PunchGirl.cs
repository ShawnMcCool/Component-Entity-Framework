using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace PunchGirl
{
	public class PunchGirl
	{
		private Texture2D texture;
		private Vector2 position;

		public PunchGirl (Texture2D texture, Vector2 position)
		{
			this.texture = texture;
			this.position = position;
		}
	}
}

