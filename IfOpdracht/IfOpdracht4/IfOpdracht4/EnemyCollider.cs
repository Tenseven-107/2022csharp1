namespace IfOpdracht4
{
    internal class EnemyCollider
    {
        internal bool CanPassWall(Enemy enemy)
        {
            //gebruik hier een || (OR)
            //je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            if (enemy.flying || enemy.incoporial || enemy.subterranian)
            {
                return true;//vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian) true is;
            }
            else return false;
        }
        internal bool CanPassWater(Enemy enemy)
        {
            //gebruik hier een || (OR)
            //je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            if (enemy.flying || enemy.incoporial || enemy.subterranian)
            {
                return true;//vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian,swimmer) true is;
            }
            else return false;
        }
    }
}