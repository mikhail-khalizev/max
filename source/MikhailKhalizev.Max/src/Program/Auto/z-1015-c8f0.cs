using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_c8f0-340d79e6")]
        public void Method_1015_c8f0()
        {
            ii(0x1015_c8f0, 5); push(0x40);                             /* push 0x40 */
            ii(0x1015_c8f5, 5); call(Definitions.sys_check_available_stack_size, 0x9458); /* call 0x10165d52 */
            ii(0x1015_c8fa, 1); push(ebx);                              /* push ebx */
            ii(0x1015_c8fb, 1); push(ecx);                              /* push ecx */
            ii(0x1015_c8fc, 1); push(edx);                              /* push edx */
            ii(0x1015_c8fd, 1); push(esi);                              /* push esi */
            ii(0x1015_c8fe, 1); push(edi);                              /* push edi */
            ii(0x1015_c8ff, 1); push(ebp);                              /* push ebp */
            ii(0x1015_c900, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_c902, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1015_c908, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1015_c90b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_c90e, 5); call(0x1007_611c, -0xe_67f7);           /* call 0x1007611c */
            ii(0x1015_c913, 3); lea(ebx, memd[ss, ebp - 16]);           /* lea ebx, [ebp-0x10] */
            ii(0x1015_c916, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c918, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_c91a, 5); call(0x1007_66ac, -0xe_6273);           /* call 0x100766ac */
            ii(0x1015_c91f, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1015_c922, 5); call(0x1007_6600, -0xe_6327);           /* call 0x10076600 */
            ii(0x1015_c927, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1015_c92a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_c92d, 3); mov(ebx, memd[ds, eax + 58]);           /* mov ebx, [eax+0x3a] */
            ii(0x1015_c930, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x1015_c933, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1015_c936, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_c939, 5); call(0x1015_c75a, -0x1e4);              /* call 0x1015c75a */
            ii(0x1015_c93e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_c941, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1015_c944, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1015_c947, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_c94a, 3); cmp(dl, memb[ds, eax + 38]);            /* cmp dl, [eax+0x26] */
            ii(0x1015_c94d, 2); if(jnz(0x1015_c965, 0x16)) goto l_0x1015_c965; /* jnz 0x1015c965 */
            ii(0x1015_c94f, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x1015_c956, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_c958, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1015_c95b, 5); call(0x1007_5f2c, -0xe_6a34);           /* call 0x10075f2c */
            ii(0x1015_c960, 5); jmp(0x1015_cbbe, 0x259); goto l_0x1015_cbbe; /* jmp 0x1015cbbe */
        l_0x1015_c965:
            ii(0x1015_c965, 7); cmp(memb[ds, 0x101c_3915], 0);          /* cmp byte [0x101c3915], 0x0 */
            ii(0x1015_c96c, 2); if(jnz(0x1015_c9aa, 0x3c)) goto l_0x1015_c9aa; /* jnz 0x1015c9aa */
            ii(0x1015_c96e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_c971, 3); dec(memb[ds, eax + 80]);                /* dec byte [eax+0x50] */
            ii(0x1015_c974, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_c977, 3); mov(al, memb[ds, eax + 80]);            /* mov al, [eax+0x50] */
            ii(0x1015_c97a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_c97f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c981, 2); if(jnz(0x1015_c98a, 7)) goto l_0x1015_c98a; /* jnz 0x1015c98a */
            ii(0x1015_c983, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_c986, 4); mov(memb[ds, eax + 87], 0);             /* mov byte [eax+0x57], 0x0 */
        l_0x1015_c98a:
            ii(0x1015_c98a, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_c98f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_c992, 5); call(0x1007_6d98, -0xe_5bff);           /* call 0x10076d98 */
            ii(0x1015_c997, 2); test(al, al);                           /* test al, al */
            ii(0x1015_c999, 2); if(jz(0x1015_c9aa, 0xf)) goto l_0x1015_c9aa; /* jz 0x1015c9aa */
            ii(0x1015_c99b, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1015_c9a0, 5); call(0x1007_65d0, -0xe_63d5);           /* call 0x100765d0 */
            ii(0x1015_c9a5, 5); call(0x100f_f637, -0x5_d373);           /* call 0x100ff637 */
        l_0x1015_c9aa:
            ii(0x1015_c9aa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_c9ad, 4); mov(ax, memw[ds, eax + 65]);            /* mov ax, [eax+0x41] */
            ii(0x1015_c9b1, 4); cmp(ax, memw[ss, ebp - 8]);             /* cmp ax, [ebp-0x8] */
            ii(0x1015_c9b5, 2); if(jg(0x1015_c9fd, 0x46)) goto l_0x1015_c9fd; /* jg 0x1015c9fd */
            ii(0x1015_c9b7, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1015_c9ba, 4); cmp(memb[ds, eax + 61], 0x1a);          /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1015_c9be, 2); if(jz(0x1015_c9c7, 7)) goto l_0x1015_c9c7; /* jz 0x1015c9c7 */
            ii(0x1015_c9c0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_c9c3, 4); inc(memw[ds, eax + 82]);                /* inc word [eax+0x52] */
        l_0x1015_c9c7:
            ii(0x1015_c9c7, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_c9cc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_c9cf, 5); call(0x1007_6d98, -0xe_5c3c);           /* call 0x10076d98 */
            ii(0x1015_c9d4, 2); test(al, al);                           /* test al, al */
            ii(0x1015_c9d6, 2); if(jz(0x1015_c9e7, 0xf)) goto l_0x1015_c9e7; /* jz 0x1015c9e7 */
            ii(0x1015_c9d8, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1015_c9dd, 5); call(0x1007_65d0, -0xe_6412);           /* call 0x100765d0 */
            ii(0x1015_c9e2, 5); call(0x100f_f637, -0x5_d3b0);           /* call 0x100ff637 */
        l_0x1015_c9e7:
            ii(0x1015_c9e7, 7); mov(memd[ss, ebp - 20], 1);             /* mov dword [ebp-0x14], 0x1 */
            ii(0x1015_c9ee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_c9f0, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1015_c9f3, 5); call(0x1007_5f2c, -0xe_6acc);           /* call 0x10075f2c */
            ii(0x1015_c9f8, 5); jmp(0x1015_cbbe, 0x1c1); goto l_0x1015_cbbe; /* jmp 0x1015cbbe */
        l_0x1015_c9fd:
            ii(0x1015_c9fd, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1015_ca00, 5); call(0x1007_6574, -0xe_6491);           /* call 0x10076574 */
            ii(0x1015_ca05, 4); cmp(memb[ds, eax + 61], 0x1a);          /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1015_ca09, 6); if(jnz(0x1015_ca9f, 0x90)) goto l_0x1015_ca9f; /* jnz 0x1015ca9f */
            ii(0x1015_ca0f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_ca12, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_ca14, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1015_ca17, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_ca19, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1015_ca1e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_ca20, 2); if(jnz(0x1015_ca89, 0x67)) goto l_0x1015_ca89; /* jnz 0x1015ca89 */
            ii(0x1015_ca22, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_ca25, 4); cmp(memb[ds, eax + 61], 0x18);          /* cmp byte [eax+0x3d], 0x18 */
            ii(0x1015_ca29, 2); if(jnz(0x1015_ca5b, 0x30)) goto l_0x1015_ca5b; /* jnz 0x1015ca5b */
            ii(0x1015_ca2b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_ca2e, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x1015_ca31, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_ca34, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_ca37, 3); mov(edx, memd[ds, edx + 24]);           /* mov edx, [edx+0x18] */
            ii(0x1015_ca3a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_ca3d, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1015_ca40, 5); call(0x1007_6aac, -0xe_5f99);           /* call 0x10076aac */
            ii(0x1015_ca45, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x1015_ca47, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1015_ca4a, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1015_ca4f, 5); mov(eax, StringDefinitions.UnableToCaptureEnemyUnit); /* mov eax, 0x101b278a */
            ii(0x1015_ca54, 5); call(0x1011_5b60, -0x4_6ef9);           /* call 0x10115b60 */
            ii(0x1015_ca59, 2); jmp(0x1015_ca89, 0x2e); goto l_0x1015_ca89; /* jmp 0x1015ca89 */
        l_0x1015_ca5b:
            ii(0x1015_ca5b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_ca5e, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x1015_ca61, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_ca64, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_ca67, 3); mov(edx, memd[ds, edx + 24]);           /* mov edx, [edx+0x18] */
            ii(0x1015_ca6a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_ca6d, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1015_ca70, 5); call(0x1007_6aac, -0xe_5fc9);           /* call 0x10076aac */
            ii(0x1015_ca75, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x1015_ca77, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1015_ca7a, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1015_ca7f, 5); mov(eax, StringDefinitions.UnableToDisableEnemyUnit2); /* mov eax, 0x101b27a8 */
            ii(0x1015_ca84, 5); call(0x1011_5b60, -0x4_6f29);           /* call 0x10115b60 */
        l_0x1015_ca89:
            ii(0x1015_ca89, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x1015_ca90, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_ca92, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1015_ca95, 5); call(0x1007_5f2c, -0xe_6b6e);           /* call 0x10075f2c */
            ii(0x1015_ca9a, 5); jmp(0x1015_cbbe, 0x11f); goto l_0x1015_cbbe; /* jmp 0x1015cbbe */
        l_0x1015_ca9f:
            ii(0x1015_ca9f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1015_caa2, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1015_caa5, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_caa7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_caaa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_caad, 5); call(0x1014_f634, -0xd47e);             /* call 0x1014f634 */
            ii(0x1015_cab2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cab5, 5); call(0x1007_15df, -0xe_b4db);           /* call 0x100715df */
            ii(0x1015_caba, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cabd, 5); call(0x1014_9fa8, -0x1_2b1a);           /* call 0x10149fa8 */
            ii(0x1015_cac2, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1015_cac5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_cac7, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1015_caca, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_cacc, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1015_cad1, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_cad3, 2); if(jnz(0x1015_caff, 0x2a)) goto l_0x1015_caff; /* jnz 0x1015caff */
            ii(0x1015_cad5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cad8, 4); cmp(memb[ds, eax + 61], 0x18);          /* cmp byte [eax+0x3d], 0x18 */
            ii(0x1015_cadc, 2); if(jnz(0x1015_caed, 0xf)) goto l_0x1015_caed; /* jnz 0x1015caed */
            ii(0x1015_cade, 5); mov(edx, 4);                            /* mov edx, 0x4 */
            ii(0x1015_cae3, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1015_cae6, 5); call(0x100f_3c32, -0x6_8eb9);           /* call 0x100f3c32 */
            ii(0x1015_caeb, 2); jmp(0x1015_cafa, 0xd); goto l_0x1015_cafa; /* jmp 0x1015cafa */
        l_0x1015_caed:
            ii(0x1015_caed, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x1015_caf2, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1015_caf5, 5); call(0x100f_3c32, -0x6_8ec8);           /* call 0x100f3c32 */
        l_0x1015_cafa:
            ii(0x1015_cafa, 5); jmp(0x1015_cb99, 0x9a); goto l_0x1015_cb99; /* jmp 0x1015cb99 */
        l_0x1015_caff:
            ii(0x1015_caff, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cb02, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_cb04, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1015_cb07, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_cb09, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1015_cb0e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_cb10, 6); if(jnz(0x1015_cb99, 0x83)) goto l_0x1015_cb99; /* jnz 0x1015cb99 */
            ii(0x1015_cb16, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cb19, 4); cmp(memb[ds, eax + 61], 0x18);          /* cmp byte [eax+0x3d], 0x18 */
            ii(0x1015_cb1d, 2); if(jnz(0x1015_cb4f, 0x30)) goto l_0x1015_cb4f; /* jnz 0x1015cb4f */
            ii(0x1015_cb1f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cb22, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x1015_cb25, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_cb28, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_cb2b, 3); mov(edx, memd[ds, edx + 24]);           /* mov edx, [edx+0x18] */
            ii(0x1015_cb2e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_cb31, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1015_cb34, 5); call(0x1007_6aac, -0xe_608d);           /* call 0x10076aac */
            ii(0x1015_cb39, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x1015_cb3b, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1015_cb3e, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1015_cb43, 5); mov(eax, StringDefinitions.UnableToCaptureEnemyUnit2); /* mov eax, 0x101b27c6 */
            ii(0x1015_cb48, 5); call(0x1011_5b60, -0x4_6fed);           /* call 0x10115b60 */
            ii(0x1015_cb4d, 2); jmp(0x1015_cb7d, 0x2e); goto l_0x1015_cb7d; /* jmp 0x1015cb7d */
        l_0x1015_cb4f:
            ii(0x1015_cb4f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cb52, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x1015_cb55, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_cb58, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_cb5b, 3); mov(edx, memd[ds, edx + 24]);           /* mov edx, [edx+0x18] */
            ii(0x1015_cb5e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_cb61, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1015_cb64, 5); call(0x1007_6aac, -0xe_60bd);           /* call 0x10076aac */
            ii(0x1015_cb69, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x1015_cb6b, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1015_cb6e, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1015_cb73, 5); mov(eax, StringDefinitions.UnableToDisableEnemyUnit); /* mov eax, 0x101b27e4 */
            ii(0x1015_cb78, 5); call(0x1011_5b60, -0x4_701d);           /* call 0x10115b60 */
        l_0x1015_cb7d:
            ii(0x1015_cb7d, 5); call(0x100d_5470, -0x8_7712);           /* call 0x100d5470 */
            ii(0x1015_cb82, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1015_cb85, 5); mov(ebx, 0x3d0);                        /* mov ebx, 0x3d0 */
            ii(0x1015_cb8a, 5); mov(edx, 0x3cb);                        /* mov edx, 0x3cb */
            ii(0x1015_cb8f, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_cb94, 5); call(0x1013_daea, -0x1_f0af);           /* call 0x1013daea */
        l_0x1015_cb99:
            ii(0x1015_cb99, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cb9c, 5); call(0x1015_c802, -0x39f);              /* call 0x1015c802 */
            ii(0x1015_cba1, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x1015_cba8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_cbaa, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1015_cbad, 5); call(0x1007_5f2c, -0xe_6c86);           /* call 0x10075f2c */
            ii(0x1015_cbb2, 2); jmp(0x1015_cbbe, 0xa); goto l_0x1015_cbbe; /* jmp 0x1015cbbe */
        //  ii(0x1015_cbb4, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1015_cbb6, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
        //  ii(0x1015_cbb9, 5); call(0x1007_5f2c, -0xe_6c92);           /* call 0x10075f2c */
        l_0x1015_cbbe:
            ii(0x1015_cbbe, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1015_cbc1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_cbc3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_cbc4, 1); pop(edi);                               /* pop edi */
            ii(0x1015_cbc5, 1); pop(esi);                               /* pop esi */
            ii(0x1015_cbc6, 1); pop(edx);                               /* pop edx */
            ii(0x1015_cbc7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_cbc8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_cbc9, 1); ret();                                  /* ret */
        }
    }
}
