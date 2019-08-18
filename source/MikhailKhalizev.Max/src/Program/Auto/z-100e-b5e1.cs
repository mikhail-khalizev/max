using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5f1be310-980e-4e22-82f2-bbc5d0ac8d58")]
        public void Method_100e_b5e1()
        {
            ii(0x100e_b5e1, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_b5e6, 5); calld(Definitions.sys_check_available_stack_size, 0x7_a767); /* call 0x10165d52 */
            ii(0x100e_b5eb, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_b5ec, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_b5ed, 1); pushd(esi);                             /* push esi */
            ii(0x100e_b5ee, 1); pushd(edi);                             /* push edi */
            ii(0x100e_b5ef, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_b5f0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b5f2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_b5f8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_b5fb, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100e_b5fe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b601, 3); mov(eax, memd_a32[ds, eax + 0x31]);     /* mov eax, [eax+0x31] */
            ii(0x100e_b604, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_b607, 5); calld(/* sys */ 0x1016_a24c, 0x7_ec40); /* call 0x1016a24c */
            ii(0x100e_b60c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_b60f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b612, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x100e_b615, 5); calld(0x100d_7f6c, -0x1_36ae);          /* call 0x100d7f6c */
            ii(0x100e_b61a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b61d, 4); cmp(memb_a32[ds, eax + 0x1a], 0);       /* cmp byte [eax+0x1a], 0x0 */
            ii(0x100e_b621, 2); if(jzd(0x100e_b62c, 0x9)) goto l_0x100e_b62c; /* jz 0x100eb62c */
            ii(0x100e_b623, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b626, 4); cmp(memb_a32[ds, eax + 0x32], 0);       /* cmp byte [eax+0x32], 0x0 */
            ii(0x100e_b62a, 2); if(jnzd(0x100e_b62e, 0x2)) goto l_0x100e_b62e; /* jnz 0x100eb62e */
        l_0x100e_b62c:
            ii(0x100e_b62c, 2); jmpd(0x100e_b637, 0x9); goto l_0x100e_b637; /* jmp 0x100eb637 */
        l_0x100e_b62e:
            ii(0x100e_b62e, 7); mov(memd_a32[ss, ebp - 0xc], 0xff);     /* mov dword [ebp-0xc], 0xff */
            ii(0x100e_b635, 2); jmpd(0x100e_b643, 0xc); goto l_0x100e_b643; /* jmp 0x100eb643 */
        l_0x100e_b637:
            ii(0x100e_b637, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b63a, 3); mov(eax, memd_a32[ds, eax + 0x2e]);     /* mov eax, [eax+0x2e] */
            ii(0x100e_b63d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_b640, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x100e_b643:
            ii(0x100e_b643, 3); pushd(memd_a32[ss, ebp - 0xc]);         /* push dword [ebp-0xc] */
            ii(0x100e_b646, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b649, 3); mov(ecx, memd_a32[ds, eax + 0xe]);      /* mov ecx, [eax+0xe] */
            ii(0x100e_b64c, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100e_b64f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b652, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_b655, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_b658, 2); sub(eax, memd_a32[ds, edx]);            /* sub eax, [edx] */
            ii(0x100e_b65a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_b65c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b65f, 3); mov(edx, memd_a32[ds, eax + 0x23]);     /* mov edx, [eax+0x23] */
            ii(0x100e_b662, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b665, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x100e_b668, 6); calld_abs(memd_a32[ds, 0x101b_ddec]);   /* call dword [0x101bddec] */
            ii(0x100e_b66e, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100e_b672, 2); if(jzd(0x100e_b682, 0xe)) goto l_0x100e_b682; /* jz 0x100eb682 */
            ii(0x100e_b674, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_b677, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b67a, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100e_b67d, 5); calld(Definitions.sys_display_draw_1, 0x7_be26); /* call 0x101674a8 */
        l_0x100e_b682:
            ii(0x100e_b682, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b684, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_b685, 1); popd(edi);                              /* pop edi */
            ii(0x100e_b686, 1); popd(esi);                              /* pop esi */
            ii(0x100e_b687, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_b688, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_b689, 1); retd(); return;                         /* ret */
        }
    }
}
