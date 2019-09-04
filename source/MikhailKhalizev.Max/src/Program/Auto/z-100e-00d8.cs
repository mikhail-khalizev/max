using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_00d8-f83cb1dc")]
        public void Method_100e_00d8()
        {
            ii(0x100e_00d8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_00dd, 5); call(Definitions.sys_check_available_stack_size, 0x8_5c70); /* call 0x10165d52 */
            ii(0x100e_00e2, 1); push(ebx);                              /* push ebx */
            ii(0x100e_00e3, 1); push(ecx);                              /* push ecx */
            ii(0x100e_00e4, 1); push(esi);                              /* push esi */
            ii(0x100e_00e5, 1); push(edi);                              /* push edi */
            ii(0x100e_00e6, 1); push(ebp);                              /* push ebp */
            ii(0x100e_00e7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_00e9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_00ef, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_00f2, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_00f5, 5); mov(ebx, 0x101b_5ec8);                  /* mov ebx, 0x101b5ec8 */
            ii(0x100e_00fa, 5); mov(edx, 4);                            /* mov edx, 0x4 */
            ii(0x100e_00ff, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_0102, 5); call(Definitions.sys_call_dtor_arr_v2, 0x8_5ed9); /* call 0x10165fe0 */
            ii(0x100e_0107, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100e_010a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_010d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_010f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0110, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0111, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0112, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0113, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0114, 1); ret();                                  /* ret */
        }
    }
}
