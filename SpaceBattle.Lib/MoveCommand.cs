namespace SpaceBattle.Lib
{
    public class MoveCommand : ICommand
    {
        private readonly IMovable ObjMove;
        public MoveCommand(IMovable movable)
        {
            ObjMove = movable;
        }
        public void Execute()
        {
            ObjMove.position += ObjMove.velocity;
        }
    }
}