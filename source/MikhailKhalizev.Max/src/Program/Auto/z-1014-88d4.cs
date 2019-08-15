using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ac6dace9-60a8-4133-b2e4-664bd751e8ed")]
        public void Method_1014_88d4()
        {
            ii(0x1014_88d4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_88d9, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d474); /* call 0x10165d52 */
            ii(0x1014_88de, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_88df, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_88e0, 1); pushd(edx);                             /* push edx */
            ii(0x1014_88e1, 1); pushd(esi);                             /* push esi */
            ii(0x1014_88e2, 1); pushd(edi);                             /* push edi */
            ii(0x1014_88e3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_88e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_88e6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_88ec, 5); mov(eax, 0x101b_d8e8);                  /* mov eax, 0x101bd8e8 */
            ii(0x1014_88f1, 5); calld(/* sys */ 0x1016_611f, 0x1_d829); /* call 0x1016611f */
            ii(0x1014_88f6, 5); mov(ecx, 0x1014_899e);                  /* mov ecx, 0x1014899e */
            ii(0x1014_88fb, 5); mov(ebx, 0x101c_814c);                  /* mov ebx, 0x101c814c */
            ii(0x1014_8900, 5); mov(edx, StringDefinitions.Unitinfo);   /* mov edx, 0x101ad188 */
            ii(0x1014_8905, 5); mov(eax, 0x101c_8150);                  /* mov eax, 0x101c8150 */
            ii(0x1014_890a, 5); calld(0x1013_b77c, -0xd193);            /* call 0x1013b77c */
            ii(0x1014_890f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8912, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8915, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8918, 10); mov(memd_a32[ds, 0x101b_d8f0], 0x1);   /* mov dword [0x101bd8f0], 0x1 */
            ii(0x1014_8922, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_8924, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_8925, 1); popd(edi);                              /* pop edi */
            ii(0x1014_8926, 1); popd(esi);                              /* pop esi */
            ii(0x1014_8927, 1); popd(edx);                              /* pop edx */
            ii(0x1014_8928, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_8929, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_892a, 1); retd(); return;                         /* ret */
        }
    }
}
