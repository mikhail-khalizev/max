using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_8d35-4ad9e62a")]
        public void Method_100d_8d35()
        {
            ii(0x100d_8d35, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100d_8d3a, 5); calld(Definitions.sys_check_available_stack_size, 0x8_d013); /* call 0x10165d52 */
            ii(0x100d_8d3f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_8d40, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_8d41, 1); pushd(esi);                             /* push esi */
            ii(0x100d_8d42, 1); pushd(edi);                             /* push edi */
            ii(0x100d_8d43, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_8d44, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_8d46, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100d_8d4c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_8d4f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_8d52, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_8d56, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100d_8d59, 6); mov(eax, memd_a32[ds, eax + 0x101c_81c0]); /* mov eax, [eax+0x101c81c0] */
            ii(0x100d_8d5f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_8d62, 7); test(memd_a32[ss, ebp - 0x10], 0x4000); /* test dword [ebp-0x10], 0x4000 */
            ii(0x100d_8d69, 2); if(jzd(0x100d_8d78, 0xd)) goto l_0x100d_8d78; /* jz 0x100d8d78 */
            ii(0x100d_8d6b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_8d6f, 5); calld(0x100c_dec2, -0xaeb2);            /* call 0x100cdec2 */
            ii(0x100d_8d74, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_8d76, 2); if(jnzd(0x100d_8d7d, 0x5)) goto l_0x100d_8d7d; /* jnz 0x100d8d7d */
        l_0x100d_8d78:
            ii(0x100d_8d78, 5); jmpd(0x100d_8df6, 0x79); goto l_0x100d_8df6; /* jmp 0x100d8df6 */
        l_0x100d_8d7d:
            ii(0x100d_8d7d, 7); test(memd_a32[ss, ebp - 0x10], 0x100);  /* test dword [ebp-0x10], 0x100 */
            ii(0x100d_8d84, 2); if(jzd(0x100d_8d8f, 0x9)) goto l_0x100d_8d8f; /* jz 0x100d8d8f */
            ii(0x100d_8d86, 7); cmp(memb_a32[ds, 0x101b_7ecc], 0);      /* cmp byte [0x101b7ecc], 0x0 */
            ii(0x100d_8d8d, 2); if(jnzd(0x100d_8da3, 0x14)) goto l_0x100d_8da3; /* jnz 0x100d8da3 */
        l_0x100d_8d8f:
            ii(0x100d_8d8f, 7); test(memd_a32[ss, ebp - 0x10], 0x40);   /* test dword [ebp-0x10], 0x40 */
            ii(0x100d_8d96, 2); if(jzd(0x100d_8da1, 0x9)) goto l_0x100d_8da1; /* jz 0x100d8da1 */
            ii(0x100d_8d98, 7); cmp(memb_a32[ds, 0x101b_7ecd], 0);      /* cmp byte [0x101b7ecd], 0x0 */
            ii(0x100d_8d9f, 2); if(jnzd(0x100d_8da3, 0x2)) goto l_0x100d_8da3; /* jnz 0x100d8da3 */
        l_0x100d_8da1:
            ii(0x100d_8da1, 2); jmpd(0x100d_8da5, 0x2); goto l_0x100d_8da5; /* jmp 0x100d8da5 */
        l_0x100d_8da3:
            ii(0x100d_8da3, 2); jmpd(0x100d_8db9, 0x14); goto l_0x100d_8db9; /* jmp 0x100d8db9 */
        l_0x100d_8da5:
            ii(0x100d_8da5, 7); test(memd_a32[ss, ebp - 0x10], 0x80);   /* test dword [ebp-0x10], 0x80 */
            ii(0x100d_8dac, 2); if(jzd(0x100d_8db7, 0x9)) goto l_0x100d_8db7; /* jz 0x100d8db7 */
            ii(0x100d_8dae, 7); cmp(memb_a32[ds, 0x101b_7ece], 0);      /* cmp byte [0x101b7ece], 0x0 */
            ii(0x100d_8db5, 2); if(jnzd(0x100d_8db9, 0x2)) goto l_0x100d_8db9; /* jnz 0x100d8db9 */
        l_0x100d_8db7:
            ii(0x100d_8db7, 2); jmpd(0x100d_8dbb, 0x2); goto l_0x100d_8dbb; /* jmp 0x100d8dbb */
        l_0x100d_8db9:
            ii(0x100d_8db9, 2); jmpd(0x100d_8dcf, 0x14); goto l_0x100d_8dcf; /* jmp 0x100d8dcf */
        l_0x100d_8dbb:
            ii(0x100d_8dbb, 7); test(memd_a32[ss, ebp - 0x10], 0x200);  /* test dword [ebp-0x10], 0x200 */
            ii(0x100d_8dc2, 2); if(jzd(0x100d_8dcd, 0x9)) goto l_0x100d_8dcd; /* jz 0x100d8dcd */
            ii(0x100d_8dc4, 7); cmp(memb_a32[ds, 0x101b_7ecf], 0);      /* cmp byte [0x101b7ecf], 0x0 */
            ii(0x100d_8dcb, 2); if(jnzd(0x100d_8dcf, 0x2)) goto l_0x100d_8dcf; /* jnz 0x100d8dcf */
        l_0x100d_8dcd:
            ii(0x100d_8dcd, 2); jmpd(0x100d_8df6, 0x27); goto l_0x100d_8df6; /* jmp 0x100d8df6 */
        l_0x100d_8dcf:
            ii(0x100d_8dcf, 7); cmp(memb_a32[ds, 0x101c_3604], 0);      /* cmp byte [0x101c3604], 0x0 */
            ii(0x100d_8dd6, 2); if(jzd(0x100d_8df0, 0x18)) goto l_0x100d_8df0; /* jz 0x100d8df0 */
            ii(0x100d_8dd8, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100d_8ddc, 5); mov(eax, memd_a32[ds, 0x101c_a562]);    /* mov eax, [0x101ca562] */
            ii(0x100d_8de1, 5); calld(0x100c_b6b0, -0xd736);            /* call 0x100cb6b0 */
            ii(0x100d_8de6, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100d_8de9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_8dec, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_8dee, 2); if(jled(0x100d_8df6, 0x6)) goto l_0x100d_8df6; /* jle 0x100d8df6 */
        l_0x100d_8df0:
            ii(0x100d_8df0, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_8df4, 2); jmpd(0x100d_8dfa, 0x4); goto l_0x100d_8dfa; /* jmp 0x100d8dfa */
        l_0x100d_8df6:
            ii(0x100d_8df6, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x100d_8dfa:
            ii(0x100d_8dfa, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100d_8dfd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_8dff, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_8e00, 1); popd(edi);                              /* pop edi */
            ii(0x100d_8e01, 1); popd(esi);                              /* pop esi */
            ii(0x100d_8e02, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_8e03, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_8e04, 1); retd(); return;                         /* ret */
        }
    }
}
