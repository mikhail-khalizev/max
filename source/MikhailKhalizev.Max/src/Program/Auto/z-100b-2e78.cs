using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b0cbf33f-f5a8-46fc-ba63-197830be56c8")]
        public void Method_100b_2e78()
        {
            ii(0x100b_2e78, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100b_2e7d, 5); calld(Definitions.sys_check_available_stack_size, 0xb_2ed0); /* call 0x10165d52 */
            ii(0x100b_2e82, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_2e83, 1); pushd(esi);                             /* push esi */
            ii(0x100b_2e84, 1); pushd(edi);                             /* push edi */
            ii(0x100b_2e85, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_2e86, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_2e88, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100b_2e8e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_2e91, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_2e94, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100b_2e97, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_2e9a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_2e9d, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100b_2ea1, 2); if(jnzd(0x100b_2ece, 0x2b)) goto l_0x100b_2ece; /* jnz 0x100b2ece */
            ii(0x100b_2ea3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2ea6, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100b_2ea9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_2eae, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_2eb0, 2); if(jled(0x100b_2eb8, 0x6)) goto l_0x100b_2eb8; /* jle 0x100b2eb8 */
            ii(0x100b_2eb2, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x100b_2eb6, 2); jmpd(0x100b_2ebc, 0x4); goto l_0x100b_2ebc; /* jmp 0x100b2ebc */
        l_0x100b_2eb8:
            ii(0x100b_2eb8, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x100b_2ebc:
            ii(0x100b_2ebc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2ebe, 3); mov(dl, memb_a32[ss, ebp - 0x14]);      /* mov dl, [ebp-0x14] */
            ii(0x100b_2ec1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2ec4, 5); calld(0x100a_297d, -0x1_054c);          /* call 0x100a297d */
            ii(0x100b_2ec9, 5); jmpd(0x100b_2f52, 0x84); goto l_0x100b_2f52; /* jmp 0x100b2f52 */
        l_0x100b_2ece:
            ii(0x100b_2ece, 4); cmp(memb_a32[ss, ebp - 0x4], 0x2);      /* cmp byte [ebp-0x4], 0x2 */
            ii(0x100b_2ed2, 6); if(jnzd(0x100b_2f52, 0x7a)) goto l_0x100b_2f52; /* jnz 0x100b2f52 */
            ii(0x100b_2ed8, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100b_2edd, 5); calld(Definitions.sys_new, 0xb_2f1e);   /* call 0x10165e00 */
            ii(0x100b_2ee2, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_2ee5, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_2ee8, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_2eeb, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100b_2eef, 2); if(jzd(0x100b_2f23, 0x32)) goto l_0x100b_2f23; /* jz 0x100b2f23 */
            ii(0x100b_2ef1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_2ef4, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2ef7, 5); calld(0x1007_65d0, -0x3_c92c);          /* call 0x100765d0 */
            ii(0x100b_2efc, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_2efe, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_2f01, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2f04, 5); calld(0x1008_a57c, -0x2_898d);          /* call 0x1008a57c */
            ii(0x100b_2f09, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100b_2f0c, 3); mov(esi, memd_a32[ss, ebp - 0x18]);     /* mov esi, [ebp-0x18] */
            ii(0x100b_2f0f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_2f11, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100b_2f13, 5); calld(0x100b_0050, -0x2ec8);            /* call 0x100b0050 */
            ii(0x100b_2f18, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_2f1b, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100b_2f1e, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100b_2f21, 2); jmpd(0x100b_2f29, 0x6); goto l_0x100b_2f29; /* jmp 0x100b2f29 */
        l_0x100b_2f23:
            ii(0x100b_2f23, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_2f26, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x100b_2f29:
            ii(0x100b_2f29, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100b_2f2c, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_2f2f, 5); calld(0x1008_b060, -0x2_7ed4);          /* call 0x1008b060 */
            ii(0x100b_2f34, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_2f37, 5); calld(0x1008_af84, -0x2_7fb8);          /* call 0x1008af84 */
            ii(0x100b_2f3c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2f3e, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_2f43, 5); calld(0x100a_4d50, -0xe1f8);            /* call 0x100a4d50 */
            ii(0x100b_2f48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2f4a, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_2f4d, 5); calld(0x1008_8b7c, -0x2_a3d6);          /* call 0x10088b7c */
        l_0x100b_2f52:
            ii(0x100b_2f52, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_2f54, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_2f55, 1); popd(edi);                              /* pop edi */
            ii(0x100b_2f56, 1); popd(esi);                              /* pop esi */
            ii(0x100b_2f57, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_2f58, 1); retd(); return;                         /* ret */
        }
    }
}
