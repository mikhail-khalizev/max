using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a26f19b7-3793-4029-b4ef-b0e29e1e11b9")]
        public void Method_1014_3cec()
        {
            ii(0x1014_3cec, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_3cf1, 5); calld(Definitions.sys_check_available_stack_size, 0x2_205c); /* call 0x10165d52 */
            ii(0x1014_3cf6, 1); pushd(esi);                             /* push esi */
            ii(0x1014_3cf7, 1); pushd(edi);                             /* push edi */
            ii(0x1014_3cf8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_3cf9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_3cfb, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1014_3d01, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_3d04, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1014_3d07, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1014_3d0a, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1014_3d0d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_3d10, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1014_3d13, 2); if(jld(0x1014_3d1d, 0x8)) goto l_0x1014_3d1d; /* jl 0x10143d1d */
            ii(0x1014_3d15, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_3d18, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_3d1b, 2); jmpd(0x1014_3d4b, 0x2e); goto l_0x1014_3d4b; /* jmp 0x10143d4b */
        l_0x1014_3d1d:
            ii(0x1014_3d1d, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x1014_3d20, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1014_3d23, 3); sub(ebx, memd_a32[ss, ebp - 0x8]);      /* sub ebx, [ebp-0x8] */
            ii(0x1014_3d26, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1014_3d29, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_3d2c, 5); calld(0x1014_37d1, -0x560);             /* call 0x101437d1 */
            ii(0x1014_3d31, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_3d34, 3); mov(ebx, memd_a32[ss, ebp - 0x14]);     /* mov ebx, [ebp-0x14] */
            ii(0x1014_3d37, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1014_3d3a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_3d3d, 5); calld(0x1014_3b69, -0x1d9);             /* call 0x10143b69 */
            ii(0x1014_3d42, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_3d45, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1014_3d48, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1014_3d4b:
            ii(0x1014_3d4b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_3d4e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_3d50, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_3d51, 1); popd(edi);                              /* pop edi */
            ii(0x1014_3d52, 1); popd(esi);                              /* pop esi */
            ii(0x1014_3d53, 1); retd(); return;                         /* ret */
        }
    }
}
