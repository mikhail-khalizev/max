using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b9e0-aa9c8d5a")]
        public void Method_1013_b9e0()
        {
            ii(0x1013_b9e0, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1013_b9e5, 5);  call(Definitions.sys_check_available_stack_size, 0x2_a368);/* call 0x10165d52 */
            ii(0x1013_b9ea, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_b9eb, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_b9ec, 1);  push(esi);                            /* push esi */
            ii(0x1013_b9ed, 1);  push(edi);                            /* push edi */
            ii(0x1013_b9ee, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_b9ef, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_b9f1, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1013_b9f7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_b9fa, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_b9fd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_ba00, 5);  call(0x1013_ba3c, 0x37);              /* call 0x1013ba3c */
            ii(0x1013_ba05, 5);  mov(edx, StringDefinitions.Rb10);     /* mov edx, 0x101acc60 */
            ii(0x1013_ba0a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ba0d, 5);  call(Definitions.my_fopen, -0x4_c5f3);/* call 0x100ef41f */
            ii(0x1013_ba12, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1013_ba14, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_ba17, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1013_ba19, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_ba1c, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1013_ba1f, 2);  if(jz(0x1013_ba27, 6)) goto l_0x1013_ba27;/* jz 0x1013ba27 */
            ii(0x1013_ba21, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1013_ba25, 2);  jmp(0x1013_ba2b, 4); goto l_0x1013_ba2b;/* jmp 0x1013ba2b */
        l_0x1013_ba27:
            ii(0x1013_ba27, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1013_ba2b:
            ii(0x1013_ba2b, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1013_ba2e, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1013_ba31, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1013_ba34, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_ba36, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_ba37, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_ba38, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_ba39, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_ba3a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_ba3b, 1);  ret();                                /* ret */
        }
    }
}
