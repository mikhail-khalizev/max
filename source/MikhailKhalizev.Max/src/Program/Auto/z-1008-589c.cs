using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_589c-f83133ee")]
        public void Method_1008_589c()
        {
            ii(0x1008_589c, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1008_589f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_58a2, 4); mov(memw_a32[ds, edx + 0x1e], ax);      /* mov [edx+0x1e], ax */
            ii(0x1008_58a6, 3); mov(eax, memd_a32[ss, ebp - 0x3a]);     /* mov eax, [ebp-0x3a] */
            ii(0x1008_58a9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_58ac, 4); mov(memw_a32[ds, edx + 0x20], ax);      /* mov [edx+0x20], ax */
            ii(0x1008_58b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_58b2, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_58b5, 5); calld(0x1007_5f6c, -0xf94e);            /* call 0x10075f6c */
            ii(0x1008_58ba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_58bc, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1008_58bf, 5); calld(0x1008_9044, 0x3780);             /* call 0x10089044 */
            ii(0x1008_58c4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_58c6, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_58c9, 5); calld(0x1008_bc9f, 0x63d1);             /* call 0x1008bc9f */
            ii(0x1008_58ce, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_58d0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_58d1, 1); popd(edi);                              /* pop edi */
            ii(0x1008_58d2, 1); popd(esi);                              /* pop esi */
            ii(0x1008_58d3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_58d4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_58d5, 1); retd(); return;                         /* ret */
        }
    }
}
