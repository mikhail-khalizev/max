using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a7e910cd-3ba1-46e7-9357-d97bc701a602")]
        public void Method_100f_f0ba()
        {
            ii(0x100f_f0ba, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100f_f0bf, 5); calld(Definitions.sys_check_available_stack_size, 0x66c8e); /* call 0x10165d52 */
            ii(0x100f_f0c4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_f0c5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_f0c6, 1); pushd(edx);                             /* push edx */
            ii(0x100f_f0c7, 1); pushd(esi);                             /* push esi */
            ii(0x100f_f0c8, 1); pushd(edi);                             /* push edi */
            ii(0x100f_f0c9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_f0ca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_f0cc, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100f_f0d2, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_f0d5, 4); cmp(memb_a32[ss, ebp - 0x4], 0xa);      /* cmp byte [ebp-0x4], 0xa */
            ii(0x100f_f0d9, 2); if(jnzd(0x100f_f0ea, 0xf)) goto l_0x100f_f0ea; /* jnz 0x100ff0ea */
            ii(0x100f_f0db, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100f_f0e0, 5); calld(0x1007_5fdc, -0x89109);           /* call 0x10075fdc */
            ii(0x100f_f0e5, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x100f_f0e8, 2); if(jzd(0x100f_f0ec, 0x2)) goto l_0x100f_f0ec; /* jz 0x100ff0ec */
        l_0x100f_f0ea:
            ii(0x100f_f0ea, 2); jmpd(0x100f_f0f2, 0x6); goto l_0x100f_f0f2; /* jmp 0x100ff0f2 */
        l_0x100f_f0ec:
            ii(0x100f_f0ec, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100f_f0f0, 2); jmpd(0x100f_f0f6, 0x4); goto l_0x100f_f0f6; /* jmp 0x100ff0f6 */
        l_0x100f_f0f2:
            ii(0x100f_f0f2, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x100f_f0f6:
            ii(0x100f_f0f6, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100f_f0f9, 5); mov(memb_a32[ds, 0x101c_3938], al);     /* mov [0x101c3938], al */
            ii(0x100f_f0fe, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x100f_f102, 5); calld(Definitions.my_game_map_start_animation, -0x1233); /* call 0x100fded4 */
            ii(0x100f_f107, 6); mov(ax, memw_a32[ds, 0x101c_37dc]);     /* mov ax, [0x101c37dc] */
            ii(0x100f_f10d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x100f_f110:
            ii(0x100f_f110, 7); cmp(memb_a32[ds, 0x101c_391e], 0x8);    /* cmp byte [0x101c391e], 0x8 */
            ii(0x100f_f117, 6); if(jnzd(0x100f_f530, 0x413)) goto l_0x100f_f530; /* jnz 0x100ff530 */
            ii(0x100f_f11d, 5); calld(0x100f_ef80, -0x1a2);             /* call 0x100fef80 */
            ii(0x100f_f122, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_f125, 5); mov(eax, memd_a32[ds, 0x101c_37da]);    /* mov eax, [0x101c37da] */
            ii(0x100f_f12a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_f12d, 5); calld(0x100f_32f7, -0xbe3b);            /* call 0x100f32f7 */
            ii(0x100f_f132, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f134, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100f_f139, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_f13c, 6); if(jnzd(0x100f_f38c, 0x24a)) goto l_0x100f_f38c; /* jnz 0x100ff38c */
            ii(0x100f_f142, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_f149, 2); if(jzd(0x100f_f183, 0x38)) goto l_0x100f_f183; /* jz 0x100ff183 */
            ii(0x100f_f14b, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
            ii(0x100f_f150, 5); calld(0x1007_5fdc, -0x89179);           /* call 0x10075fdc */
            ii(0x100f_f155, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_f157, 2); if(jzd(0x100f_f17e, 0x25)) goto l_0x100f_f17e; /* jz 0x100ff17e */
            ii(0x100f_f159, 5); calld(0x100c_aa00, -0x3475e);           /* call 0x100caa00 */
            ii(0x100f_f15e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_f163, 1); pushd(eax);                             /* push eax */
            ii(0x100f_f164, 5); calld(0x100c_aa20, -0x34749);           /* call 0x100caa20 */
            ii(0x100f_f169, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_f16b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_f16d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_f16f, 5); mov(eax, 0x101a_2a9a);                  /* mov eax, 0x101a2a9a */ /* "Starting announcement phase..." */
            ii(0x100f_f174, 5); calld(0x1011_5d23, 0x16baa);            /* call 0x10115d23 */
            ii(0x100f_f179, 5); calld(0x1012_a802, 0x2b684);            /* call 0x1012a802 */
        l_0x100f_f17e:
            ii(0x100f_f17e, 5); calld(0x1012_9753, 0x2a5d0);            /* call 0x10129753 */
        l_0x100f_f183:
            ii(0x100f_f183, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100f_f18a, 2); jmpd(0x100f_f192, 0x6); goto l_0x100f_f192; /* jmp 0x100ff192 */
        l_0x100f_f18c:
            ii(0x100f_f18c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_f18f, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100f_f192:
            ii(0x100f_f192, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f196, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_f199, 6); if(jged(0x100f_f205, 0x66)) goto l_0x100f_f205; /* jge 0x100ff205 */
            ii(0x100f_f19f, 4); cmp(memb_a32[ss, ebp - 0x4], 0xa);      /* cmp byte [ebp-0x4], 0xa */
            ii(0x100f_f1a3, 2); if(jzd(0x100f_f1b4, 0xf)) goto l_0x100f_f1b4; /* jz 0x100ff1b4 */
            ii(0x100f_f1a5, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100f_f1a9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f1ab, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_f1b0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_f1b2, 2); if(jnzd(0x100f_f1b6, 0x2)) goto l_0x100f_f1b6; /* jnz 0x100ff1b6 */
        l_0x100f_f1b4:
            ii(0x100f_f1b4, 2); jmpd(0x100f_f1ec, 0x36); goto l_0x100f_f1ec; /* jmp 0x100ff1ec */
        l_0x100f_f1b6:
            ii(0x100f_f1b6, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f1ba, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_f1c0, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_f1c6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_f1cb, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100f_f1ce, 2); if(jzd(0x100f_f1ea, 0x1a)) goto l_0x100f_f1ea; /* jz 0x100ff1ea */
            ii(0x100f_f1d0, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f1d4, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_f1da, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_f1e0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_f1e5, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100f_f1e8, 2); if(jnzd(0x100f_f1ec, 0x2)) goto l_0x100f_f1ec; /* jnz 0x100ff1ec */
        l_0x100f_f1ea:
            ii(0x100f_f1ea, 2); jmpd(0x100f_f1ee, 0x2); goto l_0x100f_f1ee; /* jmp 0x100ff1ee */
        l_0x100f_f1ec:
            ii(0x100f_f1ec, 2); jmpd(0x100f_f203, 0x15); goto l_0x100f_f203; /* jmp 0x100ff203 */
        l_0x100f_f1ee:
            ii(0x100f_f1ee, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100f_f1f1, 5); mov(memb_a32[ds, 0x101c_37c8], al);     /* mov [0x101c37c8], al */
            ii(0x100f_f1f6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f1f8, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_f1fd, 1); cwde();                                 /* cwde */
            ii(0x100f_f1fe, 5); calld(0x100f_2ec7, -0xc33c);            /* call 0x100f2ec7 */
        l_0x100f_f203:
            ii(0x100f_f203, 2); jmpd(0x100f_f18c, -0x79); goto l_0x100f_f18c; /* jmp 0x100ff18c */
        l_0x100f_f205:
            ii(0x100f_f205, 6); mov(memw_a32[ss, ebp - 0x14], 0);       /* mov word [ebp-0x14], 0x0 */
            ii(0x100f_f20b, 2); jmpd(0x100f_f214, 0x7); goto l_0x100f_f214; /* jmp 0x100ff214 */
        l_0x100f_f20d:
            ii(0x100f_f20d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_f210, 4); inc(memw_a32[ss, ebp - 0x14]);          /* inc word [ebp-0x14] */
        l_0x100f_f214:
            ii(0x100f_f214, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f218, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_f21b, 2); if(jged(0x100f_f253, 0x36)) goto l_0x100f_f253; /* jge 0x100ff253 */
            ii(0x100f_f21d, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100f_f221, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f223, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_f228, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_f22a, 2); if(jzd(0x100f_f246, 0x1a)) goto l_0x100f_f246; /* jz 0x100ff246 */
            ii(0x100f_f22c, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f230, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_f236, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_f23c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_f241, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100f_f244, 2); if(jzd(0x100f_f248, 0x2)) goto l_0x100f_f248; /* jz 0x100ff248 */
        l_0x100f_f246:
            ii(0x100f_f246, 2); jmpd(0x100f_f251, 0x9); goto l_0x100f_f251; /* jmp 0x100ff251 */
        l_0x100f_f248:
            ii(0x100f_f248, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f24c, 5); calld(0x100a_8a8d, -0x567c4);           /* call 0x100a8a8d */
        l_0x100f_f251:
            ii(0x100f_f251, 2); jmpd(0x100f_f20d, -0x46); goto l_0x100f_f20d; /* jmp 0x100ff20d */
        l_0x100f_f253:
            ii(0x100f_f253, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_f258, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x100f_f25c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f25e, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_f263, 1); cwde();                                 /* cwde */
            ii(0x100f_f264, 5); calld(0x100f_e750, -0xb19);             /* call 0x100fe750 */
            ii(0x100f_f269, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f26b, 5); calld(0x100f_fa70, 0x800);              /* call 0x100ffa70 */
            ii(0x100f_f270, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x100f_f277, 2); if(jnzd(0x100f_f282, 0x9)) goto l_0x100f_f282; /* jnz 0x100ff282 */
            ii(0x100f_f279, 5); calld(0x100f_ea2b, -0x853);             /* call 0x100fea2b */
            ii(0x100f_f27e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_f280, 2); if(jzd(0x100f_f284, 0x2)) goto l_0x100f_f284; /* jz 0x100ff284 */
        l_0x100f_f282:
            ii(0x100f_f282, 2); jmpd(0x100f_f2ea, 0x66); goto l_0x100f_f2ea; /* jmp 0x100ff2ea */
        l_0x100f_f284:
            ii(0x100f_f284, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_f28b, 2); if(jzd(0x100f_f2af, 0x22)) goto l_0x100f_f2af; /* jz 0x100ff2af */
            ii(0x100f_f28d, 5); calld(0x100c_aa00, -0x34892);           /* call 0x100caa00 */
            ii(0x100f_f292, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_f297, 1); pushd(eax);                             /* push eax */
            ii(0x100f_f298, 5); calld(0x100c_aa20, -0x3487d);           /* call 0x100caa20 */
            ii(0x100f_f29d, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_f29f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_f2a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_f2a3, 5); mov(eax, 0x101a_2ab9);                  /* mov eax, 0x101a2ab9 */ /* "Waiting for remote End Turn." */
            ii(0x100f_f2a8, 5); calld(0x1011_5d23, 0x16a76);            /* call 0x10115d23 */
            ii(0x100f_f2ad, 2); jmpd(0x100f_f2cf, 0x20); goto l_0x100f_f2cf; /* jmp 0x100ff2cf */
        l_0x100f_f2af:
            ii(0x100f_f2af, 5); calld(0x100c_aa00, -0x348b4);           /* call 0x100caa00 */
            ii(0x100f_f2b4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_f2b9, 1); pushd(eax);                             /* push eax */
            ii(0x100f_f2ba, 5); calld(0x100c_aa20, -0x3489f);           /* call 0x100caa20 */
            ii(0x100f_f2bf, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_f2c1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_f2c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_f2c5, 5); mov(eax, 0x101a_2ad6);                  /* mov eax, 0x101a2ad6 */ /* "Waiting for computer to finish turn." */
            ii(0x100f_f2ca, 5); calld(0x1011_5d23, 0x16a54);            /* call 0x10115d23 */
        l_0x100f_f2cf:
            ii(0x100f_f2cf, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x100f_f2d6, 2); if(jnzd(0x100f_f2e1, 0x9)) goto l_0x100f_f2e1; /* jnz 0x100ff2e1 */
            ii(0x100f_f2d8, 5); calld(0x100f_ea2b, -0x8b2);             /* call 0x100fea2b */
            ii(0x100f_f2dd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_f2df, 2); if(jzd(0x100f_f2e3, 0x2)) goto l_0x100f_f2e3; /* jz 0x100ff2e3 */
        l_0x100f_f2e1:
            ii(0x100f_f2e1, 2); jmpd(0x100f_f2ea, 0x7); goto l_0x100f_f2ea; /* jmp 0x100ff2ea */
        l_0x100f_f2e3:
            ii(0x100f_f2e3, 5); calld(0x1010_132c, 0x2044);             /* call 0x1010132c */
            ii(0x100f_f2e8, 2); jmpd(0x100f_f2cf, -0x1b); goto l_0x100f_f2cf; /* jmp 0x100ff2cf */
        l_0x100f_f2ea:
            ii(0x100f_f2ea, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x100f_f2f1, 2); if(jnzd(0x100f_f31a, 0x27)) goto l_0x100f_f31a; /* jnz 0x100ff31a */
            ii(0x100f_f2f3, 7); mov(memb_a32[ds, 0x101c_37c9], 0x2);    /* mov byte [0x101c37c9], 0x2 */
            ii(0x100f_f2fa, 5); calld(0x100f_53c7, -0x9f38);            /* call 0x100f53c7 */
        l_0x100f_f2ff:
            ii(0x100f_f2ff, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x100f_f306, 2); if(jnzd(0x100f_f311, 0x9)) goto l_0x100f_f311; /* jnz 0x100ff311 */
            ii(0x100f_f308, 5); calld(0x1007_57c7, -0x89b46);           /* call 0x100757c7 */
            ii(0x100f_f30d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_f30f, 2); if(jnzd(0x100f_f313, 0x2)) goto l_0x100f_f313; /* jnz 0x100ff313 */
        l_0x100f_f311:
            ii(0x100f_f311, 2); jmpd(0x100f_f31a, 0x7); goto l_0x100f_f31a; /* jmp 0x100ff31a */
        l_0x100f_f313:
            ii(0x100f_f313, 5); calld(0x1010_132c, 0x2014);             /* call 0x1010132c */
            ii(0x100f_f318, 2); jmpd(0x100f_f2ff, -0x1b); goto l_0x100f_f2ff; /* jmp 0x100ff2ff */
        l_0x100f_f31a:
            ii(0x100f_f31a, 7); mov(memb_a32[ds, 0x101c_37c9], 0x1);    /* mov byte [0x101c37c9], 0x1 */
            ii(0x100f_f321, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f323, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_f328, 1); cwde();                                 /* cwde */
            ii(0x100f_f329, 5); calld(0x100f_35f2, -0xbd3c);            /* call 0x100f35f2 */
            ii(0x100f_f32e, 7); cmp(memb_a32[ds, 0x101c_391e], 0xa);    /* cmp byte [0x101c391e], 0xa */
            ii(0x100f_f335, 2); if(jnzd(0x100f_f344, 0xd)) goto l_0x100f_f344; /* jnz 0x100ff344 */
            ii(0x100f_f337, 4); mov(memb_a32[ss, ebp - 0x4], 0xa);      /* mov byte [ebp-0x4], 0xa */
            ii(0x100f_f33b, 7); mov(memb_a32[ds, 0x101c_391e], 0x8);    /* mov byte [0x101c391e], 0x8 */
            ii(0x100f_f342, 2); jmpd(0x100f_f387, 0x43); goto l_0x100f_f387; /* jmp 0x100ff387 */
        l_0x100f_f344:
            ii(0x100f_f344, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x100f_f34b, 2); if(jnzd(0x100f_f387, 0x3a)) goto l_0x100f_f387; /* jnz 0x100ff387 */
            ii(0x100f_f34d, 6); mov(memw_a32[ss, ebp - 0x14], 0);       /* mov word [ebp-0x14], 0x0 */
            ii(0x100f_f353, 2); jmpd(0x100f_f35c, 0x7); goto l_0x100f_f35c; /* jmp 0x100ff35c */
        l_0x100f_f355:
            ii(0x100f_f355, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_f358, 4); inc(memw_a32[ss, ebp - 0x14]);          /* inc word [ebp-0x14] */
        l_0x100f_f35c:
            ii(0x100f_f35c, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f360, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_f363, 2); if(jged(0x100f_f383, 0x1e)) goto l_0x100f_f383; /* jge 0x100ff383 */
            ii(0x100f_f365, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f369, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_f36f, 7); cmp(memb_a32[ds, eax + 0x101c_a491], 0); /* cmp byte [eax+0x101ca491], 0x0 */
            ii(0x100f_f376, 2); if(jzd(0x100f_f381, 0x9)) goto l_0x100f_f381; /* jz 0x100ff381 */
            ii(0x100f_f378, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f37c, 5); calld(0x100f_edfc, -0x585);             /* call 0x100fedfc */
        l_0x100f_f381:
            ii(0x100f_f381, 2); jmpd(0x100f_f355, -0x2e); goto l_0x100f_f355; /* jmp 0x100ff355 */
        l_0x100f_f383:
            ii(0x100f_f383, 4); mov(memb_a32[ss, ebp - 0x4], 0x8);      /* mov byte [ebp-0x4], 0x8 */
        l_0x100f_f387:
            ii(0x100f_f387, 5); jmpd(0x100f_f4a8, 0x11c); goto l_0x100f_f4a8; /* jmp 0x100ff4a8 */
        l_0x100f_f38c:
            ii(0x100f_f38c, 4); cmp(memb_a32[ss, ebp - 0x4], 0xa);      /* cmp byte [ebp-0x4], 0xa */
            ii(0x100f_f390, 2); if(jnzd(0x100f_f39f, 0xd)) goto l_0x100f_f39f; /* jnz 0x100ff39f */
            ii(0x100f_f392, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f394, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_f399, 4); mov(memw_a32[ss, ebp - 0x14], ax);      /* mov [ebp-0x14], ax */
            ii(0x100f_f39d, 2); jmpd(0x100f_f3a5, 0x6); goto l_0x100f_f3a5; /* jmp 0x100ff3a5 */
        l_0x100f_f39f:
            ii(0x100f_f39f, 6); mov(memw_a32[ss, ebp - 0x14], 0);       /* mov word [ebp-0x14], 0x0 */
        l_0x100f_f3a5:
            ii(0x100f_f3a5, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x100f_f3a9, 2); jmpd(0x100f_f3b2, 0x7); goto l_0x100f_f3b2; /* jmp 0x100ff3b2 */
        l_0x100f_f3ab:
            ii(0x100f_f3ab, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_f3ae, 4); inc(memw_a32[ss, ebp - 0x14]);          /* inc word [ebp-0x14] */
        l_0x100f_f3b2:
            ii(0x100f_f3b2, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f3b6, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_f3b9, 6); if(jged(0x100f_f4a8, 0xe9)) goto l_0x100f_f4a8; /* jge 0x100ff4a8 */
            ii(0x100f_f3bf, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f3c3, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_f3c9, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_f3cf, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_f3d4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_f3d6, 2); if(jzd(0x100f_f3f2, 0x1a)) goto l_0x100f_f3f2; /* jz 0x100ff3f2 */
            ii(0x100f_f3d8, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f3dc, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_f3e2, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_f3e8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_f3ed, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_f3f0, 2); if(jnzd(0x100f_f3f7, 0x5)) goto l_0x100f_f3f7; /* jnz 0x100ff3f7 */
        l_0x100f_f3f2:
            ii(0x100f_f3f2, 5); jmpd(0x100f_f4a3, 0xac); goto l_0x100f_f4a3; /* jmp 0x100ff4a3 */
        l_0x100f_f3f7:
            ii(0x100f_f3f7, 4); cmp(memb_a32[ss, ebp - 0x4], 0xa);      /* cmp byte [ebp-0x4], 0xa */
            ii(0x100f_f3fb, 2); if(jzd(0x100f_f406, 0x9)) goto l_0x100f_f406; /* jz 0x100ff406 */
            ii(0x100f_f3fd, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f401, 5); calld(0x100f_edfc, -0x60a);             /* call 0x100fedfc */
        l_0x100f_f406:
            ii(0x100f_f406, 7); cmp(memb_a32[ds, 0x101c_3938], 0);      /* cmp byte [0x101c3938], 0x0 */
            ii(0x100f_f40d, 2); if(jzd(0x100f_f433, 0x24)) goto l_0x100f_f433; /* jz 0x100ff433 */
            ii(0x100f_f40f, 5); calld(0x1007_6054, -0x893c0);           /* call 0x10076054 */
            ii(0x100f_f414, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_f416, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100f_f418, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f41a, 5); mov(al, memb_a32[ds, 0x101c_3920]);     /* mov al, [0x101c3920] */
            ii(0x100f_f41f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_f422, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f426, 5); calld(0x1007_1d59, -0x8d6d2);           /* call 0x10071d59 */
            ii(0x100f_f42b, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100f_f42e, 5); mov(memb_a32[ds, 0x101c_37da], al);     /* mov [0x101c37da], al */
        l_0x100f_f433:
            ii(0x100f_f433, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x100f_f437, 6); imul(ebx, ebx, 0x247);                  /* imul ebx, ebx, 0x247 */
            ii(0x100f_f43d, 7); mov(memb_a32[ds, ebx + 0x101c_a491], 0); /* mov byte [ebx+0x101ca491], 0x0 */
            ii(0x100f_f444, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_f446, 3); mov(bl, memb_a32[ss, ebp - 0x18]);      /* mov bl, [ebp-0x18] */
            ii(0x100f_f449, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x100f_f44d, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f451, 5); calld(0x100f_e750, -0xd06);             /* call 0x100fe750 */
            ii(0x100f_f456, 7); cmp(memb_a32[ds, 0x101c_391e], 0xa);    /* cmp byte [0x101c391e], 0xa */
            ii(0x100f_f45d, 2); if(jnzd(0x100f_f46c, 0xd)) goto l_0x100f_f46c; /* jnz 0x100ff46c */
            ii(0x100f_f45f, 4); mov(memb_a32[ss, ebp - 0x4], 0xa);      /* mov byte [ebp-0x4], 0xa */
            ii(0x100f_f463, 7); mov(memb_a32[ds, 0x101c_391e], 0x8);    /* mov byte [0x101c391e], 0x8 */
            ii(0x100f_f46a, 2); jmpd(0x100f_f4a8, 0x3c); goto l_0x100f_f4a8; /* jmp 0x100ff4a8 */
        l_0x100f_f46c:
            ii(0x100f_f46c, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x100f_f473, 2); if(jnzd(0x100f_f4a1, 0x2c)) goto l_0x100f_f4a1; /* jnz 0x100ff4a1 */
            ii(0x100f_f475, 5); calld(0x100f_53c7, -0xa0b3);            /* call 0x100f53c7 */
        l_0x100f_f47a:
            ii(0x100f_f47a, 5); calld(0x1007_57c7, -0x89cb8);           /* call 0x100757c7 */
            ii(0x100f_f47f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_f481, 2); if(jzd(0x100f_f48a, 0x7)) goto l_0x100f_f48a; /* jz 0x100ff48a */
            ii(0x100f_f483, 5); calld(0x1010_132c, 0x1ea4);             /* call 0x1010132c */
            ii(0x100f_f488, 2); jmpd(0x100f_f47a, -0x10); goto l_0x100f_f47a; /* jmp 0x100ff47a */
        l_0x100f_f48a:
            ii(0x100f_f48a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_f48c, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_f491, 1); cwde();                                 /* cwde */
            ii(0x100f_f492, 5); calld(0x100f_35f2, -0xbea5);            /* call 0x100f35f2 */
            ii(0x100f_f497, 4); mov(memb_a32[ss, ebp - 0x4], 0x8);      /* mov byte [ebp-0x4], 0x8 */
            ii(0x100f_f49b, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
            ii(0x100f_f49f, 2); jmpd(0x100f_f4a3, 0x2); goto l_0x100f_f4a3; /* jmp 0x100ff4a3 */
        l_0x100f_f4a1:
            ii(0x100f_f4a1, 2); jmpd(0x100f_f4a8, 0x5); goto l_0x100f_f4a8; /* jmp 0x100ff4a8 */
        l_0x100f_f4a3:
            ii(0x100f_f4a3, 5); jmpd(0x100f_f3ab, -0xfd); goto l_0x100f_f3ab; /* jmp 0x100ff3ab */
        l_0x100f_f4a8:
            ii(0x100f_f4a8, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x100f_f4af, 6); if(jnzd(0x100f_f52b, 0x76)) goto l_0x100f_f52b; /* jnz 0x100ff52b */
            ii(0x100f_f4b5, 7); mov(memb_a32[ds, 0x101c_391e], 0x8);    /* mov byte [0x101c391e], 0x8 */
            ii(0x100f_f4bc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_f4be, 6); mov(bl, memb_a32[ds, 0x101c_3938]);     /* mov bl, [0x101c3938] */
            ii(0x100f_f4c4, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100f_f4c8, 5); mov(eax, memd_a32[ds, 0x101c_37da]);    /* mov eax, [0x101c37da] */
            ii(0x100f_f4cd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_f4d0, 5); calld(0x100e_efa5, -0x10530);           /* call 0x100eefa5 */
            ii(0x100f_f4d5, 2); test(al, al);                           /* test al, al */
            ii(0x100f_f4d7, 2); if(jnzd(0x100f_f530, 0x57)) goto l_0x100f_f530; /* jnz 0x100ff530 */
            ii(0x100f_f4d9, 6); mov(memw_a32[ss, ebp - 0x14], 0);       /* mov word [ebp-0x14], 0x0 */
            ii(0x100f_f4df, 2); jmpd(0x100f_f4e8, 0x7); goto l_0x100f_f4e8; /* jmp 0x100ff4e8 */
        l_0x100f_f4e1:
            ii(0x100f_f4e1, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_f4e4, 4); inc(memw_a32[ss, ebp - 0x14]);          /* inc word [ebp-0x14] */
        l_0x100f_f4e8:
            ii(0x100f_f4e8, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f4ec, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_f4ef, 2); if(jged(0x100f_f517, 0x26)) goto l_0x100f_f517; /* jge 0x100ff517 */
            ii(0x100f_f4f1, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f4f5, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_f4fb, 7); cmp(memb_a32[ds, eax + 0x101c_a491], 0); /* cmp byte [eax+0x101ca491], 0x0 */
            ii(0x100f_f502, 2); if(jzd(0x100f_f515, 0x11)) goto l_0x100f_f515; /* jz 0x100ff515 */
            ii(0x100f_f504, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_f508, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_f50e, 7); mov(memb_a32[ds, eax + 0x101c_a491], 0); /* mov byte [eax+0x101ca491], 0x0 */
        l_0x100f_f515:
            ii(0x100f_f515, 2); jmpd(0x100f_f4e1, -0x36); goto l_0x100f_f4e1; /* jmp 0x100ff4e1 */
        l_0x100f_f517:
            ii(0x100f_f517, 5); calld(0x100f_eeec, -0x630);             /* call 0x100feeec */
            ii(0x100f_f51c, 6); inc(memd_a32[ds, 0x101c_37dc]);         /* inc dword [0x101c37dc] */
            ii(0x100f_f522, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100f_f526, 5); calld(0x100f_f049, -0x4e2);             /* call 0x100ff049 */
        l_0x100f_f52b:
            ii(0x100f_f52b, 5); jmpd(0x100f_f110, -0x420); goto l_0x100f_f110; /* jmp 0x100ff110 */
        l_0x100f_f530:
            ii(0x100f_f530, 5); calld(0x100f_eac0, -0xa75);             /* call 0x100feac0 */
            ii(0x100f_f535, 7); cmp(memb_a32[ds, 0x101c_391e], 0xf);    /* cmp byte [0x101c391e], 0xf */
            ii(0x100f_f53c, 2); if(jnzd(0x100f_f548, 0xa)) goto l_0x100f_f548; /* jnz 0x100ff548 */
            ii(0x100f_f53e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_f543, 5); calld(0x100e_f3a0, -0x101a8);           /* call 0x100ef3a0 */
        l_0x100f_f548:
            ii(0x100f_f548, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_f54a, 5); mov(edx, 0x6a5);                        /* mov edx, 0x6a5 */
            ii(0x100f_f54f, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_f554, 5); calld(0x1013_cf8e, 0x3da35);            /* call 0x1013cf8e */
            ii(0x100f_f559, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_f55b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_f55c, 1); popd(edi);                              /* pop edi */
            ii(0x100f_f55d, 1); popd(esi);                              /* pop esi */
            ii(0x100f_f55e, 1); popd(edx);                              /* pop edx */
            ii(0x100f_f55f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_f560, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_f561, 1); retd(); return;                         /* ret */
        }
    }
}
