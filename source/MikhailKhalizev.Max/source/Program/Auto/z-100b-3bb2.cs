using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3bb2-f3aa6780")]
        public void Method_100b_3bb2()
        {
            ii(0x100b_3bb2, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_3bb7, 5);  call(Definitions.sys_check_available_stack_size, 0xb_2196);/* call 0x10165d52 */
            ii(0x100b_3bbc, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_3bbd, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_3bbe, 1);  push(edx);                            /* push edx */
            ii(0x100b_3bbf, 1);  push(esi);                            /* push esi */
            ii(0x100b_3bc0, 1);  push(edi);                            /* push edi */
            ii(0x100b_3bc1, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_3bc2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_3bc4, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_3bca, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_3bcd, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_3bcf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3bd2, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3bd5, 5);  call(0x1013_ad71, 0x8_7197);          /* call 0x1013ad71 */
            ii(0x100b_3bda, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_3bdc, 2);  if(jz(0x100b_3bfd, 0x1f)) goto l_0x100b_3bfd;/* jz 0x100b3bfd */
            ii(0x100b_3bde, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3be1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_3be4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3be7, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x100b_3bea, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3bed, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3bf0, 5);  call(0x1007_65d0, -0x3_d625);         /* call 0x100765d0 */
            ii(0x100b_3bf5, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_3bf7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3bfa, 3);  call_abs(memd[ds, ebx + 68]);         /* call dword [ebx+0x44] */
        l_0x100b_3bfd:
            ii(0x100b_3bfd, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_3bff, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_3c00, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_3c01, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_3c02, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_3c03, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_3c04, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_3c05, 1);  ret();                                /* ret */
        }
    }
}
