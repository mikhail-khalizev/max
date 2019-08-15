using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d9c622d9-4bb2-4cb6-9c94-b53e2f12bee0")]
        public void Method_1013_2d9a()
        {
            ii(0x1013_2d9a, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1013_2d9f, 5); calld(Definitions.sys_check_available_stack_size, 0x3_2fae); /* call 0x10165d52 */
            ii(0x1013_2da4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_2da5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_2da6, 1); pushd(esi);                             /* push esi */
            ii(0x1013_2da7, 1); pushd(edi);                             /* push edi */
            ii(0x1013_2da8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_2da9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_2dab, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1013_2db1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_2db4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_2db7, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1013_2dbe, 2); if(jzd(0x1013_2dd7, 0x17)) goto l_0x1013_2dd7; /* jz 0x10132dd7 */
            ii(0x1013_2dc0, 5); mov(edx, 0x101b_6c48);                  /* mov edx, 0x101b6c48 */
            ii(0x1013_2dc5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2dc8, 5); calld(Definitions.sys_call_dtor_arr, 0x3_31eb); /* call 0x10165fb8 */
            ii(0x1013_2dcd, 5); calld(Definitions.sys_delete_arr, 0x3_3206); /* call 0x10165fd8 */
            ii(0x1013_2dd2, 5); jmpd(0x1013_2eac, 0xd5); goto l_0x1013_2eac; /* jmp 0x10132eac */
        l_0x1013_2dd7:
            ii(0x1013_2dd7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2dda, 7); mov(memd_a32[ds, eax + 0x13], 0x101b_6c70); /* mov dword [eax+0x13], 0x101b6c70 */
            ii(0x1013_2de1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2de4, 3); mov(eax, memd_a32[ds, eax + 0x1e]);     /* mov eax, [eax+0x1e] */
            ii(0x1013_2de7, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1013_2dea, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1013_2dee, 2); if(jzd(0x1013_2e04, 0x14)) goto l_0x1013_2e04; /* jz 0x10132e04 */
            ii(0x1013_2df0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_2df2, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1013_2df5, 5); calld(Definitions.my_dtor_d2, -0x6_48c2); /* call 0x100ce538 */
            ii(0x1013_2dfa, 5); calld(Definitions.sys_delete, 0x3_3165); /* call 0x10165f64 */
            ii(0x1013_2dff, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_2e02, 2); jmpd(0x1013_2e0b, 0x7); goto l_0x1013_2e0b; /* jmp 0x10132e0b */
        l_0x1013_2e04:
            ii(0x1013_2e04, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x1013_2e0b:
            ii(0x1013_2e0b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2e0e, 3); mov(eax, memd_a32[ds, eax + 0x26]);     /* mov eax, [eax+0x26] */
            ii(0x1013_2e11, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1013_2e14, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1013_2e18, 2); if(jzd(0x1013_2e2e, 0x14)) goto l_0x1013_2e2e; /* jz 0x10132e2e */
            ii(0x1013_2e1a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_2e1c, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_2e1f, 5); calld(Definitions.my_dtor_d2, -0x6_48ec); /* call 0x100ce538 */
            ii(0x1013_2e24, 5); calld(Definitions.sys_delete, 0x3_313b); /* call 0x10165f64 */
            ii(0x1013_2e29, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_2e2c, 2); jmpd(0x1013_2e35, 0x7); goto l_0x1013_2e35; /* jmp 0x10132e35 */
        l_0x1013_2e2e:
            ii(0x1013_2e2e, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1013_2e35:
            ii(0x1013_2e35, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2e38, 3); mov(eax, memd_a32[ds, eax + 0x22]);     /* mov eax, [eax+0x22] */
            ii(0x1013_2e3b, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_2e3e, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1013_2e42, 2); if(jzd(0x1013_2e58, 0x14)) goto l_0x1013_2e58; /* jz 0x10132e58 */
            ii(0x1013_2e44, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_2e46, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_2e49, 5); calld(Definitions.my_dtor_d2, -0x6_4916); /* call 0x100ce538 */
            ii(0x1013_2e4e, 5); calld(Definitions.sys_delete, 0x3_3111); /* call 0x10165f64 */
            ii(0x1013_2e53, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_2e56, 2); jmpd(0x1013_2e5f, 0x7); goto l_0x1013_2e5f; /* jmp 0x10132e5f */
        l_0x1013_2e58:
            ii(0x1013_2e58, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1013_2e5f:
            ii(0x1013_2e5f, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1013_2e64, 5); calld(0x1007_65d0, -0xb_c899);          /* call 0x100765d0 */
            ii(0x1013_2e69, 5); calld(0x100f_fa70, -0x3_33fe);          /* call 0x100ffa70 */
            ii(0x1013_2e6e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_2e73, 5); calld(0x1010_0efe, -0x3_1f7a);          /* call 0x10100efe */
            ii(0x1013_2e78, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_2e7a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2e7d, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1013_2e80, 5); calld(0x1013_38bc, 0xa37);              /* call 0x101338bc */
            ii(0x1013_2e85, 3); sub(eax, 0x2a);                         /* sub eax, 0x2a */
            ii(0x1013_2e88, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_2e8b, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_2e90, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2e93, 5); calld(0x100d_6999, -0x5_c4ff);          /* call 0x100d6999 */
            ii(0x1013_2e98, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_2e9b, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1013_2ea2, 2); if(jzd(0x1013_2eac, 0x8)) goto l_0x1013_2eac; /* jz 0x10132eac */
            ii(0x1013_2ea4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2ea7, 5); calld(Definitions.sys_delete, 0x3_30b8); /* call 0x10165f64 */
        l_0x1013_2eac:
            ii(0x1013_2eac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2eaf, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_2eb2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_2eb5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_2eb7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_2eb8, 1); popd(edi);                              /* pop edi */
            ii(0x1013_2eb9, 1); popd(esi);                              /* pop esi */
            ii(0x1013_2eba, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_2ebb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_2ebc, 1); retd(); return;                         /* ret */
        }
    }
}
