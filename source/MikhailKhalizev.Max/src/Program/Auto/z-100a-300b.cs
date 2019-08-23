using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_300b-2dce4b83")]
        public void Method_100a_300b()
        {
            ii(0x100a_300b, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_3010, 5); calld(Definitions.sys_check_available_stack_size, 0xc_2d3d); /* call 0x10165d52 */
            ii(0x100a_3015, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3016, 1); pushd(esi);                             /* push esi */
            ii(0x100a_3017, 1); pushd(edi);                             /* push edi */
            ii(0x100a_3018, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_3019, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_301b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_3021, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_3024, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_3027, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_302a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_302c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_302d, 1); popd(edi);                              /* pop edi */
            ii(0x100a_302e, 1); popd(esi);                              /* pop esi */
            ii(0x100a_302f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_3030, 1); retd();                                 /* ret */
        }
    }
}
