using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3f1e-87447eae")]
        public void Method_1016_3f1e()
        {
            ii(0x1016_3f1e, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1016_3f23, 5); calld(Definitions.sys_check_available_stack_size, 0x1e2a); /* call 0x10165d52 */
            ii(0x1016_3f28, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_3f29, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_3f2a, 1); pushd(esi);                             /* push esi */
            ii(0x1016_3f2b, 1); pushd(edi);                             /* push edi */
            ii(0x1016_3f2c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_3f2d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_3f2f, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_3f35, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_3f38, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_3f3b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_3f3e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1016_3f41, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3f44, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x1016_3f47, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3f4a, 4); mov(memw_a32[ds, eax + 0x8], dx);       /* mov [eax+0x8], dx */
            ii(0x1016_3f4e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3f51, 4); mov(dx, memw_a32[ds, eax + 0x2]);       /* mov dx, [eax+0x2] */
            ii(0x1016_3f55, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3f58, 4); mov(memw_a32[ds, eax + 0xa], dx);       /* mov [eax+0xa], dx */
            ii(0x1016_3f5c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3f5f, 4); mov(dx, memw_a32[ds, eax + 0x4]);       /* mov dx, [eax+0x4] */
            ii(0x1016_3f63, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3f66, 4); mov(memw_a32[ds, eax + 0xc], dx);       /* mov [eax+0xc], dx */
            ii(0x1016_3f6a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3f6d, 4); mov(dx, memw_a32[ds, eax + 0x6]);       /* mov dx, [eax+0x6] */
            ii(0x1016_3f71, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3f74, 4); mov(memw_a32[ds, eax + 0xe], dx);       /* mov [eax+0xe], dx */
            ii(0x1016_3f78, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3f7b, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x1016_3f7f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3f82, 4); mov(memw_a32[ds, eax + 0x10], dx);      /* mov [eax+0x10], dx */
            ii(0x1016_3f86, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3f89, 4); mov(dx, memw_a32[ds, eax + 0x12]);      /* mov dx, [eax+0x12] */
            ii(0x1016_3f8d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3f90, 4); cmp(dx, memw_a32[ds, eax + 0xa]);       /* cmp dx, [eax+0xa] */
            ii(0x1016_3f94, 2); if(jnzd(0x1016_3f9f, 0x9)) goto l_0x1016_3f9f; /* jnz 0x10163f9f */
            ii(0x1016_3f96, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1016_3f9d, 2); jmpd(0x1016_3fb8, 0x19); goto l_0x1016_3fb8; /* jmp 0x10163fb8 */
        l_0x1016_3f9f:
            ii(0x1016_3f9f, 5); mov(ecx, 0x2031);                       /* mov ecx, 0x2031 */
            ii(0x1016_3fa4, 5); mov(ebx, StringDefinitions.UnitsmgrCpp5); /* mov ebx, 0x101b2b54 */
            ii(0x1016_3fa9, 5); mov(edx, StringDefinitions.BuildingsEqualPacketBuildings); /* mov edx, 0x101b2b61 */
            ii(0x1016_3fae, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_3fb0, 5); calld(Definitions.sys_assert, 0x1ddd);  /* call 0x10165d92 */
            ii(0x1016_3fb5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1016_3fb8:
            ii(0x1016_3fb8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_3fba, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_3fbb, 1); popd(edi);                              /* pop edi */
            ii(0x1016_3fbc, 1); popd(esi);                              /* pop esi */
            ii(0x1016_3fbd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_3fbe, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_3fbf, 1); retd();                                 /* ret */
        }
    }
}
