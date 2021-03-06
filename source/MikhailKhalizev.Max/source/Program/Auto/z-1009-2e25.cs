using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_2e25-2f04bed9")]
        public void Method_1009_2e25()
        {
            ii(0x1009_2e25, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1009_2e2a, 5);  call(Definitions.sys_check_available_stack_size, 0xd_2f23);/* call 0x10165d52 */
            ii(0x1009_2e2f, 1);  push(esi);                            /* push esi */
            ii(0x1009_2e30, 1);  push(edi);                            /* push edi */
            ii(0x1009_2e31, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_2e32, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_2e34, 6);  sub(esp, 0x28);                       /* sub esp, 0x28 */
            ii(0x1009_2e3a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_2e3d, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_2e40, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1009_2e43, 3);  mov(memd[ss, ebp - 12], ecx);         /* mov [ebp-0xc], ecx */
            ii(0x1009_2e46, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_2e49, 5);  call(0x1009_0b73, -0x22db);           /* call 0x10090b73 */
            ii(0x1009_2e4e, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_2e51, 7);  mov(memd[ss, ebp - 28], 1);           /* mov dword [ebp-0x1c], 0x1 */
            ii(0x1009_2e58, 4);  mov(memb[ss, ebp - 20], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_2e5c, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1009_2e60, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1009_2e63, 7);  test(memb[ds, eax + 0x101c_81c0], 0x10);/* test byte [eax+0x101c81c0], 0x10 */
            ii(0x1009_2e6a, 2);  if(jz(0x1009_2e73, 7)) goto l_0x1009_2e73;/* jz 0x10092e73 */
            ii(0x1009_2e6c, 7);  mov(memd[ss, ebp - 28], 2);           /* mov dword [ebp-0x1c], 0x2 */
        l_0x1009_2e73:
            ii(0x1009_2e73, 5);  cmp(memw[ss, ebp - 4], 0x28);         /* cmp word [ebp-0x4], 0x28 */
            ii(0x1009_2e78, 2);  if(jnz(0x1009_2e87, 0xd)) goto l_0x1009_2e87;/* jnz 0x10092e87 */
            ii(0x1009_2e7a, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1009_2e7d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_2e80, 5);  call(0x1009_0c63, -0x2222);           /* call 0x10090c63 */
            ii(0x1009_2e85, 2);  jmp(0x1009_2eb9, 0x32); goto l_0x1009_2eb9;/* jmp 0x10092eb9 */
        l_0x1009_2e87:
            ii(0x1009_2e87, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_2e8b, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1009_2e8e, 5);  cmp(memw[ss, ebp - 4], 0x17);         /* cmp word [ebp-0x4], 0x17 */
            ii(0x1009_2e93, 2);  if(jnz(0x1009_2e9e, 9)) goto l_0x1009_2e9e;/* jnz 0x10092e9e */
            ii(0x1009_2e95, 7);  mov(memd[ss, ebp - 40], 0xa);         /* mov dword [ebp-0x28], 0xa */
            ii(0x1009_2e9c, 2);  jmp(0x1009_2ea5, 7); goto l_0x1009_2ea5;/* jmp 0x10092ea5 */
        l_0x1009_2e9e:
            ii(0x1009_2e9e, 7);  mov(memd[ss, ebp - 40], 4);           /* mov dword [ebp-0x28], 0x4 */
        l_0x1009_2ea5:
            ii(0x1009_2ea5, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1009_2ea8, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1009_2eab, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1009_2eae, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_2eb1, 3);  mov(ecx, memd[ss, ebp - 36]);         /* mov ecx, [ebp-0x24] */
            ii(0x1009_2eb4, 5);  call(0x1009_0e54, -0x2065);           /* call 0x10090e54 */
        l_0x1009_2eb9:
            ii(0x1009_2eb9, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1009_2ebc, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1009_2ebf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_2ec2, 5);  call(0x1009_1245, -0x1c82);           /* call 0x10091245 */
            ii(0x1009_2ec7, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1009_2ecb, 1);  push(eax);                            /* push eax */
            ii(0x1009_2ecc, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_2ed0, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1009_2ed3, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1009_2ed6, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_2ed9, 5);  call(0x1009_177d, -0x1761);           /* call 0x1009177d */
            ii(0x1009_2ede, 4);  movsx(ebx, memw[ss, ebp - 28]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1009_2ee2, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1009_2ee5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_2ee8, 5);  call(0x1009_2139, -0xdb4);            /* call 0x10092139 */
            ii(0x1009_2eed, 3);  mov(ecx, memd[ss, ebp - 12]);         /* mov ecx, [ebp-0xc] */
            ii(0x1009_2ef0, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1009_2ef4, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1009_2ef7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_2efa, 5);  call(0x1009_2c20, -0x2df);            /* call 0x10092c20 */
            ii(0x1009_2eff, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x1009_2f02, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1009_2f05, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_2f08, 5);  call(0x1009_0c0d, -0x2300);           /* call 0x10090c0d */
            ii(0x1009_2f0d, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x1009_2f10, 3);  mov(memb[ss, ebp - 24], al);          /* mov [ebp-0x18], al */
            ii(0x1009_2f13, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x1009_2f16, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_2f18, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_2f19, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_2f1a, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_2f1b, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
