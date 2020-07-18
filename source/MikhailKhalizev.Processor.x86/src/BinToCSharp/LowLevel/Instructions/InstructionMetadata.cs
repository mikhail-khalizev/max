namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class InstructionMetadata
    {
        /// <summary>
        /// ���������� ��� ������ ������� ����, ��� ���������� ����� ����� �� ������� ����� �������������� �������.
        /// </summary>
        public bool HasLabel { get; set; }

        /// <summary>
        /// ���������� ��� ������ ������� ����, ��� ������� �������������� ������ ������, � �������� ��������� ����������.
        /// </summary>
        public bool IsLocalBranch { get; set; }

        /// <summary>
        /// ���������� ��� ������ ������� ����, ��� ���������� �������� ��������� �� ������������.
        /// </summary>
        public bool IsRet { get; set; }

        /// <summary>
        /// ���������� ��� ������ ������� ����, ��� ���������� �������� ����������� ���������.
        /// </summary>
        public bool IsJmp { get; set; }

        public bool IsJmpOrRet => IsJmp || IsRet;

        /// <summary>
        /// ���������� ��� ������ ������� ����, ��� ���������� �������� ��������� � ������.
        /// </summary>
        public bool IsLastInstructionInMethod {get; set; }
    }
}