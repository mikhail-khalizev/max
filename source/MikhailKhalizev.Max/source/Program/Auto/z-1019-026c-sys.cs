using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_026c-36af66f1")]
        public void /* sys */ Method_1019_026c()
        {
            ii(0x1019_026c, 2);  mov(bl, memb[ds, esi]);               /* mov bl, [esi] */
            ii(0x1019_026e, 1);  inc(esi);                             /* inc esi */
            ii(0x1019_026f, 2);  mov(bh, bl);                          /* mov bh, bl */
            ii(0x1019_0271, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1019_0273, 3);  shl(eax, 0x10);                       /* shl eax, 0x10 */
            ii(0x1019_0276, 3);  mov(ax, bx);                          /* mov ax, bx */
            ii(0x1019_0279, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1019_027b, 2);  jmp(0x1019_0294, 0x17); goto l_0x1019_0294;/* jmp 0x10190294 */
        //  ii(0x1019_027d, 23);  Недостижимый код.
        l_0x1019_0294:
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
