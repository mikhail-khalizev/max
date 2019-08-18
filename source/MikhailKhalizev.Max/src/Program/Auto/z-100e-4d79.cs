using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_4d79-c3a4c207")]
        public void Method_100e_4d79()
        {
            ii(0x100e_4d79, 5); pushd(0x68);                            /* push 0x68 */
            ii(0x100e_4d7e, 5); calld(Definitions.sys_check_available_stack_size, 0x8_0fcf); /* call 0x10165d52 */
            ii(0x100e_4d83, 1); pushd(esi);                             /* push esi */
            ii(0x100e_4d84, 1); pushd(edi);                             /* push edi */
            ii(0x100e_4d85, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_4d86, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_4d88, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x100e_4d8e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_4d91, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100e_4d94, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100e_4d97, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100e_4d9a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_4d9e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_4da0, 6); if(jnzd(0x100e_4e41, 0x9b)) goto l_0x100e_4e41; /* jnz 0x100e4e41 */
            ii(0x100e_4da6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_4da9, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_4dac, 2); jmpd(0x100e_4e12, 0x64); goto l_0x100e_4e12; /* jmp 0x100e4e12 */
        l_0x100e_4dae:
            ii(0x100e_4dae, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4db1, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100e_4db4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4db7, 3); mov(memd_a32[ds, eax + 0xc], edx);      /* mov [eax+0xc], edx */
            ii(0x100e_4dba, 5); jmpd(0x100e_4e3c, 0x7d); goto l_0x100e_4e3c; /* jmp 0x100e4e3c */
        l_0x100e_4dbf:
            ii(0x100e_4dbf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4dc2, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x100e_4dc5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4dc8, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x100e_4dcb, 5); jmpd(0x100e_4e3c, 0x6c); goto l_0x100e_4e3c; /* jmp 0x100e4e3c */
        l_0x100e_4dd0:
            ii(0x100e_4dd0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4dd3, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x100e_4dd6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_4dd9, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4dda, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4ddd, 3); mov(ecx, memd_a32[ds, eax + 0x6]);      /* mov ecx, [eax+0x6] */
            ii(0x100e_4de0, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100e_4de3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4de6, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100e_4de9, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_4dec, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4def, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100e_4df2, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_4df5, 5); calld(0x1008_b148, -0x5_9cb2);          /* call 0x1008b148 */
            ii(0x100e_4dfa, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4dfd, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x100e_4e00, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4e03, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x100e_4e06, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100e_4e09, 5); calld(0x100e_4f96, 0x188);              /* call 0x100e4f96 */
            ii(0x100e_4e0e, 2); jmpd(0x100e_4e3c, 0x2c); goto l_0x100e_4e3c; /* jmp 0x100e4e3c */
        l_0x100e_4e10:
            ii(0x100e_4e10, 2); jmpd(0x100e_4e3c, 0x2a); goto l_0x100e_4e3c; /* jmp 0x100e4e3c */
        l_0x100e_4e12:
            ii(0x100e_4e12, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_4e15, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_4e18, 5); cmp(memw_a32[ss, ebp - 0x28], 0x2);     /* cmp word [ebp-0x28], 0x2 */
            ii(0x100e_4e1d, 2); if(jbd(0x100e_4e2f, 0x10)) goto l_0x100e_4e2f; /* jb 0x100e4e2f */
            ii(0x100e_4e1f, 5); cmp(memw_a32[ss, ebp - 0x28], 0x2);     /* cmp word [ebp-0x28], 0x2 */
            ii(0x100e_4e24, 2); if(jbed(0x100e_4dbf, -0x67)) goto l_0x100e_4dbf; /* jbe 0x100e4dbf */
            ii(0x100e_4e26, 5); cmp(memw_a32[ss, ebp - 0x28], 0x3);     /* cmp word [ebp-0x28], 0x3 */
            ii(0x100e_4e2b, 2); if(jzd(0x100e_4dd0, -0x5d)) goto l_0x100e_4dd0; /* jz 0x100e4dd0 */
            ii(0x100e_4e2d, 2); jmpd(0x100e_4e10, -0x1f); goto l_0x100e_4e10; /* jmp 0x100e4e10 */
        l_0x100e_4e2f:
            ii(0x100e_4e2f, 5); cmp(memw_a32[ss, ebp - 0x28], 0x1);     /* cmp word [ebp-0x28], 0x1 */
            ii(0x100e_4e34, 6); if(jzd(0x100e_4dae, -0x8c)) goto l_0x100e_4dae; /* jz 0x100e4dae */
            ii(0x100e_4e3a, 2); jmpd(0x100e_4e10, -0x2c); goto l_0x100e_4e10; /* jmp 0x100e4e10 */
        l_0x100e_4e3c:
            ii(0x100e_4e3c, 5); jmpd(0x100e_4f90, 0x14f); goto l_0x100e_4f90; /* jmp 0x100e4f90 */
        l_0x100e_4e41:
            ii(0x100e_4e41, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_4e45, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_4e48, 6); if(jnzd(0x100e_4edc, 0x8e)) goto l_0x100e_4edc; /* jnz 0x100e4edc */
            ii(0x100e_4e4e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_4e52, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_4e54, 2); if(jnzd(0x100e_4e63, 0xd)) goto l_0x100e_4e63; /* jnz 0x100e4e63 */
            ii(0x100e_4e56, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4e59, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_4e5b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4e5e, 3); mov(memd_a32[ds, eax + 0x8], edx);      /* mov [eax+0x8], edx */
            ii(0x100e_4e61, 2); jmpd(0x100e_4ed7, 0x74); goto l_0x100e_4ed7; /* jmp 0x100e4ed7 */
        l_0x100e_4e63:
            ii(0x100e_4e63, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_4e67, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_4e6a, 2); if(jnzd(0x100e_4e75, 0x9)) goto l_0x100e_4e75; /* jnz 0x100e4e75 */
            ii(0x100e_4e6c, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100e_4e73, 2); jmpd(0x100e_4e8e, 0x19); goto l_0x100e_4e8e; /* jmp 0x100e4e8e */
        l_0x100e_4e75:
            ii(0x100e_4e75, 5); mov(ecx, 0x57);                         /* mov ecx, 0x57 */
            ii(0x100e_4e7a, 5); mov(ebx, StringDefinitions.DrawmapCpp4); /* mov ebx, 0x101a1d34 */
            ii(0x100e_4e7f, 5); mov(edx, StringDefinitions.VerticalSideEqualSideIsLower); /* mov edx, 0x101a1d40 */
            ii(0x100e_4e84, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_4e86, 5); calld(Definitions.sys_assert, 0x8_0f07); /* call 0x10165d92 */
            ii(0x100e_4e8b, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x100e_4e8e:
            ii(0x100e_4e8e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4e91, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x100e_4e94, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_4e97, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4e98, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4e9b, 3); mov(ecx, memd_a32[ds, eax + 0x6]);      /* mov ecx, [eax+0x6] */
            ii(0x100e_4e9e, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100e_4ea1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4ea4, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100e_4ea7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_4eaa, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4ead, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100e_4eb0, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100e_4eb3, 5); calld(0x1008_b148, -0x5_9d70);          /* call 0x1008b148 */
            ii(0x100e_4eb8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4ebb, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100e_4ebe, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4ec1, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x100e_4ec4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4ec7, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100e_4ec9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4ecc, 3); mov(memd_a32[ds, eax + 0x8], edx);      /* mov [eax+0x8], edx */
            ii(0x100e_4ecf, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100e_4ed2, 5); calld(0x100e_4f96, 0xbf);               /* call 0x100e4f96 */
        l_0x100e_4ed7:
            ii(0x100e_4ed7, 5); jmpd(0x100e_4f90, 0xb4); goto l_0x100e_4f90; /* jmp 0x100e4f90 */
        l_0x100e_4edc:
            ii(0x100e_4edc, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_4ee0, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100e_4ee3, 2); if(jnzd(0x100e_4eee, 0x9)) goto l_0x100e_4eee; /* jnz 0x100e4eee */
            ii(0x100e_4ee5, 7); mov(memd_a32[ss, ebp - 0x40], 0);       /* mov dword [ebp-0x40], 0x0 */
            ii(0x100e_4eec, 2); jmpd(0x100e_4f07, 0x19); goto l_0x100e_4f07; /* jmp 0x100e4f07 */
        l_0x100e_4eee:
            ii(0x100e_4eee, 5); mov(ecx, 0x5f);                         /* mov ecx, 0x5f */
            ii(0x100e_4ef3, 5); mov(ebx, StringDefinitions.DrawmapCpp6); /* mov ebx, 0x101a1d5f */
            ii(0x100e_4ef8, 5); mov(edx, StringDefinitions.HorizontalSideEqualSideIsHigher); /* mov edx, 0x101a1d6b */
            ii(0x100e_4efd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_4eff, 5); calld(Definitions.sys_assert, 0x8_0e8e); /* call 0x10165d92 */
            ii(0x100e_4f04, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x100e_4f07:
            ii(0x100e_4f07, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_4f0b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_4f0d, 2); if(jnzd(0x100e_4f1c, 0xd)) goto l_0x100e_4f1c; /* jnz 0x100e4f1c */
            ii(0x100e_4f0f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4f12, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100e_4f15, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4f18, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x100e_4f1a, 2); jmpd(0x100e_4f90, 0x74); goto l_0x100e_4f90; /* jmp 0x100e4f90 */
        l_0x100e_4f1c:
            ii(0x100e_4f1c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_4f20, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_4f23, 2); if(jnzd(0x100e_4f2e, 0x9)) goto l_0x100e_4f2e; /* jnz 0x100e4f2e */
            ii(0x100e_4f25, 7); mov(memd_a32[ss, ebp - 0x44], 0);       /* mov dword [ebp-0x44], 0x0 */
            ii(0x100e_4f2c, 2); jmpd(0x100e_4f47, 0x19); goto l_0x100e_4f47; /* jmp 0x100e4f47 */
        l_0x100e_4f2e:
            ii(0x100e_4f2e, 5); mov(ecx, 0x64);                         /* mov ecx, 0x64 */
            ii(0x100e_4f33, 5); mov(ebx, StringDefinitions.DrawmapCpp5); /* mov ebx, 0x101a1d8d */
            ii(0x100e_4f38, 5); mov(edx, StringDefinitions.VerticalSideEqualSideIsLower2); /* mov edx, 0x101a1d99 */
            ii(0x100e_4f3d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_4f3f, 5); calld(Definitions.sys_assert, 0x8_0e4e); /* call 0x10165d92 */
            ii(0x100e_4f44, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        l_0x100e_4f47:
            ii(0x100e_4f47, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4f4a, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x100e_4f4d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_4f50, 1); pushd(eax);                             /* push eax */
            ii(0x100e_4f51, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4f54, 3); mov(ecx, memd_a32[ds, eax + 0x6]);      /* mov ecx, [eax+0x6] */
            ii(0x100e_4f57, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100e_4f5a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4f5d, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100e_4f60, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_4f63, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4f66, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100e_4f69, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100e_4f6c, 5); calld(0x1008_b148, -0x5_9e29);          /* call 0x1008b148 */
            ii(0x100e_4f71, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4f74, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100e_4f77, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4f7a, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x100e_4f7d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4f80, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100e_4f83, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4f86, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x100e_4f88, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100e_4f8b, 5); calld(0x100e_4f96, 0x6);                /* call 0x100e4f96 */
        l_0x100e_4f90:
            ii(0x100e_4f90, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_4f92, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_4f93, 1); popd(edi);                              /* pop edi */
            ii(0x100e_4f94, 1); popd(esi);                              /* pop esi */
            ii(0x100e_4f95, 1); retd(); return;                         /* ret */
        }
    }
}
