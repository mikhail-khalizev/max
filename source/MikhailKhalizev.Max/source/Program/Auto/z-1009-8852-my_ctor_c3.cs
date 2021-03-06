using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_8852-5f720ef5")]
        public void my_ctor_c3()
        {
            ii(0x1009_8852, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1009_8857, 5);  call(Definitions.sys_check_available_stack_size, 0xc_d4f6);/* call 0x10165d52 */
            ii(0x1009_885c, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_885d, 1);  push(esi);                            /* push esi */
            ii(0x1009_885e, 1);  push(edi);                            /* push edi */
            ii(0x1009_885f, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_8860, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_8862, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1009_8868, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_886b, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1009_886e, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1009_8871, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1009_8874, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_8877, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_887a, 5);  call(0x1008_c86c, -0xc013);           /* call 0x1008c86c */
            ii(0x1009_887f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_8882, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_8885, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_8888, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_888b, 3);  add(eax, 0x19);                       /* add eax, 0x19 */
            ii(0x1009_888e, 5);  call(Definitions.my_ctor_0x101b_4184, -0x2_1da3);/* call 0x10076af0 */
            ii(0x1009_8893, 3);  sub(eax, 0x19);                       /* sub eax, 0x19 */
            ii(0x1009_8896, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_8899, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_889c, 7);  mov(memd[ds, eax + 2], 0x101b_4570);  /* mov dword [eax+0x2], 0x101b4570 */
            ii(0x1009_88a3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_88a6, 4);  mov(dx, memw[ds, eax + 26]);          /* mov dx, [eax+0x1a] */
            ii(0x1009_88aa, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_88ad, 4);  mov(memw[ds, eax + 25], dx);          /* mov [eax+0x19], dx */
            ii(0x1009_88b1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_88b4, 4);  mov(dx, memw[ds, eax + 28]);          /* mov dx, [eax+0x1c] */
            ii(0x1009_88b8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_88bb, 4);  mov(memw[ds, eax + 27], dx);          /* mov [eax+0x1b], dx */
            ii(0x1009_88bf, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_88c2, 4);  mov(memb[ds, eax + 29], 3);           /* mov byte [eax+0x1d], 0x3 */
            ii(0x1009_88c6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_88c9, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_88cc, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_88cf, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_88d1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_88d2, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_88d3, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_88d4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_88d5, 1);  ret();                                /* ret */
        }
    }
}
