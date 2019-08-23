using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_0d4c-52e1dae9")]
        public void Method_1015_0d4c()
        {
            ii(0x1015_0d4c, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1015_0d51, 5); calld(Definitions.sys_check_available_stack_size, 0x1_4ffc); /* call 0x10165d52 */
            ii(0x1015_0d56, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_0d57, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_0d58, 1); pushd(edx);                             /* push edx */
            ii(0x1015_0d59, 1); pushd(esi);                             /* push esi */
            ii(0x1015_0d5a, 1); pushd(edi);                             /* push edi */
            ii(0x1015_0d5b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_0d5c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_0d5e, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1015_0d64, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_0d67, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0d6a, 4); cmp(memb_a32[ds, eax + 0x5a], 0);       /* cmp byte [eax+0x5a], 0x0 */
            ii(0x1015_0d6e, 2); if(jnzd(0x1015_0d79, 0x9)) goto l_0x1015_0d79; /* jnz 0x10150d79 */
            ii(0x1015_0d70, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0d73, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1015_0d77, 2); if(jnzd(0x1015_0d7b, 0x2)) goto l_0x1015_0d7b; /* jnz 0x10150d7b */
        l_0x1015_0d79:
            ii(0x1015_0d79, 2); jmpd(0x1015_0d9b, 0x20); goto l_0x1015_0d9b; /* jmp 0x10150d9b */
        l_0x1015_0d7b:
            ii(0x1015_0d7b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0d7e, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0d81, 5); calld(0x1007_6730, -0xd_a656);          /* call 0x10076730 */
            ii(0x1015_0d86, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1015_0d89, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_0d8c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0d8f, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1015_0d92, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_0d97, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1015_0d99, 2); if(jnzd(0x1015_0d9d, 0x2)) goto l_0x1015_0d9d; /* jnz 0x10150d9d */
        l_0x1015_0d9b:
            ii(0x1015_0d9b, 2); jmpd(0x1015_0e09, 0x6c); goto l_0x1015_0e09; /* jmp 0x10150e09 */
        l_0x1015_0d9d:
            ii(0x1015_0d9d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_0da0, 5); calld(0x1007_20b1, -0xd_ecf4);          /* call 0x100720b1 */
            ii(0x1015_0da5, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_0da8, 5); calld(0x1007_20b1, -0xd_ecfc);          /* call 0x100720b1 */
            ii(0x1015_0dad, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_0db0, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1015_0db3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0db6, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_0db9, 5); calld(0x1007_68e0, -0xd_a4de);          /* call 0x100768e0 */
            ii(0x1015_0dbe, 5); calld(0x1014_3616, -0xd7ad);            /* call 0x10143616 */
            ii(0x1015_0dc3, 4); movsx(eax, memw_a32[ss, ebp - 0x12]);   /* movsx eax, word [ebp-0x12] */
            ii(0x1015_0dc7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_0dc9, 6); if(jzd(0x1015_0e48, 0x79)) goto l_0x1015_0e48; /* jz 0x10150e48 */
            ii(0x1015_0dcf, 4); movsx(eax, memw_a32[ss, ebp - 0x12]);   /* movsx eax, word [ebp-0x12] */
            ii(0x1015_0dd3, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1015_0dd6, 2); if(jled(0x1015_0dde, 0x6)) goto l_0x1015_0dde; /* jle 0x10150dde */
            ii(0x1015_0dd8, 6); mov(memw_a32[ss, ebp - 0x12], 0x1);     /* mov word [ebp-0x12], 0x1 */
        l_0x1015_0dde:
            ii(0x1015_0dde, 4); movsx(edx, memw_a32[ss, ebp - 0x12]);   /* movsx edx, word [ebp-0x12] */
            ii(0x1015_0de2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0de5, 5); calld(0x1015_01b7, -0xc33);             /* call 0x101501b7 */
            ii(0x1015_0dea, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_0ded, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_0def, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_0df1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_0df4, 2); neg(eax);                               /* neg eax */
            ii(0x1015_0df6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_0df9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0dfc, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_0dff, 5); calld(0x1007_68e0, -0xd_a524);          /* call 0x100768e0 */
            ii(0x1015_0e04, 5); calld(0x100d_7a9c, -0x7_936d);          /* call 0x100d7a9c */
        l_0x1015_0e09:
            ii(0x1015_0e09, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0e0c, 4); test(memb_a32[ds, eax + 0x15], 0x10);   /* test byte [eax+0x15], 0x10 */
            ii(0x1015_0e10, 2); if(jzd(0x1015_0e32, 0x20)) goto l_0x1015_0e32; /* jz 0x10150e32 */
            ii(0x1015_0e12, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0e15, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0e18, 5); calld(0x1007_6730, -0xd_a6ed);          /* call 0x10076730 */
            ii(0x1015_0e1d, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1015_0e20, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_0e23, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0e26, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1015_0e29, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_0e2e, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1015_0e30, 2); if(jnzd(0x1015_0e34, 0x2)) goto l_0x1015_0e34; /* jnz 0x10150e34 */
        l_0x1015_0e32:
            ii(0x1015_0e32, 2); jmpd(0x1015_0e41, 0xd); goto l_0x1015_0e41; /* jmp 0x10150e41 */
        l_0x1015_0e34:
            ii(0x1015_0e34, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_0e39, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0e3c, 5); calld(0x1015_01b7, -0xc8a);             /* call 0x101501b7 */
        l_0x1015_0e41:
            ii(0x1015_0e41, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0e44, 4); mov(memb_a32[ds, eax + 0x5a], 0);       /* mov byte [eax+0x5a], 0x0 */
        l_0x1015_0e48:
            ii(0x1015_0e48, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_0e4a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_0e4b, 1); popd(edi);                              /* pop edi */
            ii(0x1015_0e4c, 1); popd(esi);                              /* pop esi */
            ii(0x1015_0e4d, 1); popd(edx);                              /* pop edx */
            ii(0x1015_0e4e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_0e4f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_0e50, 1); retd();                                 /* ret */
        }
    }
}
