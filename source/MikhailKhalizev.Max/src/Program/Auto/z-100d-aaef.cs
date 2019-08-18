using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_aaef-cfc7b7c3")]
        public void Method_100d_aaef()
        {
            ii(0x100d_aaef, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100d_aaf4, 5); calld(Definitions.sys_check_available_stack_size, 0x8_b259); /* call 0x10165d52 */
            ii(0x100d_aaf9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_aafa, 1); pushd(esi);                             /* push esi */
            ii(0x100d_aafb, 1); pushd(edi);                             /* push edi */
            ii(0x100d_aafc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_aafd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_aaff, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100d_ab05, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_ab08, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100d_ab0b, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100d_ab0e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ab11, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100d_ab14, 6); cmp(eax, memd_a32[ds, edx + 0x345]);    /* cmp eax, [edx+0x345] */
            ii(0x100d_ab1a, 2); if(jnzd(0x100d_ab6f, 0x53)) goto l_0x100d_ab6f; /* jnz 0x100dab6f */
            ii(0x100d_ab1c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ab1f, 5); calld(0x100d_0149, -0xa9db);            /* call 0x100d0149 */
            ii(0x100d_ab24, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_ab27, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100d_ab2b, 2); if(jzd(0x100d_ab39, 0xc)) goto l_0x100d_ab39; /* jz 0x100dab39 */
            ii(0x100d_ab2d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_ab30, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100d_ab33, 4); cmp(ax, memw_a32[ds, edx + 0x59]);      /* cmp ax, [edx+0x59] */
            ii(0x100d_ab37, 2); if(jzd(0x100d_ab3b, 0x2)) goto l_0x100d_ab3b; /* jz 0x100dab3b */
        l_0x100d_ab39:
            ii(0x100d_ab39, 2); jmpd(0x100d_ab53, 0x18); goto l_0x100d_ab53; /* jmp 0x100dab53 */
        l_0x100d_ab3b:
            ii(0x100d_ab3b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_ab3e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_ab41, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_ab44, 3); mov(ebx, memd_a32[ds, eax + 0x13]);     /* mov ebx, [eax+0x13] */
            ii(0x100d_ab47, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100d_ab4b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_ab4e, 3); calld_abs(memd_a32[ds, ebx + 0xc]);     /* call dword [ebx+0xc] */
            ii(0x100d_ab51, 2); jmpd(0x100d_ab69, 0x16); goto l_0x100d_ab69; /* jmp 0x100dab69 */
        l_0x100d_ab53:
            ii(0x100d_ab53, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_ab56, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_ab59, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_ab5c, 3); mov(ebx, memd_a32[ds, eax + 0x13]);     /* mov ebx, [eax+0x13] */
            ii(0x100d_ab5f, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100d_ab63, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_ab66, 3); calld_abs(memd_a32[ds, ebx + 0x8]);     /* call dword [ebx+0x8] */
        l_0x100d_ab69:
            ii(0x100d_ab69, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100d_ab6d, 2); jmpd(0x100d_ab73, 0x4); goto l_0x100d_ab73; /* jmp 0x100dab73 */
        l_0x100d_ab6f:
            ii(0x100d_ab6f, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x100d_ab73:
            ii(0x100d_ab73, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100d_ab76, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_ab78, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_ab79, 1); popd(edi);                              /* pop edi */
            ii(0x100d_ab7a, 1); popd(esi);                              /* pop esi */
            ii(0x100d_ab7b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_ab7c, 1); retd(); return;                         /* ret */
        }
    }
}
