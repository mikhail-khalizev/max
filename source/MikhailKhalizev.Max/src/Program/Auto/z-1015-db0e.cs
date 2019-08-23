using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_db0e-82aa723e")]
        public void Method_1015_db0e()
        {
            ii(0x1015_db0e, 5); push(0x40);                             /* push 0x40 */
            ii(0x1015_db13, 5); call(Definitions.sys_check_available_stack_size, 0x823a); /* call 0x10165d52 */
            ii(0x1015_db18, 1); push(ebx);                              /* push ebx */
            ii(0x1015_db19, 1); push(ecx);                              /* push ecx */
            ii(0x1015_db1a, 1); push(edx);                              /* push edx */
            ii(0x1015_db1b, 1); push(esi);                              /* push esi */
            ii(0x1015_db1c, 1); push(edi);                              /* push edi */
            ii(0x1015_db1d, 1); push(ebp);                              /* push ebp */
            ii(0x1015_db1e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_db20, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1015_db26, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_db29, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1015_db2d, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_db33, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1015_db39, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_db3e, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1015_db41, 2); if(jz(0x1015_db5c, 0x19)) goto l_0x1015_db5c; /* jz 0x1015db5c */
            ii(0x1015_db43, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1015_db47, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_db4d, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1015_db53, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_db58, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_db5a, 2); if(jnz(0x1015_db65, 0x9)) goto l_0x1015_db65; /* jnz 0x1015db65 */
        l_0x1015_db5c:
            ii(0x1015_db5c, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_db60, 5); jmp(0x1015_de25, 0x2c0); goto l_0x1015_de25; /* jmp 0x1015de25 */
        l_0x1015_db65:
            ii(0x1015_db65, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_db67, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1015_db6b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_db6e, 5); mov(ebx, 0x101c_94b4);                  /* mov ebx, 0x101c94b4 */
            ii(0x1015_db73, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1015_db75, 5); call(0x1013_ad71, -0x2_2e09);           /* call 0x1013ad71 */
            ii(0x1015_db7a, 2); test(al, al);                           /* test al, al */
            ii(0x1015_db7c, 6); if(jz(0x1015_dc9b, 0x119)) goto l_0x1015_dc9b; /* jz 0x1015dc9b */
            ii(0x1015_db82, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1015_db86, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_db89, 5); mov(edx, 0x101c_94b4);                  /* mov edx, 0x101c94b4 */
            ii(0x1015_db8e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_db90, 5); call(0x1007_65d0, -0xe_75c5);           /* call 0x100765d0 */
            ii(0x1015_db95, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_db98, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_db9b, 5); call(0x1007_60e4, -0xe_7abc);           /* call 0x100760e4 */
            ii(0x1015_dba0, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1015_dba3, 3); mov(ebx, memd[ss, ebp - 0x18]);         /* mov ebx, [ebp-0x18] */
            ii(0x1015_dba6, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1015_dba9, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_dbac, 5); call(0x1015_d9b1, -0x200);              /* call 0x1015d9b1 */
            ii(0x1015_dbb1, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_dbb4, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1015_dbb7, 4); mov(memw[ds, edx + 0x41], ax);          /* mov [edx+0x41], ax */
            ii(0x1015_dbbb, 3); mov(eax, memd[ss, ebp - 0x1a]);         /* mov eax, [ebp-0x1a] */
            ii(0x1015_dbbe, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1015_dbc1, 4); mov(memw[ds, edx + 0x43], ax);          /* mov [edx+0x43], ax */
            ii(0x1015_dbc5, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_dbc8, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_dbcb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_dbd0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_dbd6, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1015_dbdc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_dbe1, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1015_dbe4, 2); if(jnz(0x1015_dbf4, 0xe)) goto l_0x1015_dbf4; /* jnz 0x1015dbf4 */
            ii(0x1015_dbe6, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_dbe9, 5); call(0x1007_623c, -0xe_79b2);           /* call 0x1007623c */
            ii(0x1015_dbee, 4); cmp(memb[ds, eax + 0x16], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x1015_dbf2, 2); if(jnz(0x1015_dbf6, 0x2)) goto l_0x1015_dbf6; /* jnz 0x1015dbf6 */
        l_0x1015_dbf4:
            ii(0x1015_dbf4, 2); jmp(0x1015_dc06, 0x10); goto l_0x1015_dc06; /* jmp 0x1015dc06 */
        l_0x1015_dbf6:
            ii(0x1015_dbf6, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_dbf9, 3); mov(al, memb[ds, eax + 0x50]);          /* mov al, [eax+0x50] */
            ii(0x1015_dbfc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_dc01, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1015_dc04, 2); if(jz(0x1015_dc08, 0x2)) goto l_0x1015_dc08; /* jz 0x1015dc08 */
        l_0x1015_dc06:
            ii(0x1015_dc06, 2); jmp(0x1015_dc19, 0x11); goto l_0x1015_dc19; /* jmp 0x1015dc19 */
        l_0x1015_dc08:
            ii(0x1015_dc08, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_dc0b, 4); mov(memb[ds, eax + 0x3d], 0);           /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_dc0f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_dc11, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_dc14, 5); call(0x1007_60ac, -0xe_7b6d);           /* call 0x100760ac */
        l_0x1015_dc19:
            ii(0x1015_dc19, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_dc1b, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1015_dc20, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_dc23, 5); call(0x1016_3053, 0x542b);              /* call 0x10163053 */
            ii(0x1015_dc28, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_dc2b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_dc2d, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1015_dc30, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_dc32, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1015_dc37, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_dc39, 2); if(jnz(0x1015_dc4c, 0x11)) goto l_0x1015_dc4c; /* jnz 0x1015dc4c */
            ii(0x1015_dc3b, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_dc40, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_dc43, 5); call(0x1008_b4b4, -0xd_2794);           /* call 0x1008b4b4 */
            ii(0x1015_dc48, 2); test(al, al);                           /* test al, al */
            ii(0x1015_dc4a, 2); if(jnz(0x1015_dc4e, 0x2)) goto l_0x1015_dc4e; /* jnz 0x1015dc4e */
        l_0x1015_dc4c:
            ii(0x1015_dc4c, 2); jmp(0x1015_dc5b, 0xd); goto l_0x1015_dc5b; /* jmp 0x1015dc5b */
        l_0x1015_dc4e:
            ii(0x1015_dc4e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_dc51, 5); call(0x1010_1103, -0x5_cb53);           /* call 0x10101103 */
            ii(0x1015_dc56, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1015_dc59, 2); if(jz(0x1015_dc5d, 0x2)) goto l_0x1015_dc5d; /* jz 0x1015dc5d */
        l_0x1015_dc5b:
            ii(0x1015_dc5b, 2); jmp(0x1015_dc79, 0x1c); goto l_0x1015_dc79; /* jmp 0x1015dc79 */
        l_0x1015_dc5d:
            ii(0x1015_dc5d, 5); call(0x100d_5470, -0x8_87f2);           /* call 0x100d5470 */
            ii(0x1015_dc62, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1015_dc65, 5); mov(ebx, 0x409);                        /* mov ebx, 0x409 */
            ii(0x1015_dc6a, 5); mov(edx, 0x406);                        /* mov edx, 0x406 */
            ii(0x1015_dc6f, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_dc74, 5); call(0x1013_daea, -0x2_018f);           /* call 0x1013daea */
        l_0x1015_dc79:
            ii(0x1015_dc79, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_dc7e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_dc81, 5); call(0x1007_6d98, -0xe_6eee);           /* call 0x10076d98 */
            ii(0x1015_dc86, 2); test(al, al);                           /* test al, al */
            ii(0x1015_dc88, 2); if(jz(0x1015_dc92, 0x8)) goto l_0x1015_dc92; /* jz 0x1015dc92 */
            ii(0x1015_dc8a, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_dc8d, 5); call(0x1010_094d, -0x5_d345);           /* call 0x1010094d */
        l_0x1015_dc92:
            ii(0x1015_dc92, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_dc96, 5); jmp(0x1015_de25, 0x18a); goto l_0x1015_de25; /* jmp 0x1015de25 */
        l_0x1015_dc9b:
            ii(0x1015_dc9b, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1015_dca2, 2); jmp(0x1015_dcaa, 0x6); goto l_0x1015_dcaa; /* jmp 0x1015dcaa */
        l_0x1015_dca4:
            ii(0x1015_dca4, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_dca7, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x1015_dcaa:
            ii(0x1015_dcaa, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_dcae, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1015_dcb1, 6); if(jge(0x1015_de21, 0x16a)) goto l_0x1015_de21; /* jge 0x1015de21 */
            ii(0x1015_dcb7, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_dcba, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1015_dcbe, 6); if(jz(0x1015_de1c, 0x158)) goto l_0x1015_de1c; /* jz 0x1015de1c */
            ii(0x1015_dcc4, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x1015_dcc8, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_dccb, 5); call(0x1007_64fc, -0xe_77d4);           /* call 0x100764fc */
            ii(0x1015_dcd0, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1015_dcd3, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1015_dcd7, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_dcdb, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1015_dcde, 5); mov(edx, 0x101c_9480);                  /* mov edx, 0x101c9480 */
            ii(0x1015_dce3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_dce5, 5); call(0x1007_6338, -0xe_79b2);           /* call 0x10076338 */
            ii(0x1015_dcea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_dcec, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_dcef, 5); call(0x1007_643c, -0xe_78b8);           /* call 0x1007643c */
            ii(0x1015_dcf4, 2); jmp(0x1015_dcfe, 0x8); goto l_0x1015_dcfe; /* jmp 0x1015dcfe */
        l_0x1015_dcf6:
            ii(0x1015_dcf6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_dcf9, 5); call(0x1007_6bf8, -0xe_7106);           /* call 0x10076bf8 */
        l_0x1015_dcfe:
            ii(0x1015_dcfe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_dd00, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_dd03, 5); call(0x1013_ad71, -0x2_2f97);           /* call 0x1013ad71 */
            ii(0x1015_dd08, 2); test(al, al);                           /* test al, al */
            ii(0x1015_dd0a, 2); if(jz(0x1015_dd59, 0x4d)) goto l_0x1015_dd59; /* jz 0x1015dd59 */
            ii(0x1015_dd0c, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1015_dd10, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_dd13, 5); call(0x1007_63a0, -0xe_7978);           /* call 0x100763a0 */
            ii(0x1015_dd18, 5); call(0x1007_6074, -0xe_7ca9);           /* call 0x10076074 */
            ii(0x1015_dd1d, 2); test(al, al);                           /* test al, al */
            ii(0x1015_dd1f, 2); if(jz(0x1015_dd42, 0x21)) goto l_0x1015_dd42; /* jz 0x1015dd42 */
            ii(0x1015_dd21, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_dd24, 5); call(0x1007_6408, -0xe_7921);           /* call 0x10076408 */
            ii(0x1015_dd29, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_dd2b, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1015_dd2f, 3); imul(ebx, eax, 0xa);                    /* imul ebx, eax, 0xa */
            ii(0x1015_dd32, 5); mov(eax, 0x101c_9480);                  /* mov eax, 0x101c9480 */
            ii(0x1015_dd37, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1015_dd39, 5); call(0x1015_d921, -0x41d);              /* call 0x1015d921 */
            ii(0x1015_dd3e, 2); test(al, al);                           /* test al, al */
            ii(0x1015_dd40, 2); if(jnz(0x1015_dd44, 0x2)) goto l_0x1015_dd44; /* jnz 0x1015dd44 */
        l_0x1015_dd42:
            ii(0x1015_dd42, 2); jmp(0x1015_dd57, 0x13); goto l_0x1015_dd57; /* jmp 0x1015dd57 */
        l_0x1015_dd44:
            ii(0x1015_dd44, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_dd48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_dd4a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_dd4d, 5); call(0x1007_5f6c, -0xe_7de6);           /* call 0x10075f6c */
            ii(0x1015_dd52, 5); jmp(0x1015_de25, 0xce); goto l_0x1015_de25; /* jmp 0x1015de25 */
        l_0x1015_dd57:
            ii(0x1015_dd57, 2); jmp(0x1015_dcf6, -0x63); goto l_0x1015_dcf6; /* jmp 0x1015dcf6 */
        l_0x1015_dd59:
            ii(0x1015_dd59, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_dd5d, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1015_dd60, 5); mov(edx, 0x101c_9480);                  /* mov edx, 0x101c9480 */
            ii(0x1015_dd65, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_dd67, 5); call(0x1007_6338, -0xe_7a34);           /* call 0x10076338 */
            ii(0x1015_dd6c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_dd6e, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_dd71, 5); call(0x1007_643c, -0xe_793a);           /* call 0x1007643c */
            ii(0x1015_dd76, 2); jmp(0x1015_dd80, 0x8); goto l_0x1015_dd80; /* jmp 0x1015dd80 */
        l_0x1015_dd78:
            ii(0x1015_dd78, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_dd7b, 5); call(0x1007_6bf8, -0xe_7188);           /* call 0x10076bf8 */
        l_0x1015_dd80:
            ii(0x1015_dd80, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_dd82, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_dd85, 5); call(0x1013_ad71, -0x2_3019);           /* call 0x1013ad71 */
            ii(0x1015_dd8a, 2); test(al, al);                           /* test al, al */
            ii(0x1015_dd8c, 6); if(jz(0x1015_de12, 0x80)) goto l_0x1015_de12; /* jz 0x1015de12 */
            ii(0x1015_dd92, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1015_dd96, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_dd99, 5); call(0x1007_63a0, -0xe_79fe);           /* call 0x100763a0 */
            ii(0x1015_dd9e, 5); call(0x1007_6074, -0xe_7d2f);           /* call 0x10076074 */
            ii(0x1015_dda3, 2); test(al, al);                           /* test al, al */
            ii(0x1015_dda5, 2); if(jz(0x1015_de0d, 0x66)) goto l_0x1015_de0d; /* jz 0x1015de0d */
            ii(0x1015_dda7, 5); mov(ebx, 0x101c_8184);                  /* mov ebx, 0x101c8184 */
            ii(0x1015_ddac, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ddaf, 5); call(0x1007_6408, -0xe_79ac);           /* call 0x10076408 */
            ii(0x1015_ddb4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_ddb6, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1015_ddba, 5); call(0x1015_d879, -0x546);              /* call 0x1015d879 */
            ii(0x1015_ddbf, 2); test(al, al);                           /* test al, al */
            ii(0x1015_ddc1, 2); if(jnz(0x1015_dddf, 0x1c)) goto l_0x1015_dddf; /* jnz 0x1015dddf */
            ii(0x1015_ddc3, 5); mov(ebx, 0x101c_81a8);                  /* mov ebx, 0x101c81a8 */
            ii(0x1015_ddc8, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_ddcb, 5); call(0x1007_6408, -0xe_79c8);           /* call 0x10076408 */
            ii(0x1015_ddd0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_ddd2, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1015_ddd6, 5); call(0x1015_d879, -0x562);              /* call 0x1015d879 */
            ii(0x1015_dddb, 2); test(al, al);                           /* test al, al */
            ii(0x1015_dddd, 2); if(jz(0x1015_dde1, 0x2)) goto l_0x1015_dde1; /* jz 0x1015dde1 */
        l_0x1015_dddf:
            ii(0x1015_dddf, 2); jmp(0x1015_ddfd, 0x1c); goto l_0x1015_ddfd; /* jmp 0x1015ddfd */
        l_0x1015_dde1:
            ii(0x1015_dde1, 5); mov(ebx, 0x101c_819c);                  /* mov ebx, 0x101c819c */
            ii(0x1015_dde6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_dde9, 5); call(0x1007_6408, -0xe_79e6);           /* call 0x10076408 */
            ii(0x1015_ddee, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_ddf0, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1015_ddf4, 5); call(0x1015_d879, -0x580);              /* call 0x1015d879 */
            ii(0x1015_ddf9, 2); test(al, al);                           /* test al, al */
            ii(0x1015_ddfb, 2); if(jz(0x1015_de0d, 0x10)) goto l_0x1015_de0d; /* jz 0x1015de0d */
        l_0x1015_ddfd:
            ii(0x1015_ddfd, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_de01, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_de03, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_de06, 5); call(0x1007_5f6c, -0xe_7e9f);           /* call 0x10075f6c */
            ii(0x1015_de0b, 2); jmp(0x1015_de25, 0x18); goto l_0x1015_de25; /* jmp 0x1015de25 */
        l_0x1015_de0d:
            ii(0x1015_de0d, 5); jmp(0x1015_dd78, -0x9a); goto l_0x1015_dd78; /* jmp 0x1015dd78 */
        l_0x1015_de12:
            ii(0x1015_de12, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_de14, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_de17, 5); call(0x1007_5f6c, -0xe_7eb0);           /* call 0x10075f6c */
        l_0x1015_de1c:
            ii(0x1015_de1c, 5); jmp(0x1015_dca4, -0x17d); goto l_0x1015_dca4; /* jmp 0x1015dca4 */
        l_0x1015_de21:
            ii(0x1015_de21, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_de25:
            ii(0x1015_de25, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1015_de28, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_de2a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_de2b, 1); pop(edi);                               /* pop edi */
            ii(0x1015_de2c, 1); pop(esi);                               /* pop esi */
            ii(0x1015_de2d, 1); pop(edx);                               /* pop edx */
            ii(0x1015_de2e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_de2f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_de30, 1); ret();                                  /* ret */
        }
    }
}
