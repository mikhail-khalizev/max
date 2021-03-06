using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_e5c2-43b943c7")]
        public void Method_100b_e5c2()
        {
            ii(0x100b_e5c2, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100b_e5c7, 5);  call(Definitions.sys_check_available_stack_size, 0xa_7786);/* call 0x10165d52 */
            ii(0x100b_e5cc, 1);  push(esi);                            /* push esi */
            ii(0x100b_e5cd, 1);  push(edi);                            /* push edi */
            ii(0x100b_e5ce, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_e5cf, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_e5d1, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x100b_e5d7, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_e5da, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_e5dd, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100b_e5e0, 3);  mov(memd[ss, ebp - 12], ecx);         /* mov [ebp-0xc], ecx */
            ii(0x100b_e5e3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_e5e6, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_e5e9, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_e5ec, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100b_e5ef, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_e5f2, 3);  call_abs(memd[ds, edx + 20]);         /* call dword [edx+0x14] */
            ii(0x100b_e5f5, 3);  movsx(esi, ax);                       /* movsx esi, ax */
            ii(0x100b_e5f8, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x100b_e5fb, 4);  movsx(edi, memw[ss, ebp - 4]);        /* movsx edi, word [ebp-0x4] */
            ii(0x100b_e5ff, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_e602, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100b_e605, 5);  call(0x1007_5e64, -0x4_87a6);         /* call 0x10075e64 */
            ii(0x100b_e60a, 3);  mov(ecx, memd[ss, ebp - 16]);         /* mov ecx, [ebp-0x10] */
            ii(0x100b_e60d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_e60f, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x100b_e611, 5);  call(0x100b_9da4, -0x4872);           /* call 0x100b9da4 */
            ii(0x100b_e616, 2);  mov(ecx, esi);                        /* mov ecx, esi */
            ii(0x100b_e618, 2);  mov(edx, edi);                        /* mov edx, edi */
            ii(0x100b_e61a, 5);  call(0x1009_6e02, -0x2_781d);         /* call 0x10096e02 */
            ii(0x100b_e61f, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x100b_e622, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x100b_e625, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_e627, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_e628, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_e629, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_e62a, 1);  ret();                                /* ret */
        }
    }
}
