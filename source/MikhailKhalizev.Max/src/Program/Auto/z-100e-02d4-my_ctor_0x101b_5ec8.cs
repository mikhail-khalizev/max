using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_02d4-961afb15")]
        public void my_ctor_0x101b_5ec8()
        {
            ii(0x100e_02d4, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100e_02d9, 5); call(Definitions.sys_check_available_stack_size, 0x8_5a74); /* call 0x10165d52 */
            ii(0x100e_02de, 1); push(ebx);                              /* push ebx */
            ii(0x100e_02df, 1); push(ecx);                              /* push ecx */
            ii(0x100e_02e0, 1); push(edx);                              /* push edx */
            ii(0x100e_02e1, 1); push(esi);                              /* push esi */
            ii(0x100e_02e2, 1); push(edi);                              /* push edi */
            ii(0x100e_02e3, 1); push(ebp);                              /* push ebp */
            ii(0x100e_02e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_02e6, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_02ec, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_02ef, 5); call(0x1008_b3ec, -0x5_4f08);           /* call 0x1008b3ec */
            ii(0x100e_02f4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_02f7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_02fa, 5); call(0x1008_b1e4, -0x5_511b);           /* call 0x1008b1e4 */
            ii(0x100e_02ff, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_0302, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_0305, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_0308, 5); call(0x100e_0a20, 0x713);               /* call 0x100e0a20 */
            ii(0x100e_030d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_0310, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_0313, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x100e_0316, 5); call(0x100e_09b8, 0x69d);               /* call 0x100e09b8 */
            ii(0x100e_031b, 3); sub(eax, 4);                            /* sub eax, 0x4 */
            ii(0x100e_031e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_0321, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_0324, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_0327, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_032a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_032d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_0330, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0332, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0333, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0334, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0335, 1); pop(edx);                               /* pop edx */
            ii(0x100e_0336, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0337, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0338, 1); ret();                                  /* ret */
        }
    }
}
