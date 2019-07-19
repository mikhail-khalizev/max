using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator
{
    public class PageRawDto
    {
        public string CreationDate { get; set; }
        public string ModDate { get; set; }
        public int Number { get; set; }
        public JToken Tables { get; set; }
        public JToken Texts { get; set; }
    }

    public class LinkDto
    {
        public string Href { get; set; }
        public string Rel { get; set; }
    }

    public class RectDto
    {
        public double LLX { get; set; }
        public double LLY { get; set; }
        public double URX { get; set; }
        public double URY { get; set; }
    }

    public class PositionDto
    {
        public double XIndent { get; set; }
        public double YIndent { get; set; }
    }

    public class BaselinePositionDto
    {
        public double XIndent { get; set; }
        public double YIndent { get; set; }
    }

    public class ForegroundColorDto
    {
        public int A { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
    }

    public class TextStateDto
    {
        public double FontSize { get; set; }
        public string Font { get; set; }
        public ForegroundColorDto ForegroundColor { get; set; }
        public string FontStyle { get; set; }
    }

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

    public class TextRectsDto
    {
        public IList<ListDto> List { get; set; }
    }

    public class Rectangle
    {
        public double LLX { get; set; }
        public double LLY { get; set; }
        public double URX { get; set; }
        public double URY { get; set; }
    }

    public class CellListDto
    {
        public TextRectsDto TextRects { get; set; }
        public Rectangle Rectangle { get; set; }
    }

    public class RowListDto
    {
        public IList<CellListDto> CellList { get; set; }
        public Rectangle Rectangle { get; set; }
    }

    public class TableDto
    {
        public IList<LinkDto> Links { get; set; }
        public IList<RowListDto> RowList { get; set; }
        public Rectangle Rectangle { get; set; }
        public int PageNum { get; set; }
        public string Id { get; set; }
    }

    public class TextDto
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

    public class PageDto
    {
        public string CreationDate { get; set; }
        public string ModDate { get; set; }
        public int Number { get; set; }
        public IList<TableDto> Tables { get; set; }
        public IList<TextDto> Texts { get; set; }
    }


}