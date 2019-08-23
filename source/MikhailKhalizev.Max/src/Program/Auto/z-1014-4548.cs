using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_4548-d10c50f8")]
        public void Method_1014_4548()
        {
            ii(0x1014_4548, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_454d, 5); calld(Definitions.sys_check_available_stack_size, 0x2_1800); /* call 0x10165d52 */
            ii(0x1014_4552, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_4553, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_4554, 1); pushd(esi);                             /* push esi */
            ii(0x1014_4555, 1); pushd(edi);                             /* push edi */
            ii(0x1014_4556, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_4557, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_4559, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_455f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_4562, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_4565, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_4568, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x1014_456b, 5); calld(0x100c_fbbe, -0x7_49b2);          /* call 0x100cfbbe */
            ii(0x1014_4570, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_4573, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_4576, 7); add(memw_a32[ds, edx + 0x154], ax);     /* add [edx+0x154], ax */
            ii(0x1014_457d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_4580, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_4583, 7); sub(memw_a32[ds, edx + 0x15c], ax);     /* sub [edx+0x15c], ax */
            ii(0x1014_458a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_458d, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x1014_4590, 5); calld(0x1007_6884, -0xc_dd11);          /* call 0x10076884 */
            ii(0x1014_4595, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_4597, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_459a, 4); add(memw_a32[ds, edx + 0x8], ax);       /* add [edx+0x8], ax */
            ii(0x1014_459e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_45a1, 5); calld(0x1014_3d54, -0x852);             /* call 0x10143d54 */
            ii(0x1014_45a6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_45a8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_45a9, 1); popd(edi);                              /* pop edi */
            ii(0x1014_45aa, 1); popd(esi);                              /* pop esi */
            ii(0x1014_45ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_45ac, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_45ad, 1); retd();                                 /* ret */
        }
    }
}
