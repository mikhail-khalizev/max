using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0264-58197d3c")]
        public void Method_100d_0264()
        {
            ii(0x100d_0264, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100d_0269, 5);  call(Definitions.sys_check_available_stack_size, 0x9_5ae4);/* call 0x10165d52 */
            ii(0x100d_026e, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_026f, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_0270, 1);  push(esi);                            /* push esi */
            ii(0x100d_0271, 1);  push(edi);                            /* push edi */
            ii(0x100d_0272, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_0273, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_0275, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100d_027b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_027e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_0281, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0284, 5);  call(0x100d_0149, -0x140);            /* call 0x100d0149 */
            ii(0x100d_0289, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_028c, 3);  lea(edx, memd[ss, ebp - 12]);         /* lea edx, [ebp-0xc] */
            ii(0x100d_028f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0292, 5);  call(0x1008_b268, -0x4_502f);         /* call 0x1008b268 */
            ii(0x100d_0297, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_0299, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_029c, 4);  mov(memw[ds, eax + 38], dx);          /* mov [eax+0x26], dx */
            ii(0x100d_02a0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_02a3, 3);  mov(eax, memd[ds, eax + 36]);         /* mov eax, [eax+0x24] */
            ii(0x100d_02a6, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_02a9, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_02ab, 2);  if(jge(0x100d_02b6, 9)) goto l_0x100d_02b6;/* jge 0x100d02b6 */
            ii(0x100d_02ad, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_02b0, 6);  mov(memw[ds, eax + 38], 0);           /* mov word [eax+0x26], 0x0 */
        l_0x100d_02b6:
            ii(0x100d_02b6, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_02b9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_02bc, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_02bf, 5);  call(0x100d_5494, 0x51d0);            /* call 0x100d5494 */
            ii(0x100d_02c4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_02c7, 3);  mov(edx, memd[ds, eax + 36]);         /* mov edx, [eax+0x24] */
            ii(0x100d_02ca, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_02cd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_02d0, 5);  call(0x100d_01a3, -0x132);            /* call 0x100d01a3 */
            ii(0x100d_02d5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_02d8, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_02db, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_02de, 3);  mov(edx, memd[ds, eax + 64]);         /* mov edx, [eax+0x40] */
            ii(0x100d_02e1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_02e4, 3);  call_abs(memd[ds, edx + 16]);         /* call dword [edx+0x10] */
            ii(0x100d_02e7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_02ea, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_02ed, 5);  call(Definitions.my_2_get_count, -0x4_4f8a);/* call 0x1008b368 */
            ii(0x100d_02f2, 1);  cwde();                               /* cwde */
            ii(0x100d_02f3, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_02f5, 2);  if(jz(0x100d_0305, 0xe)) goto l_0x100d_0305;/* jz 0x100d0305 */
            ii(0x100d_02f7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_02fa, 5);  call(0x100d_0149, -0x1b6);            /* call 0x100d0149 */
            ii(0x100d_02ff, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x100d_0303, 2);  if(jz(0x100d_030f, 0xa)) goto l_0x100d_030f;/* jz 0x100d030f */
        l_0x100d_0305:
            ii(0x100d_0305, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_0307, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_030a, 5);  call(0x100d_0617, 0x308);             /* call 0x100d0617 */
        l_0x100d_030f:
            ii(0x100d_030f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_0311, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_0312, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_0313, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_0314, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_0315, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_0316, 1);  ret();                                /* ret */
        }
    }
}
