using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("413e55e5-3570-44d1-a480-65282eff5e6f")]
        public void Method_100c_fbf5()
        {
            ii(0x100c_fbf5, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_fbfa, 5); calld(Definitions.sys_check_available_stack_size, 0x9_6153); /* call 0x10165d52 */
            ii(0x100c_fbff, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_fc00, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_fc01, 1); pushd(esi);                             /* push esi */
            ii(0x100c_fc02, 1); pushd(edi);                             /* push edi */
            ii(0x100c_fc03, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_fc04, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_fc06, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_fc0c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_fc0f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_fc12, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_fc15, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_fc18, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_fc1b, 4); cmp(memb_a32[ds, eax + 0x37], 0);       /* cmp byte [eax+0x37], 0x0 */
            ii(0x100c_fc1f, 2); if(jnzd(0x100c_fc3e, 0x1d)) goto l_0x100c_fc3e; /* jnz 0x100cfc3e */
            ii(0x100c_fc21, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_fc24, 4); mov(memb_a32[ds, eax + 0x37], 0x1);     /* mov byte [eax+0x37], 0x1 */
            ii(0x100c_fc28, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_fc2b, 3); mov(eax, memd_a32[ds, eax + 0x33]);     /* mov eax, [eax+0x33] */
            ii(0x100c_fc2e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_fc31, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100c_fc34, 2); if(jzd(0x100c_fc3e, 0x8)) goto l_0x100c_fc3e; /* jz 0x100cfc3e */
            ii(0x100c_fc36, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_fc39, 5); calld(0x100c_fbbe, -0x80);              /* call 0x100cfbbe */
        l_0x100c_fc3e:
            ii(0x100c_fc3e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_fc41, 4); cmp(memd_a32[ds, eax + 0x29], 0);       /* cmp dword [eax+0x29], 0x0 */
            ii(0x100c_fc45, 2); if(jzd(0x100c_fc56, 0xf)) goto l_0x100c_fc56; /* jz 0x100cfc56 */
            ii(0x100c_fc47, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100c_fc4a, 3); mov(edx, memd_a32[ds, ebx + 0x1c]);     /* mov edx, [ebx+0x1c] */
            ii(0x100c_fc4d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_fc50, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100c_fc53, 3); calld_abs(memd_a32[ds, ebx + 0x29]);    /* call dword [ebx+0x29] */
        l_0x100c_fc56:
            ii(0x100c_fc56, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_fc58, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_fc59, 1); popd(edi);                              /* pop edi */
            ii(0x100c_fc5a, 1); popd(esi);                              /* pop esi */
            ii(0x100c_fc5b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_fc5c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_fc5d, 1); retd(); return;                         /* ret */
        }
    }
}
