using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f3f5eac4-be4b-4168-9118-0aa1e7290188")]
        public void Method_100c_2e41()
        {
            ii(0x100c_2e41, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x100c_2e46, 5); calld(Definitions.sys_check_available_stack_size, 0xa2f07); /* call 0x10165d52 */
            ii(0x100c_2e4b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_2e4c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_2e4d, 1); pushd(esi);                             /* push esi */
            ii(0x100c_2e4e, 1); pushd(edi);                             /* push edi */
            ii(0x100c_2e4f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_2e50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_2e52, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100c_2e58, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_2e5b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_2e5e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2e61, 4); cmp(memd_a32[ds, eax + 0x67], 0);       /* cmp dword [eax+0x67], 0x0 */
            ii(0x100c_2e65, 6); if(jzd(0x100c_2fb9, 0x14e)) goto l_0x100c_2fb9; /* jz 0x100c2fb9 */
            ii(0x100c_2e6b, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100c_2e6e, 3); mov(ebx, memd_a32[ds, ebx + 0x1a]);     /* mov ebx, [ebx+0x1a] */
            ii(0x100c_2e71, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_2e74, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_2e77, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100c_2e7a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_2e7d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_2e80, 5); calld(0x1007_6aac, -0x4c3d9);           /* call 0x10076aac */
            ii(0x100c_2e85, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_2e88, 5); calld(0x1007_623c, -0x4cc51);           /* call 0x1007623c */
            ii(0x100c_2e8d, 4); mov(ax, memw_a32[ds, eax + 0xe]);       /* mov ax, [eax+0xe] */
            ii(0x100c_2e91, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_2e94, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x100c_2e99, 1); pushd(eax);                             /* push eax */
            ii(0x100c_2e9a, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100c_2e9e, 1); pushd(eax);                             /* push eax */
            ii(0x100c_2e9f, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x100c_2ea4, 3); mov(eax, memd_a32[ss, ebp - 0xe]);      /* mov eax, [ebp-0xe] */
            ii(0x100c_2ea7, 1); inc(eax);                               /* inc eax */
            ii(0x100c_2ea8, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100c_2eab, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_2eae, 1); dec(eax);                               /* dec eax */
            ii(0x100c_2eaf, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_2eb2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2eb5, 5); calld(0x100c_2d1f, -0x19b);             /* call 0x100c2d1f */
            ii(0x100c_2eba, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100c_2ebf, 1); pushd(eax);                             /* push eax */
            ii(0x100c_2ec0, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100c_2ec4, 1); pushd(eax);                             /* push eax */
            ii(0x100c_2ec5, 5); mov(ecx, 0x4);                          /* mov ecx, 0x4 */
            ii(0x100c_2eca, 3); mov(eax, memd_a32[ss, ebp - 0xe]);      /* mov eax, [ebp-0xe] */
            ii(0x100c_2ecd, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100c_2ed2, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100c_2ed5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_2ed8, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100c_2edb, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_2ede, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2ee1, 5); calld(0x100c_2d1f, -0x1c7);             /* call 0x100c2d1f */
            ii(0x100c_2ee6, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100c_2eeb, 1); pushd(eax);                             /* push eax */
            ii(0x100c_2eec, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100c_2ef0, 1); pushd(eax);                             /* push eax */
            ii(0x100c_2ef1, 5); mov(ecx, 0x6);                          /* mov ecx, 0x6 */
            ii(0x100c_2ef6, 3); mov(eax, memd_a32[ss, ebp - 0xe]);      /* mov eax, [ebp-0xe] */
            ii(0x100c_2ef9, 5); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100c_2efe, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100c_2f01, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_2f04, 3); sub(eax, 0x3);                          /* sub eax, 0x3 */
            ii(0x100c_2f07, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_2f0a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2f0d, 5); calld(0x100c_2d1f, -0x1f3);             /* call 0x100c2d1f */
            ii(0x100c_2f12, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_2f17, 1); pushd(eax);                             /* push eax */
            ii(0x100c_2f18, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100c_2f1c, 1); pushd(eax);                             /* push eax */
            ii(0x100c_2f1d, 5); mov(ecx, 0x8);                          /* mov ecx, 0x8 */
            ii(0x100c_2f22, 3); mov(eax, memd_a32[ss, ebp - 0xe]);      /* mov eax, [ebp-0xe] */
            ii(0x100c_2f25, 5); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100c_2f2a, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100c_2f2d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_2f30, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x100c_2f33, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_2f36, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2f39, 5); calld(0x100c_2d1f, -0x21f);             /* call 0x100c2d1f */
            ii(0x100c_2f3e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_2f40, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2f43, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x100c_2f46, 5); calld(0x1013_ad11, 0x77dc6);            /* call 0x1013ad11 */
            ii(0x100c_2f4b, 2); test(al, al);                           /* test al, al */
            ii(0x100c_2f4d, 2); if(jzd(0x100c_2fb9, 0x6a)) goto l_0x100c_2fb9; /* jz 0x100c2fb9 */
            ii(0x100c_2f4f, 5); mov(eax, 0x23);                         /* mov eax, 0x23 */
            ii(0x100c_2f54, 5); calld(Definitions.sys_new, 0xa2ea7);    /* call 0x10165e00 */
            ii(0x100c_2f59, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_2f5c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_2f5f, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_2f62, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100c_2f66, 2); if(jzd(0x100c_2f8e, 0x26)) goto l_0x100c_2f8e; /* jz 0x100c2f8e */
            ii(0x100c_2f68, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x100c_2f6b, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100c_2f6e, 5); calld(0x1007_5e64, -0x4d10f);           /* call 0x10075e64 */
            ii(0x100c_2f73, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_2f75, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2f78, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100c_2f7b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_2f7e, 5); calld(0x1009_ef13, -0x24070);           /* call 0x1009ef13 */
            ii(0x100c_2f83, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100c_2f86, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100c_2f89, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100c_2f8c, 2); jmpd(0x100c_2f94, 0x6); goto l_0x100c_2f94; /* jmp 0x100c2f94 */
        l_0x100c_2f8e:
            ii(0x100c_2f8e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_2f91, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x100c_2f94:
            ii(0x100c_2f94, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_2f97, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2f9a, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x100c_2f9d, 5); calld(0x1008_afe4, -0x37fbe);           /* call 0x1008afe4 */
            ii(0x100c_2fa2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2fa5, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x100c_2fa8, 5); calld(0x1008_af84, -0x38029);           /* call 0x1008af84 */
            ii(0x100c_2fad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_2faf, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_2fb4, 5); calld(0x100a_4d50, -0x1e269);           /* call 0x100a4d50 */
        l_0x100c_2fb9:
            ii(0x100c_2fb9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_2fbb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_2fbc, 1); popd(edi);                              /* pop edi */
            ii(0x100c_2fbd, 1); popd(esi);                              /* pop esi */
            ii(0x100c_2fbe, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_2fbf, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_2fc0, 1); retd(); return;                         /* ret */
        }
    }
}
