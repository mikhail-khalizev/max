using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3b27-1c1efb44")]
        public void Method_100b_3b27()
        {
            ii(0x100b_3b27, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100b_3b2c, 5);  call(Definitions.sys_check_available_stack_size, 0xb_2221);/* call 0x10165d52 */
            ii(0x100b_3b31, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_3b32, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_3b33, 1);  push(esi);                            /* push esi */
            ii(0x100b_3b34, 1);  push(edi);                            /* push edi */
            ii(0x100b_3b35, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_3b36, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_3b38, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_3b3e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_3b41, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_3b44, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_3b47, 3);  add(edx, 0x13);                       /* add edx, 0x13 */
            ii(0x100b_3b4a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3b4d, 5);  call(0x1007_6d98, -0x3_cdba);         /* call 0x10076d98 */
            ii(0x100b_3b52, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_3b54, 2);  if(jz(0x100b_3b6b, 0x15)) goto l_0x100b_3b6b;/* jz 0x100b3b6b */
            ii(0x100b_3b56, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100b_3b5b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3b5e, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3b61, 5);  call(0x1007_65d0, -0x3_d596);         /* call 0x100765d0 */
            ii(0x100b_3b66, 5);  call(0x100a_297d, -0x1_11ee);         /* call 0x100a297d */
        l_0x100b_3b6b:
            ii(0x100b_3b6b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_3b6d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_3b6e, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_3b6f, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_3b70, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_3b71, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_3b72, 1);  ret();                                /* ret */
        }
    }
}
