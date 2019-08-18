using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a026-af623c7f")]
        public void Method_1009_a026()
        {
            ii(0x1009_a026, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_a02b, 5); calld(Definitions.sys_check_available_stack_size, 0xc_bd22); /* call 0x10165d52 */
            ii(0x1009_a030, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_a031, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_a032, 1); pushd(edx);                             /* push edx */
            ii(0x1009_a033, 1); pushd(esi);                             /* push esi */
            ii(0x1009_a034, 1); pushd(edi);                             /* push edi */
            ii(0x1009_a035, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_a036, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a038, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_a03e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_a041, 4); mov(memb_a32[ss, ebp - 0x8], 0x1b);     /* mov byte [ebp-0x8], 0x1b */
            ii(0x1009_a045, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_a048, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a04a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_a04b, 1); popd(edi);                              /* pop edi */
            ii(0x1009_a04c, 1); popd(esi);                              /* pop esi */
            ii(0x1009_a04d, 1); popd(edx);                              /* pop edx */
            ii(0x1009_a04e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_a04f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_a050, 1); retd(); return;                         /* ret */
        }
    }
}
