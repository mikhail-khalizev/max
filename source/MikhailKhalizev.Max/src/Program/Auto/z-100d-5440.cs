using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5440-fe6d4413")]
        public void Method_100d_5440()
        {
            ii(0x100d_5440, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_5445, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0908); /* call 0x10165d52 */
            ii(0x100d_544a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_544b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_544c, 1); pushd(edx);                             /* push edx */
            ii(0x100d_544d, 1); pushd(esi);                             /* push esi */
            ii(0x100d_544e, 1); pushd(edi);                             /* push edi */
            ii(0x100d_544f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_5450, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5452, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_5458, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_545b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_545e, 3); mov(al, memb_a32[ds, eax + 0x7a]);      /* mov al, [eax+0x7a] */
            ii(0x100d_5461, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100d_5464, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100d_5467, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_5469, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_546a, 1); popd(edi);                              /* pop edi */
            ii(0x100d_546b, 1); popd(esi);                              /* pop esi */
            ii(0x100d_546c, 1); popd(edx);                              /* pop edx */
            ii(0x100d_546d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_546e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_546f, 1); retd();                                 /* ret */
        }
    }
}
