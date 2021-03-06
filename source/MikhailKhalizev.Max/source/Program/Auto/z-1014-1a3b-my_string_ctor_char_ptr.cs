using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1a3b-a8582809")]
        public void my_string_ctor_char_ptr()
        {
            ii(0x1014_1a3b, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1014_1a40, 5);  call(Definitions.sys_check_available_stack_size, 0x2_430d);/* call 0x10165d52 */
            ii(0x1014_1a45, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_1a46, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_1a47, 1);  push(esi);                            /* push esi */
            ii(0x1014_1a48, 1);  push(edi);                            /* push edi */
            ii(0x1014_1a49, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_1a4a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_1a4c, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1014_1a52, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_1a55, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_1a58, 5);  mov(eax, 0xc);                        /* mov eax, 0xc */
            ii(0x1014_1a5d, 5);  call(Definitions.sys_new, 0x2_439e);  /* call 0x10165e00 */
            ii(0x1014_1a62, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_1a65, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_1a68, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_1a6b, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1014_1a6f, 2);  if(jz(0x1014_1a87, 0x16)) goto l_0x1014_1a87;/* jz 0x10141a87 */
            ii(0x1014_1a71, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_1a74, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_1a77, 5);  call(Definitions.my_strobj_ctor_char_ptr, -0x2e0);/* call 0x1014179c */
            ii(0x1014_1a7c, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_1a7f, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1014_1a82, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_1a85, 2);  jmp(0x1014_1a8d, 6); goto l_0x1014_1a8d;/* jmp 0x10141a8d */
        l_0x1014_1a87:
            ii(0x1014_1a87, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_1a8a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1014_1a8d:
            ii(0x1014_1a8d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_1a90, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_1a93, 2);  mov(memd[ds, edx], eax);              /* mov [edx], eax */
            ii(0x1014_1a95, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_1a98, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1014_1a9b, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1014_1a9e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_1aa0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_1aa1, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_1aa2, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_1aa3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_1aa4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_1aa5, 1);  ret();                                /* ret */
        }
    }
}
