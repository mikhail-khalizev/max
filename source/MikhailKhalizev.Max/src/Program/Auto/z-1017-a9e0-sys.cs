using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_a9e0-4602cf34")]
        public void /* sys */ Method_1017_a9e0()
        {
            ii(0x1017_a9e0, 1); push(ebp);                              /* push ebp */
            ii(0x1017_a9e1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_a9e3, 1); push(ebx);                              /* push ebx */
            ii(0x1017_a9e4, 1); push(ecx);                              /* push ecx */
            ii(0x1017_a9e5, 1); push(edx);                              /* push edx */
            ii(0x1017_a9e6, 1); push(esi);                              /* push esi */
            ii(0x1017_a9e7, 1); push(edi);                              /* push edi */
            ii(0x1017_a9e8, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_a9eb, 7); cmp(memd[ds, 0x1020_9c94], 0);          /* cmp dword [0x10209c94], 0x0 */
            ii(0x1017_a9f2, 2); if(jz(0x1017_aa40, 0x4c)) goto l_0x1017_aa40; /* jz 0x1017aa40 */
            ii(0x1017_a9f4, 5); mov(edx, 0x100);                        /* mov edx, 0x100 */
            ii(0x1017_a9f9, 5); mov(eax, 0x1020_9750);                  /* mov eax, 0x10209750 */
            ii(0x1017_a9fe, 5); mov(ebx, 0x1020_9550);                  /* mov ebx, 0x10209550 */
            ii(0x1017_aa03, 6); lea(eax, memd[ds, eax + 0]);            /* lea eax, [eax] */
            ii(0x1017_aa09, 6); lea(edx, memd[ds, edx + 0]);            /* lea edx, [edx] */
            ii(0x1017_aa0f, 1); nop();                                  /* nop */
        l_0x1017_aa10:
            ii(0x1017_aa10, 4); movzx(esi, memb[ds, eax + 0x1]);        /* movzx esi, byte [eax+0x1] */
            ii(0x1017_aa14, 4); movzx(edi, memb[ds, eax + 0x2]);        /* movzx edi, byte [eax+0x2] */
            ii(0x1017_aa18, 1); inc(eax);                               /* inc eax */
            ii(0x1017_aa19, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x1017_aa1c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_aa1e, 2); sar(esi, 0x1);                          /* sar esi, 1 */
            ii(0x1017_aa20, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1017_aa23, 2); sar(ecx, 0x1);                          /* sar ecx, 1 */
            ii(0x1017_aa25, 2); sar(edi, 0x1);                          /* sar edi, 1 */
            ii(0x1017_aa27, 3); shl(esi, 0x5);                          /* shl esi, 0x5 */
            ii(0x1017_aa2a, 3); shl(ecx, 0xa);                          /* shl ecx, 0xa */
            ii(0x1017_aa2d, 3); mov(memd[ss, ebp - 0x18], edi);         /* mov [ebp-0x18], edi */
            ii(0x1017_aa30, 2); or(ecx, esi);                           /* or ecx, esi */
            ii(0x1017_aa32, 3); mov(esi, memd[ss, ebp - 0x18]);         /* mov esi, [ebp-0x18] */
            ii(0x1017_aa35, 1); inc(eax);                               /* inc eax */
            ii(0x1017_aa36, 2); or(ecx, esi);                           /* or ecx, esi */
            ii(0x1017_aa38, 1); inc(eax);                               /* inc eax */
            ii(0x1017_aa39, 4); mov(memw[ds, ebx - 0x2], cx);           /* mov [ebx-0x2], cx */
            ii(0x1017_aa3d, 1); dec(edx);                               /* dec edx */
            ii(0x1017_aa3e, 2); if(jnz(0x1017_aa10, -0x30)) goto l_0x1017_aa10; /* jnz 0x1017aa10 */
        l_0x1017_aa40:
            ii(0x1017_aa40, 3); lea(esp, memd[ss, ebp - 0x14]);         /* lea esp, [ebp-0x14] */
            ii(0x1017_aa43, 1); pop(edi);                               /* pop edi */
            ii(0x1017_aa44, 1); pop(esi);                               /* pop esi */
            ii(0x1017_aa45, 1); pop(edx);                               /* pop edx */
            ii(0x1017_aa46, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_aa47, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_aa48, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_aa49, 1); ret();                                  /* ret */
        }
    }
}
