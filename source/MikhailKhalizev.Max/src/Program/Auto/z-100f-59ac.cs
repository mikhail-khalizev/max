using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2902a548-8b23-4f6e-ba86-c508d44b4e85")]
        public void Method_100f_59ac()
        {
            ii(0x100f_59ac, 5); pushd(0x5c);                            /* push 0x5c */
            ii(0x100f_59b1, 5); calld(Definitions.sys_check_available_stack_size, 0x7_039c); /* call 0x10165d52 */
            ii(0x100f_59b6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_59b7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_59b8, 1); pushd(edx);                             /* push edx */
            ii(0x100f_59b9, 1); pushd(esi);                             /* push esi */
            ii(0x100f_59ba, 1); pushd(edi);                             /* push edi */
            ii(0x100f_59bb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_59bc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_59be, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x100f_59c4, 7); mov(memd_a32[ss, ebp - 0x8], 0x5);      /* mov dword [ebp-0x8], 0x5 */
        l_0x100f_59cb:
            ii(0x100f_59cb, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x100f_59ce, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x100f_59d3, 2); if(jzd(0x100f_59f0, 0x1b)) goto l_0x100f_59f0; /* jz 0x100f59f0 */
            ii(0x100f_59d5, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_59d9, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_59dc, 6); mov(edx, memd_a32[ds, edx + 0x101b_8ac4]); /* mov edx, [edx+0x101b8ac4] */
            ii(0x100f_59e2, 5); mov(eax, 0x101c_39b4);                  /* mov eax, 0x101c39b4 */
            ii(0x100f_59e7, 5); calld(0x1010_2aec, 0xd100);             /* call 0x10102aec */
            ii(0x100f_59ec, 2); test(al, al);                           /* test al, al */
            ii(0x100f_59ee, 2); if(jzd(0x100f_59cb, -0x25)) goto l_0x100f_59cb; /* jz 0x100f59cb */
        l_0x100f_59f0:
            ii(0x100f_59f0, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_59f4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_59f6, 6); if(jld_func(0x100f_618f, 0x793)) return; /* jl 0x100f618f */
            ii(0x100f_59fc, 5); mov(al, memb_a32[ds, 0x101c_5624]);     /* mov al, [0x101c5624] */
            ii(0x100f_5a01, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_5a04, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100f_5a08, 2); if(jnzd(0x100f_5a5a, 0x50)) goto l_0x100f_5a5a; /* jnz 0x100f5a5a */
            ii(0x100f_5a0a, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100f_5a11, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100f_5a18, 2); jmpd(0x100f_5a20, 0x6); goto l_0x100f_5a20; /* jmp 0x100f5a20 */
        l_0x100f_5a1a:
            ii(0x100f_5a1a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_5a1d, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100f_5a20:
            ii(0x100f_5a20, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100f_5a24, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_5a27, 2); if(jged(0x100f_5a5a, 0x31)) goto l_0x100f_5a5a; /* jge 0x100f5a5a */
            ii(0x100f_5a29, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100f_5a2d, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_5a33, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_5a39, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_5a3e, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_5a41, 2); if(jnzd(0x100f_5a52, 0xf)) goto l_0x100f_5a52; /* jnz 0x100f5a52 */
            ii(0x100f_5a43, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100f_5a47, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_5a49, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_5a4e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5a50, 2); if(jnzd(0x100f_5a54, 0x2)) goto l_0x100f_5a54; /* jnz 0x100f5a54 */
        l_0x100f_5a52:
            ii(0x100f_5a52, 2); jmpd(0x100f_5a58, 0x4); goto l_0x100f_5a58; /* jmp 0x100f5a58 */
        l_0x100f_5a54:
            ii(0x100f_5a54, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
        l_0x100f_5a58:
            ii(0x100f_5a58, 2); jmpd(0x100f_5a1a, -0x40); goto l_0x100f_5a1a; /* jmp 0x100f5a1a */
        l_0x100f_5a5a:
            ii(0x100f_5a5a, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100f_5a5e, 6); if(jzd(0x100f_5ad8, 0x74)) goto l_0x100f_5ad8; /* jz 0x100f5ad8 */
            ii(0x100f_5a64, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_5a6b, 2); if(jzd(0x100f_5a78, 0xb)) goto l_0x100f_5a78; /* jz 0x100f5a78 */
            ii(0x100f_5a6d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_5a6f, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100f_5a74, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_5a76, 2); if(jnzd(0x100f_5a7a, 0x2)) goto l_0x100f_5a7a; /* jnz 0x100f5a7a */
        l_0x100f_5a78:
            ii(0x100f_5a78, 2); jmpd(0x100f_5a9f, 0x25); goto l_0x100f_5a9f; /* jmp 0x100f5a9f */
        l_0x100f_5a7a:
            ii(0x100f_5a7a, 5); calld(0x100c_aa00, -0x2_b07f);          /* call 0x100caa00 */
            ii(0x100f_5a7f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_5a84, 1); pushd(eax);                             /* push eax */
            ii(0x100f_5a85, 5); calld(0x100c_aa20, -0x2_b06a);          /* call 0x100caa20 */
            ii(0x100f_5a8a, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_5a8c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_5a8e, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100f_5a93, 5); mov(eax, StringDefinitions.Cheater);    /* mov eax, 0x101a25b4 */
            ii(0x100f_5a98, 5); calld(0x1011_5d23, 0x2_0286);           /* call 0x10115d23 */
            ii(0x100f_5a9d, 2); jmpd(0x100f_5ad3, 0x34); goto l_0x100f_5ad3; /* jmp 0x100f5ad3 */
        l_0x100f_5a9f:
            ii(0x100f_5a9f, 5); calld(0x100c_aa00, -0x2_b0a4);          /* call 0x100caa00 */
            ii(0x100f_5aa4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_5aa9, 1); pushd(eax);                             /* push eax */
            ii(0x100f_5aaa, 5); calld(0x100c_aa20, -0x2_b08f);          /* call 0x100caa20 */
            ii(0x100f_5aaf, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_5ab1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_5ab3, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100f_5ab8, 5); mov(eax, StringDefinitions.CheaterPrepareToPayThePrice); /* mov eax, 0x101a25bd */
            ii(0x100f_5abd, 5); calld(0x1011_5d23, 0x2_0261);           /* call 0x10115d23 */
            ii(0x100f_5ac2, 7); mov(memb_a32[ds, 0x101c_39b0], 0x1);    /* mov byte [0x101c39b0], 0x1 */
            ii(0x100f_5ac9, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_5ace, 5); mov(memb_a32[ds, 0x101c_39b1], al);     /* mov [0x101c39b1], al */
        l_0x100f_5ad3:
            ii(0x100f_5ad3, 5); if(jmpd_func(0x100f_618f, 0x6b7)) return; /* jmp 0x100f618f */
        l_0x100f_5ad8:
            ii(0x100f_5ad8, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100f_5add, 5); calld(0x1007_6338, -0x7_f7aa);          /* call 0x10076338 */
            ii(0x100f_5ae2, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100f_5ae5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5ae7, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_5ae9, 5); calld(0x1007_64b8, -0x7_f636);          /* call 0x100764b8 */
            ii(0x100f_5aee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_5af1, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_5af4, 5); if(jmpd_func(0x100f_6168, 0x66f)) return; /* jmp 0x100f6168 */
        }
    }
}
