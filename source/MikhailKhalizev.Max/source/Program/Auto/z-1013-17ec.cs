using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_17ec-f96c0f8a")]
        public void Method_1013_17ec()
        {
            ii(0x1013_17ec, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_17f1, 5);  call(Definitions.sys_check_available_stack_size, 0x3_455c);/* call 0x10165d52 */
            ii(0x1013_17f6, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_17f7, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_17f8, 1);  push(esi);                            /* push esi */
            ii(0x1013_17f9, 1);  push(edi);                            /* push edi */
            ii(0x1013_17fa, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_17fb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_17fd, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_1803, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1806, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_1809, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x1013_1810, 2);  if(jz(0x1013_1826, 0x14)) goto l_0x1013_1826;/* jz 0x10131826 */
            ii(0x1013_1812, 5);  mov(edx, 0x101b_6bac);                /* mov edx, 0x101b6bac */
            ii(0x1013_1817, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_181a, 5);  call(Definitions.sys_call_dtor_arr, 0x3_4799);/* call 0x10165fb8 */
            ii(0x1013_181f, 5);  call(Definitions.sys_delete_arr, 0x3_47b4);/* call 0x10165fd8 */
            ii(0x1013_1824, 2);  jmp(0x1013_186d, 0x47); goto l_0x1013_186d;/* jmp 0x1013186d */
        l_0x1013_1826:
            ii(0x1013_1826, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_1828, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_182b, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x1013_182e, 5);  call(Definitions.my_string_dtor, 0x1_02f7);/* call 0x10141b2a */
            ii(0x1013_1833, 3);  sub(eax, 0xa);                        /* sub eax, 0xa */
            ii(0x1013_1836, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1839, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_183b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_183e, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1013_1841, 5);  call(0x1013_17ac, -0x9a);             /* call 0x101317ac */
            ii(0x1013_1846, 3);  sub(eax, 6);                          /* sub eax, 0x6 */
            ii(0x1013_1849, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_184c, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1013_1851, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1854, 5);  call(0x1013_ab27, 0x92ce);            /* call 0x1013ab27 */
            ii(0x1013_1859, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_185c, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x1013_1863, 2);  if(jz(0x1013_186d, 8)) goto l_0x1013_186d;/* jz 0x1013186d */
            ii(0x1013_1865, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1868, 5);  call(Definitions.sys_delete, 0x3_46f7);/* call 0x10165f64 */
        l_0x1013_186d:
            ii(0x1013_186d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1870, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_1873, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_1876, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_1878, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_1879, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_187a, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_187b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_187c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_187d, 1);  ret();                                /* ret */
        }
    }
}
