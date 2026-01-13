using Godot;
using System;

public partial class ResetButton : Button {
    private Panel statusDot;
    private PlayPauseButton playPauseButton;

    public override void _Ready() {
        statusDot = (Panel)GetParent().GetParent().FindChild("StatusDot");
        playPauseButton = GetParent().GetNode<PlayPauseButton>("PlayPauseButton");
    }

    public override void _Pressed() {
        ((StyleBoxFlat)statusDot.GetThemeStylebox("panel")).BgColor = PlayPauseButton.Stopped;
        statusDot.QueueRedraw();
        playPauseButton.Icon = ResourceLoader.Load<CompressedTexture2D>("res://sprites/icons/play_arrow.svg");
        playPauseButton.playing = false;
    }
}
