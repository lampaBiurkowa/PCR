﻿using FateDisclosed.Screens;
using MotionNET;

namespace FateDisclosed
{
    public class MoviePlayer
    {
        public DataSource movie { get; private set; }
        VideoPlayback video;
        AudioPlayback audio;
        AbstractScreen screen;

        public MoviePlayer(string path, AbstractScreen parentScreen, bool playSound = true)
        {
            screen = parentScreen;

            movie = new DataSource();
            movie.LoadFromFile(path, EnableAudio:playSound);
            video = new VideoPlayback(movie);
            audio = new AudioPlayback(movie);
        }

        public void Draw()
        {
            screen.app.win.Draw(video);
        }

        public void Play()
        {
            movie.Play();
        }

        public void Stop()
        {
            movie.Stop();
        }

        public void Pause()
        {
            movie.Pause();
        }

        public void Update()
        {
            movie.Update();
        }
    }
}
