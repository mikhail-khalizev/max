using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1df31b82-f835-4429-9206-84a4df7b090b")]
        public void Method_100f_fa70()
        {
            ii(0x100f_fa70, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100f_fa75, 5); calld(Definitions.sys_check_available_stack_size, 0x662d8); /* call 0x10165d52 */
            ii(0x100f_fa7a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_fa7b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_fa7c, 1); pushd(edx);                             /* push edx */
            ii(0x100f_fa7d, 1); pushd(esi);                             /* push esi */
            ii(0x100f_fa7e, 1); pushd(edi);                             /* push edi */
            ii(0x100f_fa7f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_fa80, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_fa82, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100f_fa88, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_fa8b, 7); cmp(memb_a32[ds, 0x101c_3916], 0);      /* cmp byte [0x101c3916], 0x0 */
            ii(0x100f_fa92, 2); if(jnzd(0x100f_fa9f, 0xb)) goto l_0x100f_fa9f; /* jnz 0x100ffa9f */
            ii(0x100f_fa94, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_fa96, 5); mov(al, memb_a32[ds, 0x101c_3919]);     /* mov al, [0x101c3919] */
            ii(0x100f_fa9b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_fa9d, 2); if(jnzd(0x100f_faa4, 0x5)) goto l_0x100f_faa4; /* jnz 0x100ffaa4 */
        l_0x100f_fa9f:
            ii(0x100f_fa9f, 5); jmpd(0x100f_fc0a, 0x166); goto l_0x100f_fc0a; /* jmp 0x100ffc0a */
        l_0x100f_faa4:
            ii(0x100f_faa4, 5); calld(0x100d_51e4, -0x2a8c5);           /* call 0x100d51e4 */
            ii(0x100f_faa9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_faab, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100f_faad, 5); calld(0x100d_5204, -0x2a8ae);           /* call 0x100d5204 */
            ii(0x100f_fab2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_fab4, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100f_fab6, 5); mov(eax, memd_a32[ds, 0x101c_393c]);    /* mov eax, [0x101c393c] */
            ii(0x100f_fabb, 5); calld(0x100c_fa7c, -0x30044);           /* call 0x100cfa7c */
            ii(0x100f_fac0, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100f_fac7, 2); jmpd(0x100f_facf, 0x6); goto l_0x100f_facf; /* jmp 0x100ffacf */
        l_0x100f_fac9:
            ii(0x100f_fac9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_facc, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100f_facf:
            ii(0x100f_facf, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_fad3, 3); cmp(eax, 0x18);                         /* cmp eax, 0x18 */
            ii(0x100f_fad6, 2); if(jaed(0x100f_fb1f, 0x47)) goto l_0x100f_fb1f; /* jae 0x100ffb1f */
            ii(0x100f_fad8, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_fadc, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_fadf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_fae1, 6); mov(dl, memb_a32[ds, eax + 0x101b_8757]); /* mov dl, [eax+0x101b8757] */
            ii(0x100f_fae7, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_faeb, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_faee, 6); mov(eax, memd_a32[ds, eax + 0x101b_8753]); /* mov eax, [eax+0x101b8753] */
            ii(0x100f_faf4, 5); calld(0x100c_fb73, -0x2ff86);           /* call 0x100cfb73 */
            ii(0x100f_faf9, 5); calld(0x100d_51e4, -0x2a91a);           /* call 0x100d51e4 */
            ii(0x100f_fafe, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_fb00, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100f_fb02, 5); calld(0x100d_5204, -0x2a903);           /* call 0x100d5204 */
            ii(0x100f_fb07, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_fb09, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100f_fb0b, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_fb0f, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_fb12, 6); mov(eax, memd_a32[ds, eax + 0x101b_8753]); /* mov eax, [eax+0x101b8753] */
            ii(0x100f_fb18, 5); calld(0x100c_fa7c, -0x300a1);           /* call 0x100cfa7c */
            ii(0x100f_fb1d, 2); jmpd(0x100f_fac9, -0x56); goto l_0x100f_fac9; /* jmp 0x100ffac9 */
        l_0x100f_fb1f:
            ii(0x100f_fb1f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_fb21, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100f_fb26, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_fb28, 2); if(jzd(0x100f_fb49, 0x1f)) goto l_0x100f_fb49; /* jz 0x100ffb49 */
            ii(0x100f_fb2a, 7); cmp(memb_a32[ds, 0x101c_391e], 0x8);    /* cmp byte [0x101c391e], 0x8 */
            ii(0x100f_fb31, 2); if(jnzd(0x100f_fb39, 0x6)) goto l_0x100f_fb39; /* jnz 0x100ffb39 */
            ii(0x100f_fb33, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100f_fb37, 2); jmpd(0x100f_fb3d, 0x4); goto l_0x100f_fb3d; /* jmp 0x100ffb3d */
        l_0x100f_fb39:
            ii(0x100f_fb39, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x100f_fb3d:
            ii(0x100f_fb3d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_fb3f, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100f_fb42, 5); calld(0x100f_4fa2, -0xaba5);            /* call 0x100f4fa2 */
            ii(0x100f_fb47, 2); jmpd(0x100f_fb7a, 0x31); goto l_0x100f_fb7a; /* jmp 0x100ffb7a */
        l_0x100f_fb49:
            ii(0x100f_fb49, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_fb4b, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_fb50, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_fb56, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_fb5c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_fb61, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_fb64, 2); if(jnzd(0x100f_fb6c, 0x6)) goto l_0x100f_fb6c; /* jnz 0x100ffb6c */
            ii(0x100f_fb66, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x100f_fb6a, 2); jmpd(0x100f_fb70, 0x4); goto l_0x100f_fb70; /* jmp 0x100ffb70 */
        l_0x100f_fb6c:
            ii(0x100f_fb6c, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x100f_fb70:
            ii(0x100f_fb70, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_fb72, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100f_fb75, 5); calld(0x100f_4fa2, -0xabd8);            /* call 0x100f4fa2 */
        l_0x100f_fb7a:
            ii(0x100f_fb7a, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x100f_fb81, 2); if(jnzd(0x100f_fb8f, 0xc)) goto l_0x100f_fb8f; /* jnz 0x100ffb8f */
            ii(0x100f_fb83, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_fb85, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100f_fb8a, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100f_fb8d, 2); if(jzd(0x100f_fb91, 0x2)) goto l_0x100f_fb91; /* jz 0x100ffb91 */
        l_0x100f_fb8f:
            ii(0x100f_fb8f, 2); jmpd(0x100f_fb96, 0x5); goto l_0x100f_fb96; /* jmp 0x100ffb96 */
        l_0x100f_fb91:
            ii(0x100f_fb91, 5); jmpd(0x100f_fc0a, 0x74); goto l_0x100f_fc0a; /* jmp 0x100ffc0a */
        l_0x100f_fb96:
            ii(0x100f_fb96, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100f_fb9a, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100f_fba1, 2); jmpd(0x100f_fba9, 0x6); goto l_0x100f_fba9; /* jmp 0x100ffba9 */
        l_0x100f_fba3:
            ii(0x100f_fba3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_fba6, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100f_fba9:
            ii(0x100f_fba9, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_fbad, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_fbb0, 2); if(jged(0x100f_fbd2, 0x20)) goto l_0x100f_fbd2; /* jge 0x100ffbd2 */
            ii(0x100f_fbb2, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_fbb6, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_fbbc, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_fbc2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_fbc7, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_fbca, 2); if(jnzd(0x100f_fbd0, 0x4)) goto l_0x100f_fbd0; /* jnz 0x100ffbd0 */
            ii(0x100f_fbcc, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x100f_fbd0:
            ii(0x100f_fbd0, 2); jmpd(0x100f_fba3, -0x2f); goto l_0x100f_fba3; /* jmp 0x100ffba3 */
        l_0x100f_fbd2:
            ii(0x100f_fbd2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_fbd4, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_fbd9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_fbdf, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_fbe5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_fbea, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_fbed, 2); if(jzd(0x100f_fbf5, 0x6)) goto l_0x100f_fbf5; /* jz 0x100ffbf5 */
            ii(0x100f_fbef, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_fbf3, 2); if(jzd(0x100f_fc0a, 0x15)) goto l_0x100f_fc0a; /* jz 0x100ffc0a */
        l_0x100f_fbf5:
            ii(0x100f_fbf5, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100f_fbf9, 2); if(jzd(0x100f_fc03, 0x8)) goto l_0x100f_fc03; /* jz 0x100ffc03 */
            ii(0x100f_fbfb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_fbfe, 5); calld(0x100f_f637, -0x5cc);             /* call 0x100ff637 */
        l_0x100f_fc03:
            ii(0x100f_fc03, 7); mov(memb_a32[ds, 0x101c_3916], 0x1);    /* mov byte [0x101c3916], 0x1 */
        l_0x100f_fc0a:
            ii(0x100f_fc0a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_fc0c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_fc0d, 1); popd(edi);                              /* pop edi */
            ii(0x100f_fc0e, 1); popd(esi);                              /* pop esi */
            ii(0x100f_fc0f, 1); popd(edx);                              /* pop edx */
            ii(0x100f_fc10, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_fc11, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_fc12, 1); retd(); return;                         /* ret */
        }
    }
}
