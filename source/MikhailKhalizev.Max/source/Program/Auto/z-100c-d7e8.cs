using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d7e8-cd6d9fbf")]
        public void Method_100c_d7e8()
        {
            ii(0x100c_d7e8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_d7ed, 5);  call(Definitions.sys_check_available_stack_size, 0x9_8560);/* call 0x10165d52 */
            ii(0x100c_d7f2, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_d7f3, 1);  push(esi);                            /* push esi */
            ii(0x100c_d7f4, 1);  push(edi);                            /* push edi */
            ii(0x100c_d7f5, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_d7f6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_d7f8, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100c_d7fe, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_d801, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_d804, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100c_d807, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_d80a, 7);  mov(memd[ds, eax + 12], 0x101b_5b7c); /* mov dword [eax+0xc], 0x101b5b7c */
            ii(0x100c_d811, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d814, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100c_d817, 4);  mov(memw[ds, edx + 6], ax);           /* mov [edx+0x6], ax */
            ii(0x100c_d81b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d81e, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100c_d821, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x100c_d824, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_d827, 6);  mov(memw[ds, eax + 4], 0);            /* mov word [eax+0x4], 0x0 */
            ii(0x100c_d82d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_d830, 6);  mov(memw[ds, eax + 2], 0);            /* mov word [eax+0x2], 0x0 */
            ii(0x100c_d836, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_d839, 7);  mov(memd[ds, eax + 8], 0);            /* mov dword [eax+0x8], 0x0 */
            ii(0x100c_d840, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_d843, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_d846, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_d849, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_d84b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_d84c, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_d84d, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_d84e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_d84f, 1);  ret();                                /* ret */
        }
    }
}
