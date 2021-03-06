using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ba6f-ed37f46c")]
        public void Method_100c_ba6f()
        {
            ii(0x100c_ba6f, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_ba74, 5);  call(Definitions.sys_check_available_stack_size, 0x9_a2d9);/* call 0x10165d52 */
            ii(0x100c_ba79, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_ba7a, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_ba7b, 1);  push(edx);                            /* push edx */
            ii(0x100c_ba7c, 1);  push(esi);                            /* push esi */
            ii(0x100c_ba7d, 1);  push(edi);                            /* push edi */
            ii(0x100c_ba7e, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_ba7f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_ba81, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_ba87, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_ba8a, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_ba8d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_ba90, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_ba93, 5);  call(0x1007_6574, -0x5_5524);         /* call 0x10076574 */
            ii(0x100c_ba98, 5);  call(0x1015_27ed, 0x8_6d50);          /* call 0x101527ed */
            ii(0x100c_ba9d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_baa0, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_baa3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_baa6, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_baa9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_baac, 3);  call_abs(memd[ds, edx + 124]);        /* call dword [edx+0x7c] */
            ii(0x100c_baaf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_bab2, 5);  call(0x100c_c6df, 0xc28);             /* call 0x100cc6df */
            ii(0x100c_bab7, 5);  call(0x1008_b0e4, -0x4_09d8);         /* call 0x1008b0e4 */
            ii(0x100c_babc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_babe, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100c_bac0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_bac3, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_bac6, 5);  call(0x1007_65d0, -0x5_54fb);         /* call 0x100765d0 */
            ii(0x100c_bacb, 5);  call(0x100a_297d, -0x2_9153);         /* call 0x100a297d */
            ii(0x100c_bad0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_bad2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_bad3, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_bad4, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_bad5, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_bad6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_bad7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_bad8, 1);  ret();                                /* ret */
        }
    }
}
