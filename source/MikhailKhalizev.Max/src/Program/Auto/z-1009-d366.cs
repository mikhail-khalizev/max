using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_d366-139ccb77")]
        public void Method_1009_d366()
        {
            ii(0x1009_d366, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_d36b, 5); calld(Definitions.sys_check_available_stack_size, 0xc_89e2); /* call 0x10165d52 */
            ii(0x1009_d370, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_d371, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_d372, 1); pushd(edx);                             /* push edx */
            ii(0x1009_d373, 1); pushd(esi);                             /* push esi */
            ii(0x1009_d374, 1); pushd(edi);                             /* push edi */
            ii(0x1009_d375, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_d376, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_d378, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_d37e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_d381, 4); mov(memb_a32[ss, ebp - 0x8], 0x27);     /* mov byte [ebp-0x8], 0x27 */
            ii(0x1009_d385, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_d388, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_d38a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_d38b, 1); popd(edi);                              /* pop edi */
            ii(0x1009_d38c, 1); popd(esi);                              /* pop esi */
            ii(0x1009_d38d, 1); popd(edx);                              /* pop edx */
            ii(0x1009_d38e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_d38f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_d390, 1); retd(); return;                         /* ret */
        }
    }
}
