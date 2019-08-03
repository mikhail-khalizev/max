using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2776363d-dbb5-4456-b73f-d36774c4cb29")]
        public void Method_100e_71bd()
        {
            ii(0x100e_71bd, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x100e_71c2, 5); calld(Definitions.sys_check_available_stack_size, 0x7eb8b); /* call 0x10165d52 */
            ii(0x100e_71c7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_71c8, 1); pushd(esi);                             /* push esi */
            ii(0x100e_71c9, 1); pushd(edi);                             /* push edi */
            ii(0x100e_71ca, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_71cb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_71cd, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_71d3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_71d6, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100e_71d9, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100e_71dc, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100e_71e0, 2); if(jzd(0x100e_71f2, 0x10)) goto l_0x100e_71f2; /* jz 0x100e71f2 */
            ii(0x100e_71e2, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100e_71e5, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x100e_71e8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_71eb, 5); calld(0x1015_3297, 0x6c0a7);            /* call 0x10153297 */
            ii(0x100e_71f0, 2); jmpd(0x100e_7200, 0xe); goto l_0x100e_7200; /* jmp 0x100e7200 */
        l_0x100e_71f2:
            ii(0x100e_71f2, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100e_71f5, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x100e_71f8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_71fb, 5); calld(0x1015_31ef, 0x6bfef);            /* call 0x101531ef */
        l_0x100e_7200:
            ii(0x100e_7200, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_7203, 4); test(memb_a32[ds, eax + 0x14], 0x40);   /* test byte [eax+0x14], 0x40 */
            ii(0x100e_7207, 2); if(jzd(0x100e_7216, 0xd)) goto l_0x100e_7216; /* jz 0x100e7216 */
            ii(0x100e_7209, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_720c, 5); calld(0x1010_1103, 0x19ef2);            /* call 0x10101103 */
            ii(0x100e_7211, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100e_7214, 2); if(jnzd(0x100e_721b, 0x5)) goto l_0x100e_721b; /* jnz 0x100e721b */
        l_0x100e_7216:
            ii(0x100e_7216, 5); jmpd(0x100e_72da, 0xbf); goto l_0x100e_72da; /* jmp 0x100e72da */
        l_0x100e_721b:
            ii(0x100e_721b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_721e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_7220, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_7223, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_7225, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100e_722a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_722c, 2); if(jnzd(0x100e_725b, 0x2d)) goto l_0x100e_725b; /* jnz 0x100e725b */
            ii(0x100e_722e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_7231, 4); cmp(memb_a32[ds, eax + 0x3e], 0x2a);    /* cmp byte [eax+0x3e], 0x2a */
            ii(0x100e_7235, 2); if(jzd(0x100e_7240, 0x9)) goto l_0x100e_7240; /* jz 0x100e7240 */
            ii(0x100e_7237, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_723a, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1d);    /* cmp byte [eax+0x3e], 0x1d */
            ii(0x100e_723e, 2); if(jnzd(0x100e_7251, 0x11)) goto l_0x100e_7251; /* jnz 0x100e7251 */
        l_0x100e_7240:
            ii(0x100e_7240, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_7242, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_7245, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x100e_7248, 5); calld(0x1013_ad11, 0x53ac4);            /* call 0x1013ad11 */
            ii(0x100e_724d, 2); test(al, al);                           /* test al, al */
            ii(0x100e_724f, 2); if(jnzd(0x100e_7253, 0x2)) goto l_0x100e_7253; /* jnz 0x100e7253 */
        l_0x100e_7251:
            ii(0x100e_7251, 2); jmpd(0x100e_725b, 0x8); goto l_0x100e_725b; /* jmp 0x100e725b */
        l_0x100e_7253:
            ii(0x100e_7253, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_7256, 5); calld(0x100e_634b, -0xf10);             /* call 0x100e634b */
        l_0x100e_725b:
            ii(0x100e_725b, 7); cmp(memb_a32[ds, 0x101c_37cd], 0);      /* cmp byte [0x101c37cd], 0x0 */
            ii(0x100e_7262, 2); if(jnzd(0x100e_726d, 0x9)) goto l_0x100e_726d; /* jnz 0x100e726d */
            ii(0x100e_7264, 7); cmp(memb_a32[ds, 0x101c_37cc], 0);      /* cmp byte [0x101c37cc], 0x0 */
            ii(0x100e_726b, 2); if(jzd(0x100e_726f, 0x2)) goto l_0x100e_726f; /* jz 0x100e726f */
        l_0x100e_726d:
            ii(0x100e_726d, 2); jmpd(0x100e_7278, 0x9); goto l_0x100e_7278; /* jmp 0x100e7278 */
        l_0x100e_726f:
            ii(0x100e_726f, 7); cmp(memb_a32[ds, 0x101c_37ce], 0);      /* cmp byte [0x101c37ce], 0x0 */
            ii(0x100e_7276, 2); if(jzd(0x100e_727a, 0x2)) goto l_0x100e_727a; /* jz 0x100e727a */
        l_0x100e_7278:
            ii(0x100e_7278, 2); jmpd(0x100e_7283, 0x9); goto l_0x100e_7283; /* jmp 0x100e7283 */
        l_0x100e_727a:
            ii(0x100e_727a, 7); cmp(memb_a32[ds, 0x101c_37cf], 0);      /* cmp byte [0x101c37cf], 0x0 */
            ii(0x100e_7281, 2); if(jzd(0x100e_728e, 0xb)) goto l_0x100e_728e; /* jz 0x100e728e */
        l_0x100e_7283:
            ii(0x100e_7283, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_7286, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_7289, 5); calld(0x100e_68fb, -0x993);             /* call 0x100e68fb */
        l_0x100e_728e:
            ii(0x100e_728e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_7290, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_7295, 5); calld(0x1013_ad71, 0x53ad7);            /* call 0x1013ad71 */
            ii(0x100e_729a, 2); test(al, al);                           /* test al, al */
            ii(0x100e_729c, 2); if(jzd(0x100e_72b1, 0x13)) goto l_0x100e_72b1; /* jz 0x100e72b1 */
            ii(0x100e_729e, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_72a3, 5); calld(0x1007_6574, -0x70d34);           /* call 0x10076574 */
            ii(0x100e_72a8, 5); calld(0x1007_61d4, -0x710d9);           /* call 0x100761d4 */
            ii(0x100e_72ad, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_72af, 2); if(jnzd(0x100e_72b3, 0x2)) goto l_0x100e_72b3; /* jnz 0x100e72b3 */
        l_0x100e_72b1:
            ii(0x100e_72b1, 2); jmpd(0x100e_72d0, 0x1d); goto l_0x100e_72d0; /* jmp 0x100e72d0 */
        l_0x100e_72b3:
            ii(0x100e_72b3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_72b6, 5); calld(0x1007_61d4, -0x710e7);           /* call 0x100761d4 */
            ii(0x100e_72bb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_72bd, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_72c2, 5); calld(0x1007_6574, -0x70d53);           /* call 0x10076574 */
            ii(0x100e_72c7, 5); calld(0x1007_61d4, -0x710f8);           /* call 0x100761d4 */
            ii(0x100e_72cc, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_72ce, 2); if(jzd(0x100e_72d2, 0x2)) goto l_0x100e_72d2; /* jz 0x100e72d2 */
        l_0x100e_72d0:
            ii(0x100e_72d0, 2); jmpd(0x100e_72da, 0x8); goto l_0x100e_72da; /* jmp 0x100e72da */
        l_0x100e_72d2:
            ii(0x100e_72d2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_72d5, 5); calld(0x100e_6d36, -0x5a4);             /* call 0x100e6d36 */
        l_0x100e_72da:
            ii(0x100e_72da, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_72dd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_72df, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_72e2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_72e4, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100e_72e9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_72eb, 2); if(jnzd(0x100e_72f5, 0x8)) goto l_0x100e_72f5; /* jnz 0x100e72f5 */
            ii(0x100e_72ed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_72f0, 5); calld(0x100e_7004, -0x2f1);             /* call 0x100e7004 */
        l_0x100e_72f5:
            ii(0x100e_72f5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_72f8, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_72fd, 5); calld(0x1007_6e00, -0x70502);           /* call 0x10076e00 */
            ii(0x100e_7302, 2); test(al, al);                           /* test al, al */
            ii(0x100e_7304, 6); if(jzd(0x100e_73f2, 0xe8)) goto l_0x100e_73f2; /* jz 0x100e73f2 */
            ii(0x100e_730a, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100e_730f, 5); calld(0x100e_883d, 0x1529);             /* call 0x100e883d */
            ii(0x100e_7314, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x100e_7317, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_731a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_731f, 5); calld(0x1007_6574, -0x70db0);           /* call 0x10076574 */
            ii(0x100e_7324, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x100e_7328, 2); if(jzd(0x100e_7333, 0x9)) goto l_0x100e_7333; /* jz 0x100e7333 */
            ii(0x100e_732a, 7); mov(memd_a32[ss, ebp - 0x14], 0x40);    /* mov dword [ebp-0x14], 0x40 */
            ii(0x100e_7331, 2); jmpd(0x100e_733a, 0x7); goto l_0x100e_733a; /* jmp 0x100e733a */
        l_0x100e_7333:
            ii(0x100e_7333, 7); mov(memd_a32[ss, ebp - 0x14], 0x20);    /* mov dword [ebp-0x14], 0x20 */
        l_0x100e_733a:
            ii(0x100e_733a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_733f, 1); pushd(eax);                             /* push eax */
            ii(0x100e_7340, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_7345, 5); calld(0x1007_6574, -0x70dd6);           /* call 0x10076574 */
            ii(0x100e_734a, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100e_734d, 3); and(eax, 0x10);                         /* and eax, 0x10 */
            ii(0x100e_7350, 1); pushd(eax);                             /* push eax */
            ii(0x100e_7351, 6); pushd(memd_a32[ds, 0x101c_38c4]);       /* push dword [0x101c38c4] */
            ii(0x100e_7357, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_735a, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100e_735e, 1); dec(eax);                               /* dec eax */
            ii(0x100e_735f, 1); cwde();                                 /* cwde */
            ii(0x100e_7360, 1); pushd(eax);                             /* push eax */
            ii(0x100e_7361, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_7364, 4); mov(ax, memw_a32[ds, eax + 0x18]);      /* mov ax, [eax+0x18] */
            ii(0x100e_7368, 1); dec(eax);                               /* dec eax */
            ii(0x100e_7369, 1); cwde();                                 /* cwde */
            ii(0x100e_736a, 1); pushd(eax);                             /* push eax */
            ii(0x100e_736b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_736e, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100e_7371, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_7374, 1); pushd(eax);                             /* push eax */
            ii(0x100e_7375, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_7378, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100e_737b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_737e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_737f, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_7384, 5); calld(0x1007_6574, -0x70e15);           /* call 0x10076574 */
            ii(0x100e_7389, 3); mov(edx, memd_a32[ds, eax + 0x16]);     /* mov edx, [eax+0x16] */
            ii(0x100e_738c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_738f, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100e_7393, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_7395, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_7398, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_739a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_739d, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_73a3, 6); mov(edx, memd_a32[ds, 0x101c_38fc]);    /* mov edx, [0x101c38fc] */
            ii(0x100e_73a9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_73ac, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_73ae, 1); inc(eax);                               /* inc eax */
            ii(0x100e_73af, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_73b2, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_73b7, 5); calld(0x1007_6574, -0x70e48);           /* call 0x10076574 */
            ii(0x100e_73bc, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x100e_73bf, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_73c2, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100e_73c6, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_73c8, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_73cb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_73cd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_73d0, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_73d6, 6); mov(edx, memd_a32[ds, 0x101c_38fa]);    /* mov edx, [0x101c38fa] */
            ii(0x100e_73dc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_73df, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_73e1, 1); inc(eax);                               /* inc eax */
            ii(0x100e_73e2, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_73e5, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x100e_73ea, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_73ed, 5); calld(0x1010_2273, 0x1ae81);            /* call 0x10102273 */
        l_0x100e_73f2:
            ii(0x100e_73f2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_73f4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_73f5, 1); popd(edi);                              /* pop edi */
            ii(0x100e_73f6, 1); popd(esi);                              /* pop esi */
            ii(0x100e_73f7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_73f8, 1); retd(); return;                         /* ret */
        }
    }
}
