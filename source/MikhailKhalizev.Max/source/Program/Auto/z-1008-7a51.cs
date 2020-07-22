using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_7a51-aaaf155")]
        public void Method_1008_7a51()
        {
            ii(0x1008_7a51, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_7a56, 5);  call(Definitions.sys_check_available_stack_size, 0xd_e2f7);/* call 0x10165d52 */
            ii(0x1008_7a5b, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_7a5c, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_7a5d, 1);  push(edx);                            /* push edx */
            ii(0x1008_7a5e, 1);  push(esi);                            /* push esi */
            ii(0x1008_7a5f, 1);  push(edi);                            /* push edi */
            ii(0x1008_7a60, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_7a61, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_7a63, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_7a69, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_7a6c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_7a6e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_7a71, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1008_7a74, 5);  call(0x1013_ad71, 0xb_32f8);          /* call 0x1013ad71 */
            ii(0x1008_7a79, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x1008_7a7c, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_7a7f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_7a81, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_7a82, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_7a83, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_7a84, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_7a85, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_7a86, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_7a87, 1);  ret();                                /* ret */
        }
    }
}
