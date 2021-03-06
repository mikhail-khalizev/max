using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_b9e1-effeea71")]
        public void Method_1011_b9e1()
        {
            ii(0x1011_b9e1, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1011_b9e6, 5);  call(Definitions.sys_check_available_stack_size, 0x4_a367);/* call 0x10165d52 */
            ii(0x1011_b9eb, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_b9ec, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_b9ed, 1);  push(edx);                            /* push edx */
            ii(0x1011_b9ee, 1);  push(esi);                            /* push esi */
            ii(0x1011_b9ef, 1);  push(edi);                            /* push edi */
            ii(0x1011_b9f0, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_b9f1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_b9f3, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1011_b9f9, 5);  mov(eax, 0x1c);                       /* mov eax, 0x1c */
            ii(0x1011_b9fe, 5);  call(Definitions.sys_new, 0x4_a3fd);  /* call 0x10165e00 */
            ii(0x1011_ba03, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_ba06, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ba09, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_ba0c, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1011_ba10, 2);  if(jz(0x1011_ba25, 0x13)) goto l_0x1011_ba25;/* jz 0x1011ba25 */
            ii(0x1011_ba12, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ba15, 5);  call(0x1011_9ee6, -0x1b34);           /* call 0x10119ee6 */
            ii(0x1011_ba1a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_ba1d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_ba20, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_ba23, 2);  jmp(0x1011_ba2b, 6); goto l_0x1011_ba2b;/* jmp 0x1011ba2b */
        l_0x1011_ba25:
            ii(0x1011_ba25, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_ba28, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x1011_ba2b:
            ii(0x1011_ba2b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_ba2e, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_ba31, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_ba34, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_ba36, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_ba37, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_ba38, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_ba39, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_ba3a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_ba3b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_ba3c, 1);  ret();                                /* ret */
        }
    }
}
