using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_59ac-9cb2a7d8")]
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
            ii(0x100f_59f6, 6); if(jld(0x100f_618f, 0x793)) goto l_0x100f_618f; /* jl 0x100f618f */
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
            ii(0x100f_5ad3, 5); jmpd(0x100f_618f, 0x6b7); goto l_0x100f_618f; /* jmp 0x100f618f */
        l_0x100f_5ad8:
            ii(0x100f_5ad8, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100f_5add, 5); calld(0x1007_6338, -0x7_f7aa);          /* call 0x10076338 */
            ii(0x100f_5ae2, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100f_5ae5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5ae7, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_5ae9, 5); calld(0x1007_64b8, -0x7_f636);          /* call 0x100764b8 */
            ii(0x100f_5aee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_5af1, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_5af4, 5); jmpd(0x100f_6168, 0x66f); goto l_0x100f_6168; /* jmp 0x100f6168 */
        l_0x100f_5af9:
            ii(0x100f_5af9, 7); cmp(memb_a32[ds, 0x101c_3980], 0);      /* cmp byte [0x101c3980], 0x0 */
            ii(0x100f_5b00, 2); if(jnzd(0x100f_5b08, 0x6)) goto l_0x100f_5b08; /* jnz 0x100f5b08 */
            ii(0x100f_5b02, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x100f_5b06, 2); jmpd(0x100f_5b0c, 0x4); goto l_0x100f_5b0c; /* jmp 0x100f5b0c */
        l_0x100f_5b08:
            ii(0x100f_5b08, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
        l_0x100f_5b0c:
            ii(0x100f_5b0c, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x100f_5b0f, 5); mov(memb_a32[ds, 0x101c_3980], al);     /* mov [0x101c3980], al */
            ii(0x100f_5b14, 5); calld(0x100f_f5c1, 0x9aa8);             /* call 0x100ff5c1 */
            ii(0x100f_5b19, 5); jmpd(0x100f_6185, 0x667); goto l_0x100f_6185; /* jmp 0x100f6185 */
        l_0x100f_5b1e:
            ii(0x100f_5b1e, 7); xor(memb_a32[ds, 0x101c_3910], 0x1);    /* xor byte [0x101c3910], 0x1 */
            ii(0x100f_5b25, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_5b2a, 5); calld(0x100f_a7e8, 0x4cb9);             /* call 0x100fa7e8 */
            ii(0x100f_5b2f, 5); jmpd(0x100f_6185, 0x651); goto l_0x100f_6185; /* jmp 0x100f6185 */
        l_0x100f_5b34:
            ii(0x100f_5b34, 2); jmpd(0x100f_5b3e, 0x8); goto l_0x100f_5b3e; /* jmp 0x100f5b3e */
        l_0x100f_5b36:
            ii(0x100f_5b36, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5b39, 5); calld(0x1007_6bf8, -0x7_ef46);          /* call 0x10076bf8 */
        l_0x100f_5b3e:
            ii(0x100f_5b3e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5b40, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5b43, 5); calld(0x1013_ad71, 0x4_5229);           /* call 0x1013ad71 */
            ii(0x100f_5b48, 2); test(al, al);                           /* test al, al */
            ii(0x100f_5b4a, 6); if(jzd(0x100f_5bc4, 0x74)) goto l_0x100f_5bc4; /* jz 0x100f5bc4 */
            ii(0x100f_5b50, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5b53, 5); calld(0x1007_63a0, -0x7_f7b8);          /* call 0x100763a0 */
            ii(0x100f_5b58, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5b5a, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100f_5b5d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_5b5f, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_5b64, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5b66, 2); if(jnzd(0x100f_5b82, 0x1a)) goto l_0x100f_5b82; /* jnz 0x100f5b82 */
            ii(0x100f_5b68, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5b6b, 5); calld(0x1007_63a0, -0x7_f7d0);          /* call 0x100763a0 */
            ii(0x100f_5b70, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100f_5b73, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_5b76, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_5b79, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x1); /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x100f_5b80, 2); if(jged(0x100f_5b84, 0x2)) goto l_0x100f_5b84; /* jge 0x100f5b84 */
        l_0x100f_5b82:
            ii(0x100f_5b82, 2); jmpd(0x100f_5b9e, 0x1a); goto l_0x100f_5b9e; /* jmp 0x100f5b9e */
        l_0x100f_5b84:
            ii(0x100f_5b84, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5b87, 5); calld(0x1007_63a0, -0x7_f7ec);          /* call 0x100763a0 */
            ii(0x100f_5b8c, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100f_5b8f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_5b92, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_5b95, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x3); /* cmp byte [eax+0x101c81d5], 0x3 */
            ii(0x100f_5b9c, 2); if(jled(0x100f_5ba0, 0x2)) goto l_0x100f_5ba0; /* jle 0x100f5ba0 */
        l_0x100f_5b9e:
            ii(0x100f_5b9e, 2); jmpd(0x100f_5bbf, 0x1f); goto l_0x100f_5bbf; /* jmp 0x100f5bbf */
        l_0x100f_5ba0:
            ii(0x100f_5ba0, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5ba3, 5); calld(0x1007_63a0, -0x7_f808);          /* call 0x100763a0 */
            ii(0x100f_5ba8, 5); calld(0x1007_623c, -0x7_f971);          /* call 0x1007623c */
            ii(0x100f_5bad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5baf, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5bb2, 5); calld(0x1007_63a0, -0x7_f817);          /* call 0x100763a0 */
            ii(0x100f_5bb7, 4); mov(dx, memw_a32[ds, edx + 0x19]);      /* mov dx, [edx+0x19] */
            ii(0x100f_5bbb, 4); mov(memw_a32[ds, eax + 0x52], dx);      /* mov [eax+0x52], dx */
        l_0x100f_5bbf:
            ii(0x100f_5bbf, 5); jmpd(0x100f_5b36, -0x8e); goto l_0x100f_5b36; /* jmp 0x100f5b36 */
        l_0x100f_5bc4:
            ii(0x100f_5bc4, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100f_5bc9, 5); calld(0x1007_6338, -0x7_f896);          /* call 0x10076338 */
            ii(0x100f_5bce, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100f_5bd1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5bd3, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_5bd5, 5); calld(0x1007_643c, -0x7_f79e);          /* call 0x1007643c */
            ii(0x100f_5bda, 2); jmpd(0x100f_5be4, 0x8); goto l_0x100f_5be4; /* jmp 0x100f5be4 */
        l_0x100f_5bdc:
            ii(0x100f_5bdc, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5bdf, 5); calld(0x1007_6bf8, -0x7_efec);          /* call 0x10076bf8 */
        l_0x100f_5be4:
            ii(0x100f_5be4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5be6, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5be9, 5); calld(0x1013_ad71, 0x4_5183);           /* call 0x1013ad71 */
            ii(0x100f_5bee, 2); test(al, al);                           /* test al, al */
            ii(0x100f_5bf0, 6); if(jzd(0x100f_5c6a, 0x74)) goto l_0x100f_5c6a; /* jz 0x100f5c6a */
            ii(0x100f_5bf6, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5bf9, 5); calld(0x1007_63a0, -0x7_f85e);          /* call 0x100763a0 */
            ii(0x100f_5bfe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5c00, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100f_5c03, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_5c05, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_5c0a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5c0c, 2); if(jnzd(0x100f_5c28, 0x1a)) goto l_0x100f_5c28; /* jnz 0x100f5c28 */
            ii(0x100f_5c0e, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5c11, 5); calld(0x1007_63a0, -0x7_f876);          /* call 0x100763a0 */
            ii(0x100f_5c16, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100f_5c19, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_5c1c, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_5c1f, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x1); /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x100f_5c26, 2); if(jged(0x100f_5c2a, 0x2)) goto l_0x100f_5c2a; /* jge 0x100f5c2a */
        l_0x100f_5c28:
            ii(0x100f_5c28, 2); jmpd(0x100f_5c44, 0x1a); goto l_0x100f_5c44; /* jmp 0x100f5c44 */
        l_0x100f_5c2a:
            ii(0x100f_5c2a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5c2d, 5); calld(0x1007_63a0, -0x7_f892);          /* call 0x100763a0 */
            ii(0x100f_5c32, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100f_5c35, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_5c38, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_5c3b, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x3); /* cmp byte [eax+0x101c81d5], 0x3 */
            ii(0x100f_5c42, 2); if(jled(0x100f_5c46, 0x2)) goto l_0x100f_5c46; /* jle 0x100f5c46 */
        l_0x100f_5c44:
            ii(0x100f_5c44, 2); jmpd(0x100f_5c65, 0x1f); goto l_0x100f_5c65; /* jmp 0x100f5c65 */
        l_0x100f_5c46:
            ii(0x100f_5c46, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5c49, 5); calld(0x1007_63a0, -0x7_f8ae);          /* call 0x100763a0 */
            ii(0x100f_5c4e, 5); calld(0x1007_623c, -0x7_fa17);          /* call 0x1007623c */
            ii(0x100f_5c53, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5c55, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5c58, 5); calld(0x1007_63a0, -0x7_f8bd);          /* call 0x100763a0 */
            ii(0x100f_5c5d, 4); mov(dx, memw_a32[ds, edx + 0x19]);      /* mov dx, [edx+0x19] */
            ii(0x100f_5c61, 4); mov(memw_a32[ds, eax + 0x52], dx);      /* mov [eax+0x52], dx */
        l_0x100f_5c65:
            ii(0x100f_5c65, 5); jmpd(0x100f_5bdc, -0x8e); goto l_0x100f_5bdc; /* jmp 0x100f5bdc */
        l_0x100f_5c6a:
            ii(0x100f_5c6a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5c6f, 5); calld(0x1007_65d0, -0x7_f6a4);          /* call 0x100765d0 */
            ii(0x100f_5c74, 5); calld(0x100f_f637, 0x99be);             /* call 0x100ff637 */
            ii(0x100f_5c79, 5); jmpd(0x100f_6185, 0x507); goto l_0x100f_6185; /* jmp 0x100f6185 */
        l_0x100f_5c7e:
            ii(0x100f_5c7e, 2); jmpd(0x100f_5c88, 0x8); goto l_0x100f_5c88; /* jmp 0x100f5c88 */
        l_0x100f_5c80:
            ii(0x100f_5c80, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5c83, 5); calld(0x1007_6bf8, -0x7_f090);          /* call 0x10076bf8 */
        l_0x100f_5c88:
            ii(0x100f_5c88, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5c8a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5c8d, 5); calld(0x1013_ad71, 0x4_50df);           /* call 0x1013ad71 */
            ii(0x100f_5c92, 2); test(al, al);                           /* test al, al */
            ii(0x100f_5c94, 2); if(jzd(0x100f_5ccd, 0x37)) goto l_0x100f_5ccd; /* jz 0x100f5ccd */
            ii(0x100f_5c96, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5c99, 5); calld(0x1007_63a0, -0x7_f8fe);          /* call 0x100763a0 */
            ii(0x100f_5c9e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5ca0, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100f_5ca3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_5ca5, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_5caa, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5cac, 2); if(jnzd(0x100f_5ccb, 0x1d)) goto l_0x100f_5ccb; /* jnz 0x100f5ccb */
            ii(0x100f_5cae, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5cb1, 5); calld(0x1007_63a0, -0x7_f916);          /* call 0x100763a0 */
            ii(0x100f_5cb6, 5); calld(0x1007_623c, -0x7_fa7f);          /* call 0x1007623c */
            ii(0x100f_5cbb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5cbd, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5cc0, 5); calld(0x1007_63a0, -0x7_f925);          /* call 0x100763a0 */
            ii(0x100f_5cc5, 3); mov(dl, memb_a32[ds, edx + 0x1b]);      /* mov dl, [edx+0x1b] */
            ii(0x100f_5cc8, 3); mov(memb_a32[ds, eax + 0x54], dl);      /* mov [eax+0x54], dl */
        l_0x100f_5ccb:
            ii(0x100f_5ccb, 2); jmpd(0x100f_5c80, -0x4d); goto l_0x100f_5c80; /* jmp 0x100f5c80 */
        l_0x100f_5ccd:
            ii(0x100f_5ccd, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100f_5cd2, 5); calld(0x1007_6338, -0x7_f99f);          /* call 0x10076338 */
            ii(0x100f_5cd7, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100f_5cda, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5cdc, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_5cde, 5); calld(0x1007_643c, -0x7_f8a7);          /* call 0x1007643c */
            ii(0x100f_5ce3, 2); jmpd(0x100f_5ced, 0x8); goto l_0x100f_5ced; /* jmp 0x100f5ced */
        l_0x100f_5ce5:
            ii(0x100f_5ce5, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5ce8, 5); calld(0x1007_6bf8, -0x7_f0f5);          /* call 0x10076bf8 */
        l_0x100f_5ced:
            ii(0x100f_5ced, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5cef, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5cf2, 5); calld(0x1013_ad71, 0x4_507a);           /* call 0x1013ad71 */
            ii(0x100f_5cf7, 2); test(al, al);                           /* test al, al */
            ii(0x100f_5cf9, 2); if(jzd(0x100f_5d32, 0x37)) goto l_0x100f_5d32; /* jz 0x100f5d32 */
            ii(0x100f_5cfb, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5cfe, 5); calld(0x1007_63a0, -0x7_f963);          /* call 0x100763a0 */
            ii(0x100f_5d03, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5d05, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100f_5d08, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_5d0a, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_5d0f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5d11, 2); if(jnzd(0x100f_5d30, 0x1d)) goto l_0x100f_5d30; /* jnz 0x100f5d30 */
            ii(0x100f_5d13, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5d16, 5); calld(0x1007_63a0, -0x7_f97b);          /* call 0x100763a0 */
            ii(0x100f_5d1b, 5); calld(0x1007_623c, -0x7_fae4);          /* call 0x1007623c */
            ii(0x100f_5d20, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5d22, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5d25, 5); calld(0x1007_63a0, -0x7_f98a);          /* call 0x100763a0 */
            ii(0x100f_5d2a, 3); mov(dl, memb_a32[ds, edx + 0x1b]);      /* mov dl, [edx+0x1b] */
            ii(0x100f_5d2d, 3); mov(memb_a32[ds, eax + 0x54], dl);      /* mov [eax+0x54], dl */
        l_0x100f_5d30:
            ii(0x100f_5d30, 2); jmpd(0x100f_5ce5, -0x4d); goto l_0x100f_5ce5; /* jmp 0x100f5ce5 */
        l_0x100f_5d32:
            ii(0x100f_5d32, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100f_5d37, 5); calld(0x1007_6338, -0x7_fa04);          /* call 0x10076338 */
            ii(0x100f_5d3c, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100f_5d3f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5d41, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_5d43, 5); calld(0x1007_643c, -0x7_f90c);          /* call 0x1007643c */
            ii(0x100f_5d48, 2); jmpd(0x100f_5d52, 0x8); goto l_0x100f_5d52; /* jmp 0x100f5d52 */
        l_0x100f_5d4a:
            ii(0x100f_5d4a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5d4d, 5); calld(0x1007_6bf8, -0x7_f15a);          /* call 0x10076bf8 */
        l_0x100f_5d52:
            ii(0x100f_5d52, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5d54, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5d57, 5); calld(0x1013_ad71, 0x4_5015);           /* call 0x1013ad71 */
            ii(0x100f_5d5c, 2); test(al, al);                           /* test al, al */
            ii(0x100f_5d5e, 2); if(jzd(0x100f_5d97, 0x37)) goto l_0x100f_5d97; /* jz 0x100f5d97 */
            ii(0x100f_5d60, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5d63, 5); calld(0x1007_63a0, -0x7_f9c8);          /* call 0x100763a0 */
            ii(0x100f_5d68, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5d6a, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100f_5d6d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_5d6f, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_5d74, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5d76, 2); if(jnzd(0x100f_5d95, 0x1d)) goto l_0x100f_5d95; /* jnz 0x100f5d95 */
            ii(0x100f_5d78, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5d7b, 5); calld(0x1007_63a0, -0x7_f9e0);          /* call 0x100763a0 */
            ii(0x100f_5d80, 5); calld(0x1007_623c, -0x7_fb49);          /* call 0x1007623c */
            ii(0x100f_5d85, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5d87, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_5d8a, 5); calld(0x1007_63a0, -0x7_f9ef);          /* call 0x100763a0 */
            ii(0x100f_5d8f, 3); mov(dl, memb_a32[ds, edx + 0x1b]);      /* mov dl, [edx+0x1b] */
            ii(0x100f_5d92, 3); mov(memb_a32[ds, eax + 0x54], dl);      /* mov [eax+0x54], dl */
        l_0x100f_5d95:
            ii(0x100f_5d95, 2); jmpd(0x100f_5d4a, -0x4d); goto l_0x100f_5d4a; /* jmp 0x100f5d4a */
        l_0x100f_5d97:
            ii(0x100f_5d97, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5d9c, 5); calld(0x1007_65d0, -0x7_f7d1);          /* call 0x100765d0 */
            ii(0x100f_5da1, 5); calld(0x100f_f637, 0x9891);             /* call 0x100ff637 */
            ii(0x100f_5da6, 5); jmpd(0x100f_6185, 0x3da); goto l_0x100f_6185; /* jmp 0x100f6185 */
        l_0x100f_5dab:
            ii(0x100f_5dab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5dad, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5db2, 5); calld(0x1013_ad71, 0x4_4fba);           /* call 0x1013ad71 */
            ii(0x100f_5db7, 2); test(al, al);                           /* test al, al */
            ii(0x100f_5db9, 6); if(jzd(0x100f_614f, 0x390)) goto l_0x100f_614f; /* jz 0x100f614f */
            ii(0x100f_5dbf, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5dc4, 5); calld(0x1007_6574, -0x7_f855);          /* call 0x10076574 */
            ii(0x100f_5dc9, 5); calld(0x1007_623c, -0x7_fb92);          /* call 0x1007623c */
            ii(0x100f_5dce, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5dd0, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100f_5dd3, 5); calld(0x1007_6800, -0x7_f5d8);          /* call 0x10076800 */
            ii(0x100f_5dd8, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x100f_5ddd, 5); calld(Definitions.sys_new, 0x7_001e);   /* call 0x10165e00 */
            ii(0x100f_5de2, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100f_5de5, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100f_5de8, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100f_5deb, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100f_5def, 2); if(jzd(0x100f_5e0e, 0x1d)) goto l_0x100f_5e0e; /* jz 0x100f5e0e */
            ii(0x100f_5df1, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100f_5df4, 5); calld(0x100c_b6f0, -0x2_a709);          /* call 0x100cb6f0 */
            ii(0x100f_5df9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5dfb, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100f_5dfe, 5); calld(0x100c_a2f8, -0x2_bb0b);          /* call 0x100ca2f8 */
            ii(0x100f_5e03, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100f_5e06, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_5e09, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100f_5e0c, 2); jmpd(0x100f_5e14, 0x6); goto l_0x100f_5e14; /* jmp 0x100f5e14 */
        l_0x100f_5e0e:
            ii(0x100f_5e0e, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100f_5e11, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x100f_5e14:
            ii(0x100f_5e14, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x100f_5e17, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5e1a, 5); calld(0x1007_6800, -0x7_f61f);          /* call 0x10076800 */
            ii(0x100f_5e1f, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5e24, 5); calld(0x1007_6574, -0x7_f8b5);          /* call 0x10076574 */
            ii(0x100f_5e29, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100f_5e2c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_5e2f, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5e34, 5); calld(0x1007_6574, -0x7_f8c5);          /* call 0x10076574 */
            ii(0x100f_5e39, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100f_5e3c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_5e41, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_5e47, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x100f_5e4d, 5); calld(0x100c_b6b0, -0x2_a7a2);          /* call 0x100cb6b0 */
            ii(0x100f_5e52, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x100f_5e55:
            ii(0x100f_5e55, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5e58, 5); calld(0x1007_6730, -0x7_f72d);          /* call 0x10076730 */
            ii(0x100f_5e5d, 5); calld(0x100c_b7e4, -0x2_a67e);          /* call 0x100cb7e4 */
            ii(0x100f_5e62, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100f_5e67, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5e6a, 5); calld(0x1007_6730, -0x7_f73f);          /* call 0x10076730 */
            ii(0x100f_5e6f, 5); calld(0x100c_b7b4, -0x2_a6c0);          /* call 0x100cb7b4 */
            ii(0x100f_5e74, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5e77, 5); calld(0x1007_6730, -0x7_f74c);          /* call 0x10076730 */
            ii(0x100f_5e7c, 5); calld(0x100e_f36c, -0x6b15);            /* call 0x100ef36c */
            ii(0x100f_5e81, 1); cwde();                                 /* cwde */
            ii(0x100f_5e82, 3); cmp(eax, 0x1e);                         /* cmp eax, 0x1e */
            ii(0x100f_5e85, 2); if(jld(0x100f_5e55, -0x32)) goto l_0x100f_5e55; /* jl 0x100f5e55 */
            ii(0x100f_5e87, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5e8a, 5); calld(0x1007_6730, -0x7_f75f);          /* call 0x10076730 */
            ii(0x100f_5e8f, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x100f_5e92, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_5e95, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5e98, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100f_5e9b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_5e9e, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_5ea0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5ea2, 2); if(jged(0x100f_5eb9, 0x15)) goto l_0x100f_5eb9; /* jge 0x100f5eb9 */
            ii(0x100f_5ea4, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5ea7, 4); mov(dx, memw_a32[ds, eax + 0xe]);       /* mov dx, [eax+0xe] */
            ii(0x100f_5eab, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100f_5ead, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5eb0, 5); calld(0x1007_6730, -0x7_f785);          /* call 0x10076730 */
            ii(0x100f_5eb5, 4); mov(memw_a32[ds, eax + 0xe], dx);       /* mov [eax+0xe], dx */
        l_0x100f_5eb9:
            ii(0x100f_5eb9, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5ebc, 5); calld(0x1007_6730, -0x7_f791);          /* call 0x10076730 */
            ii(0x100f_5ec1, 3); mov(edx, memd_a32[ds, eax + 0xa]);      /* mov edx, [eax+0xa] */
            ii(0x100f_5ec4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_5ec7, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5eca, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100f_5ecd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_5ed0, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_5ed2, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5ed4, 2); if(jged(0x100f_5eeb, 0x15)) goto l_0x100f_5eeb; /* jge 0x100f5eeb */
            ii(0x100f_5ed6, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5ed9, 4); mov(dx, memw_a32[ds, eax + 0xc]);       /* mov dx, [eax+0xc] */
            ii(0x100f_5edd, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100f_5edf, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5ee2, 5); calld(0x1007_6730, -0x7_f7b7);          /* call 0x10076730 */
            ii(0x100f_5ee7, 4); mov(memw_a32[ds, eax + 0xc], dx);       /* mov [eax+0xc], dx */
        l_0x100f_5eeb:
            ii(0x100f_5eeb, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5eee, 5); calld(0x1007_6730, -0x7_f7c3);          /* call 0x10076730 */
            ii(0x100f_5ef3, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100f_5ef6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_5ef9, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5efc, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100f_5eff, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_5f02, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_5f04, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5f06, 2); if(jged(0x100f_5f1d, 0x15)) goto l_0x100f_5f1d; /* jge 0x100f5f1d */
            ii(0x100f_5f08, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5f0b, 4); mov(dx, memw_a32[ds, eax + 0xa]);       /* mov dx, [eax+0xa] */
            ii(0x100f_5f0f, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100f_5f11, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5f14, 5); calld(0x1007_6730, -0x7_f7e9);          /* call 0x10076730 */
            ii(0x100f_5f19, 4); mov(memw_a32[ds, eax + 0xa], dx);       /* mov [eax+0xa], dx */
        l_0x100f_5f1d:
            ii(0x100f_5f1d, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5f20, 5); calld(0x1007_6730, -0x7_f7f5);          /* call 0x10076730 */
            ii(0x100f_5f25, 3); mov(edx, memd_a32[ds, eax + 0x15]);     /* mov edx, [eax+0x15] */
            ii(0x100f_5f28, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_5f2b, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5f2e, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x100f_5f31, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_5f34, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_5f36, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5f38, 2); if(jged(0x100f_5f4f, 0x15)) goto l_0x100f_5f4f; /* jge 0x100f5f4f */
            ii(0x100f_5f3a, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5f3d, 4); mov(dx, memw_a32[ds, eax + 0x17]);      /* mov dx, [eax+0x17] */
            ii(0x100f_5f41, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100f_5f43, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5f46, 5); calld(0x1007_6730, -0x7_f81b);          /* call 0x10076730 */
            ii(0x100f_5f4b, 4); mov(memw_a32[ds, eax + 0x17], dx);      /* mov [eax+0x17], dx */
        l_0x100f_5f4f:
            ii(0x100f_5f4f, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5f52, 5); calld(0x1007_6730, -0x7_f827);          /* call 0x10076730 */
            ii(0x100f_5f57, 3); mov(edx, memd_a32[ds, eax + 0x10]);     /* mov edx, [eax+0x10] */
            ii(0x100f_5f5a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_5f5d, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5f60, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100f_5f63, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_5f66, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_5f68, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5f6a, 2); if(jged(0x100f_5f81, 0x15)) goto l_0x100f_5f81; /* jge 0x100f5f81 */
            ii(0x100f_5f6c, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5f6f, 4); mov(dx, memw_a32[ds, eax + 0x12]);      /* mov dx, [eax+0x12] */
            ii(0x100f_5f73, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100f_5f75, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5f78, 5); calld(0x1007_6730, -0x7_f84d);          /* call 0x10076730 */
            ii(0x100f_5f7d, 4); mov(memw_a32[ds, eax + 0x12], dx);      /* mov [eax+0x12], dx */
        l_0x100f_5f81:
            ii(0x100f_5f81, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5f84, 5); calld(0x1007_6730, -0x7_f859);          /* call 0x10076730 */
            ii(0x100f_5f89, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x100f_5f8c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_5f8f, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5f92, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100f_5f95, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_5f98, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_5f9a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5f9c, 2); if(jged(0x100f_5fb3, 0x15)) goto l_0x100f_5fb3; /* jge 0x100f5fb3 */
            ii(0x100f_5f9e, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5fa1, 4); mov(dx, memw_a32[ds, eax + 0x10]);      /* mov dx, [eax+0x10] */
            ii(0x100f_5fa5, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100f_5fa7, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5faa, 5); calld(0x1007_6730, -0x7_f87f);          /* call 0x10076730 */
            ii(0x100f_5faf, 4); mov(memw_a32[ds, eax + 0x10], dx);      /* mov [eax+0x10], dx */
        l_0x100f_5fb3:
            ii(0x100f_5fb3, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5fb6, 5); calld(0x1007_6730, -0x7_f88b);          /* call 0x10076730 */
            ii(0x100f_5fbb, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x100f_5fbe, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_5fc1, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5fc4, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100f_5fc7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_5fca, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_5fcc, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5fce, 2); if(jged(0x100f_5fe5, 0x15)) goto l_0x100f_5fe5; /* jge 0x100f5fe5 */
            ii(0x100f_5fd0, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100f_5fd3, 4); mov(dx, memw_a32[ds, eax + 0x14]);      /* mov dx, [eax+0x14] */
            ii(0x100f_5fd7, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100f_5fd9, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5fdc, 5); calld(0x1007_6730, -0x7_f8b1);          /* call 0x10076730 */
            ii(0x100f_5fe1, 4); mov(memw_a32[ds, eax + 0x14], dx);      /* mov [eax+0x14], dx */
        l_0x100f_5fe5:
            ii(0x100f_5fe5, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_5fe8, 5); calld(0x1007_6730, -0x7_f8bd);          /* call 0x10076730 */
            ii(0x100f_5fed, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_5fef, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5ff4, 5); calld(0x1007_6574, -0x7_fa85);          /* call 0x10076574 */
            ii(0x100f_5ff9, 3); mov(dl, memb_a32[ds, edx + 0xa]);       /* mov dl, [edx+0xa] */
            ii(0x100f_5ffc, 3); mov(memb_a32[ds, eax + 0x4d], dl);      /* mov [eax+0x4d], dl */
            ii(0x100f_5fff, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_6002, 5); calld(0x1007_6730, -0x7_f8d7);          /* call 0x10076730 */
            ii(0x100f_6007, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_6009, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100f_600c, 5); calld(0x1007_6730, -0x7_f8e1);          /* call 0x10076730 */
            ii(0x100f_6011, 4); mov(dx, memw_a32[ds, edx + 0xe]);       /* mov dx, [edx+0xe] */
            ii(0x100f_6015, 4); cmp(dx, memw_a32[ds, eax + 0xe]);       /* cmp dx, [eax+0xe] */
            ii(0x100f_6019, 2); if(jnzd(0x100f_6037, 0x1c)) goto l_0x100f_6037; /* jnz 0x100f6037 */
            ii(0x100f_601b, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_601e, 5); calld(0x1007_6730, -0x7_f8f3);          /* call 0x10076730 */
            ii(0x100f_6023, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_6025, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100f_6028, 5); calld(0x1007_6730, -0x7_f8fd);          /* call 0x10076730 */
            ii(0x100f_602d, 4); mov(dx, memw_a32[ds, edx + 0xc]);       /* mov dx, [edx+0xc] */
            ii(0x100f_6031, 4); cmp(dx, memw_a32[ds, eax + 0xc]);       /* cmp dx, [eax+0xc] */
            ii(0x100f_6035, 2); if(jzd(0x100f_6039, 0x2)) goto l_0x100f_6039; /* jz 0x100f6039 */
        l_0x100f_6037:
            ii(0x100f_6037, 2); jmpd(0x100f_6055, 0x1c); goto l_0x100f_6055; /* jmp 0x100f6055 */
        l_0x100f_6039:
            ii(0x100f_6039, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_603c, 5); calld(0x1007_6730, -0x7_f911);          /* call 0x10076730 */
            ii(0x100f_6041, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_6043, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100f_6046, 5); calld(0x1007_6730, -0x7_f91b);          /* call 0x10076730 */
            ii(0x100f_604b, 4); mov(dx, memw_a32[ds, edx + 0xa]);       /* mov dx, [edx+0xa] */
            ii(0x100f_604f, 4); cmp(dx, memw_a32[ds, eax + 0xa]);       /* cmp dx, [eax+0xa] */
            ii(0x100f_6053, 2); if(jzd(0x100f_6057, 0x2)) goto l_0x100f_6057; /* jz 0x100f6057 */
        l_0x100f_6055:
            ii(0x100f_6055, 2); jmpd(0x100f_6073, 0x1c); goto l_0x100f_6073; /* jmp 0x100f6073 */
        l_0x100f_6057:
            ii(0x100f_6057, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_605a, 5); calld(0x1007_6730, -0x7_f92f);          /* call 0x10076730 */
            ii(0x100f_605f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_6061, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100f_6064, 5); calld(0x1007_6730, -0x7_f939);          /* call 0x10076730 */
            ii(0x100f_6069, 4); mov(dx, memw_a32[ds, edx + 0x17]);      /* mov dx, [edx+0x17] */
            ii(0x100f_606d, 4); cmp(dx, memw_a32[ds, eax + 0x17]);      /* cmp dx, [eax+0x17] */
            ii(0x100f_6071, 2); if(jzd(0x100f_6075, 0x2)) goto l_0x100f_6075; /* jz 0x100f6075 */
        l_0x100f_6073:
            ii(0x100f_6073, 2); jmpd(0x100f_6091, 0x1c); goto l_0x100f_6091; /* jmp 0x100f6091 */
        l_0x100f_6075:
            ii(0x100f_6075, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_6078, 5); calld(0x1007_6730, -0x7_f94d);          /* call 0x10076730 */
            ii(0x100f_607d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_607f, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100f_6082, 5); calld(0x1007_6730, -0x7_f957);          /* call 0x10076730 */
            ii(0x100f_6087, 4); mov(dx, memw_a32[ds, edx + 0x12]);      /* mov dx, [edx+0x12] */
            ii(0x100f_608b, 4); cmp(dx, memw_a32[ds, eax + 0x12]);      /* cmp dx, [eax+0x12] */
            ii(0x100f_608f, 2); if(jzd(0x100f_6093, 0x2)) goto l_0x100f_6093; /* jz 0x100f6093 */
        l_0x100f_6091:
            ii(0x100f_6091, 2); jmpd(0x100f_60af, 0x1c); goto l_0x100f_60af; /* jmp 0x100f60af */
        l_0x100f_6093:
            ii(0x100f_6093, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_6096, 5); calld(0x1007_6730, -0x7_f96b);          /* call 0x10076730 */
            ii(0x100f_609b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_609d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100f_60a0, 5); calld(0x1007_6730, -0x7_f975);          /* call 0x10076730 */
            ii(0x100f_60a5, 4); mov(dx, memw_a32[ds, edx + 0x10]);      /* mov dx, [edx+0x10] */
            ii(0x100f_60a9, 4); cmp(dx, memw_a32[ds, eax + 0x10]);      /* cmp dx, [eax+0x10] */
            ii(0x100f_60ad, 2); if(jzd(0x100f_60b1, 0x2)) goto l_0x100f_60b1; /* jz 0x100f60b1 */
        l_0x100f_60af:
            ii(0x100f_60af, 2); jmpd(0x100f_60cd, 0x1c); goto l_0x100f_60cd; /* jmp 0x100f60cd */
        l_0x100f_60b1:
            ii(0x100f_60b1, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_60b4, 5); calld(0x1007_6730, -0x7_f989);          /* call 0x10076730 */
            ii(0x100f_60b9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_60bb, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100f_60be, 5); calld(0x1007_6730, -0x7_f993);          /* call 0x10076730 */
            ii(0x100f_60c3, 4); mov(dx, memw_a32[ds, edx + 0x14]);      /* mov dx, [edx+0x14] */
            ii(0x100f_60c7, 4); cmp(dx, memw_a32[ds, eax + 0x14]);      /* cmp dx, [eax+0x14] */
            ii(0x100f_60cb, 2); if(jzd(0x100f_613b, 0x6e)) goto l_0x100f_613b; /* jz 0x100f613b */
        l_0x100f_60cd:
            ii(0x100f_60cd, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x100f_60d0, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_60d5, 5); calld(0x1007_6574, -0x7_fb66);          /* call 0x10076574 */
            ii(0x100f_60da, 5); calld(0x1014_edfa, 0x5_8d1b);           /* call 0x1014edfa */
            ii(0x100f_60df, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_60e2, 5); calld(0x100c_b74c, -0x2_a99b);          /* call 0x100cb74c */
            ii(0x100f_60e7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_60e9, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_60ee, 5); calld(0x1007_6574, -0x7_fb7f);          /* call 0x10076574 */
            ii(0x100f_60f3, 5); calld(0x1010_2bc4, 0xcacc);             /* call 0x10102bc4 */
            ii(0x100f_60f8, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100f_60fd, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_6102, 5); calld(0x1007_65d0, -0x7_fb37);          /* call 0x100765d0 */
            ii(0x100f_6107, 5); calld(0x1007_1838, -0x8_48d4);          /* call 0x10071838 */
            ii(0x100f_610c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_610e, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100f_6111, 5); calld(0x1007_65d0, -0x7_fb46);          /* call 0x100765d0 */
            ii(0x100f_6116, 5); calld(0x1007_1838, -0x8_48e3);          /* call 0x10071838 */
            ii(0x100f_611b, 7); mov(memb_a32[ds, 0x101c_391b], 0x1);    /* mov byte [0x101c391b], 0x1 */
            ii(0x100f_6122, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_6127, 5); calld(0x1007_65d0, -0x7_fb5c);          /* call 0x100765d0 */
            ii(0x100f_612c, 5); calld(0x100f_f637, 0x9506);             /* call 0x100ff637 */
            ii(0x100f_6131, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_6133, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100f_6136, 5); calld(0x1007_5f2c, -0x8_020f);          /* call 0x10075f2c */
        l_0x100f_613b:
            ii(0x100f_613b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_613d, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100f_6140, 5); calld(0x1007_5eec, -0x8_0259);          /* call 0x10075eec */
            ii(0x100f_6145, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_6147, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100f_614a, 5); calld(0x1007_5eec, -0x8_0263);          /* call 0x10075eec */
        l_0x100f_614f:
            ii(0x100f_614f, 2); jmpd(0x100f_6185, 0x34); goto l_0x100f_6185; /* jmp 0x100f6185 */
        l_0x100f_6151:
            ii(0x100f_6151, 2); jmpd(0x100f_6185, 0x32); goto l_0x100f_6185; /* jmp 0x100f6185 */
        //  ii(0x100f_6153, 1); nop();                                  /* nop */
        //  ii(0x100f_6154, 20); /* Служебная область с абсолютными адресами переходов. (0x100f_5af9, 0x100f_5b1e, 0x100f_5b34, 0x100f_5c7e, 0x100f_5dab). */
        l_0x100f_6168:
            ii(0x100f_6168, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_616b, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100f_616e, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x4);     /* cmp word [ebp-0x3c], 0x4 */
            ii(0x100f_6173, 2); if(jad(0x100f_6151, -0x24)) goto l_0x100f_6151; /* ja 0x100f6151 */
            ii(0x100f_6175, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6177, 4); mov(ax, memw_a32[ss, ebp - 0x3c]);      /* mov ax, [ebp-0x3c] */
            ii(0x100f_617b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_617e, 7); 
            switch (jmpd_abs_switch(memd_a32[cs, eax + 0x100f_6154]))
            {
                case 0x100f_5af9:
                    goto l_0x100f_5af9;
                case 0x100f_5b1e:
                    goto l_0x100f_5b1e;
                case 0x100f_5b34:
                    goto l_0x100f_5b34;
                case 0x100f_5c7e:
                    goto l_0x100f_5c7e;
                case 0x100f_5dab:
                    goto l_0x100f_5dab;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x100f6154] */
        l_0x100f_6185:
            ii(0x100f_6185, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_6187, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100f_618a, 5); calld(0x1007_5f6c, -0x8_0223);          /* call 0x10075f6c */
        l_0x100f_618f:
            ii(0x100f_618f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_6191, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_6192, 1); popd(edi);                              /* pop edi */
            ii(0x100f_6193, 1); popd(esi);                              /* pop esi */
            ii(0x100f_6194, 1); popd(edx);                              /* pop edx */
            ii(0x100f_6195, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_6196, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_6197, 1); retd(); return;                         /* ret */
        }
    }
}
