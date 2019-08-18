using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_b229-f25f012f")]
        public void Method_100d_b229()
        {
            ii(0x100d_b229, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100d_b22e, 5); calld(Definitions.sys_check_available_stack_size, 0x8_ab1f); /* call 0x10165d52 */
            ii(0x100d_b233, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_b234, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_b235, 1); pushd(edx);                             /* push edx */
            ii(0x100d_b236, 1); pushd(esi);                             /* push esi */
            ii(0x100d_b237, 1); pushd(edi);                             /* push edi */
            ii(0x100d_b238, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_b239, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_b23b, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100d_b241, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_b244, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_b247, 6); mov(eax, memd_a32[ds, eax + 0x345]);    /* mov eax, [eax+0x345] */
            ii(0x100d_b24d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_b250, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_b253, 3); mov(edx, memd_a32[ds, eax + 0x40]);     /* mov edx, [eax+0x40] */
            ii(0x100d_b256, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_b259, 3); calld_abs(memd_a32[ds, edx + 0x10]);    /* call dword [edx+0x10] */
            ii(0x100d_b25c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_b25f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_b262, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b265, 3); mov(ebx, memd_a32[ds, eax + 0x13]);     /* mov ebx, [eax+0x13] */
            ii(0x100d_b268, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_b26b, 6); mov(eax, memd_a32[ds, eax + 0x345]);    /* mov eax, [eax+0x345] */
            ii(0x100d_b271, 5); calld(0x100d_0149, -0xb12d);            /* call 0x100d0149 */
            ii(0x100d_b276, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_b279, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_b27c, 3); calld_abs(memd_a32[ds, ebx + 0x8]);     /* call dword [ebx+0x8] */
        l_0x100d_b27f:
            ii(0x100d_b27f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_b282, 7); cmp(memb_a32[ds, eax + 0x343], 0);      /* cmp byte [eax+0x343], 0x0 */
            ii(0x100d_b289, 2); if(jnzd(0x100d_b2c0, 0x35)) goto l_0x100d_b2c0; /* jnz 0x100db2c0 */
            ii(0x100d_b28b, 5); calld(/* sys */ 0x1016_b208, 0x8_ff78); /* call 0x1016b208 */
            ii(0x100d_b290, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_b293, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100d_b297, 2); if(jled(0x100d_b2ae, 0x15)) goto l_0x100d_b2ae; /* jle 0x100db2ae */
            ii(0x100d_b299, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_b29c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_b29f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_b2a2, 3); mov(ebx, memd_a32[ds, eax + 0x13]);     /* mov ebx, [eax+0x13] */
            ii(0x100d_b2a5, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_b2a8, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_b2ab, 3); calld_abs(memd_a32[ds, ebx + 0x20]);    /* call dword [ebx+0x20] */
        l_0x100d_b2ae:
            ii(0x100d_b2ae, 5); calld(0x100d_5094, -0x621f);            /* call 0x100d5094 */
            ii(0x100d_b2b3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_b2b5, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_b2b7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_b2b9, 5); calld(0x1010_0e32, 0x2_5b74);           /* call 0x10100e32 */
            ii(0x100d_b2be, 2); jmpd(0x100d_b27f, -0x41); goto l_0x100d_b27f; /* jmp 0x100db27f */
        l_0x100d_b2c0:
            ii(0x100d_b2c0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_b2c3, 7); cmp(memb_a32[ds, eax + 0x344], 0);      /* cmp byte [eax+0x344], 0x0 */
            ii(0x100d_b2ca, 2); if(jnzd(0x100d_b2d5, 0x9)) goto l_0x100d_b2d5; /* jnz 0x100db2d5 */
            ii(0x100d_b2cc, 7); mov(memd_a32[ss, ebp - 0x1c], 0x1);     /* mov dword [ebp-0x1c], 0x1 */
            ii(0x100d_b2d3, 2); jmpd(0x100d_b2dc, 0x7); goto l_0x100d_b2dc; /* jmp 0x100db2dc */
        l_0x100d_b2d5:
            ii(0x100d_b2d5, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
        l_0x100d_b2dc:
            ii(0x100d_b2dc, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_b2df, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_b2e2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_b2e5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_b2e7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_b2e8, 1); popd(edi);                              /* pop edi */
            ii(0x100d_b2e9, 1); popd(esi);                              /* pop esi */
            ii(0x100d_b2ea, 1); popd(edx);                              /* pop edx */
            ii(0x100d_b2eb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_b2ec, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_b2ed, 1); retd(); return;                         /* ret */
        }
    }
}
