using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8388-b70b8a0f")]
        public void Method_100b_8388()
        {
            ii(0x100b_8388, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_8389, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_838a, 1); pushd(edx);                             /* push edx */
            ii(0x100b_838b, 1); pushd(esi);                             /* push esi */
            ii(0x100b_838c, 1); pushd(edi);                             /* push edi */
            ii(0x100b_838d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_838e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8390, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100b_8396, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x100b_839a, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100b_839d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_839f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_83a0, 1); popd(edi);                              /* pop edi */
            ii(0x100b_83a1, 1); popd(esi);                              /* pop esi */
            ii(0x100b_83a2, 1); popd(edx);                              /* pop edx */
            ii(0x100b_83a3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_83a4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_83a5, 1); retd();                                 /* ret */
        }
    }
}
