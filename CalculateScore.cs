using System.Collections.Generic;
using CoreGameEngine;
namespace MoonBuggy_2020
{
    /// <summary>
    /// class responsible to read the scores and calculate them.
    /// </summary>
    public class CalculateScore :Component
    {
        private List<GameObject> holes;

        private Game gameScore;

        public CalculateScore(Game gameScore, List<GameObject> holes)
        {
            this.holes = holes;

            this.gameScore = gameScore;
        }

        public override void Update()
        {
            for(int i = holes.Count - 1; i >= 0; i--)
            {
                if (holes[i].GetComponent<Position>().Pos.X == 160)
                {
                    gameScore.AddScore();
                }
            }
        }
    }
}