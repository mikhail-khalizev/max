using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_b9c7-e213bb1")]
        public void Method_1007_b9c7()
        {
            ii(0x1007_b9c7, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_b9cc, 5);  call(Definitions.sys_check_available_stack_size, 0xe_a381);/* call 0x10165d52 */
            ii(0x1007_b9d1, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_b9d2, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_b9d3, 1);  push(edx);                            /* push edx */
            ii(0x1007_b9d4, 1);  push(esi);                            /* push esi */
            ii(0x1007_b9d5, 1);  push(edi);                            /* push edi */
            ii(0x1007_b9d6, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_b9d7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_b9d9, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_b9df, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_b9e2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_b9e4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b9e7, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_b9ea, 5);  call(0x1013_ad11, 0xb_f322);          /* call 0x1013ad11 */
            ii(0x1007_b9ef, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_b9f1, 2);  if(jnz(0x1007_ba23, 0x30)) goto l_0x1007_ba23;/* jnz 0x1007ba23 */
            ii(0x1007_b9f3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_b9f5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b9f8, 3);  add(eax, 0x29);                       /* add eax, 0x29 */
            ii(0x1007_b9fb, 5);  call(0x1007_6630, -0x53d0);           /* call 0x10076630 */
            ii(0x1007_ba00, 3);  lea(edx, memd[ss, ebp - 8]);          /* lea edx, [ebp-0x8] */
            ii(0x1007_ba03, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_ba06, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_ba09, 5);  call(0x1008_a228, 0xe81a);            /* call 0x1008a228 */
            ii(0x1007_ba0e, 5);  call(0x100b_8e63, 0x3_d450);          /* call 0x100b8e63 */
            ii(0x1007_ba13, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_ba16, 5);  call(0x1007_bd04, 0x2e9);             /* call 0x1007bd04 */
            ii(0x1007_ba1b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_ba1e, 5);  call(0x1007_b91c, -0x107);            /* call 0x1007b91c */
        l_0x1007_ba23:
            ii(0x1007_ba23, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_ba25, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_ba26, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_ba27, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_ba28, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_ba29, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_ba2a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_ba2b, 1);  ret();                                /* ret */
        }
    }
}
