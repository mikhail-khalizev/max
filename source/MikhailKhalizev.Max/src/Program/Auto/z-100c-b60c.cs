using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("32c68cec-52af-4958-a105-e7eacac9a3bb")]
        public void Method_100c_b60c()
        {
            ii(0x100c_b60c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_b611, 5); calld(Definitions.sys_check_available_stack_size, 0x9a73c); /* call 0x10165d52 */
            ii(0x100c_b616, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b617, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b618, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b619, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b61a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b61b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b61d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b623, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b626, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b629, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b62c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_b62f, 4); mov(memw_a32[ds, edx + 0x6], ax);       /* mov [edx+0x6], ax */
            ii(0x100c_b633, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b635, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b636, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b637, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b638, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b639, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b63a, 1); retd(); return;                         /* ret */
        }
    }
}
