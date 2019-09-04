using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_284c-3984709f")]
        public void Method_100a_284c()
        {
            ii(0x100a_284c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_2851, 5);  call(Definitions.sys_check_available_stack_size, 0xc_34fc);/* call 0x10165d52 */
            ii(0x100a_2856, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_2857, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_2858, 1);  push(esi);                            /* push esi */
            ii(0x100a_2859, 1);  push(edi);                            /* push edi */
            ii(0x100a_285a, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_285b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_285d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_2863, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_2866, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_2869, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_286c, 7);  mov(memd[ds, eax + 2], 0x101b_4f54);  /* mov dword [eax+0x2], 0x101b4f54 */
            ii(0x100a_2873, 7);  dec(memw[ds, 0x101c_31b6]);           /* dec word [0x101c31b6] */
            ii(0x100a_287a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_287c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_287f, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x100a_2882, 5);  call(0x1008_8b7c, -0x1_9d0b);         /* call 0x10088b7c */
            ii(0x100a_2887, 3);  sub(eax, 0xf);                        /* sub eax, 0xf */
            ii(0x100a_288a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_288d, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100a_2892, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_2895, 5);  call(0x1013_ab27, 0x9_828d);          /* call 0x1013ab27 */
            ii(0x100a_289a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_289d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_28a0, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_28a3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_28a6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_28a8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_28a9, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_28aa, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_28ab, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_28ac, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_28ad, 1);  ret();                                /* ret */
        }
    }
}
