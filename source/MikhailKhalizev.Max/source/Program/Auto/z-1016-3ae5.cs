using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3ae5-a3aed9df")]
        public void Method_1016_3ae5()
        {
            ii(0x1016_3ae5, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1016_3aea, 5);  call(Definitions.sys_check_available_stack_size, 0x2263);/* call 0x10165d52 */
            ii(0x1016_3aef, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_3af0, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_3af1, 1);  push(edx);                            /* push edx */
            ii(0x1016_3af2, 1);  push(esi);                            /* push esi */
            ii(0x1016_3af3, 1);  push(edi);                            /* push edi */
            ii(0x1016_3af4, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_3af5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_3af7, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1016_3afd, 5);  mov(eax, 0x24);                       /* mov eax, 0x24 */
            ii(0x1016_3b02, 5);  call(Definitions.sys_new, 0x22f9);    /* call 0x10165e00 */
            ii(0x1016_3b07, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_3b0a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3b0d, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1016_3b10, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1016_3b14, 2);  if(jz(0x1016_3b29, 0x13)) goto l_0x1016_3b29;/* jz 0x10163b29 */
            ii(0x1016_3b16, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_3b19, 5);  call(0x1016_3505, -0x619);            /* call 0x10163505 */
            ii(0x1016_3b1e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1016_3b21, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_3b24, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1016_3b27, 2);  jmp(0x1016_3b2f, 6); goto l_0x1016_3b2f;/* jmp 0x10163b2f */
        l_0x1016_3b29:
            ii(0x1016_3b29, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1016_3b2c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x1016_3b2f:
            ii(0x1016_3b2f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3b32, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1016_3b35, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1016_3b38, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_3b3a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_3b3b, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_3b3c, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_3b3d, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_3b3e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_3b3f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_3b40, 1);  ret();                                /* ret */
        }
    }
}
