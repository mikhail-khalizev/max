using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_1c98-c69b17ca")]
        public void Method_100e_1c98()
        {
            ii(0x100e_1c98, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_1c9d, 5);  call(Definitions.sys_check_available_stack_size, 0x8_40b0);/* call 0x10165d52 */
            ii(0x100e_1ca2, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_1ca3, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_1ca4, 1);  push(esi);                            /* push esi */
            ii(0x100e_1ca5, 1);  push(edi);                            /* push edi */
            ii(0x100e_1ca6, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_1ca7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_1ca9, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_1caf, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_1cb2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_1cb5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_1cb8, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_1cbb, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_1cbd, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_1cc0, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x100e_1cc3, 5);  call(0x1013_ad11, 0x5_9049);          /* call 0x1013ad11 */
            ii(0x100e_1cc8, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_1cca, 2);  if(jnz(0x100e_1ce3, 0x17)) goto l_0x100e_1ce3;/* jnz 0x100e1ce3 */
            ii(0x100e_1ccc, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_1ccf, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x100e_1cd2, 5);  call(0x1007_65d0, -0x6_b707);         /* call 0x100765d0 */
            ii(0x100e_1cd7, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_1cd9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_1cdc, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100e_1cde, 5);  call(0x100e_30e6, 0x1403);            /* call 0x100e30e6 */
        l_0x100e_1ce3:
            ii(0x100e_1ce3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_1ce5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_1ce6, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_1ce7, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_1ce8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_1ce9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_1cea, 1);  ret();                                /* ret */
        }
    }
}
