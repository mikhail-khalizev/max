using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a30ac046-3f08-4476-9dd9-e2106516cd1d")]
        public void Method_1016_43f8()
        {
            ii(0x1016_43f8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_43fd, 5); calld(Definitions.sys_check_available_stack_size, 0x1950); /* call 0x10165d52 */
            ii(0x1016_4402, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_4403, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4404, 1); pushd(edx);                             /* push edx */
            ii(0x1016_4405, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4406, 1); pushd(edi);                             /* push edi */
            ii(0x1016_4407, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_4408, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_440a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_4410, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_4413, 5); calld(0x1016_484c, 0x434);              /* call 0x1016484c */
            ii(0x1016_4418, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_441b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_441e, 5); calld(0x1016_47f8, 0x3d5);              /* call 0x101647f8 */
            ii(0x1016_4423, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_4426, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4429, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_442b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_442c, 1); popd(edi);                              /* pop edi */
            ii(0x1016_442d, 1); popd(esi);                              /* pop esi */
            ii(0x1016_442e, 1); popd(edx);                              /* pop edx */
            ii(0x1016_442f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_4430, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_4431, 1); retd(); return;                         /* ret */
        }
    }
}
