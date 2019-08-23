using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_dbbd-6e515761")]
        public void Method_1008_dbbd()
        {
            ii(0x1008_dbbd, 5); push(0x30);                             /* push 0x30 */
            ii(0x1008_dbc2, 5); call(Definitions.sys_check_available_stack_size, 0xd_818b); /* call 0x10165d52 */
            ii(0x1008_dbc7, 1); push(ebx);                              /* push ebx */
            ii(0x1008_dbc8, 1); push(ecx);                              /* push ecx */
            ii(0x1008_dbc9, 1); push(edx);                              /* push edx */
            ii(0x1008_dbca, 1); push(esi);                              /* push esi */
            ii(0x1008_dbcb, 1); push(edi);                              /* push edi */
            ii(0x1008_dbcc, 1); push(ebp);                              /* push ebp */
            ii(0x1008_dbcd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_dbcf, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_dbd5, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_dbd8, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1008_dbdb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dbde, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_dbe1, 5); call(0x1007_6574, -0x1_7672);           /* call 0x10076574 */
            ii(0x1008_dbe6, 5); call(0x1015_0a5f, 0xc_2e74);            /* call 0x10150a5f */
            ii(0x1008_dbeb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dbee, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_dbf1, 5); call(0x1007_6b90, -0x1_7066);           /* call 0x10076b90 */
            ii(0x1008_dbf6, 1); cwde();                                 /* cwde */
            ii(0x1008_dbf7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_dbf9, 2); if(jle(0x1008_dc0a, 0xf)) goto l_0x1008_dc0a; /* jle 0x1008dc0a */
            ii(0x1008_dbfb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_dbfd, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_dc00, 5); call(0x1008_8b04, -0x5101);             /* call 0x10088b04 */
            ii(0x1008_dc05, 5); jmp(0x1008_df35, 0x32b); goto l_0x1008_df35; /* jmp 0x1008df35 */
        l_0x1008_dc0a:
            ii(0x1008_dc0a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_dc0d, 4); mov(memb[ds, edx + 0x25], 0x9);         /* mov byte [edx+0x25], 0x9 */
            ii(0x1008_dc11, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_dc14, 3); mov(eax, memd[ds, edx + 0x11]);         /* mov eax, [edx+0x11] */
            ii(0x1008_dc17, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_dc1a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_dc1d, 3); mov(edx, memd[ds, edx + 0x7]);          /* mov edx, [edx+0x7] */
            ii(0x1008_dc20, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_dc23, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1008_dc29, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x1008_dc2e, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1008_dc30, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_dc32, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_dc34, 5); call(0x100d_fd2c, 0x5_20f3);            /* call 0x100dfd2c */
            ii(0x1008_dc39, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_dc3b, 5); call(0x100a_314c, 0x1_550c);            /* call 0x100a314c */
            ii(0x1008_dc40, 4); cmp(ax, memw[ds, edx + 0x8]);           /* cmp ax, [edx+0x8] */
            ii(0x1008_dc44, 2); if(jge(0x1008_dc5d, 0x17)) goto l_0x1008_dc5d; /* jge 0x1008dc5d */
            ii(0x1008_dc46, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dc49, 5); call(0x1008_df3e, 0x2f0);               /* call 0x1008df3e */
            ii(0x1008_dc4e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_dc50, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_dc53, 5); call(0x1008_8b04, -0x5154);             /* call 0x10088b04 */
            ii(0x1008_dc58, 5); jmp(0x1008_df35, 0x2d8); goto l_0x1008_df35; /* jmp 0x1008df35 */
        l_0x1008_dc5d:
            ii(0x1008_dc5d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1008_dc62, 1); push(eax);                              /* push eax */
            ii(0x1008_dc63, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dc66, 3); mov(ecx, memd[ds, eax + 0x21]);         /* mov ecx, [eax+0x21] */
            ii(0x1008_dc69, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1008_dc6c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dc6f, 3); mov(ebx, memd[ds, eax + 0x1f]);         /* mov ebx, [eax+0x1f] */
            ii(0x1008_dc72, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_dc75, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dc78, 3); mov(edx, memd[ds, eax + 0x7]);          /* mov edx, [eax+0x7] */
            ii(0x1008_dc7b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_dc7e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dc81, 3); mov(eax, memd[ds, eax + 0x11]);         /* mov eax, [eax+0x11] */
            ii(0x1008_dc84, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_dc87, 5); call(0x1007_02b9, -0x1_d9d3);           /* call 0x100702b9 */
            ii(0x1008_dc8c, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1008_dc8f, 2); if(jnz(0x1008_dca8, 0x17)) goto l_0x1008_dca8; /* jnz 0x1008dca8 */
            ii(0x1008_dc91, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dc94, 5); call(0x1008_df3e, 0x2a5);               /* call 0x1008df3e */
            ii(0x1008_dc99, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_dc9b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_dc9e, 5); call(0x1008_8b04, -0x519f);             /* call 0x10088b04 */
            ii(0x1008_dca3, 5); jmp(0x1008_df35, 0x28d); goto l_0x1008_df35; /* jmp 0x1008df35 */
        l_0x1008_dca8:
            ii(0x1008_dca8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_dcaa, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dcad, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_dcb0, 5); call(0x1013_ad71, 0xa_d0bc);            /* call 0x1013ad71 */
            ii(0x1008_dcb5, 2); test(al, al);                           /* test al, al */
            ii(0x1008_dcb7, 2); if(jz(0x1008_dcd7, 0x1e)) goto l_0x1008_dcd7; /* jz 0x1008dcd7 */
            ii(0x1008_dcb9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dcbc, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_dcbf, 5); call(0x1008_af28, -0x2d9c);             /* call 0x1008af28 */
            ii(0x1008_dcc4, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_dcc7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_dcca, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x1008_dccd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_dcd0, 3); call_abs(memd[ds, edx + 0x24]);         /* call dword [edx+0x24] */
            ii(0x1008_dcd3, 2); test(al, al);                           /* test al, al */
            ii(0x1008_dcd5, 2); if(jz(0x1008_dcd9, 0x2)) goto l_0x1008_dcd9; /* jz 0x1008dcd9 */
        l_0x1008_dcd7:
            ii(0x1008_dcd7, 2); jmp(0x1008_dcf0, 0x17); goto l_0x1008_dcf0; /* jmp 0x1008dcf0 */
        l_0x1008_dcd9:
            ii(0x1008_dcd9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dcdc, 5); call(0x1008_df3e, 0x25d);               /* call 0x1008df3e */
            ii(0x1008_dce1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_dce3, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_dce6, 5); call(0x1008_8b04, -0x51e7);             /* call 0x10088b04 */
            ii(0x1008_dceb, 5); jmp(0x1008_df35, 0x245); goto l_0x1008_df35; /* jmp 0x1008df35 */
        l_0x1008_dcf0:
            ii(0x1008_dcf0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dcf3, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_dcf6, 5); call(0x1007_6574, -0x1_7787);           /* call 0x10076574 */
            ii(0x1008_dcfb, 5); call(0x1015_26ac, 0xc_49ac);            /* call 0x101526ac */
            ii(0x1008_dd00, 3); cmp(eax, memd[ss, ebp - 0x4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1008_dd03, 2); if(jz(0x1008_dd1b, 0x16)) goto l_0x1008_dd1b; /* jz 0x1008dd1b */
            ii(0x1008_dd05, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dd08, 4); mov(memb[ds, eax + 0x25], 0x7);         /* mov byte [eax+0x25], 0x7 */
            ii(0x1008_dd0c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_dd0e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_dd11, 5); call(0x1008_8b04, -0x5212);             /* call 0x10088b04 */
            ii(0x1008_dd16, 5); jmp(0x1008_df35, 0x21a); goto l_0x1008_df35; /* jmp 0x1008df35 */
        l_0x1008_dd1b:
            ii(0x1008_dd1b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dd1e, 5); call(0x1008_f52c, 0x1809);              /* call 0x1008f52c */
            ii(0x1008_dd23, 2); test(al, al);                           /* test al, al */
            ii(0x1008_dd25, 2); if(jz(0x1008_dd36, 0xf)) goto l_0x1008_dd36; /* jz 0x1008dd36 */
            ii(0x1008_dd27, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_dd29, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_dd2c, 5); call(0x1008_8b04, -0x522d);             /* call 0x10088b04 */
            ii(0x1008_dd31, 5); jmp(0x1008_df35, 0x1ff); goto l_0x1008_df35; /* jmp 0x1008df35 */
        l_0x1008_dd36:
            ii(0x1008_dd36, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dd39, 5); call(0x1008_e1b5, 0x477);               /* call 0x1008e1b5 */
            ii(0x1008_dd3e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_dd40, 2); if(jz(0x1008_dd51, 0xf)) goto l_0x1008_dd51; /* jz 0x1008dd51 */
            ii(0x1008_dd42, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_dd44, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_dd47, 5); call(0x1008_8b04, -0x5248);             /* call 0x10088b04 */
            ii(0x1008_dd4c, 5); jmp(0x1008_df35, 0x1e4); goto l_0x1008_df35; /* jmp 0x1008df35 */
        l_0x1008_dd51:
            ii(0x1008_dd51, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dd54, 5); call(0x1008_e39c, 0x643);               /* call 0x1008e39c */
            ii(0x1008_dd59, 2); test(al, al);                           /* test al, al */
            ii(0x1008_dd5b, 2); if(jz(0x1008_dd6c, 0xf)) goto l_0x1008_dd6c; /* jz 0x1008dd6c */
            ii(0x1008_dd5d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_dd5f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_dd62, 5); call(0x1008_8b04, -0x5263);             /* call 0x10088b04 */
            ii(0x1008_dd67, 5); jmp(0x1008_df35, 0x1c9); goto l_0x1008_df35; /* jmp 0x1008df35 */
        l_0x1008_dd6c:
            ii(0x1008_dd6c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1008_dd6e, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1008_dd73, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_dd76, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x1008_dd79, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_dd7c, 5); call(0x1007_5e64, -0x1_7f1d);           /* call 0x10075e64 */
            ii(0x1008_dd81, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_dd83, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dd86, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_dd89, 5); call(0x1008_abbc, -0x31d2);             /* call 0x1008abbc */
            ii(0x1008_dd8e, 5); call(0x100a_90f9, 0x1_b366);            /* call 0x100a90f9 */
            ii(0x1008_dd93, 2); test(al, al);                           /* test al, al */
            ii(0x1008_dd95, 2); if(jz(0x1008_ddc7, 0x30)) goto l_0x1008_ddc7; /* jz 0x1008ddc7 */
            ii(0x1008_dd97, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1008_dd9c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dd9f, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_dda2, 5); call(0x1007_65d0, -0x1_77d7);           /* call 0x100765d0 */
            ii(0x1008_dda7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_dda9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ddac, 5); call(0x100a_3671, 0x1_58c0);            /* call 0x100a3671 */
            ii(0x1008_ddb1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ddb4, 4); mov(memb[ds, eax + 0x25], 0x7);         /* mov byte [eax+0x25], 0x7 */
            ii(0x1008_ddb8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_ddba, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_ddbd, 5); call(0x1008_8b04, -0x52be);             /* call 0x10088b04 */
            ii(0x1008_ddc2, 5); jmp(0x1008_df35, 0x16e); goto l_0x1008_df35; /* jmp 0x1008df35 */
        l_0x1008_ddc7:
            ii(0x1008_ddc7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ddca, 5); call(0x1008_fa3b, 0x1c6c);              /* call 0x1008fa3b */
            ii(0x1008_ddcf, 2); test(al, al);                           /* test al, al */
            ii(0x1008_ddd1, 2); if(jnz(0x1008_dde2, 0xf)) goto l_0x1008_dde2; /* jnz 0x1008dde2 */
            ii(0x1008_ddd3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_ddd5, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_ddd8, 5); call(0x1008_8b04, -0x52d9);             /* call 0x10088b04 */
            ii(0x1008_dddd, 5); jmp(0x1008_df35, 0x153); goto l_0x1008_df35; /* jmp 0x1008df35 */
        l_0x1008_dde2:
            ii(0x1008_dde2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_dde4, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x1008_dde9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_ddeb, 2); if(jnz(0x1008_de02, 0x15)) goto l_0x1008_de02; /* jnz 0x1008de02 */
            ii(0x1008_dded, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ddf0, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_ddf3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_ddf6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_ddf8, 6); mov(dl, memb[ds, 0x101c_37c8]);         /* mov dl, [0x101c37c8] */
            ii(0x1008_ddfe, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_de00, 2); if(jnz(0x1008_de04, 0x2)) goto l_0x1008_de04; /* jnz 0x1008de04 */
        l_0x1008_de02:
            ii(0x1008_de02, 2); jmp(0x1008_de13, 0xf); goto l_0x1008_de13; /* jmp 0x1008de13 */
        l_0x1008_de04:
            ii(0x1008_de04, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_de06, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_de09, 5); call(0x1008_8b04, -0x530a);             /* call 0x10088b04 */
            ii(0x1008_de0e, 5); jmp(0x1008_df35, 0x122); goto l_0x1008_df35; /* jmp 0x1008df35 */
        l_0x1008_de13:
            ii(0x1008_de13, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_de16, 5); call(0x1009_caf8, 0xecdd);              /* call 0x1009caf8 */
            ii(0x1008_de1b, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_de1e, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x1008_de21, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_de24, 5); call(0x1008_b2a8, -0x2b81);             /* call 0x1008b2a8 */
            ii(0x1008_de29, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1008_de2e, 5); call(0x1007_5fdc, -0x1_7e57);           /* call 0x10075fdc */
            ii(0x1008_de33, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1008_de36, 2); if(jl(0x1008_de86, 0x4e)) goto l_0x1008_de86; /* jl 0x1008de86 */
            ii(0x1008_de38, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_de3b, 5); cmp(memw[ds, eax + 0x13], 0x28);        /* cmp word [eax+0x13], 0x28 */
            ii(0x1008_de40, 2); if(jz(0x1008_de84, 0x42)) goto l_0x1008_de84; /* jz 0x1008de84 */
            ii(0x1008_de42, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_de45, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_de48, 5); call(0x1007_6574, -0x1_78d9);           /* call 0x10076574 */
            ii(0x1008_de4d, 5); call(0x1007_623c, -0x1_7c16);           /* call 0x1007623c */
            ii(0x1008_de52, 3); mov(edx, memd[ds, eax + 0x17]);         /* mov edx, [eax+0x17] */
            ii(0x1008_de55, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_de58, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_de5b, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_de5e, 5); call(0x1007_6574, -0x1_78ef);           /* call 0x10076574 */
            ii(0x1008_de63, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1008_de66, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_de69, 3); sub(edx, 0x2);                          /* sub edx, 0x2 */
            ii(0x1008_de6c, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1008_de6e, 2); if(jl(0x1008_de82, 0x12)) goto l_0x1008_de82; /* jl 0x1008de82 */
            ii(0x1008_de70, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_de73, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_de76, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_de79, 5); call(0x100a_5c69, 0x1_7deb);            /* call 0x100a5c69 */
            ii(0x1008_de7e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_de80, 2); if(jz(0x1008_de84, 0x2)) goto l_0x1008_de84; /* jz 0x1008de84 */
        l_0x1008_de82:
            ii(0x1008_de82, 2); jmp(0x1008_de86, 0x2); goto l_0x1008_de86; /* jmp 0x1008de86 */
        l_0x1008_de84:
            ii(0x1008_de84, 2); jmp(0x1008_de88, 0x2); goto l_0x1008_de88; /* jmp 0x1008de88 */
        l_0x1008_de86:
            ii(0x1008_de86, 2); jmp(0x1008_de9f, 0x17); goto l_0x1008_de9f; /* jmp 0x1008de9f */
        l_0x1008_de88:
            ii(0x1008_de88, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1008_de8d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_de90, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_de93, 5); call(0x1007_6574, -0x1_7924);           /* call 0x10076574 */
            ii(0x1008_de98, 5); call(0x1009_c970, 0xead3);              /* call 0x1009c970 */
            ii(0x1008_de9d, 2); jmp(0x1008_deb4, 0x15); goto l_0x1008_deb4; /* jmp 0x1008deb4 */
        l_0x1008_de9f:
            ii(0x1008_de9f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_dea4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dea7, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_deaa, 5); call(0x1007_6574, -0x1_793b);           /* call 0x10076574 */
            ii(0x1008_deaf, 5); call(0x1009_c970, 0xeabc);              /* call 0x1009c970 */
        l_0x1008_deb4:
            ii(0x1008_deb4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_deb7, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_deba, 5); call(0x1007_6574, -0x1_794b);           /* call 0x10076574 */
            ii(0x1008_debf, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_dec2, 4); mov(dx, memw[ds, edx + 0x21]);          /* mov dx, [edx+0x21] */
            ii(0x1008_dec6, 4); mov(memw[ds, eax + 0x41], dx);          /* mov [eax+0x41], dx */
            ii(0x1008_deca, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_decd, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_ded0, 5); call(0x1007_6574, -0x1_7961);           /* call 0x10076574 */
            ii(0x1008_ded5, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_ded8, 4); mov(dx, memw[ds, edx + 0x23]);          /* mov dx, [edx+0x23] */
            ii(0x1008_dedc, 4); mov(memw[ds, eax + 0x43], dx);          /* mov [eax+0x43], dx */
            ii(0x1008_dee0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_dee2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_dee5, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_dee8, 5); call(0x1007_6574, -0x1_7979);           /* call 0x10076574 */
            ii(0x1008_deed, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1008_def0, 5); call(0x1007_6a34, -0x1_74c1);           /* call 0x10076a34 */
            ii(0x1008_def5, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1008_defc, 2); if(jz(0x1008_df0e, 0x10)) goto l_0x1008_df0e; /* jz 0x1008df0e */
            ii(0x1008_defe, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_df01, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_df04, 5); call(0x1007_65d0, -0x1_7939);           /* call 0x100765d0 */
            ii(0x1008_df09, 5); call(0x1012_ae8d, 0x9_cf7f);            /* call 0x1012ae8d */
        l_0x1008_df0e:
            ii(0x1008_df0e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_df11, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_df14, 5); call(0x1007_6574, -0x1_79a5);           /* call 0x10076574 */
            ii(0x1008_df19, 5); call(0x1015_2387, 0xc_4469);            /* call 0x10152387 */
            ii(0x1008_df1e, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_df23, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_df26, 5); call(0x100a_2a04, 0x1_4ad9);            /* call 0x100a2a04 */
            ii(0x1008_df2b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_df2d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_df30, 5); call(0x1008_8b04, -0x5431);             /* call 0x10088b04 */
        l_0x1008_df35:
            ii(0x1008_df35, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_df37, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_df38, 1); pop(edi);                               /* pop edi */
            ii(0x1008_df39, 1); pop(esi);                               /* pop esi */
            ii(0x1008_df3a, 1); pop(edx);                               /* pop edx */
            ii(0x1008_df3b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_df3c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_df3d, 1); ret();                                  /* ret */
        }
    }
}
