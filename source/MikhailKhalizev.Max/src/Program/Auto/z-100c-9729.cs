using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0808934d-ed93-4c55-8b34-ba79cb990435")]
        public void Method_100c_9729()
        {
            ii(0x100c_9729, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100c_972e, 5); calld(Definitions.sys_check_available_stack_size, 0x9_c61f); /* call 0x10165d52 */
            ii(0x100c_9733, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_9734, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_9735, 1); pushd(esi);                             /* push esi */
            ii(0x100c_9736, 1); pushd(edi);                             /* push edi */
            ii(0x100c_9737, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_9738, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_973a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_9740, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_9743, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_9746, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_9749, 3); mov(edx, memd_a32[ds, eax + 0x11]);     /* mov edx, [eax+0x11] */
            ii(0x100c_974c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_974f, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x100c_9754, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_9757, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_9759, 2); if(jld(0x100c_976a, 0xf)) goto l_0x100c_976a; /* jl 0x100c976a */
            ii(0x100c_975b, 5); mov(edx, StringDefinitions.UpdateTerrainFinished); /* mov edx, 0x101a1358 */
            ii(0x100c_9760, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_9763, 5); calld(Definitions.sys_strcpy, 0x9_c767); /* call 0x10165ecf */
            ii(0x100c_9768, 2); jmpd(0x100c_9792, 0x28); goto l_0x100c_9792; /* jmp 0x100c9792 */
        l_0x100c_976a:
            ii(0x100c_976a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_976d, 3); mov(eax, memd_a32[ds, eax + 0x13]);     /* mov eax, [eax+0x13] */
            ii(0x100c_9770, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_9773, 1); inc(eax);                               /* inc eax */
            ii(0x100c_9774, 1); pushd(eax);                             /* push eax */
            ii(0x100c_9775, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_9778, 3); mov(eax, memd_a32[ds, eax + 0x11]);     /* mov eax, [eax+0x11] */
            ii(0x100c_977b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_977e, 1); inc(eax);                               /* inc eax */
            ii(0x100c_977f, 1); pushd(eax);                             /* push eax */
            ii(0x100c_9780, 5); mov(eax, StringDefinitions.UpdateTerrainII); /* mov eax, 0x101a1372 */
            ii(0x100c_9785, 1); pushd(eax);                             /* push eax */
            ii(0x100c_9786, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_9789, 1); pushd(eax);                             /* push eax */
            ii(0x100c_978a, 5); calld(Definitions.sys_sprintf, 0x9_c772); /* call 0x10165f01 */
            ii(0x100c_978f, 3); add(esp, 0x10);                         /* add esp, 0x10 */
        l_0x100c_9792:
            ii(0x100c_9792, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_9795, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_9798, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_979b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_979d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_979e, 1); popd(edi);                              /* pop edi */
            ii(0x100c_979f, 1); popd(esi);                              /* pop esi */
            ii(0x100c_97a0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_97a1, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_97a2, 1); retd(); return;                         /* ret */
        }
    }
}
