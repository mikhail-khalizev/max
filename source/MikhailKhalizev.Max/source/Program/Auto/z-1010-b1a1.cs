using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_b1a1-3f1bd431")]
        public void Method_1010_b1a1()
        {
            ii(0x1010_b1a1, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_b1a6, 5);  call(Definitions.sys_check_available_stack_size, 0x5_aba7);/* call 0x10165d52 */
            ii(0x1010_b1ab, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_b1ac, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_b1ad, 1);  push(edx);                            /* push edx */
            ii(0x1010_b1ae, 1);  push(esi);                            /* push esi */
            ii(0x1010_b1af, 1);  push(edi);                            /* push edi */
            ii(0x1010_b1b0, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_b1b1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_b1b3, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_b1b9, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_b1bc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b1bf, 3);  mov(edx, memd[ds, eax + 13]);         /* mov edx, [eax+0xd] */
            ii(0x1010_b1c2, 3);  sub(edx, 0x22);                       /* sub edx, 0x22 */
            ii(0x1010_b1c5, 5);  mov(eax, 0x4f);                       /* mov eax, 0x4f */
            ii(0x1010_b1ca, 5);  call(0x100c_aafc, -0x4_06d3);         /* call 0x100caafc */
            ii(0x1010_b1cf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b1d2, 5);  call(0x1010_a564, -0xc73);            /* call 0x1010a564 */
            ii(0x1010_b1d7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b1da, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_b1dc, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1010_b1df, 5);  call(Definitions.sys_display_draw_0, 0x5_c2a0);/* call 0x10167484 */
            ii(0x1010_b1e4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_b1e6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_b1e7, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_b1e8, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_b1e9, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_b1ea, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_b1eb, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_b1ec, 1);  ret();                                /* ret */
        }
    }
}
