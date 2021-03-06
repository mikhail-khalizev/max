using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2ce8-966e7d7f")]
        public void Method_100a_2ce8()
        {
            ii(0x100a_2ce8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_2ced, 5);  call(Definitions.sys_check_available_stack_size, 0xc_3060);/* call 0x10165d52 */
            ii(0x100a_2cf2, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_2cf3, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_2cf4, 1);  push(esi);                            /* push esi */
            ii(0x100a_2cf5, 1);  push(edi);                            /* push edi */
            ii(0x100a_2cf6, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_2cf7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_2cf9, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_2cff, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_2d02, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_2d05, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2d08, 6);  mov(memd[ds, eax], 0);                /* mov dword [eax], 0x0 */
            ii(0x100a_2d0e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2d11, 7);  mov(memd[ds, eax + 4], 0);            /* mov dword [eax+0x4], 0x0 */
            ii(0x100a_2d18, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2d1b, 7);  mov(memd[ds, eax + 8], 0);            /* mov dword [eax+0x8], 0x0 */
            ii(0x100a_2d22, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2d25, 7);  mov(memd[ds, eax + 12], 0);           /* mov dword [eax+0xc], 0x0 */
            ii(0x100a_2d2c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2d2f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_2d32, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_2d35, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_2d37, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_2d38, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_2d39, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_2d3a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_2d3b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_2d3c, 1);  ret();                                /* ret */
        }
    }
}
