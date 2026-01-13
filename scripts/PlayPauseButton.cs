using Godot;
using System;

public partial class PlayPauseButton : Button {
    public static readonly Color Stopped = Color.Color8(255, 0, 0);
    private static readonly Color Paused = Color.Color8(255, 196, 3);
    private static readonly Color Running = Color.Color8(0, 255, 0);

    private Panel statusDot;
    public bool playing;

    public override void _Ready() {
        statusDot = (Panel)GetParent().GetParent().FindChild("StatusDot");
    }

    public override void _Pressed() {
        if (playing) {
            ((StyleBoxFlat)statusDot.GetThemeStylebox("panel")).BgColor = Paused;
            Icon = ResourceLoader.Load<CompressedTexture2D>("res://sprites/icons/play_arrow.svg");
        } else {
            ((StyleBoxFlat)statusDot.GetThemeStylebox("panel")).BgColor = Running;
            Icon = ResourceLoader.Load<CompressedTexture2D>("res://sprites/icons/pause.svg");
        }
        playing = !playing;
        statusDot.QueueRedraw();
    }
}
