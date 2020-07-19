using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_1aa2-8ea6a706")]
        public void Method_100b_1aa2()
        {
            ii(0x100b_1aa2, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_1aa7, 5);  call(Definitions.sys_check_available_stack_size, 0xb_42a6);/* call 0x10165d52 */
            ii(0x100b_1aac, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_1aad, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_1aae, 1);  push(edx);                            /* push edx */
            ii(0x100b_1aaf, 1);  push(esi);                            /* push esi */
            ii(0x100b_1ab0, 1);  push(edi);                            /* push edi */
            ii(0x100b_1ab1, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_1ab2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_1ab4, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_1aba, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_1abd, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_1abf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_1ac2, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x100b_1ac5, 5);  call(0x1013_ad71, 0x8_92a7);          /* call 0x1013ad71 */
            ii(0x100b_1aca, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_1acc, 2);  if(jz(0x100b_1ae5, 0x17)) goto l_0x100b_1ae5;/* jz 0x100b1ae5 */
            ii(0x100b_1ace, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_1ad1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_1ad4, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x100b_1ad7, 5);  call(0x1007_6574, -0x3_b568);         /* call 0x10076574 */
            ii(0x100b_1adc, 5);  call(0x1015_2a52, 0xa_0f71);          /* call 0x10152a52 */
            ii(0x100b_1ae1, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_1ae3, 2);  if(jnz(0x100b_1ae7, 2)) goto l_0x100b_1ae7;/* jnz 0x100b1ae7 */
        l_0x100b_1ae5:
            ii(0x100b_1ae5, 2);  jmp(0x100b_1b06, 0x1f); goto l_0x100b_1b06;/* jmp 0x100b1b06 */
        l_0x100b_1ae7:
            ii(0x100b_1ae7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_1aea, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_1aed, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1af0, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x100b_1af3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_1af6, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x100b_1af9, 5);  call(0x1007_65d0, -0x3_b52e);         /* call 0x100765d0 */
            ii(0x100b_1afe, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_1b00, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1b03, 3);  call_abs(memd[ds, ebx + 68]);         /* call dword [ebx+0x44] */
        l_0x100b_1b06:
            ii(0x100b_1b06, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_1b08, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_1b09, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_1b0a, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_1b0b, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_1b0c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_1b0d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_1b0e, 1);  ret();                                /* ret */
        }
    }
}
