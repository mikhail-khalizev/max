using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f6317576-7124-44ff-ab50-17377c6ba7a2")]
        public void my_dtor_d3()
        {
            ii(0x100d_7d33, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_7d38, 5); calld(Definitions.sys_check_available_stack_size, 0x8e015); /* call 0x10165d52 */
            ii(0x100d_7d3d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_7d3e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_7d3f, 1); pushd(esi);                             /* push esi */
            ii(0x100d_7d40, 1); pushd(edi);                             /* push edi */
            ii(0x100d_7d41, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_7d42, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_7d44, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_7d4a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_7d4d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_7d50, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7d53, 4); cmp(memb_a32[ds, eax + 0xc], 0);        /* cmp byte [eax+0xc], 0x0 */
            ii(0x100d_7d57, 2); if(jzd(0x100d_7d63, 0xa)) goto l_0x100d_7d63; /* jz 0x100d7d63 */
            ii(0x100d_7d59, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7d5c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100d_7d5e, 5); calld(Definitions.sys_delete, 0x8e201); /* call 0x10165f64 */
        l_0x100d_7d63:
            ii(0x100d_7d63, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7d66, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_7d69, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_7d6c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_7d6e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_7d6f, 1); popd(edi);                              /* pop edi */
            ii(0x100d_7d70, 1); popd(esi);                              /* pop esi */
            ii(0x100d_7d71, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_7d72, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_7d73, 1); retd(); return;                         /* ret */
        }
    }
}
