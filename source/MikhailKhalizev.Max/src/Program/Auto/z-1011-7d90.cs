using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("99dcf087-01c2-4e51-951e-45ddc942f397")]
        public void Method_1011_7d90()
        {
            ii(0x1011_7d90, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_7d95, 5); calld(Definitions.sys_check_available_stack_size, 0x4_dfb8); /* call 0x10165d52 */
            ii(0x1011_7d9a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_7d9b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7d9c, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7d9d, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7d9e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7d9f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7da1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_7da7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_7daa, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_7dad, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_7db0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_7db3, 5); calld(0x1007_6cd0, -0xa_10e8);          /* call 0x10076cd0 */
            ii(0x1011_7db8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_7dbb, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1011_7dbe, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_7dc1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_7dc4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_7dc7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_7dca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7dcc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_7dcd, 1); popd(edi);                              /* pop edi */
            ii(0x1011_7dce, 1); popd(esi);                              /* pop esi */
            ii(0x1011_7dcf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_7dd0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_7dd1, 1); retd(); return;                         /* ret */
        }
    }
}