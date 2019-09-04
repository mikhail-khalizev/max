using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_0280-ce4d8b82")]
        public void /* sys */ Method_1019_0280()
        {
            ii(0x1019_0280, 3);  mov(bx, memw[ds, esi]);               /* mov bx, [esi] */
            ii(0x1019_0283, 3);  add(esi, 2);                          /* add esi, 0x2 */
            ii(0x1019_0286, 3);  mov(ax, bx);                          /* mov ax, bx */
            ii(0x1019_0289, 3);  shl(eax, 0x10);                       /* shl eax, 0x10 */
            ii(0x1019_028c, 3);  mov(ax, bx);                          /* mov ax, bx */
            ii(0x1019_028f, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1019_0291, 3);  rol(ebx, 8);                          /* rol ebx, 0x8 */
            ii(0x1019_0294, 6);  mov(edx, memd[ds, 0x1020_9cd0]);      /* mov edx, [0x10209cd0] */
            ii(0x1019_029a, 2);  mov(memd[ds, edi], eax);              /* mov [edi], eax */
            ii(0x1019_029c, 3);  mov(memd[ds, edi + 4], eax);          /* mov [edi+0x4], eax */
            ii(0x1019_029f, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_02a1, 2);  mov(memd[ds, edi], ebx);              /* mov [edi], ebx */
            ii(0x1019_02a3, 3);  mov(memd[ds, edi + 4], ebx);          /* mov [edi+0x4], ebx */
            ii(0x1019_02a6, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_02a8, 2);  mov(memd[ds, edi], eax);              /* mov [edi], eax */
            ii(0x1019_02aa, 3);  mov(memd[ds, edi + 4], eax);          /* mov [edi+0x4], eax */
            ii(0x1019_02ad, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_02af, 2);  mov(memd[ds, edi], ebx);              /* mov [edi], ebx */
            ii(0x1019_02b1, 3);  mov(memd[ds, edi + 4], ebx);          /* mov [edi+0x4], ebx */
            ii(0x1019_02b4, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_02b6, 2);  mov(memd[ds, edi], eax);              /* mov [edi], eax */
            ii(0x1019_02b8, 3);  mov(memd[ds, edi + 4], eax);          /* mov [edi+0x4], eax */
            ii(0x1019_02bb, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_02bd, 2);  mov(memd[ds, edi], ebx);              /* mov [edi], ebx */
            ii(0x1019_02bf, 3);  mov(memd[ds, edi + 4], ebx);          /* mov [edi+0x4], ebx */
            ii(0x1019_02c2, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_02c4, 2);  mov(memd[ds, edi], eax);              /* mov [edi], eax */
            ii(0x1019_02c6, 3);  mov(memd[ds, edi + 4], eax);          /* mov [edi+0x4], eax */
            ii(0x1019_02c9, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_02cb, 2);  mov(memd[ds, edi], ebx);              /* mov [edi], ebx */
            ii(0x1019_02cd, 3);  mov(memd[ds, edi + 4], ebx);          /* mov [edi+0x4], ebx */
            ii(0x1019_02d0, 3);  sub(edi, memd[ss, ebp - 16]);         /* sub edi, [ebp-0x10] */
            ii(0x1019_02d3, 1);  ret();                                /* ret */
        }
    }
}
