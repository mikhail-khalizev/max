using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_4796-50b08457")]
        public void Method_100f_4796()
        {
            ii(0x100f_4796, 5);  push(0x1c);                           /* push 0x1c */
            ii(0x100f_479b, 5);  call(Definitions.sys_check_available_stack_size, 0x7_15b2);/* call 0x10165d52 */
            ii(0x100f_47a0, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_47a1, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_47a2, 1);  push(edx);                            /* push edx */
            ii(0x100f_47a3, 1);  push(esi);                            /* push esi */
            ii(0x100f_47a4, 1);  push(edi);                            /* push edi */
            ii(0x100f_47a5, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_47a6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_47a8, 6);  sub(esp, 0);                          /* sub esp, 0x0 */
            ii(0x100f_47ae, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_47b0, 5);  mov(eax, memd[ds, 0x101b_87d1]);      /* mov eax, [0x101b87d1] */
            ii(0x100f_47b5, 5);  call(0x100c_fb73, -0x2_4c47);         /* call 0x100cfb73 */
            ii(0x100f_47ba, 5);  call(0x100f_fc13, 0xb454);            /* call 0x100ffc13 */
            ii(0x100f_47bf, 5);  call(0x1013_16c7, 0x3_cf03);          /* call 0x101316c7 */
            ii(0x100f_47c4, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x100f_47c9, 5);  call(/* sys */ 0x1016_a24c, 0x7_5a7e);/* call 0x1016a24c */
            ii(0x100f_47ce, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_47d3, 5);  call(0x1007_6600, -0x7_e1d8);         /* call 0x10076600 */
            ii(0x100f_47d8, 5);  call(0x100f_fa70, 0xb293);            /* call 0x100ffa70 */
            ii(0x100f_47dd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_47de, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_47df, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_47e0, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_47e1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_47e2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_47e3, 1);  ret();                                /* ret */
        }
    }
}
