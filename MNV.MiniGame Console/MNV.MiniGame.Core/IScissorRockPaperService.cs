using System;

namespace MNV.MiniGame.Core
{
    public interface IScissorRockPaperService
    {
        int Play(string user, string computer);
        string ChoiceConvert(string val);
        string ResultMessage(int val);
    }
}
