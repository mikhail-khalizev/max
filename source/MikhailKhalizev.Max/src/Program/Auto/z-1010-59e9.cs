using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_59e9-57655576")]
        public void Method_1010_59e9()
        {
            ii(0x1010_59e9, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1010_59ee, 5); calld(Definitions.sys_check_available_stack_size, 0x6_035f); /* call 0x10165d52 */
            ii(0x1010_59f3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_59f4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_59f5, 1); pushd(esi);                             /* push esi */
            ii(0x1010_59f6, 1); pushd(edi);                             /* push edi */
            ii(0x1010_59f7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_59f8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_59fa, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_5a00, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_5a03, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_5a06, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x1010_5a0b, 5); calld(0x100e_883d, -0x1_d1d3);          /* call 0x100e883d */
            ii(0x1010_5a10, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_5a13, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_5a17, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_5a1a, 2); cmp(edx, memd_a32[ds, eax]);            /* cmp edx, [eax] */
            ii(0x1010_5a1c, 2); if(jld(0x1010_5a2a, 0xc)) goto l_0x1010_5a2a; /* jl 0x10105a2a */
            ii(0x1010_5a1e, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_5a22, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_5a25, 3); cmp(edx, memd_a32[ds, eax + 0x8]);      /* cmp edx, [eax+0x8] */
            ii(0x1010_5a28, 2); if(jled(0x1010_5a2c, 0x2)) goto l_0x1010_5a2c; /* jle 0x10105a2c */
        l_0x1010_5a2a:
            ii(0x1010_5a2a, 2); jmpd(0x1010_5a38, 0xc); goto l_0x1010_5a38; /* jmp 0x10105a38 */
        l_0x1010_5a2c:
            ii(0x1010_5a2c, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1010_5a30, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_5a33, 3); cmp(edx, memd_a32[ds, eax + 0x4]);      /* cmp edx, [eax+0x4] */
            ii(0x1010_5a36, 2); if(jged(0x1010_5a3a, 0x2)) goto l_0x1010_5a3a; /* jge 0x10105a3a */
        l_0x1010_5a38:
            ii(0x1010_5a38, 2); jmpd(0x1010_5a46, 0xc); goto l_0x1010_5a46; /* jmp 0x10105a46 */
        l_0x1010_5a3a:
            ii(0x1010_5a3a, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1010_5a3e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_5a41, 3); cmp(edx, memd_a32[ds, eax + 0xc]);      /* cmp edx, [eax+0xc] */
            ii(0x1010_5a44, 2); if(jled(0x1010_5a52, 0xc)) goto l_0x1010_5a52; /* jle 0x10105a52 */
        l_0x1010_5a46:
            ii(0x1010_5a46, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1010_5a4d, 5); jmpd(0x1010_5af5, 0xa3); goto l_0x1010_5af5; /* jmp 0x10105af5 */
        l_0x1010_5a52:
            ii(0x1010_5a52, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_5a56, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_5a59, 2); sub(edx, memd_a32[ds, eax]);            /* sub edx, [eax] */
            ii(0x1010_5a5b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_5a5d, 7); imul(eax, memd_a32[ds, 0x101c_38c4]);   /* imul eax, [0x101c38c4] */
            ii(0x1010_5a64, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_5a67, 6); add(eax, memd_a32[ds, 0x101c_38ec]);    /* add eax, [0x101c38ec] */
            ii(0x1010_5a6d, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1010_5a70, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_5a73, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1010_5a77, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_5a7a, 3); sub(edx, memd_a32[ds, eax + 0x4]);      /* sub edx, [eax+0x4] */
            ii(0x1010_5a7d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_5a7f, 7); imul(eax, memd_a32[ds, 0x101c_38c4]);   /* imul eax, [0x101c38c4] */
            ii(0x1010_5a86, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_5a89, 6); add(eax, memd_a32[ds, 0x101c_38f0]);    /* add eax, [0x101c38f0] */
            ii(0x1010_5a8f, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1010_5a92, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_5a95, 5); mov(ecx, 0x40_0000);                    /* mov ecx, 0x400000 */
            ii(0x1010_5a9a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_5a9c, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1010_5aa1, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_5aa4, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1010_5aa8, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_5aac, 5); calld(0x1007_388b, -0x9_2226);          /* call 0x1007388b */
            ii(0x1010_5ab1, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_5ab4, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_5ab8, 2); if(jnzd(0x1010_5ad7, 0x1d)) goto l_0x1010_5ad7; /* jnz 0x10105ad7 */
            ii(0x1010_5aba, 5); mov(ecx, 0x40_0000);                    /* mov ecx, 0x400000 */
            ii(0x1010_5abf, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1010_5ac3, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_5ac7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_5ac9, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1010_5ace, 1); cwde();                                 /* cwde */
            ii(0x1010_5acf, 5); calld(0x1007_459a, -0x9_153a);          /* call 0x1007459a */
            ii(0x1010_5ad4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1010_5ad7:
            ii(0x1010_5ad7, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_5adb, 2); if(jnzd(0x1010_5ae6, 0x9)) goto l_0x1010_5ae6; /* jnz 0x10105ae6 */
            ii(0x1010_5add, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1010_5ae4, 2); jmpd(0x1010_5af5, 0xf); goto l_0x1010_5af5; /* jmp 0x10105af5 */
        l_0x1010_5ae6:
            ii(0x1010_5ae6, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_5ae9, 5); calld(0x1014_0d43, 0x3_b255);           /* call 0x10140d43 */
            ii(0x1010_5aee, 7); mov(memd_a32[ss, ebp - 0x10], 0x1);     /* mov dword [ebp-0x10], 0x1 */
        l_0x1010_5af5:
            ii(0x1010_5af5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_5af8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_5afa, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_5afb, 1); popd(edi);                              /* pop edi */
            ii(0x1010_5afc, 1); popd(esi);                              /* pop esi */
            ii(0x1010_5afd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_5afe, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_5aff, 1); retd(); return;                         /* ret */
        }
    }
}
