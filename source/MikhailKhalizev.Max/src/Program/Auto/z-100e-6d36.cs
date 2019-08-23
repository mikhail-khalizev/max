using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_6d36-2b46fd4b")]
        public void Method_100e_6d36()
        {
            ii(0x100e_6d36, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100e_6d3b, 5); calld(Definitions.sys_check_available_stack_size, 0x7_f012); /* call 0x10165d52 */
            ii(0x100e_6d40, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_6d41, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_6d42, 1); pushd(edx);                             /* push edx */
            ii(0x100e_6d43, 1); pushd(esi);                             /* push esi */
            ii(0x100e_6d44, 1); pushd(edi);                             /* push edi */
            ii(0x100e_6d45, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_6d46, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_6d48, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_6d4e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_6d51, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100e_6d56, 5); calld(0x100e_883d, 0x1ae2);             /* call 0x100e883d */
            ii(0x100e_6d5b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_6d5e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6d61, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100e_6d64, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_6d67, 3); sub(eax, 0x20);                         /* sub eax, 0x20 */
            ii(0x100e_6d6a, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100e_6d6d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_6d6f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_6d71, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_6d74, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_6d7a, 6); mov(edx, memd_a32[ds, 0x101c_38fa]);    /* mov edx, [0x101c38fa] */
            ii(0x100e_6d80, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_6d83, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_6d85, 1); inc(eax);                               /* inc eax */
            ii(0x100e_6d86, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_6d89, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_6d8c, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x100e_6d8f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_6d92, 3); sub(eax, 0x20);                         /* sub eax, 0x20 */
            ii(0x100e_6d95, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100e_6d98, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_6d9a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_6d9c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_6d9f, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_6da5, 6); mov(edx, memd_a32[ds, 0x101c_38fc]);    /* mov edx, [0x101c38fc] */
            ii(0x100e_6dab, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_6dae, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_6db0, 1); inc(eax);                               /* inc eax */
            ii(0x100e_6db1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_6db4, 6); mov(ax, memw_a32[ds, 0x101c_38c0]);     /* mov ax, [0x101c38c0] */
            ii(0x100e_6dba, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100e_6dbd, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_6dc0, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100e_6dc4, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100e_6dc8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_6dca, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_6dcc, 2); if(jld(0x100e_6ddc, 0xe)) goto l_0x100e_6ddc; /* jl 0x100e6ddc */
            ii(0x100e_6dce, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100e_6dd2, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100e_6dd6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_6dd8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_6dda, 2); if(jged(0x100e_6dde, 0x2)) goto l_0x100e_6dde; /* jge 0x100e6dde */
        l_0x100e_6ddc:
            ii(0x100e_6ddc, 2); jmpd(0x100e_6dea, 0xc); goto l_0x100e_6dea; /* jmp 0x100e6dea */
        l_0x100e_6dde:
            ii(0x100e_6dde, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_6de1, 7); cmp(ax, memw_a32[ds, 0x101b_8748]);     /* cmp ax, [0x101b8748] */
            ii(0x100e_6de8, 2); if(jld(0x100e_6dec, 0x2)) goto l_0x100e_6dec; /* jl 0x100e6dec */
        l_0x100e_6dea:
            ii(0x100e_6dea, 2); jmpd(0x100e_6df8, 0xc); goto l_0x100e_6df8; /* jmp 0x100e6df8 */
        l_0x100e_6dec:
            ii(0x100e_6dec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_6def, 7); cmp(ax, memw_a32[ds, 0x101b_874a]);     /* cmp ax, [0x101b874a] */
            ii(0x100e_6df6, 2); if(jld(0x100e_6dfa, 0x2)) goto l_0x100e_6dfa; /* jl 0x100e6dfa */
        l_0x100e_6df8:
            ii(0x100e_6df8, 2); jmpd(0x100e_6e25, 0x2b); goto l_0x100e_6e25; /* jmp 0x100e6e25 */
        l_0x100e_6dfa:
            ii(0x100e_6dfa, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x100e_6dff, 1); pushd(eax);                             /* push eax */
            ii(0x100e_6e00, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_6e03, 3); pushd(memd_a32[ds, eax + 0x16]);        /* push dword [eax+0x16] */
            ii(0x100e_6e06, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_6e09, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100e_6e0c, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_6e0f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_6e12, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100e_6e15, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_6e18, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100e_6e1c, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100e_6e20, 5); calld(0x100e_67a1, -0x684);             /* call 0x100e67a1 */
        l_0x100e_6e25:
            ii(0x100e_6e25, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_6e27, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_6e28, 1); popd(edi);                              /* pop edi */
            ii(0x100e_6e29, 1); popd(esi);                              /* pop esi */
            ii(0x100e_6e2a, 1); popd(edx);                              /* pop edx */
            ii(0x100e_6e2b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_6e2c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_6e2d, 1); retd();                                 /* ret */
        }
    }
}
