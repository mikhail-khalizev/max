using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d8f127be-0d61-402b-83b0-ba1e83a6ca86")]
        public void Method_1008_8d8c()
        {
            ii(0x1008_8d8c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_8d91, 5); calld(Definitions.sys_check_available_stack_size, 0xd_cfbc); /* call 0x10165d52 */
            ii(0x1008_8d96, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_8d97, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_8d98, 1); pushd(esi);                             /* push esi */
            ii(0x1008_8d99, 1); pushd(edi);                             /* push edi */
            ii(0x1008_8d9a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_8d9b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8d9d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8da3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8da6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_8da9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8dae, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8db1, 5); calld(0x1008_8a84, -0x332);             /* call 0x10088a84 */
            ii(0x1008_8db6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8db9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8dbc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_8dbf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_8dc2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8dc4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8dc5, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8dc6, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8dc7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8dc8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8dc9, 1); retd(); return;                         /* ret */
        }
    }
}