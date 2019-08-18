using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0a6d8b7d-dca8-4df1-a658-cc3f38d5d784")]
        public void Method_1008_fcc6()
        {
            ii(0x1008_fcc6, 5); pushd(0x84);                            /* push 0x84 */
            ii(0x1008_fccb, 5); calld(Definitions.sys_check_available_stack_size, 0xd_6082); /* call 0x10165d52 */
            ii(0x1008_fcd0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_fcd1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_fcd2, 1); pushd(esi);                             /* push esi */
            ii(0x1008_fcd3, 1); pushd(edi);                             /* push edi */
            ii(0x1008_fcd4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_fcd5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_fcd7, 6); sub(esp, 0x60);                         /* sub esp, 0x60 */
            ii(0x1008_fcdd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_fce0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_fce3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_fce6, 3); add(edx, 0x15);                         /* add edx, 0x15 */
            ii(0x1008_fce9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_fcec, 5); calld(0x1008_b4b4, -0x483d);            /* call 0x1008b4b4 */
            ii(0x1008_fcf1, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fcf3, 2); if(jnzd(0x1008_fd04, 0xf)) goto l_0x1008_fd04; /* jnz 0x1008fd04 */
            ii(0x1008_fcf5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_fcf8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_fcfb, 5); calld(0x1015_2a52, 0xc_2d52);           /* call 0x10152a52 */
            ii(0x1008_fd00, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fd02, 2); if(jnzd(0x1008_fd0d, 0x9)) goto l_0x1008_fd0d; /* jnz 0x1008fd0d */
        l_0x1008_fd04:
            ii(0x1008_fd04, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_fd08, 5); jmpd(0x1009_00a4, 0x397); goto l_0x1009_00a4; /* jmp 0x100900a4 */
        l_0x1008_fd0d:
            ii(0x1008_fd0d, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1008_fd12, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_fd15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fd18, 5); calld(0x100a_3671, 0x1_3954);           /* call 0x100a3671 */
            ii(0x1008_fd1d, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fd1f, 2); if(jzd(0x1008_fd2a, 0x9)) goto l_0x1008_fd2a; /* jz 0x1008fd2a */
            ii(0x1008_fd21, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_fd25, 5); jmpd(0x1009_00a4, 0x37a); goto l_0x1009_00a4; /* jmp 0x100900a4 */
        l_0x1008_fd2a:
            ii(0x1008_fd2a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fd2d, 3); mov(al, memb_a32[ds, eax + 0x25]);      /* mov al, [eax+0x25] */
            ii(0x1008_fd30, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1008_fd33, 5); jmpd(0x1009_006e, 0x336); goto l_0x1009_006e; /* jmp 0x1009006e */
        l_0x1008_fd38:
            ii(0x1008_fd38, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fd3b, 5); calld(0x1008_fa3b, -0x305);             /* call 0x1008fa3b */
            ii(0x1008_fd40, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fd42, 6); if(jzd(0x1008_fdbf, 0x77)) goto l_0x1008_fdbf; /* jz 0x1008fdbf */
            ii(0x1008_fd48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_fd4a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fd4d, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_fd50, 5); calld(0x1013_ad71, 0xa_b01c);           /* call 0x1013ad71 */
            ii(0x1008_fd55, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fd57, 2); if(jzd(0x1008_fd6f, 0x16)) goto l_0x1008_fd6f; /* jz 0x1008fd6f */
            ii(0x1008_fd59, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fd5c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_fd5f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_fd62, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_fd65, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_fd68, 3); calld_abs(memd_a32[ds, edx + 0x74]);    /* call dword [edx+0x74] */
            ii(0x1008_fd6b, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fd6d, 2); if(jzd(0x1008_fd71, 0x2)) goto l_0x1008_fd71; /* jz 0x1008fd71 */
        l_0x1008_fd6f:
            ii(0x1008_fd6f, 2); jmpd(0x1008_fd7b, 0xa); goto l_0x1008_fd7b; /* jmp 0x1008fd7b */
        l_0x1008_fd71:
            ii(0x1008_fd71, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fd74, 5); calld(0x1008_f76b, -0x60e);             /* call 0x1008f76b */
            ii(0x1008_fd79, 2); jmpd(0x1008_fdbf, 0x44); goto l_0x1008_fdbf; /* jmp 0x1008fdbf */
        l_0x1008_fd7b:
            ii(0x1008_fd7b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fd7e, 5); calld(0x1008_f52c, -0x857);             /* call 0x1008f52c */
            ii(0x1008_fd83, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fd85, 2); if(jnzd(0x1008_fd93, 0xc)) goto l_0x1008_fd93; /* jnz 0x1008fd93 */
            ii(0x1008_fd87, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fd8a, 5); calld(0x1008_e1b5, -0x1bda);            /* call 0x1008e1b5 */
            ii(0x1008_fd8f, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fd91, 2); if(jzd(0x1008_fd95, 0x2)) goto l_0x1008_fd95; /* jz 0x1008fd95 */
        l_0x1008_fd93:
            ii(0x1008_fd93, 2); jmpd(0x1008_fda1, 0xc); goto l_0x1008_fda1; /* jmp 0x1008fda1 */
        l_0x1008_fd95:
            ii(0x1008_fd95, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fd98, 5); calld(0x1008_e39c, -0x1a01);            /* call 0x1008e39c */
            ii(0x1008_fd9d, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fd9f, 2); if(jzd(0x1008_fda3, 0x2)) goto l_0x1008_fda3; /* jz 0x1008fda3 */
        l_0x1008_fda1:
            ii(0x1008_fda1, 2); jmpd(0x1008_fdbf, 0x1c); goto l_0x1008_fdbf; /* jmp 0x1008fdbf */
        l_0x1008_fda3:
            ii(0x1008_fda3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fda6, 4); mov(memb_a32[ds, eax + 0x25], 0x7);     /* mov byte [eax+0x25], 0x7 */
            ii(0x1008_fdaa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fdad, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_fdb0, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_fdb3, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_fdb6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_fdb9, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_fdbc, 3); calld_abs(memd_a32[ds, ebx + 0x44]);    /* call dword [ebx+0x44] */
        l_0x1008_fdbf:
            ii(0x1008_fdbf, 5); jmpd(0x1009_00a0, 0x2dc); goto l_0x1009_00a0; /* jmp 0x100900a0 */
        l_0x1008_fdc4:
            ii(0x1008_fdc4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fdc7, 5); calld(0x1008_d6ba, -0x2712);            /* call 0x1008d6ba */
            ii(0x1008_fdcc, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fdce, 2); if(jzd(0x1008_fdd9, 0x9)) goto l_0x1008_fdd9; /* jz 0x1008fdd9 */
            ii(0x1008_fdd0, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_fdd4, 5); jmpd(0x1009_00a4, 0x2cb); goto l_0x1009_00a4; /* jmp 0x100900a4 */
        l_0x1008_fdd9:
            ii(0x1008_fdd9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fddc, 5); calld(0x1008_fa3b, -0x3a6);             /* call 0x1008fa3b */
            ii(0x1008_fde1, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fde3, 6); if(jzd(0x1009_004f, 0x266)) goto l_0x1009_004f; /* jz 0x1009004f */
            ii(0x1008_fde9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fdec, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_fdef, 5); calld(0x1007_6574, -0x1_9880);          /* call 0x10076574 */
            ii(0x1008_fdf4, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1008_fdf8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fdfb, 4); cmp(dx, memw_a32[ds, eax + 0x21]);      /* cmp dx, [eax+0x21] */
            ii(0x1008_fdff, 2); if(jnzd(0x1008_fe1d, 0x1c)) goto l_0x1008_fe1d; /* jnz 0x1008fe1d */
            ii(0x1008_fe01, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fe04, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_fe07, 5); calld(0x1007_6574, -0x1_9898);          /* call 0x10076574 */
            ii(0x1008_fe0c, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1008_fe10, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fe13, 4); cmp(dx, memw_a32[ds, eax + 0x23]);      /* cmp dx, [eax+0x23] */
            ii(0x1008_fe17, 6); if(jzd(0x1008_ff42, 0x125)) goto l_0x1008_ff42; /* jz 0x1008ff42 */
        l_0x1008_fe1d:
            ii(0x1008_fe1d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_fe20, 5); calld(Definitions.my_ctor_0x101b_4184, -0x1_9335); /* call 0x10076af0 */
            ii(0x1008_fe25, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fe28, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_fe2b, 5); calld(0x1007_6b90, -0x1_92a0);          /* call 0x10076b90 */
            ii(0x1008_fe30, 1); cwde();                                 /* cwde */
            ii(0x1008_fe31, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_fe33, 2); if(jnzd(0x1008_fe3e, 0x9)) goto l_0x1008_fe3e; /* jnz 0x1008fe3e */
            ii(0x1008_fe35, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1008_fe3c, 2); jmpd(0x1008_fe45, 0x7); goto l_0x1008_fe45; /* jmp 0x1008fe45 */
        l_0x1008_fe3e:
            ii(0x1008_fe3e, 7); mov(memd_a32[ss, ebp - 0x20], 0x8);     /* mov dword [ebp-0x20], 0x8 */
        l_0x1008_fe45:
            ii(0x1008_fe45, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fe48, 4); mov(memb_a32[ds, eax + 0x25], 0x7);     /* mov byte [eax+0x25], 0x7 */
            ii(0x1008_fe4c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fe4f, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_fe52, 5); calld(0x1007_6574, -0x1_98e3);          /* call 0x10076574 */
            ii(0x1008_fe57, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1008_fe5b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_fe5e, 4); sub(ax, memw_a32[ds, edx + 0x21]);      /* sub ax, [edx+0x21] */
            ii(0x1008_fe62, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x1008_fe66, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fe69, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_fe6c, 5); calld(0x1007_6574, -0x1_98fd);          /* call 0x10076574 */
            ii(0x1008_fe71, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1008_fe75, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_fe78, 4); sub(ax, memw_a32[ds, edx + 0x23]);      /* sub ax, [edx+0x23] */
            ii(0x1008_fe7c, 4); mov(memw_a32[ss, ebp - 0x1a], ax);      /* mov [ebp-0x1a], ax */
            ii(0x1008_fe80, 4); movsx(edx, memw_a32[ss, ebp - 0x1a]);   /* movsx edx, word [ebp-0x1a] */
            ii(0x1008_fe84, 4); movsx(eax, memw_a32[ss, ebp - 0x1a]);   /* movsx eax, word [ebp-0x1a] */
            ii(0x1008_fe88, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1008_fe8b, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1008_fe8d, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1008_fe91, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1008_fe95, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1008_fe98, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1008_fe9a, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1008_fe9e, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1008_fea0, 6); if(jled(0x1008_ff39, 0x93)) goto l_0x1008_ff39; /* jle 0x1008ff39 */
            ii(0x1008_fea6, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1008_feab, 5); calld(Definitions.sys_new, 0xd_5f50);   /* call 0x10165e00 */
            ii(0x1008_feb0, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1008_feb3, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1008_feb6, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1008_feb9, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1008_febd, 2); if(jzd(0x1008_ff01, 0x42)) goto l_0x1008_ff01; /* jz 0x1008ff01 */
            ii(0x1008_febf, 5); mov(eax, 0x1009_0249);                  /* mov eax, 0x10090249 */
            ii(0x1008_fec4, 1); pushd(eax);                             /* push eax */
            ii(0x1008_fec5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_fec8, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x1008_fecb, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1008_fece, 5); calld(0x1007_5e64, -0x1_a06f);          /* call 0x10075e64 */
            ii(0x1008_fed3, 1); pushd(eax);                             /* push eax */
            ii(0x1008_fed4, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1008_fed9, 1); pushd(eax);                             /* push eax */
            ii(0x1008_feda, 4); movsx(ecx, memw_a32[ss, ebp - 0x20]);   /* movsx ecx, word [ebp-0x20] */
            ii(0x1008_fede, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1008_fee1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fee4, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_fee7, 5); calld(0x1007_65d0, -0x1_991c);          /* call 0x100765d0 */
            ii(0x1008_feec, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_feee, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1008_fef1, 5); calld(0x100a_c220, 0x1_c32a);           /* call 0x100ac220 */
            ii(0x1008_fef6, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1008_fef9, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1008_fefc, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1008_feff, 2); jmpd(0x1008_ff07, 0x6); goto l_0x1008_ff07; /* jmp 0x1008ff07 */
        l_0x1008_ff01:
            ii(0x1008_ff01, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1008_ff04, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x1008_ff07:
            ii(0x1008_ff07, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x1008_ff0a, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1008_ff0d, 5); calld(0x1008_b060, -0x4eb2);            /* call 0x1008b060 */
            ii(0x1008_ff12, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1008_ff15, 5); calld(0x1008_af84, -0x4f96);            /* call 0x1008af84 */
            ii(0x1008_ff1a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_ff1c, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_ff21, 5); calld(0x100a_4d50, 0x1_4e2a);           /* call 0x100a4d50 */
            ii(0x1008_ff26, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_ff2a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_ff2c, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1008_ff2f, 5); calld(0x1008_8b7c, -0x73b8);            /* call 0x10088b7c */
            ii(0x1008_ff34, 5); jmpd(0x1009_00a4, 0x16b); goto l_0x1009_00a4; /* jmp 0x100900a4 */
        l_0x1008_ff39:
            ii(0x1008_ff39, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_ff3d, 5); jmpd(0x1009_00a4, 0x162); goto l_0x1009_00a4; /* jmp 0x100900a4 */
        l_0x1008_ff42:
            ii(0x1008_ff42, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_ff45, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x1008_ff48, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_ff4b, 5); calld(0x1007_5e64, -0x1_a0ec);          /* call 0x10075e64 */
            ii(0x1008_ff50, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_ff52, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_ff55, 3); mov(eax, memd_a32[ds, eax + 0x11]);     /* mov eax, [eax+0x11] */
            ii(0x1008_ff58, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_ff5b, 5); calld(0x1008_ba6a, -0x44f6);            /* call 0x1008ba6a */
            ii(0x1008_ff60, 2); test(al, al);                           /* test al, al */
            ii(0x1008_ff62, 2); if(jnzd(0x1008_ff75, 0x11)) goto l_0x1008_ff75; /* jnz 0x1008ff75 */
            ii(0x1008_ff64, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_ff67, 5); calld(0x1008_df3e, -0x202e);            /* call 0x1008df3e */
            ii(0x1008_ff6c, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_ff70, 5); jmpd(0x1009_00a4, 0x12f); goto l_0x1009_00a4; /* jmp 0x100900a4 */
        l_0x1008_ff75:
            ii(0x1008_ff75, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_ff78, 3); mov(eax, memd_a32[ds, eax + 0x11]);     /* mov eax, [eax+0x11] */
            ii(0x1008_ff7b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_ff7e, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1008_ff81, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x10); /* test byte [eax+0x101c81c0], 0x10 */
            ii(0x1008_ff88, 2); if(jnzd(0x1008_ff97, 0xd)) goto l_0x1008_ff97; /* jnz 0x1008ff97 */
            ii(0x1008_ff8a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_ff8d, 5); calld(0x1008_dbbd, -0x23d5);            /* call 0x1008dbbd */
            ii(0x1008_ff92, 5); jmpd(0x1009_004f, 0xb8); goto l_0x1009_004f; /* jmp 0x1009004f */
        l_0x1008_ff97:
            ii(0x1008_ff97, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_ff9a, 4); mov(memb_a32[ds, eax + 0x25], 0x8);     /* mov byte [eax+0x25], 0x8 */
            ii(0x1008_ff9e, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x1008_ffa3, 5); calld(Definitions.sys_new, 0xd_5e58);   /* call 0x10165e00 */
            ii(0x1008_ffa8, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1008_ffab, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1008_ffae, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1008_ffb1, 4); cmp(memd_a32[ss, ebp - 0x44], 0);       /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1008_ffb5, 2); if(jzd(0x1009_0013, 0x5c)) goto l_0x1009_0013; /* jz 0x10090013 */
            ii(0x1008_ffb7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_ffba, 4); mov(ax, memw_a32[ds, eax + 0x23]);      /* mov ax, [eax+0x23] */
            ii(0x1008_ffbe, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1008_ffc3, 1); cwde();                                 /* cwde */
            ii(0x1008_ffc4, 1); pushd(eax);                             /* push eax */
            ii(0x1008_ffc5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_ffc8, 4); mov(ax, memw_a32[ds, eax + 0x21]);      /* mov ax, [eax+0x21] */
            ii(0x1008_ffcc, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1008_ffd1, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1008_ffd4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_ffd7, 3); mov(ebx, memd_a32[ds, eax + 0x21]);     /* mov ebx, [eax+0x21] */
            ii(0x1008_ffda, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_ffdd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_ffe0, 3); mov(edx, memd_a32[ds, eax + 0x1f]);     /* mov edx, [eax+0x1f] */
            ii(0x1008_ffe3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_ffe6, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_ffe9, 5); calld(0x1008_b148, -0x4ea6);            /* call 0x1008b148 */
            ii(0x1008_ffee, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1008_fff0, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1008_fff3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_fff6, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_fff9, 5); calld(0x1007_6600, -0x1_99fe);          /* call 0x10076600 */
            ii(0x1008_fffe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_0000, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1009_0003, 5); calld(0x100a_7491, 0x1_7489);           /* call 0x100a7491 */
            ii(0x1009_0008, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1009_000b, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1009_000e, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1009_0011, 2); jmpd(0x1009_0019, 0x6); goto l_0x1009_0019; /* jmp 0x10090019 */
        l_0x1009_0013:
            ii(0x1009_0013, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1009_0016, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
        l_0x1009_0019:
            ii(0x1009_0019, 3); mov(edx, memd_a32[ss, ebp - 0x5c]);     /* mov edx, [ebp-0x5c] */
            ii(0x1009_001c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_001f, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1009_0022, 5); calld(0x1009_c8f8, 0xc8d1);             /* call 0x1009c8f8 */
            ii(0x1009_0027, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_002a, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1009_002d, 5); calld(0x1009_c8c8, 0xc896);             /* call 0x1009c8c8 */
            ii(0x1009_0032, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_0034, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_0037, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_003a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_003d, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1009_0043, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x1009_0048, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1009_004a, 5); calld(0x100c_21b2, 0x3_2163);           /* call 0x100c21b2 */
        l_0x1009_004f:
            ii(0x1009_004f, 2); jmpd(0x1009_00a0, 0x4f); goto l_0x1009_00a0; /* jmp 0x100900a0 */
        l_0x1009_0051:
            ii(0x1009_0051, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_0054, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_0057, 5); calld(0x1007_6574, -0x1_9ae8);          /* call 0x10076574 */
            ii(0x1009_005c, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1009_0060, 2); if(jnzd(0x1009_006a, 0x8)) goto l_0x1009_006a; /* jnz 0x1009006a */
            ii(0x1009_0062, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_0065, 5); calld(0x1008_e07b, -0x1fef);            /* call 0x1008e07b */
        l_0x1009_006a:
            ii(0x1009_006a, 2); jmpd(0x1009_00a0, 0x34); goto l_0x1009_00a0; /* jmp 0x100900a0 */
        l_0x1009_006c:
            ii(0x1009_006c, 2); jmpd(0x1009_00a0, 0x32); goto l_0x1009_00a0; /* jmp 0x100900a0 */
        l_0x1009_006e:
            ii(0x1009_006e, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1009_0071, 3); mov(memb_a32[ss, ebp - 0x60], al);      /* mov [ebp-0x60], al */
            ii(0x1009_0074, 4); cmp(memb_a32[ss, ebp - 0x60], 0x7);     /* cmp byte [ebp-0x60], 0x7 */
            ii(0x1009_0078, 2); if(jbd(0x1009_0094, 0x1a)) goto l_0x1009_0094; /* jb 0x10090094 */
            ii(0x1009_007a, 4); cmp(memb_a32[ss, ebp - 0x60], 0x7);     /* cmp byte [ebp-0x60], 0x7 */
            ii(0x1009_007e, 6); if(jbed(0x1008_fdc4, -0x2c0)) goto l_0x1008_fdc4; /* jbe 0x1008fdc4 */
            ii(0x1009_0084, 4); cmp(memb_a32[ss, ebp - 0x60], 0xa);     /* cmp byte [ebp-0x60], 0xa */
            ii(0x1009_0088, 2); if(jbd(0x1009_0092, 0x8)) goto l_0x1009_0092; /* jb 0x10090092 */
            ii(0x1009_008a, 4); cmp(memb_a32[ss, ebp - 0x60], 0xb);     /* cmp byte [ebp-0x60], 0xb */
            ii(0x1009_008e, 2); if(jbed(0x1009_0051, -0x3f)) goto l_0x1009_0051; /* jbe 0x10090051 */
            ii(0x1009_0090, 2); jmpd(0x1009_006c, -0x26); goto l_0x1009_006c; /* jmp 0x1009006c */
        l_0x1009_0092:
            ii(0x1009_0092, 2); jmpd(0x1009_006c, -0x28); goto l_0x1009_006c; /* jmp 0x1009006c */
        l_0x1009_0094:
            ii(0x1009_0094, 4); cmp(memb_a32[ss, ebp - 0x60], 0x4);     /* cmp byte [ebp-0x60], 0x4 */
            ii(0x1009_0098, 6); if(jzd(0x1008_fd38, -0x366)) goto l_0x1008_fd38; /* jz 0x1008fd38 */
            ii(0x1009_009e, 2); jmpd(0x1009_006c, -0x34); goto l_0x1009_006c; /* jmp 0x1009006c */
        l_0x1009_00a0:
            ii(0x1009_00a0, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x1009_00a4:
            ii(0x1009_00a4, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1009_00a7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_00a9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_00aa, 1); popd(edi);                              /* pop edi */
            ii(0x1009_00ab, 1); popd(esi);                              /* pop esi */
            ii(0x1009_00ac, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_00ad, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_00ae, 1); retd(); return;                         /* ret */
        }
    }
}
