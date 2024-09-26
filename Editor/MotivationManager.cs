using Sandbox;
using System;
namespace Editor;

public static class MotivationManager
{
	static RealTimeUntil Cooldown;

	static MotivationManager()
	{
		Game.SetRandomSeed( DateTime.Now.Second );
		Cooldown = 5;
	}

	[EditorEvent.FrameAttribute]
	public static void Frame()
	{
		if ( !Cooldown )
		{
			return;
		}

		_ = new MotivationNotice();

		const int MIN_MINUTES = 15;
		const int MAX_MINUTES = 30;

		Cooldown = 60 * Game.Random.Next( MIN_MINUTES, MAX_MINUTES );
	}
}
