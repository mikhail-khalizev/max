using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_1c60-2f293c93")]
        public void Method_1007_1c60()
        {
            ii(0x1007_1c60, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_1c65, 5);  call(Definitions.sys_check_available_stack_size, 0xf_40e8);/* call 0x10165d52 */
            ii(0x1007_1c6a, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_1c6b, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_1c6c, 1);  push(edx);                            /* push edx */
            ii(0x1007_1c6d, 1);  push(esi);                            /* push esi */
            ii(0x1007_1c6e, 1);  push(edi);                            /* push edi */
            ii(0x1007_1c6f, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_1c70, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_1c72, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_1c78, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_1c7b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_1c7e, 5);  call(0x1007_6338, 0x46b5);            /* call 0x10076338 */
            ii(0x1007_1c83, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_1c85, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_1c88, 5);  call(0x1007_64b8, 0x482b);            /* call 0x100764b8 */
        l_0x1007_1c8d:
            ii(0x1007_1c8d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_1c8f, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_1c92, 5);  call(0x1013_ad71, 0xc_90da);          /* call 0x1013ad71 */
            ii(0x1007_1c97, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_1c99, 2);  if(jz(0x1007_1cb7, 0x1c)) goto l_0x1007_1cb7;/* jz 0x10071cb7 */
            ii(0x1007_1c9b, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1007_1ca0, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_1ca3, 5);  call(0x1007_6408, 0x4760);            /* call 0x10076408 */
            ii(0x1007_1ca8, 5);  call(0x1007_1838, -0x475);            /* call 0x10071838 */
            ii(0x1007_1cad, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_1cb0, 5);  call(0x1007_6bf8, 0x4f43);            /* call 0x10076bf8 */
            ii(0x1007_1cb5, 2);  jmp(0x1007_1c8d, -0x2a); goto l_0x1007_1c8d;/* jmp 0x10071c8d */
        l_0x1007_1cb7:
            ii(0x1007_1cb7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_1cb9, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_1cbc, 5);  call(0x1007_5f6c, 0x42ab);            /* call 0x10075f6c */
            ii(0x1007_1cc1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_1cc3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_1cc4, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_1cc5, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_1cc6, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_1cc7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_1cc8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_1cc9, 1);  ret();                                /* ret */
        }
    }
}
