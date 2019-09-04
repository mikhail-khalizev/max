using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6e7c-4d2fb7bc")]
        public void Method_1007_6e7c()
        {
            ii(0x1007_6e7c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_6e81, 5);  call(Definitions.sys_check_available_stack_size, 0xe_eecc);/* call 0x10165d52 */
            ii(0x1007_6e86, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_6e87, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6e88, 1);  push(esi);                            /* push esi */
            ii(0x1007_6e89, 1);  push(edi);                            /* push edi */
            ii(0x1007_6e8a, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6e8b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6e8d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_6e93, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6e96, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_6e99, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6e9c, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1007_6e9f, 2);  if(jle(0x1007_6ea9, 8)) goto l_0x1007_6ea9;/* jle 0x10076ea9 */
            ii(0x1007_6ea1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6ea4, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_6ea7, 2);  jmp(0x1007_6eaf, 6); goto l_0x1007_6eaf;/* jmp 0x10076eaf */
        l_0x1007_6ea9:
            ii(0x1007_6ea9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6eac, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1007_6eaf:
            ii(0x1007_6eaf, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_6eb2, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_6eb5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_6eb8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_6eba, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_6ebb, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_6ebc, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6ebd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6ebe, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6ebf, 1);  ret();                                /* ret */
        }
    }
}
