using System;

namespace FD.UI
{
    public interface ISceneChanger
    {
        float TimeLeft { get; }
        float TimePassed { get; }

        Action OnLoadStarted { get; }
        Action OnLoadFinished { get; }

        void Load(string sceneName);
    }
}
