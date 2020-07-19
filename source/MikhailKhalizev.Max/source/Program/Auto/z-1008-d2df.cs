using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_d2df-18733a60")]
        public void Method_1008_d2df()
        {
            ii(0x1008_d2df, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1008_d2e4, 5);  call(Definitions.sys_check_available_stack_size, 0xd_8a69);/* call 0x10165d52 */
            ii(0x1008_d2e9, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_d2ea, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_d2eb, 1);  push(edx);                            /* push edx */
            ii(0x1008_d2ec, 1);  push(esi);                            /* push esi */
            ii(0x1008_d2ed, 1);  push(edi);                            /* push edi */
            ii(0x1008_d2ee, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_d2ef, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_d2f1, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1008_d2f7, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_d2fa, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_d2fc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_d2ff, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1008_d302, 5);  call(0x1013_ad71, 0xa_da6a);          /* call 0x1013ad71 */
            ii(0x1008_d307, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_d309, 2);  if(jz(0x1008_d339, 0x2e)) goto l_0x1008_d339;/* jz 0x1008d339 */
            ii(0x1008_d30b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_d30e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_d311, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1008_d314, 5);  call(0x1007_6574, -0x1_6da5);         /* call 0x10076574 */
            ii(0x1008_d319, 5);  call(0x1015_27ed, 0xc_54cf);          /* call 0x101527ed */
            ii(0x1008_d31e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_d321, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1008_d324, 5);  call(0x1007_6574, -0x1_6db5);         /* call 0x10076574 */
            ii(0x1008_d329, 4);  cmp(memb[ds, eax + 62], 0x1f);        /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1008_d32d, 2);  if(jnz(0x1008_d337, 8)) goto l_0x1008_d337;/* jnz 0x1008d337 */
            ii(0x1008_d32f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_d332, 5);  call(0x1008_d461, 0x12a);             /* call 0x1008d461 */
        l_0x1008_d337:
            ii(0x1008_d337, 2);  jmp(0x1008_d346, 0xd); goto l_0x1008_d346;/* jmp 0x1008d346 */
        l_0x1008_d339:
            ii(0x1008_d339, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1008_d33e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_d341, 5);  call(0x100a_2a04, 0x1_56be);          /* call 0x100a2a04 */
        l_0x1008_d346:
            ii(0x1008_d346, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_d348, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_d349, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_d34a, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_d34b, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_d34c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_d34d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_d34e, 1);  ret();                                /* ret */
        }
    }
}
