namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator.Dto
{
    public class ListDto
    {
        public string Text { get; set; }
        public int Page { get; set; }
        public RectDto Rect { get; set; }
        public string HorizontalAlignment { get; set; }
        public string VerticalAlignment { get; set; }
        public PositionDto Position { get; set; }
        public BaselinePositionDto BaselinePosition { get; set; }
        public TextStateDto TextState { get; set; }
    }
}