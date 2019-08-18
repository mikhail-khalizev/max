using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("13207b91-3e18-4021-8f78-0c0590843197")]
        public void Method_100c_a668()
        {
            ii(0x100c_a668, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_a66d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_b6e0); /* call 0x10165d52 */
            ii(0x100c_a672, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a673, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a674, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a675, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a676, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a677, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a679, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a67f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a682, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_a685, 3); mov(edi, memd_a32[ss, ebp - 0x8]);      /* mov edi, [ebp-0x8] */
            ii(0x100c_a688, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x100c_a68b, 2); movsw_a32();                            /* movsw */
            ii(0x100c_a68d, 1); movsb_a32();                            /* movsb */
            ii(0x100c_a68e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a691, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_a694, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_a697, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a699, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a69a, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a69b, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a69c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a69d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a69e, 1); retd(); return;                         /* ret */
        }
    }
}
