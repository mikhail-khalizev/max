using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_daed-cb1881cb")]
        public void Method_100a_daed()
        {
            ii(0x100a_daed, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x100a_daf2, 5); calld(Definitions.sys_check_available_stack_size, 0xb_825b); /* call 0x10165d52 */
            ii(0x100a_daf7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_daf8, 1); pushd(esi);                             /* push esi */
            ii(0x100a_daf9, 1); pushd(edi);                             /* push edi */
            ii(0x100a_dafa, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_dafb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_dafd, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x100a_db03, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_db06, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_db09, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_db0c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_db0f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_db12, 5); calld(0x1007_5e64, -0x3_7cb3);          /* call 0x10075e64 */
            ii(0x100a_db17, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100a_db1a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_db1d, 5); calld(0x100b_8204, 0xa6e2);             /* call 0x100b8204 */
            ii(0x100a_db22, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100a_db29, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_db2d, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x100a_db31, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100a_db38, 2); jmpd(0x100a_db40, 0x6); goto l_0x100a_db40; /* jmp 0x100adb40 */
        l_0x100a_db3a:
            ii(0x100a_db3a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_db3d, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x100a_db40:
            ii(0x100a_db40, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_db43, 5); calld(0x100b_82bc, 0xa774);             /* call 0x100b82bc */
            ii(0x100a_db48, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x100a_db4c, 6); if(jled(0x100a_dc18, 0xc6)) goto l_0x100a_dc18; /* jle 0x100adc18 */
            ii(0x100a_db52, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_db56, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_db59, 5); calld(0x100b_827c, 0xa71e);             /* call 0x100b827c */
            ii(0x100a_db5e, 4); movsx(ax, memb_a32[ds, eax]);           /* movsx ax, byte [eax] */
            ii(0x100a_db62, 4); add(memw_a32[ss, ebp - 0x24], ax);      /* add [ebp-0x24], ax */
            ii(0x100a_db66, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_db6a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_db6d, 5); calld(0x100b_827c, 0xa70a);             /* call 0x100b827c */
            ii(0x100a_db72, 5); movsx(ax, memb_a32[ds, eax + 0x1]);     /* movsx ax, byte [eax+0x1] */
            ii(0x100a_db77, 4); add(memw_a32[ss, ebp - 0x22], ax);      /* add [ebp-0x22], ax */
            ii(0x100a_db7b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_db7d, 1); pushd(eax);                             /* push eax */
            ii(0x100a_db7e, 4); movsx(ecx, memw_a32[ss, ebp - 0x22]);   /* movsx ecx, word [ebp-0x22] */
            ii(0x100a_db82, 4); movsx(ebx, memw_a32[ss, ebp - 0x24]);   /* movsx ebx, word [ebp-0x24] */
            ii(0x100a_db86, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_db89, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x100a_db8c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_db8f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_db92, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_db95, 5); calld(0x1007_6574, -0x3_7626);          /* call 0x10076574 */
            ii(0x100a_db9a, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_db9d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_dba0, 5); calld(0x1007_02b9, -0x3_d8ec);          /* call 0x100702b9 */
            ii(0x100a_dba5, 1); cwde();                                 /* cwde */
            ii(0x100a_dba6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_dba8, 2); if(jnzd(0x100a_dbf9, 0x4f)) goto l_0x100a_dbf9; /* jnz 0x100adbf9 */
            ii(0x100a_dbaa, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100a_dbae, 2); if(jnzd(0x100a_dbf1, 0x41)) goto l_0x100a_dbf1; /* jnz 0x100adbf1 */
            ii(0x100a_dbb0, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_dbb4, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_dbb7, 5); calld(0x100b_827c, 0xa6c0);             /* call 0x100b827c */
            ii(0x100a_dbbc, 4); movsx(dx, memb_a32[ds, eax]);           /* movsx dx, byte [eax] */
            ii(0x100a_dbc0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dbc3, 3); mov(ebx, memd_a32[ss, ebp - 0x24]);     /* mov ebx, [ebp-0x24] */
            ii(0x100a_dbc6, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x100a_dbc8, 4); mov(memw_a32[ds, eax + 0x1e], bx);      /* mov [eax+0x1e], bx */
            ii(0x100a_dbcc, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_dbd0, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_dbd3, 5); calld(0x100b_827c, 0xa6a4);             /* call 0x100b827c */
            ii(0x100a_dbd8, 5); movsx(dx, memb_a32[ds, eax + 0x1]);     /* movsx dx, byte [eax+0x1] */
            ii(0x100a_dbdd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dbe0, 3); mov(ebx, memd_a32[ss, ebp - 0x22]);     /* mov ebx, [ebp-0x22] */
            ii(0x100a_dbe3, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x100a_dbe5, 4); mov(memw_a32[ds, eax + 0x20], bx);      /* mov [eax+0x20], bx */
            ii(0x100a_dbe9, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100a_dbed, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
        l_0x100a_dbf1:
            ii(0x100a_dbf1, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100a_dbf4, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
            ii(0x100a_dbf7, 2); jmpd(0x100a_dc13, 0x1a); goto l_0x100a_dc13; /* jmp 0x100adc13 */
        l_0x100a_dbf9:
            ii(0x100a_dbf9, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100a_dbfd, 2); if(jzd(0x100a_dc13, 0x14)) goto l_0x100a_dc13; /* jz 0x100adc13 */
            ii(0x100a_dbff, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100a_dc02, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dc05, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100a_dc08, 5); calld(0x1008_8b44, -0x2_50c9);          /* call 0x10088b44 */
            ii(0x100a_dc0d, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_dc11, 2); jmpd(0x100a_dc18, 0x5); goto l_0x100a_dc18; /* jmp 0x100adc18 */
        l_0x100a_dc13:
            ii(0x100a_dc13, 5); jmpd(0x100a_db3a, -0xde); goto l_0x100a_db3a; /* jmp 0x100adb3a */
        l_0x100a_dc18:
            ii(0x100a_dc18, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x100a_dc1c, 2); if(jnzd(0x100a_dc45, 0x27)) goto l_0x100a_dc45; /* jnz 0x100adc45 */
            ii(0x100a_dc1e, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_dc21, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_dc24, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100a_dc27, 5); calld(0x1007_5e64, -0x3_7dc8);          /* call 0x10075e64 */
            ii(0x100a_dc2c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_dc2e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dc31, 5); calld(0x100a_d0e3, -0xb53);             /* call 0x100ad0e3 */
            ii(0x100a_dc36, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_dc38, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_dc3b, 5); calld(0x100b_7294, 0x9654);             /* call 0x100b7294 */
            ii(0x100a_dc40, 5); jmpd(0x100a_deae, 0x269); goto l_0x100a_deae; /* jmp 0x100adeae */
        l_0x100a_dc45:
            ii(0x100a_dc45, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100a_dc49, 2); if(jzd(0x100a_dc7c, 0x31)) goto l_0x100a_dc7c; /* jz 0x100adc7c */
            ii(0x100a_dc4b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dc4e, 4); cmp(memb_a32[ds, eax + 0x47], 0);       /* cmp byte [eax+0x47], 0x0 */
            ii(0x100a_dc52, 2); if(jzd(0x100a_dc60, 0xc)) goto l_0x100a_dc60; /* jz 0x100adc60 */
            ii(0x100a_dc54, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_dc56, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dc59, 5); calld(0x100a_cbbb, -0x10a3);            /* call 0x100acbbb */
            ii(0x100a_dc5e, 2); jmpd(0x100a_dc6d, 0xd); goto l_0x100a_dc6d; /* jmp 0x100adc6d */
        l_0x100a_dc60:
            ii(0x100a_dc60, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100a_dc65, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dc68, 5); calld(0x100a_d02d, -0xc40);             /* call 0x100ad02d */
        l_0x100a_dc6d:
            ii(0x100a_dc6d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_dc6f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_dc72, 5); calld(0x100b_7294, 0x961d);             /* call 0x100b7294 */
            ii(0x100a_dc77, 5); jmpd(0x100a_deae, 0x232); goto l_0x100a_deae; /* jmp 0x100adeae */
        l_0x100a_dc7c:
            ii(0x100a_dc7c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dc7f, 4); cmp(memb_a32[ds, eax + 0x47], 0);       /* cmp byte [eax+0x47], 0x0 */
            ii(0x100a_dc83, 2); if(jnzd(0x100a_dcf0, 0x6b)) goto l_0x100a_dcf0; /* jnz 0x100adcf0 */
            ii(0x100a_dc85, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x100a_dc8a, 5); calld(Definitions.sys_new, 0xb_8171);   /* call 0x10165e00 */
            ii(0x100a_dc8f, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100a_dc92, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100a_dc95, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100a_dc98, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x100a_dc9c, 2); if(jzd(0x100a_dccc, 0x2e)) goto l_0x100a_dccc; /* jz 0x100adccc */
            ii(0x100a_dc9e, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x100a_dca1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dca4, 3); mov(ebx, memd_a32[ds, eax + 0x24]);     /* mov ebx, [eax+0x24] */
            ii(0x100a_dca7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_dcaa, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dcad, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_dcb0, 5); calld(0x1007_65d0, -0x3_76e5);          /* call 0x100765d0 */
            ii(0x100a_dcb5, 3); mov(esi, memd_a32[ss, ebp - 0x2c]);     /* mov esi, [ebp-0x2c] */
            ii(0x100a_dcb8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_dcba, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100a_dcbc, 5); calld(0x100b_88f0, 0xac2f);             /* call 0x100b88f0 */
            ii(0x100a_dcc1, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100a_dcc4, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100a_dcc7, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100a_dcca, 2); jmpd(0x100a_dcd2, 0x6); goto l_0x100a_dcd2; /* jmp 0x100adcd2 */
        l_0x100a_dccc:
            ii(0x100a_dccc, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100a_dccf, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x100a_dcd2:
            ii(0x100a_dcd2, 3); mov(edx, memd_a32[ss, ebp - 0x38]);     /* mov edx, [ebp-0x38] */
            ii(0x100a_dcd5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dcd8, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_dcdb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_dcde, 6); imul(ebx, eax, 0xc5);                   /* imul ebx, eax, 0xc5 */
            ii(0x100a_dce4, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100a_dce9, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_dceb, 5); calld(0x100b_9c11, 0xbf21);             /* call 0x100b9c11 */
        l_0x100a_dcf0:
            ii(0x100a_dcf0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dcf3, 5); cmp(memw_a32[ds, eax + 0x26], 0x48);    /* cmp word [eax+0x26], 0x48 */
            ii(0x100a_dcf8, 2); if(jnzd(0x100a_dd16, 0x1c)) goto l_0x100a_dd16; /* jnz 0x100add16 */
            ii(0x100a_dcfa, 5); mov(ebx, 0x48);                         /* mov ebx, 0x48 */
            ii(0x100a_dcff, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dd02, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x100a_dd05, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_dd08, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100a_dd0d, 5); calld(0x100a_d632, -0x6e0);             /* call 0x100ad632 */
            ii(0x100a_dd12, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_dd14, 2); if(jzd(0x100a_dd1b, 0x5)) goto l_0x100a_dd1b; /* jz 0x100add1b */
        l_0x100a_dd16:
            ii(0x100a_dd16, 5); jmpd(0x100a_de39, 0x11e); goto l_0x100a_de39; /* jmp 0x100ade39 */
        l_0x100a_dd1b:
            ii(0x100a_dd1b, 5); mov(ebx, 0x17);                         /* mov ebx, 0x17 */
            ii(0x100a_dd20, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dd23, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x100a_dd26, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_dd29, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_dd2e, 5); calld(0x100a_d632, -0x701);             /* call 0x100ad632 */
            ii(0x100a_dd33, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_dd35, 2); if(jnzd(0x100a_dd3b, 0x4)) goto l_0x100a_dd3b; /* jnz 0x100add3b */
            ii(0x100a_dd37, 4); add(memd_a32[ss, ebp - 0x1c], -0x14 /* 0xec */); /* add dword [ebp-0x1c], 0xffffffec */
        l_0x100a_dd3b:
            ii(0x100a_dd3b, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100a_dd3f, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100a_dd42, 6); if(jged(0x100a_de39, 0xf1)) goto l_0x100a_de39; /* jge 0x100ade39 */
            ii(0x100a_dd48, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_dd4b, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100a_dd4e, 5); calld(0x1007_5e64, -0x3_7eef);          /* call 0x10075e64 */
            ii(0x100a_dd53, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_dd55, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dd58, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_dd5b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_dd5e, 6); imul(ebx, eax, 0xc5);                   /* imul ebx, eax, 0xc5 */
            ii(0x100a_dd64, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100a_dd69, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_dd6b, 5); calld(0x100b_9da4, 0xc034);             /* call 0x100b9da4 */
            ii(0x100a_dd70, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100a_dd73, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_dd76, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100a_dd79, 5); calld(0x1008_8b44, -0x2_523a);          /* call 0x10088b44 */
            ii(0x100a_dd7e, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100a_dd85, 2); jmpd(0x100a_dd8d, 0x6); goto l_0x100a_dd8d; /* jmp 0x100add8d */
        l_0x100a_dd87:
            ii(0x100a_dd87, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_dd8a, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x100a_dd8d:
            ii(0x100a_dd8d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_dd90, 5); calld(0x100b_82bc, 0xa527);             /* call 0x100b82bc */
            ii(0x100a_dd95, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x100a_dd99, 6); if(jled(0x100a_de39, 0x9a)) goto l_0x100a_de39; /* jle 0x100ade39 */
            ii(0x100a_dd9f, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_dda3, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_dda6, 5); calld(0x100b_827c, 0xa4d1);             /* call 0x100b827c */
            ii(0x100a_ddab, 4); movsx(ax, memb_a32[ds, eax]);           /* movsx ax, byte [eax] */
            ii(0x100a_ddaf, 4); add(memw_a32[ss, ebp - 0x24], ax);      /* add [ebp-0x24], ax */
            ii(0x100a_ddb3, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_ddb7, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_ddba, 5); calld(0x100b_827c, 0xa4bd);             /* call 0x100b827c */
            ii(0x100a_ddbf, 5); movsx(ax, memb_a32[ds, eax + 0x1]);     /* movsx ax, byte [eax+0x1] */
            ii(0x100a_ddc4, 4); add(memw_a32[ss, ebp - 0x22], ax);      /* add [ebp-0x22], ax */
            ii(0x100a_ddc8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_ddca, 1); pushd(eax);                             /* push eax */
            ii(0x100a_ddcb, 4); movsx(ecx, memw_a32[ss, ebp - 0x22]);   /* movsx ecx, word [ebp-0x22] */
            ii(0x100a_ddcf, 4); movsx(ebx, memw_a32[ss, ebp - 0x24]);   /* movsx ebx, word [ebp-0x24] */
            ii(0x100a_ddd3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_ddd6, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x100a_ddd9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_dddc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_dddf, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_dde2, 5); calld(0x1007_6574, -0x3_7873);          /* call 0x10076574 */
            ii(0x100a_dde7, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_ddea, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_dded, 5); calld(0x1007_02b9, -0x3_db39);          /* call 0x100702b9 */
            ii(0x100a_ddf2, 1); cwde();                                 /* cwde */
            ii(0x100a_ddf3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_ddf5, 2); if(jnzd(0x100a_de1a, 0x23)) goto l_0x100a_de1a; /* jnz 0x100ade1a */
            ii(0x100a_ddf7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_ddf9, 1); pushd(eax);                             /* push eax */
            ii(0x100a_ddfa, 4); movsx(ecx, memw_a32[ss, ebp - 0x22]);   /* movsx ecx, word [ebp-0x22] */
            ii(0x100a_ddfe, 4); movsx(ebx, memw_a32[ss, ebp - 0x24]);   /* movsx ebx, word [ebp-0x24] */
            ii(0x100a_de02, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_de05, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x100a_de08, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_de0b, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x100a_de10, 5); calld(0x1007_02b9, -0x3_db5c);          /* call 0x100702b9 */
            ii(0x100a_de15, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100a_de18, 2); if(jnzd(0x100a_de1c, 0x2)) goto l_0x100a_de1c; /* jnz 0x100ade1c */
        l_0x100a_de1a:
            ii(0x100a_de1a, 2); jmpd(0x100a_de34, 0x18); goto l_0x100a_de34; /* jmp 0x100ade34 */
        l_0x100a_de1c:
            ii(0x100a_de1c, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100a_de1f, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100a_de22, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x100a_de25, 5); calld(0x1007_5e64, -0x3_7fc6);          /* call 0x10075e64 */
            ii(0x100a_de2a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_de2c, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100a_de2f, 5); calld(0x1009_6cab, -0x1_7189);          /* call 0x10096cab */
        l_0x100a_de34:
            ii(0x100a_de34, 5); jmpd(0x100a_dd87, -0xb2); goto l_0x100a_dd87; /* jmp 0x100add87 */
        l_0x100a_de39:
            ii(0x100a_de39, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_de3c, 3); mov(edx, memd_a32[ds, eax + 0x24]);     /* mov edx, [eax+0x24] */
            ii(0x100a_de3f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_de42, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_de45, 5); calld(0x100a_deb5, 0x6b);               /* call 0x100adeb5 */
            ii(0x100a_de4a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_de4d, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x100a_de50, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_de53, 4); cmp(dx, memw_a32[ds, eax + 0x1e]);      /* cmp dx, [eax+0x1e] */
            ii(0x100a_de57, 2); if(jnzd(0x100a_de69, 0x10)) goto l_0x100a_de69; /* jnz 0x100ade69 */
            ii(0x100a_de59, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_de5c, 4); mov(dx, memw_a32[ds, eax + 0x2]);       /* mov dx, [eax+0x2] */
            ii(0x100a_de60, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_de63, 4); cmp(dx, memw_a32[ds, eax + 0x20]);      /* cmp dx, [eax+0x20] */
            ii(0x100a_de67, 2); if(jzd(0x100a_de6b, 0x2)) goto l_0x100a_de6b; /* jz 0x100ade6b */
        l_0x100a_de69:
            ii(0x100a_de69, 2); jmpd(0x100a_de8c, 0x21); goto l_0x100a_de8c; /* jmp 0x100ade8c */
        l_0x100a_de6b:
            ii(0x100a_de6b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_de6e, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100a_de71, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100a_de74, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100a_de77, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_de7a, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_de7d, 5); calld(0x1007_65d0, -0x3_78b2);          /* call 0x100765d0 */
            ii(0x100a_de82, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_de84, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100a_de87, 3); calld_abs(memd_a32[ds, ebx + 0x44]);    /* call dword [ebx+0x44] */
            ii(0x100a_de8a, 2); jmpd(0x100a_dea4, 0x18); goto l_0x100a_dea4; /* jmp 0x100adea4 */
        l_0x100a_de8c:
            ii(0x100a_de8c, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_de8f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_de92, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x100a_de95, 5); calld(0x1007_5e64, -0x3_8036);          /* call 0x10075e64 */
            ii(0x100a_de9a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_de9c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_de9f, 5); calld(0x100a_d0e3, -0xdc1);             /* call 0x100ad0e3 */
        l_0x100a_dea4:
            ii(0x100a_dea4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_dea6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_dea9, 5); calld(0x100b_7294, 0x93e6);             /* call 0x100b7294 */
        l_0x100a_deae:
            ii(0x100a_deae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_deb0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_deb1, 1); popd(edi);                              /* pop edi */
            ii(0x100a_deb2, 1); popd(esi);                              /* pop esi */
            ii(0x100a_deb3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_deb4, 1); retd(); return;                         /* ret */
        }
    }
}
