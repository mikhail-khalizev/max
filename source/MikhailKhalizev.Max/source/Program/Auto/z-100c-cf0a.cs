using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_cf0a-d54a562b")]
        public void Method_100c_cf0a()
        {
            ii(0x100c_cf0a, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100c_cf0f, 5);  call(Definitions.sys_check_available_stack_size, 0x9_8e3e);/* call 0x10165d52 */
            ii(0x100c_cf14, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_cf15, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_cf16, 1);  push(edx);                            /* push edx */
            ii(0x100c_cf17, 1);  push(esi);                            /* push esi */
            ii(0x100c_cf18, 1);  push(edi);                            /* push edi */
            ii(0x100c_cf19, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_cf1a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_cf1c, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100c_cf22, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_cf25, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_cf28, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_cf2b, 5);  call(0x1007_65d0, -0x5_6960);         /* call 0x100765d0 */
            ii(0x100c_cf30, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_cf32, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_cf35, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100c_cf38, 5);  call(0x1007_6574, -0x5_69c9);         /* call 0x10076574 */
            ii(0x100c_cf3d, 5);  call(0x1008_a998, -0x4_25aa);         /* call 0x1008a998 */
            ii(0x100c_cf42, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100c_cf44, 5);  mov(edx, 0x13);                       /* mov edx, 0x13 */
            ii(0x100c_cf49, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_cf4c, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100c_cf4f, 5);  call(0x1007_65d0, -0x5_6984);         /* call 0x100765d0 */
            ii(0x100c_cf54, 5);  call(0x1016_3053, 0x9_60fa);          /* call 0x10163053 */
            ii(0x100c_cf59, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_cf5b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_cf5c, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_cf5d, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_cf5e, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_cf5f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_cf60, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_cf61, 1);  ret();                                /* ret */
        }
    }
}
