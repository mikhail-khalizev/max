using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6d00-9df8c1ce")]
        public void Method_1013_6d00()
        {
            ii(0x1013_6d00, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1013_6d05, 5);  call(Definitions.sys_check_available_stack_size, 0x2_f048);/* call 0x10165d52 */
            ii(0x1013_6d0a, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_6d0b, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_6d0c, 1);  push(esi);                            /* push esi */
            ii(0x1013_6d0d, 1);  push(edi);                            /* push edi */
            ii(0x1013_6d0e, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_6d0f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_6d11, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1013_6d17, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_6d1a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_6d1d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_6d20, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_6d22, 3);  mov(memd[ss, ebp - 18], eax);         /* mov [ebp-0x12], eax */
            ii(0x1013_6d25, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6d28, 3);  mov(memd[ss, ebp - 14], eax);         /* mov [ebp-0xe], eax */
            ii(0x1013_6d2b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_6d2e, 4);  mov(ax, memw[ds, eax + 12]);          /* mov ax, [eax+0xc] */
            ii(0x1013_6d32, 4);  mov(memw[ss, ebp - 20], ax);          /* mov [ebp-0x14], ax */
            ii(0x1013_6d36, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_6d39, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1013_6d3c, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_6d3f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_6d42, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x1013_6d45, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_6d48, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_6d4b, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1013_6d4e, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_6d51, 3);  add(eax, memd[ds, edx + 12]);         /* add eax, [edx+0xc] */
            ii(0x1013_6d54, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_6d57, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_6d5a, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x1013_6d5d, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_6d60, 3);  add(eax, memd[ds, edx + 16]);         /* add eax, [edx+0x10] */
            ii(0x1013_6d63, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_6d66, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x1013_6d69, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_6d6c, 3);  mov(eax, memd[ds, eax + 79]);         /* mov eax, [eax+0x4f] */
            ii(0x1013_6d6f, 5);  call(0x100e_b528, -0x4_b84c);         /* call 0x100eb528 */
            ii(0x1013_6d74, 5);  call(0x100d_6104, -0x6_0c75);         /* call 0x100d6104 */
            ii(0x1013_6d79, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_6d7b, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1013_6d7d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_6d80, 3);  mov(eax, memd[ds, eax + 79]);         /* mov eax, [eax+0x4f] */
            ii(0x1013_6d83, 5);  call(0x100e_b5e1, -0x4_b7a7);         /* call 0x100eb5e1 */
            ii(0x1013_6d88, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_6d8a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_6d8b, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_6d8c, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_6d8d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_6d8e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_6d8f, 1);  ret();                                /* ret */
        }
    }
}
