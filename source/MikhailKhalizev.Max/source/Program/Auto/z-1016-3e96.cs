using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3e96-62ce1341")]
        public void Method_1016_3e96()
        {
            ii(0x1016_3e96, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1016_3e9b, 5);  call(Definitions.sys_check_available_stack_size, 0x1eb2);/* call 0x10165d52 */
            ii(0x1016_3ea0, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_3ea1, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_3ea2, 1);  push(esi);                            /* push esi */
            ii(0x1016_3ea3, 1);  push(edi);                            /* push edi */
            ii(0x1016_3ea4, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_3ea5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_3ea7, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1016_3ead, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_3eb0, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_3eb3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3eb6, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1016_3eb9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3ebc, 4);  mov(dx, memw[ds, eax + 8]);           /* mov dx, [eax+0x8] */
            ii(0x1016_3ec0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_3ec3, 3);  mov(memw[ds, eax], dx);               /* mov [eax], dx */
            ii(0x1016_3ec6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3ec9, 4);  mov(dx, memw[ds, eax + 10]);          /* mov dx, [eax+0xa] */
            ii(0x1016_3ecd, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_3ed0, 4);  mov(memw[ds, eax + 2], dx);           /* mov [eax+0x2], dx */
            ii(0x1016_3ed4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3ed7, 4);  mov(dx, memw[ds, eax + 12]);          /* mov dx, [eax+0xc] */
            ii(0x1016_3edb, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_3ede, 4);  mov(memw[ds, eax + 4], dx);           /* mov [eax+0x4], dx */
            ii(0x1016_3ee2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3ee5, 4);  mov(dx, memw[ds, eax + 14]);          /* mov dx, [eax+0xe] */
            ii(0x1016_3ee9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_3eec, 4);  mov(memw[ds, eax + 6], dx);           /* mov [eax+0x6], dx */
            ii(0x1016_3ef0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3ef3, 4);  mov(dx, memw[ds, eax + 16]);          /* mov dx, [eax+0x10] */
            ii(0x1016_3ef7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_3efa, 4);  mov(memw[ds, eax + 8], dx);           /* mov [eax+0x8], dx */
            ii(0x1016_3efe, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3f01, 4);  mov(dx, memw[ds, eax + 18]);          /* mov dx, [eax+0x12] */
            ii(0x1016_3f05, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_3f08, 4);  mov(memw[ds, eax + 10], dx);          /* mov [eax+0xa], dx */
            ii(0x1016_3f0c, 7);  mov(memd[ss, ebp - 12], 0xc);         /* mov dword [ebp-0xc], 0xc */
            ii(0x1016_3f13, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1016_3f16, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_3f18, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_3f19, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_3f1a, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_3f1b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_3f1c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_3f1d, 1);  ret();                                /* ret */
        }
    }
}
