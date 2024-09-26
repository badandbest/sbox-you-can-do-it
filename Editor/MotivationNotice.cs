using Sandbox;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static Sandbox.ResourceLibrary;
namespace Editor;

public class MotivationNotice : NoticeWidget
{
	[ModuleInitializer]
	public static async void Start()
	{
		while ( Sandbox.Application.IsEditor )
		{
			const int MIN_MINUTES = 15;
			const int MAX_MINUTES = 30;

			var minutes = Game.Random.Next( MIN_MINUTES, MAX_MINUTES );
			await Task.Delay( TimeSpan.FromMinutes( minutes ) );
			
			_ = new MotivationNotice();
		}
	}

	public string Portrait { get; init; }
	public string Message { get; init; }

	public string Bubble => FileSystem.Mounted.GetFullPath( "portraits/bubble.png" );

	protected override Vector2 SizeHint() => new( 512, 384 );

	public MotivationNotice()
	{
		var personality = Game.Random.FromArray( GetAll<MotivationResource>().ToArray() );

		Portrait = personality.GetPortrait();
		Message = personality.GetMessage();
	}

	protected override void OnPaint()
	{
		Paint.SetPen( Theme.Black );
		Paint.SetDefaultFont( 16 );
		
		var rect = LocalRect.Align( 350, TextFlag.LeftBottom );
		Paint.Draw( rect, Portrait );
		
		rect = LocalRect.Align( 250, TextFlag.RightTop );
		Paint.Draw( rect, Bubble );

		rect = rect.Shrink( 0, 0, 0, 55 );
		Paint.DrawText( rect, Message );
	}
}
