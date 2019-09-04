using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_5dd6-c7aac30f")]
        public void Method_1012_5dd6()
        {
            ii(0x1012_5dd6, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1012_5ddb, 5);  call(Definitions.sys_check_available_stack_size, 0x3_ff72);/* call 0x10165d52 */
            ii(0x1012_5de0, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_5de1, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_5de2, 1);  push(esi);                            /* push esi */
            ii(0x1012_5de3, 1);  push(edi);                            /* push edi */
            ii(0x1012_5de4, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_5de5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_5de7, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1012_5ded, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_5df0, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_5df3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_5df6, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_5df9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_5dfc, 5);  call(0x1016_186c, 0x3_ba6b);          /* call 0x1016186c */
            ii(0x1012_5e01, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_5e04, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x1012_5e06, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_5e09, 3);  mov(memb[ds, eax + 61], dl);          /* mov [eax+0x3d], dl */
            ii(0x1012_5e0c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_5e0f, 3);  mov(dl, memb[ds, eax + 1]);           /* mov dl, [eax+0x1] */
            ii(0x1012_5e12, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_5e15, 3);  mov(memb[ds, eax + 62], dl);          /* mov [eax+0x3e], dl */
            ii(0x1012_5e18, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_5e1b, 3);  mov(dl, memb[ds, eax + 2]);           /* mov dl, [eax+0x2] */
            ii(0x1012_5e1e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_5e21, 3);  mov(memb[ds, eax + 63], dl);          /* mov [eax+0x3f], dl */
            ii(0x1012_5e24, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_5e27, 3);  mov(dl, memb[ds, eax + 3]);           /* mov dl, [eax+0x3] */
            ii(0x1012_5e2a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_5e2d, 3);  mov(memb[ds, eax + 64], dl);          /* mov [eax+0x40], dl */
            ii(0x1012_5e30, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_5e33, 3);  mov(dl, memb[ds, eax + 4]);           /* mov dl, [eax+0x4] */
            ii(0x1012_5e36, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_5e39, 3);  mov(memb[ds, eax + 91], dl);          /* mov [eax+0x5b], dl */
            ii(0x1012_5e3c, 7);  mov(memd[ss, ebp - 12], 5);           /* mov dword [ebp-0xc], 0x5 */
            ii(0x1012_5e43, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_5e46, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_5e48, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_5e49, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_5e4a, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_5e4b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_5e4c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_5e4d, 1);  ret();                                /* ret */
        }
    }
}
