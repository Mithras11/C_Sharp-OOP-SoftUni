namespace P02.Graphic_Editor.Models
{
    using Contracts;

    public class Circle : IShape
    {
        public string Draw()
        {
            return "I'm Circle";
        }
    }
}
