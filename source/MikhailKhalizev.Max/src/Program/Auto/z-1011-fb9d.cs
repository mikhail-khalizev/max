using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_fb9d-cb7464c1")]
        public void Method_1011_fb9d()
        {
            ii(0x1011_fb9d, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_fba2, 5); calld(Definitions.sys_check_available_stack_size, 0x4_61ab); /* call 0x10165d52 */
            ii(0x1011_fba7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_fba8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_fba9, 1); pushd(edx);                             /* push edx */
            ii(0x1011_fbaa, 1); pushd(esi);                             /* push esi */
            ii(0x1011_fbab, 1); pushd(edi);                             /* push edi */
            ii(0x1011_fbac, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_fbad, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_fbaf, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_fbb5, 6); mov(edx, memd_a32[ds, 0x101c_52e2]);    /* mov edx, [0x101c52e2] */
            ii(0x1011_fbbb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_fbbe, 1); inc(edx);                               /* inc edx */
            ii(0x1011_fbbf, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1011_fbc4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_fbc6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_fbc9, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1011_fbcb, 7); mov(memw_a32[ds, 0x101c_52e4], dx);     /* mov [0x101c52e4], dx */
            ii(0x1011_fbd2, 6); mov(ax, memw_a32[ds, 0x101c_52e4]);     /* mov ax, [0x101c52e4] */
            ii(0x1011_fbd8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_fbdb, 2); jmpd(0x1011_fc48, 0x6b); goto l_0x1011_fc48; /* jmp 0x1011fc48 */
        l_0x1011_fbdd:
            ii(0x1011_fbdd, 5); calld(0x100c_aa00, -0x5_51e2);          /* call 0x100caa00 */
            ii(0x1011_fbe2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_fbe7, 1); pushd(eax);                             /* push eax */
            ii(0x1011_fbe8, 5); calld(0x100c_aa20, -0x5_51cd);          /* call 0x100caa20 */
            ii(0x1011_fbed, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1011_fbef, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_fbf1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_fbf3, 5); mov(eax, StringDefinitions.NoPathDebugging); /* mov eax, 0x101a7e06 */
            ii(0x1011_fbf8, 5); calld(0x1011_5d23, -0x9eda);            /* call 0x10115d23 */
            ii(0x1011_fbfd, 5); jmpd(0x1011_fc72, 0x70); goto l_0x1011_fc72; /* jmp 0x1011fc72 */
        l_0x1011_fc02:
            ii(0x1011_fc02, 5); calld(0x100c_aa00, -0x5_5207);          /* call 0x100caa00 */
            ii(0x1011_fc07, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_fc0c, 1); pushd(eax);                             /* push eax */
            ii(0x1011_fc0d, 5); calld(0x100c_aa20, -0x5_51f2);          /* call 0x100caa20 */
            ii(0x1011_fc12, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1011_fc14, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_fc16, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_fc18, 5); mov(eax, StringDefinitions.ShowPathGeneratorStatistics); /* mov eax, 0x101a7e19 */
            ii(0x1011_fc1d, 5); calld(0x1011_5d23, -0x9eff);            /* call 0x10115d23 */
            ii(0x1011_fc22, 2); jmpd(0x1011_fc72, 0x4e); goto l_0x1011_fc72; /* jmp 0x1011fc72 */
        l_0x1011_fc24:
            ii(0x1011_fc24, 5); calld(0x100c_aa00, -0x5_5229);          /* call 0x100caa00 */
            ii(0x1011_fc29, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_fc2e, 1); pushd(eax);                             /* push eax */
            ii(0x1011_fc2f, 5); calld(0x100c_aa20, -0x5_5214);          /* call 0x100caa20 */
            ii(0x1011_fc34, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1011_fc36, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_fc38, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_fc3a, 5); mov(eax, StringDefinitions.DrawPathSearches); /* mov eax, 0x101a7e38 */
            ii(0x1011_fc3f, 5); calld(0x1011_5d23, -0x9f21);            /* call 0x10115d23 */
            ii(0x1011_fc44, 2); jmpd(0x1011_fc72, 0x2c); goto l_0x1011_fc72; /* jmp 0x1011fc72 */
        l_0x1011_fc46:
            ii(0x1011_fc46, 2); jmpd(0x1011_fc72, 0x2a); goto l_0x1011_fc72; /* jmp 0x1011fc72 */
        l_0x1011_fc48:
            ii(0x1011_fc48, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_fc4b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_fc4e, 5); cmp(memw_a32[ss, ebp - 0x8], 0x1);      /* cmp word [ebp-0x8], 0x1 */
            ii(0x1011_fc53, 2); if(jbd(0x1011_fc65, 0x10)) goto l_0x1011_fc65; /* jb 0x1011fc65 */
            ii(0x1011_fc55, 5); cmp(memw_a32[ss, ebp - 0x8], 0x1);      /* cmp word [ebp-0x8], 0x1 */
            ii(0x1011_fc5a, 2); if(jbed(0x1011_fc02, -0x5a)) goto l_0x1011_fc02; /* jbe 0x1011fc02 */
            ii(0x1011_fc5c, 5); cmp(memw_a32[ss, ebp - 0x8], 0x2);      /* cmp word [ebp-0x8], 0x2 */
            ii(0x1011_fc61, 2); if(jzd(0x1011_fc24, -0x3f)) goto l_0x1011_fc24; /* jz 0x1011fc24 */
            ii(0x1011_fc63, 2); jmpd(0x1011_fc46, -0x1f); goto l_0x1011_fc46; /* jmp 0x1011fc46 */
        l_0x1011_fc65:
            ii(0x1011_fc65, 5); cmp(memw_a32[ss, ebp - 0x8], 0);        /* cmp word [ebp-0x8], 0x0 */
            ii(0x1011_fc6a, 6); if(jzd(0x1011_fbdd, -0x93)) goto l_0x1011_fbdd; /* jz 0x1011fbdd */
            ii(0x1011_fc70, 2); jmpd(0x1011_fc46, -0x2c); goto l_0x1011_fc46; /* jmp 0x1011fc46 */
        l_0x1011_fc72:
            ii(0x1011_fc72, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_fc74, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_fc75, 1); popd(edi);                              /* pop edi */
            ii(0x1011_fc76, 1); popd(esi);                              /* pop esi */
            ii(0x1011_fc77, 1); popd(edx);                              /* pop edx */
            ii(0x1011_fc78, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_fc79, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_fc7a, 1); retd();                                 /* ret */
        }
    }
}
