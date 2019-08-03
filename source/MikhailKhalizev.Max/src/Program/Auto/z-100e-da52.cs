using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("05dee0be-5fc3-4d91-9fed-24dd1d8d083b")]
        public void Method_100e_da52()
        {
            ii(0x100e_da52, 5); pushd(0xcc);                            /* push 0xcc */
            ii(0x100e_da57, 5); calld(Definitions.sys_check_available_stack_size, 0x782f6); /* call 0x10165d52 */
            ii(0x100e_da5c, 1); pushd(esi);                             /* push esi */
            ii(0x100e_da5d, 1); pushd(edi);                             /* push edi */
            ii(0x100e_da5e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_da5f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_da61, 6); sub(esp, 0xa8);                         /* sub esp, 0xa8 */
            ii(0x100e_da67, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_da6a, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100e_da6d, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100e_da70, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x100e_da73, 7); mov(memd_a32[ss, ebp - 0x18], 0x50);    /* mov dword [ebp-0x18], 0x50 */
            ii(0x100e_da7a, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_da81, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100e_da88, 2); if(jnzd(0x100e_da90, 0x6)) goto l_0x100e_da90; /* jnz 0x100eda90 */
            ii(0x100e_da8a, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100e_da8e, 2); if(jzd(0x100e_dac1, 0x31)) goto l_0x100e_dac1; /* jz 0x100edac1 */
        l_0x100e_da90:
            ii(0x100e_da90, 5); mov(edx, 0x101c_367c);                  /* mov edx, 0x101c367c */
            ii(0x100e_da95, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100e_da98, 5); calld(0x100d_4d78, -0x18d25);           /* call 0x100d4d78 */
            ii(0x100e_da9d, 1); pushd(eax);                             /* push eax */
            ii(0x100e_da9e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_daa3, 1); pushd(eax);                             /* push eax */
            ii(0x100e_daa4, 5); mov(eax, 0x1b8);                        /* mov eax, 0x1b8 */
            ii(0x100e_daa9, 1); pushd(eax);                             /* push eax */
            ii(0x100e_daaa, 5); mov(ecx, 0xa);                          /* mov ecx, 0xa */
            ii(0x100e_daaf, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x100e_dab4, 5); mov(edx, 0x101a_1f04);                  /* mov edx, 0x101a1f04 */ /* "Game Over" */
            ii(0x100e_dab9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_dabc, 5); calld(0x100e_a99a, -0x3127);            /* call 0x100ea99a */
        l_0x100e_dac1:
            ii(0x100e_dac1, 7); mov(memd_a32[ss, ebp - 0x18], 0x50);    /* mov dword [ebp-0x18], 0x50 */
            ii(0x100e_dac8, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_dacf, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x100e_dad6, 2); jmpd(0x100e_dade, 0x6); goto l_0x100e_dade; /* jmp 0x100edade */
        l_0x100e_dad8:
            ii(0x100e_dad8, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_dadb, 3); inc(memd_a32[ss, ebp - 0x24]);          /* inc dword [ebp-0x24] */
        l_0x100e_dade:
            ii(0x100e_dade, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_dae2, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100e_dae5, 6); if(jged(0x100e_dc44, 0x159)) goto l_0x100e_dc44; /* jge 0x100edc44 */
            ii(0x100e_daeb, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_daef, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_daf5, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100e_dafb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_db00, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_db02, 6); if(jzd(0x100e_dc3f, 0x137)) goto l_0x100e_dc3f; /* jz 0x100edc3f */
            ii(0x100e_db08, 4); add(memd_a32[ss, ebp - 0x18], 0x6e);    /* add dword [ebp-0x18], 0x6e */
            ii(0x100e_db0c, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_db0f, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
            ii(0x100e_db12, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_db15, 5); add(eax, 0x5a);                         /* add eax, 0x5a */
            ii(0x100e_db1a, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_db1d, 3); lea(edi, ebp - 0x34);                   /* lea edi, [ebp-0x34] */
            ii(0x100e_db20, 5); mov(esi, 0x101c_3680);                  /* mov esi, 0x101c3680 */
            ii(0x100e_db25, 1); movsd_a32();                            /* movsd */
            ii(0x100e_db26, 1); movsd_a32();                            /* movsd */
            ii(0x100e_db27, 1); movsd_a32();                            /* movsd */
            ii(0x100e_db28, 5); mov(ecx, 0xc7);                         /* mov ecx, 0xc7 */
            ii(0x100e_db2d, 5); mov(ebx, 0xe6);                         /* mov ebx, 0xe6 */
            ii(0x100e_db32, 5); mov(edx, 0xa5);                         /* mov edx, 0xa5 */
            ii(0x100e_db37, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100e_db3a, 5); calld(0x100d_53a4, -0x1879b);           /* call 0x100d53a4 */
            ii(0x100e_db3f, 5); mov(ecx, 0xc7);                         /* mov ecx, 0xc7 */
            ii(0x100e_db44, 5); mov(ebx, 0xee);                         /* mov ebx, 0xee */
            ii(0x100e_db49, 5); mov(edx, 0xa5);                         /* mov edx, 0xa5 */
            ii(0x100e_db4e, 3); lea(eax, ebp - 0x31);                   /* lea eax, [ebp-0x31] */
            ii(0x100e_db51, 5); calld(0x100d_53a4, -0x187b2);           /* call 0x100d53a4 */
            ii(0x100e_db56, 5); mov(ecx, 0xc7);                         /* mov ecx, 0xc7 */
            ii(0x100e_db5b, 5); mov(ebx, 0xf5);                         /* mov ebx, 0xf5 */
            ii(0x100e_db60, 5); mov(edx, 0xa5);                         /* mov edx, 0xa5 */
            ii(0x100e_db65, 3); lea(eax, ebp - 0x2e);                   /* lea eax, [ebp-0x2e] */
            ii(0x100e_db68, 5); calld(0x100d_53a4, -0x187c9);           /* call 0x100d53a4 */
            ii(0x100e_db6d, 5); mov(ecx, 0xc7);                         /* mov ecx, 0xc7 */
            ii(0x100e_db72, 5); mov(ebx, 0xd6);                         /* mov ebx, 0xd6 */
            ii(0x100e_db77, 5); mov(edx, 0xa5);                         /* mov edx, 0xa5 */
            ii(0x100e_db7c, 3); lea(eax, ebp - 0x2b);                   /* lea eax, [ebp-0x2b] */
            ii(0x100e_db7f, 5); calld(0x100d_53a4, -0x187e0);           /* call 0x100d53a4 */
            ii(0x100e_db84, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_db88, 3); lea(eax, eax + eax * 2);                /* lea eax, [eax+eax*2] */
            ii(0x100e_db8b, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x100e_db8e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_db90, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100e_db93, 5); calld(0x100d_4d78, -0x18e20);           /* call 0x100d4d78 */
            ii(0x100e_db98, 1); pushd(eax);                             /* push eax */
            ii(0x100e_db99, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_db9e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_db9f, 5); mov(eax, 0x5a);                         /* mov eax, 0x5a */
            ii(0x100e_dba4, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dba5, 5); mov(ecx, 0x2c);                         /* mov ecx, 0x2c */
            ii(0x100e_dbaa, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_dbae, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_dbb2, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dbb3, 5); mov(eax, 0x101a_1f0e);                  /* mov eax, 0x101a1f0e */ /* "%i" */
            ii(0x100e_dbb8, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dbb9, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x100e_dbbe, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dbbf, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100e_dbc2, 5); calld(Definitions.my_string_ctor, 0x53f21); /* call 0x10141ae8 */
            ii(0x100e_dbc7, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dbc8, 5); calld(0x1014_2037, 0x5446a);            /* call 0x10142037 */
            ii(0x100e_dbcd, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100e_dbd0, 5); calld(Definitions.my_strobj_c_str_v2, -0x6440d); /* call 0x100897c8 */
            ii(0x100e_dbd5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_dbd7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_dbda, 5); calld(0x100e_a99a, -0x3245);            /* call 0x100ea99a */
            ii(0x100e_dbdf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_dbe1, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100e_dbe4, 5); calld(Definitions.my_string_dtor, 0x53f41); /* call 0x10141b2a */
            ii(0x100e_dbe9, 5); mov(ecx, 0x28);                         /* mov ecx, 0x28 */
            ii(0x100e_dbee, 3); lea(ebx, ebp - 0x64);                   /* lea ebx, [ebp-0x64] */
            ii(0x100e_dbf1, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x100e_dbf4, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x100e_dbf6, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x100e_dbf9, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x100e_dbfe, 5); calld(0x1010_6281, 0x1867e);            /* call 0x10106281 */
            ii(0x100e_dc03, 5); mov(edx, 0x101c_367c);                  /* mov edx, 0x101c367c */
            ii(0x100e_dc08, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x100e_dc0b, 5); calld(0x100d_4d78, -0x18e98);           /* call 0x100d4d78 */
            ii(0x100e_dc10, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dc11, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_dc16, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dc17, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_dc1c, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dc1d, 5); mov(eax, 0x37);                         /* mov eax, 0x37 */
            ii(0x100e_dc22, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dc23, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_dc26, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100e_dc29, 1); cwde();                                 /* cwde */
            ii(0x100e_dc2a, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dc2b, 5); mov(ecx, 0x3d);                         /* mov ecx, 0x3d */
            ii(0x100e_dc30, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_dc34, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x100e_dc37, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_dc3a, 5); calld(0x100e_ab9d, -0x30a2);            /* call 0x100eab9d */
        l_0x100e_dc3f:
            ii(0x100e_dc3f, 5); jmpd(0x100e_dad8, -0x16c); goto l_0x100e_dad8; /* jmp 0x100edad8 */
        l_0x100e_dc44:
            ii(0x100e_dc44, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_dc47, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100e_dc4a, 5); calld(Definitions.sys_display_draw_0, 0x79835); /* call 0x10167484 */
            ii(0x100e_dc4f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_dc54, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dc55, 5); mov(eax, 0xac);                         /* mov eax, 0xac */
            ii(0x100e_dc5a, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dc5b, 5); mov(ecx, 0x74);                         /* mov ecx, 0x74 */
            ii(0x100e_dc60, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_dc62, 5); mov(edx, 0x101a_1f11);                  /* mov edx, 0x101a1f11 */ /* "Points" */
            ii(0x100e_dc67, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_dc6a, 5); calld(0x100e_d76b, -0x504);             /* call 0x100ed76b */
            ii(0x100e_dc6f, 7); mov(memd_a32[ss, ebp - 0x18], 0x50);    /* mov dword [ebp-0x18], 0x50 */
            ii(0x100e_dc76, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_dc7d, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100e_dc81, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_dc83, 5); calld(0x100e_cd4d, -0xf3b);             /* call 0x100ecd4d */
            ii(0x100e_dc88, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100e_dc8b, 6); mov(memw_a32[ss, ebp - 0x24], 0);       /* mov word [ebp-0x24], 0x0 */
            ii(0x100e_dc91, 2); jmpd(0x100e_dc9a, 0x7); goto l_0x100e_dc9a; /* jmp 0x100edc9a */
        l_0x100e_dc93:
            ii(0x100e_dc93, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_dc96, 4); inc(memw_a32[ss, ebp - 0x24]);          /* inc word [ebp-0x24] */
        l_0x100e_dc9a:
            ii(0x100e_dc9a, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_dc9e, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100e_dca1, 6); if(jged(0x100e_ddd8, 0x131)) goto l_0x100e_ddd8; /* jge 0x100eddd8 */
            ii(0x100e_dca7, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_dcab, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_dcb1, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100e_dcb7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_dcbc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_dcbe, 6); if(jzd(0x100e_ddd3, 0x10f)) goto l_0x100e_ddd3; /* jz 0x100eddd3 */
            ii(0x100e_dcc4, 4); add(memd_a32[ss, ebp - 0x18], 0x6e);    /* add dword [ebp-0x18], 0x6e */
            ii(0x100e_dcc8, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_dccb, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
            ii(0x100e_dcce, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_dcd1, 5); add(eax, 0x5a);                         /* add eax, 0x5a */
            ii(0x100e_dcd6, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_dcd9, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x100e_dcdd, 6); if(jnzd(0x100e_dd75, 0x92)) goto l_0x100e_dd75; /* jnz 0x100edd75 */
            ii(0x100e_dce3, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x100e_dce7, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100e_dced, 6); pushd(memd_a32[ds, edx + 0x101c_a550]); /* push dword [edx+0x101ca550] */
            ii(0x100e_dcf3, 5); mov(eax, 0x101a_1f18);                  /* mov eax, 0x101a1f18 */ /* "%i" */
            ii(0x100e_dcf8, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dcf9, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100e_dcfc, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dcfd, 5); calld(Definitions.sys_sprintf, 0x781ff); /* call 0x10165f01 */
            ii(0x100e_dd02, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100e_dd05, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100e_dd0a, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dd0b, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_dd0e, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100e_dd11, 1); cwde();                                 /* cwde */
            ii(0x100e_dd12, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dd13, 5); mov(ecx, 0x74);                         /* mov ecx, 0x74 */
            ii(0x100e_dd18, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_dd1c, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x100e_dd1f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_dd22, 5); calld(0x100e_d76b, -0x5bc);             /* call 0x100ed76b */
            ii(0x100e_dd27, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100e_dd2b, 2); if(jnzd(0x100e_dd3d, 0x10)) goto l_0x100e_dd3d; /* jnz 0x100edd3d */
            ii(0x100e_dd2d, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_dd31, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_dd33, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x100e_dd36, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_dd39, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_dd3b, 2); if(jnzd(0x100e_dd73, 0x36)) goto l_0x100e_dd73; /* jnz 0x100edd73 */
        l_0x100e_dd3d:
            ii(0x100e_dd3d, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100e_dd42, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dd43, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_dd46, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100e_dd49, 1); cwde();                                 /* cwde */
            ii(0x100e_dd4a, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dd4b, 5); mov(ecx, 0x84);                         /* mov ecx, 0x84 */
            ii(0x100e_dd50, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_dd54, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_dd58, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_dd5a, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100e_dd5d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_dd5f, 3); movsx(edx, memw_a32[ds, edx]);          /* movsx edx, word [edx] */
            ii(0x100e_dd62, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100e_dd65, 6); mov(edx, memd_a32[ds, edx + 0x101b_8660]); /* mov edx, [edx+0x101b8660] */
            ii(0x100e_dd6b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_dd6e, 5); calld(0x100e_d76b, -0x608);             /* call 0x100ed76b */
        l_0x100e_dd73:
            ii(0x100e_dd73, 2); jmpd(0x100e_ddd3, 0x5e); goto l_0x100e_ddd3; /* jmp 0x100eddd3 */
        l_0x100e_dd75:
            ii(0x100e_dd75, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_dd79, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_dd7b, 2); if(jnzd(0x100e_ddd3, 0x56)) goto l_0x100e_ddd3; /* jnz 0x100eddd3 */
            ii(0x100e_dd7d, 7); mov(memd_a32[ss, ebp - 0x6c], 0x2);     /* mov dword [ebp-0x6c], 0x2 */
            ii(0x100e_dd84, 3); pushd(memd_a32[ss, ebp - 0x6c]);        /* push dword [ebp-0x6c] */
            ii(0x100e_dd87, 7); mov(memd_a32[ss, ebp - 0x70], 0x22);    /* mov dword [ebp-0x70], 0x22 */
            ii(0x100e_dd8e, 3); pushd(memd_a32[ss, ebp - 0x70]);        /* push dword [ebp-0x70] */
            ii(0x100e_dd91, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_dd94, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100e_dd97, 1); cwde();                                 /* cwde */
            ii(0x100e_dd98, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x100e_dd9b, 3); pushd(memd_a32[ss, ebp - 0x74]);        /* push dword [ebp-0x74] */
            ii(0x100e_dd9e, 7); mov(memd_a32[ss, ebp - 0x78], 0x74);    /* mov dword [ebp-0x78], 0x74 */
            ii(0x100e_dda5, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100e_dda9, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x100e_ddac, 4); cmp(memb_a32[ss, ebp - 0x14], 0x2);     /* cmp byte [ebp-0x14], 0x2 */
            ii(0x100e_ddb0, 2); if(jnzd(0x100e_ddbb, 0x9)) goto l_0x100e_ddbb; /* jnz 0x100eddbb */
            ii(0x100e_ddb2, 7); mov(memd_a32[ss, ebp - 0x80], 0x101a_1f1b); /* mov dword [ebp-0x80], 0x101a1f1b */ /* "Mission Success" */
            ii(0x100e_ddb9, 2); jmpd(0x100e_ddc2, 0x7); goto l_0x100e_ddc2; /* jmp 0x100eddc2 */
        l_0x100e_ddbb:
            ii(0x100e_ddbb, 7); mov(memd_a32[ss, ebp - 0x80], 0x101a_1f2b); /* mov dword [ebp-0x80], 0x101a1f2b */ /* "Mission Failed" */
        l_0x100e_ddc2:
            ii(0x100e_ddc2, 3); mov(edx, memd_a32[ss, ebp - 0x80]);     /* mov edx, [ebp-0x80] */
            ii(0x100e_ddc5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_ddc8, 3); mov(ecx, memd_a32[ss, ebp - 0x78]);     /* mov ecx, [ebp-0x78] */
            ii(0x100e_ddcb, 3); mov(ebx, memd_a32[ss, ebp - 0x7c]);     /* mov ebx, [ebp-0x7c] */
            ii(0x100e_ddce, 5); calld(0x100e_d950, -0x483);             /* call 0x100ed950 */
        l_0x100e_ddd3:
            ii(0x100e_ddd3, 5); jmpd(0x100e_dc93, -0x145); goto l_0x100e_dc93; /* jmp 0x100edc93 */
        l_0x100e_ddd8:
            ii(0x100e_ddd8, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_dddd, 1); pushd(eax);                             /* push eax */
            ii(0x100e_ddde, 5); mov(eax, 0xac);                         /* mov eax, 0xac */
            ii(0x100e_dde3, 1); pushd(eax);                             /* push eax */
            ii(0x100e_dde4, 5); mov(ecx, 0xa6);                         /* mov ecx, 0xa6 */
            ii(0x100e_dde9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_ddeb, 5); mov(edx, 0x101a_1f3a);                  /* mov edx, 0x101a1f3a */ /* "Factories Built" */
            ii(0x100e_ddf0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_ddf3, 5); calld(0x100e_d76b, -0x68d);             /* call 0x100ed76b */
            ii(0x100e_ddf8, 7); mov(memd_a32[ss, ebp - 0x18], 0x50);    /* mov dword [ebp-0x18], 0x50 */
            ii(0x100e_ddff, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_de06, 6); mov(memw_a32[ss, ebp - 0x24], 0);       /* mov word [ebp-0x24], 0x0 */
            ii(0x100e_de0c, 2); jmpd(0x100e_de15, 0x7); goto l_0x100e_de15; /* jmp 0x100ede15 */
        l_0x100e_de0e:
            ii(0x100e_de0e, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_de11, 4); inc(memw_a32[ss, ebp - 0x24]);          /* inc word [ebp-0x24] */
        l_0x100e_de15:
            ii(0x100e_de15, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_de19, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100e_de1c, 6); if(jged(0x100e_deb0, 0x8e)) goto l_0x100e_deb0; /* jge 0x100edeb0 */
            ii(0x100e_de22, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_de26, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_de2c, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100e_de32, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_de37, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_de39, 2); if(jzd(0x100e_deab, 0x70)) goto l_0x100e_deab; /* jz 0x100edeab */
            ii(0x100e_de3b, 4); add(memd_a32[ss, ebp - 0x18], 0x6e);    /* add dword [ebp-0x18], 0x6e */
            ii(0x100e_de3f, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_de42, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
            ii(0x100e_de45, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_de48, 5); add(eax, 0x5a);                         /* add eax, 0x5a */
            ii(0x100e_de4d, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_de50, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_de54, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_de5a, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x100e_de5f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_de61, 6); mov(memd_a32[ss, ebp - 0x84], edx);     /* mov [ebp-0x84], edx */
            ii(0x100e_de67, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100e_de6d, 6); mov(eax, memd_a32[ds, eax + 0x111]);    /* mov eax, [eax+0x111] */
            ii(0x100e_de73, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_de76, 1); pushd(eax);                             /* push eax */
            ii(0x100e_de77, 5); mov(eax, 0x101a_1f4a);                  /* mov eax, 0x101a1f4a */ /* "%i" */
            ii(0x100e_de7c, 1); pushd(eax);                             /* push eax */
            ii(0x100e_de7d, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100e_de80, 1); pushd(eax);                             /* push eax */
            ii(0x100e_de81, 5); calld(Definitions.sys_sprintf, 0x7807b); /* call 0x10165f01 */
            ii(0x100e_de86, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100e_de89, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100e_de8e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_de8f, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_de92, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100e_de95, 1); cwde();                                 /* cwde */
            ii(0x100e_de96, 1); pushd(eax);                             /* push eax */
            ii(0x100e_de97, 5); mov(ecx, 0xa6);                         /* mov ecx, 0xa6 */
            ii(0x100e_de9c, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_dea0, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x100e_dea3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_dea6, 5); calld(0x100e_d76b, -0x740);             /* call 0x100ed76b */
        l_0x100e_deab:
            ii(0x100e_deab, 5); jmpd(0x100e_de0e, -0xa2); goto l_0x100e_de0e; /* jmp 0x100ede0e */
        l_0x100e_deb0:
            ii(0x100e_deb0, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_deb5, 1); pushd(eax);                             /* push eax */
            ii(0x100e_deb6, 5); mov(eax, 0xac);                         /* mov eax, 0xac */
            ii(0x100e_debb, 1); pushd(eax);                             /* push eax */
            ii(0x100e_debc, 5); mov(ecx, 0xc6);                         /* mov ecx, 0xc6 */
            ii(0x100e_dec1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_dec3, 5); mov(edx, 0x101a_1f4d);                  /* mov edx, 0x101a1f4d */ /* "Mines Built" */
            ii(0x100e_dec8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_decb, 5); calld(0x100e_d76b, -0x765);             /* call 0x100ed76b */
            ii(0x100e_ded0, 7); mov(memd_a32[ss, ebp - 0x18], 0x50);    /* mov dword [ebp-0x18], 0x50 */
            ii(0x100e_ded7, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_dede, 6); mov(memw_a32[ss, ebp - 0x24], 0);       /* mov word [ebp-0x24], 0x0 */
            ii(0x100e_dee4, 2); jmpd(0x100e_deed, 0x7); goto l_0x100e_deed; /* jmp 0x100edeed */
        l_0x100e_dee6:
            ii(0x100e_dee6, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_dee9, 4); inc(memw_a32[ss, ebp - 0x24]);          /* inc word [ebp-0x24] */
        l_0x100e_deed:
            ii(0x100e_deed, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_def1, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100e_def4, 6); if(jged(0x100e_df88, 0x8e)) goto l_0x100e_df88; /* jge 0x100edf88 */
            ii(0x100e_defa, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_defe, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_df04, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100e_df0a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_df0f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_df11, 2); if(jzd(0x100e_df83, 0x70)) goto l_0x100e_df83; /* jz 0x100edf83 */
            ii(0x100e_df13, 4); add(memd_a32[ss, ebp - 0x18], 0x6e);    /* add dword [ebp-0x18], 0x6e */
            ii(0x100e_df17, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_df1a, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
            ii(0x100e_df1d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_df20, 5); add(eax, 0x5a);                         /* add eax, 0x5a */
            ii(0x100e_df25, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_df28, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_df2c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_df32, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x100e_df37, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_df39, 6); mov(memd_a32[ss, ebp - 0x88], edx);     /* mov [ebp-0x88], edx */
            ii(0x100e_df3f, 6); mov(eax, memd_a32[ss, ebp - 0x88]);     /* mov eax, [ebp-0x88] */
            ii(0x100e_df45, 6); mov(eax, memd_a32[ds, eax + 0x113]);    /* mov eax, [eax+0x113] */
            ii(0x100e_df4b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_df4e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_df4f, 5); mov(eax, 0x101a_1f59);                  /* mov eax, 0x101a1f59 */ /* "%i" */
            ii(0x100e_df54, 1); pushd(eax);                             /* push eax */
            ii(0x100e_df55, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100e_df58, 1); pushd(eax);                             /* push eax */
            ii(0x100e_df59, 5); calld(Definitions.sys_sprintf, 0x77fa3); /* call 0x10165f01 */
            ii(0x100e_df5e, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100e_df61, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100e_df66, 1); pushd(eax);                             /* push eax */
            ii(0x100e_df67, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_df6a, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100e_df6d, 1); cwde();                                 /* cwde */
            ii(0x100e_df6e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_df6f, 5); mov(ecx, 0xc6);                         /* mov ecx, 0xc6 */
            ii(0x100e_df74, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_df78, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x100e_df7b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_df7e, 5); calld(0x100e_d76b, -0x818);             /* call 0x100ed76b */
        l_0x100e_df83:
            ii(0x100e_df83, 5); jmpd(0x100e_dee6, -0xa2); goto l_0x100e_dee6; /* jmp 0x100edee6 */
        l_0x100e_df88:
            ii(0x100e_df88, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_df8d, 1); pushd(eax);                             /* push eax */
            ii(0x100e_df8e, 5); mov(eax, 0xac);                         /* mov eax, 0xac */
            ii(0x100e_df93, 1); pushd(eax);                             /* push eax */
            ii(0x100e_df94, 5); mov(ecx, 0xe6);                         /* mov ecx, 0xe6 */
            ii(0x100e_df99, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_df9b, 5); mov(edx, 0x101a_1f5c);                  /* mov edx, 0x101a1f5c */ /* "Buildings Built" */
            ii(0x100e_dfa0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_dfa3, 5); calld(0x100e_d76b, -0x83d);             /* call 0x100ed76b */
            ii(0x100e_dfa8, 7); mov(memd_a32[ss, ebp - 0x18], 0x50);    /* mov dword [ebp-0x18], 0x50 */
            ii(0x100e_dfaf, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_dfb6, 6); mov(memw_a32[ss, ebp - 0x24], 0);       /* mov word [ebp-0x24], 0x0 */
            ii(0x100e_dfbc, 2); jmpd(0x100e_dfc5, 0x7); goto l_0x100e_dfc5; /* jmp 0x100edfc5 */
        l_0x100e_dfbe:
            ii(0x100e_dfbe, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_dfc1, 4); inc(memw_a32[ss, ebp - 0x24]);          /* inc word [ebp-0x24] */
        l_0x100e_dfc5:
            ii(0x100e_dfc5, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_dfc9, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100e_dfcc, 6); if(jged(0x100e_e060, 0x8e)) goto l_0x100e_e060; /* jge 0x100ee060 */
            ii(0x100e_dfd2, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_dfd6, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_dfdc, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100e_dfe2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_dfe7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_dfe9, 2); if(jzd(0x100e_e05b, 0x70)) goto l_0x100e_e05b; /* jz 0x100ee05b */
            ii(0x100e_dfeb, 4); add(memd_a32[ss, ebp - 0x18], 0x6e);    /* add dword [ebp-0x18], 0x6e */
            ii(0x100e_dfef, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_dff2, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
            ii(0x100e_dff5, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_dff8, 5); add(eax, 0x5a);                         /* add eax, 0x5a */
            ii(0x100e_dffd, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_e000, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_e004, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_e00a, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x100e_e00f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_e011, 6); mov(memd_a32[ss, ebp - 0x8c], edx);     /* mov [ebp-0x8c], edx */
            ii(0x100e_e017, 6); mov(eax, memd_a32[ss, ebp - 0x8c]);     /* mov eax, [ebp-0x8c] */
            ii(0x100e_e01d, 6); mov(eax, memd_a32[ds, eax + 0x115]);    /* mov eax, [eax+0x115] */
            ii(0x100e_e023, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_e026, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e027, 5); mov(eax, 0x101a_1f6c);                  /* mov eax, 0x101a1f6c */ /* "%i" */
            ii(0x100e_e02c, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e02d, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100e_e030, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e031, 5); calld(Definitions.sys_sprintf, 0x77ecb); /* call 0x10165f01 */
            ii(0x100e_e036, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100e_e039, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100e_e03e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e03f, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_e042, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100e_e045, 1); cwde();                                 /* cwde */
            ii(0x100e_e046, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e047, 5); mov(ecx, 0xe6);                         /* mov ecx, 0xe6 */
            ii(0x100e_e04c, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_e050, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x100e_e053, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_e056, 5); calld(0x100e_d76b, -0x8f0);             /* call 0x100ed76b */
        l_0x100e_e05b:
            ii(0x100e_e05b, 5); jmpd(0x100e_dfbe, -0xa2); goto l_0x100e_dfbe; /* jmp 0x100edfbe */
        l_0x100e_e060:
            ii(0x100e_e060, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_e065, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e066, 5); mov(eax, 0xac);                         /* mov eax, 0xac */
            ii(0x100e_e06b, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e06c, 5); mov(ecx, 0xf6);                         /* mov ecx, 0xf6 */
            ii(0x100e_e071, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_e073, 5); mov(edx, 0x101a_1f6f);                  /* mov edx, 0x101a1f6f */ /* "Lost" */
            ii(0x100e_e078, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_e07b, 5); calld(0x100e_d76b, -0x915);             /* call 0x100ed76b */
            ii(0x100e_e080, 7); mov(memd_a32[ss, ebp - 0x18], 0x50);    /* mov dword [ebp-0x18], 0x50 */
            ii(0x100e_e087, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_e08e, 6); mov(memw_a32[ss, ebp - 0x24], 0);       /* mov word [ebp-0x24], 0x0 */
            ii(0x100e_e094, 2); jmpd(0x100e_e09d, 0x7); goto l_0x100e_e09d; /* jmp 0x100ee09d */
        l_0x100e_e096:
            ii(0x100e_e096, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_e099, 4); inc(memw_a32[ss, ebp - 0x24]);          /* inc word [ebp-0x24] */
        l_0x100e_e09d:
            ii(0x100e_e09d, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_e0a1, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100e_e0a4, 6); if(jged(0x100e_e193, 0xe9)) goto l_0x100e_e193; /* jge 0x100ee193 */
            ii(0x100e_e0aa, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_e0ae, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_e0b4, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100e_e0ba, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_e0bf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_e0c1, 6); if(jzd(0x100e_e18e, 0xc7)) goto l_0x100e_e18e; /* jz 0x100ee18e */
            ii(0x100e_e0c7, 4); add(memd_a32[ss, ebp - 0x18], 0x6e);    /* add dword [ebp-0x18], 0x6e */
            ii(0x100e_e0cb, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_e0ce, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
            ii(0x100e_e0d1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_e0d4, 5); add(eax, 0x5a);                         /* add eax, 0x5a */
            ii(0x100e_e0d9, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_e0dc, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_e0e0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_e0e6, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x100e_e0eb, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_e0ed, 6); mov(memd_a32[ss, ebp - 0x90], edx);     /* mov [ebp-0x90], edx */
            ii(0x100e_e0f3, 10); mov(memd_a32[ss, ebp - 0x94], 0);      /* mov dword [ebp-0x94], 0x0 */
            ii(0x100e_e0fd, 10); mov(memd_a32[ss, ebp - 0x98], 0);      /* mov dword [ebp-0x98], 0x0 */
            ii(0x100e_e107, 2); jmpd(0x100e_e115, 0xc); goto l_0x100e_e115; /* jmp 0x100ee115 */
        l_0x100e_e109:
            ii(0x100e_e109, 6); mov(eax, memd_a32[ss, ebp - 0x98]);     /* mov eax, [ebp-0x98] */
            ii(0x100e_e10f, 6); inc(memd_a32[ss, ebp - 0x98]);          /* inc dword [ebp-0x98] */
        l_0x100e_e115:
            ii(0x100e_e115, 7); movsx(eax, memw_a32[ss, ebp - 0x98]);   /* movsx eax, word [ebp-0x98] */
            ii(0x100e_e11c, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100e_e11f, 2); if(jged(0x100e_e152, 0x31)) goto l_0x100e_e152; /* jge 0x100ee152 */
            ii(0x100e_e121, 7); movsx(eax, memw_a32[ss, ebp - 0x98]);   /* movsx eax, word [ebp-0x98] */
            ii(0x100e_e128, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100e_e12b, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x10); /* test byte [eax+0x101c81c0], 0x10 */
            ii(0x100e_e132, 2); if(jzd(0x100e_e150, 0x1c)) goto l_0x100e_e150; /* jz 0x100ee150 */
            ii(0x100e_e134, 7); movsx(eax, memw_a32[ss, ebp - 0x98]);   /* movsx eax, word [ebp-0x98] */
            ii(0x100e_e13b, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_e13d, 6); add(eax, memd_a32[ss, ebp - 0x90]);     /* add eax, [ebp-0x90] */
            ii(0x100e_e143, 7); mov(ax, memw_a32[ds, eax + 0x181]);     /* mov ax, [eax+0x181] */
            ii(0x100e_e14a, 6); add(memd_a32[ss, ebp - 0x94], eax);     /* add [ebp-0x94], eax */
        l_0x100e_e150:
            ii(0x100e_e150, 2); jmpd(0x100e_e109, -0x49); goto l_0x100e_e109; /* jmp 0x100ee109 */
        l_0x100e_e152:
            ii(0x100e_e152, 7); movsx(eax, memw_a32[ss, ebp - 0x94]);   /* movsx eax, word [ebp-0x94] */
            ii(0x100e_e159, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e15a, 5); mov(eax, 0x101a_1f74);                  /* mov eax, 0x101a1f74 */ /* "%i" */
            ii(0x100e_e15f, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e160, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100e_e163, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e164, 5); calld(Definitions.sys_sprintf, 0x77d98); /* call 0x10165f01 */
            ii(0x100e_e169, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100e_e16c, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100e_e171, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e172, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_e175, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100e_e178, 1); cwde();                                 /* cwde */
            ii(0x100e_e179, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e17a, 5); mov(ecx, 0xf6);                         /* mov ecx, 0xf6 */
            ii(0x100e_e17f, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_e183, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x100e_e186, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_e189, 5); calld(0x100e_d76b, -0xa23);             /* call 0x100ed76b */
        l_0x100e_e18e:
            ii(0x100e_e18e, 5); jmpd(0x100e_e096, -0xfd); goto l_0x100e_e096; /* jmp 0x100ee096 */
        l_0x100e_e193:
            ii(0x100e_e193, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_e198, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e199, 5); mov(eax, 0xac);                         /* mov eax, 0xac */
            ii(0x100e_e19e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e19f, 5); mov(ecx, 0x116);                        /* mov ecx, 0x116 */
            ii(0x100e_e1a4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_e1a6, 5); mov(edx, 0x101a_1f77);                  /* mov edx, 0x101a1f77 */ /* "Units Built" */
            ii(0x100e_e1ab, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_e1ae, 5); calld(0x100e_d76b, -0xa48);             /* call 0x100ed76b */
            ii(0x100e_e1b3, 7); mov(memd_a32[ss, ebp - 0x18], 0x50);    /* mov dword [ebp-0x18], 0x50 */
            ii(0x100e_e1ba, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_e1c1, 6); mov(memw_a32[ss, ebp - 0x24], 0);       /* mov word [ebp-0x24], 0x0 */
            ii(0x100e_e1c7, 2); jmpd(0x100e_e1d0, 0x7); goto l_0x100e_e1d0; /* jmp 0x100ee1d0 */
        l_0x100e_e1c9:
            ii(0x100e_e1c9, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_e1cc, 4); inc(memw_a32[ss, ebp - 0x24]);          /* inc word [ebp-0x24] */
        l_0x100e_e1d0:
            ii(0x100e_e1d0, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_e1d4, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100e_e1d7, 6); if(jged(0x100e_e26b, 0x8e)) goto l_0x100e_e26b; /* jge 0x100ee26b */
            ii(0x100e_e1dd, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_e1e1, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_e1e7, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100e_e1ed, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_e1f2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_e1f4, 2); if(jzd(0x100e_e266, 0x70)) goto l_0x100e_e266; /* jz 0x100ee266 */
            ii(0x100e_e1f6, 4); add(memd_a32[ss, ebp - 0x18], 0x6e);    /* add dword [ebp-0x18], 0x6e */
            ii(0x100e_e1fa, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_e1fd, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
            ii(0x100e_e200, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_e203, 5); add(eax, 0x5a);                         /* add eax, 0x5a */
            ii(0x100e_e208, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_e20b, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_e20f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_e215, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x100e_e21a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_e21c, 6); mov(memd_a32[ss, ebp - 0x9c], edx);     /* mov [ebp-0x9c], edx */
            ii(0x100e_e222, 6); mov(eax, memd_a32[ss, ebp - 0x9c]);     /* mov eax, [ebp-0x9c] */
            ii(0x100e_e228, 6); mov(eax, memd_a32[ds, eax + 0x117]);    /* mov eax, [eax+0x117] */
            ii(0x100e_e22e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_e231, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e232, 5); mov(eax, 0x101a_1f83);                  /* mov eax, 0x101a1f83 */ /* "%i" */
            ii(0x100e_e237, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e238, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100e_e23b, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e23c, 5); calld(Definitions.sys_sprintf, 0x77cc0); /* call 0x10165f01 */
            ii(0x100e_e241, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100e_e244, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100e_e249, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e24a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_e24d, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100e_e250, 1); cwde();                                 /* cwde */
            ii(0x100e_e251, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e252, 5); mov(ecx, 0x116);                        /* mov ecx, 0x116 */
            ii(0x100e_e257, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_e25b, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x100e_e25e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_e261, 5); calld(0x100e_d76b, -0xafb);             /* call 0x100ed76b */
        l_0x100e_e266:
            ii(0x100e_e266, 5); jmpd(0x100e_e1c9, -0xa2); goto l_0x100e_e1c9; /* jmp 0x100ee1c9 */
        l_0x100e_e26b:
            ii(0x100e_e26b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_e270, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e271, 5); mov(eax, 0xac);                         /* mov eax, 0xac */
            ii(0x100e_e276, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e277, 5); mov(ecx, 0x126);                        /* mov ecx, 0x126 */
            ii(0x100e_e27c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_e27e, 5); mov(edx, 0x101a_1f86);                  /* mov edx, 0x101a1f86 */ /* "Lost" */
            ii(0x100e_e283, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_e286, 5); calld(0x100e_d76b, -0xb20);             /* call 0x100ed76b */
            ii(0x100e_e28b, 7); mov(memd_a32[ss, ebp - 0x18], 0x50);    /* mov dword [ebp-0x18], 0x50 */
            ii(0x100e_e292, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_e299, 6); mov(memw_a32[ss, ebp - 0x24], 0);       /* mov word [ebp-0x24], 0x0 */
            ii(0x100e_e29f, 2); jmpd(0x100e_e2a8, 0x7); goto l_0x100e_e2a8; /* jmp 0x100ee2a8 */
        l_0x100e_e2a1:
            ii(0x100e_e2a1, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_e2a4, 4); inc(memw_a32[ss, ebp - 0x24]);          /* inc word [ebp-0x24] */
        l_0x100e_e2a8:
            ii(0x100e_e2a8, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_e2ac, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100e_e2af, 6); if(jged(0x100e_e39e, 0xe9)) goto l_0x100e_e39e; /* jge 0x100ee39e */
            ii(0x100e_e2b5, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_e2b9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_e2bf, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100e_e2c5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_e2ca, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_e2cc, 6); if(jzd(0x100e_e399, 0xc7)) goto l_0x100e_e399; /* jz 0x100ee399 */
            ii(0x100e_e2d2, 4); add(memd_a32[ss, ebp - 0x18], 0x6e);    /* add dword [ebp-0x18], 0x6e */
            ii(0x100e_e2d6, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_e2d9, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
            ii(0x100e_e2dc, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_e2df, 5); add(eax, 0x5a);                         /* add eax, 0x5a */
            ii(0x100e_e2e4, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_e2e7, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_e2eb, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_e2f1, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x100e_e2f6, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_e2f8, 6); mov(memd_a32[ss, ebp - 0xa0], edx);     /* mov [ebp-0xa0], edx */
            ii(0x100e_e2fe, 10); mov(memd_a32[ss, ebp - 0x94], 0);      /* mov dword [ebp-0x94], 0x0 */
            ii(0x100e_e308, 10); mov(memd_a32[ss, ebp - 0x98], 0);      /* mov dword [ebp-0x98], 0x0 */
            ii(0x100e_e312, 2); jmpd(0x100e_e320, 0xc); goto l_0x100e_e320; /* jmp 0x100ee320 */
        l_0x100e_e314:
            ii(0x100e_e314, 6); mov(eax, memd_a32[ss, ebp - 0x98]);     /* mov eax, [ebp-0x98] */
            ii(0x100e_e31a, 6); inc(memd_a32[ss, ebp - 0x98]);          /* inc dword [ebp-0x98] */
        l_0x100e_e320:
            ii(0x100e_e320, 7); movsx(eax, memw_a32[ss, ebp - 0x98]);   /* movsx eax, word [ebp-0x98] */
            ii(0x100e_e327, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100e_e32a, 2); if(jged(0x100e_e35d, 0x31)) goto l_0x100e_e35d; /* jge 0x100ee35d */
            ii(0x100e_e32c, 7); movsx(eax, memw_a32[ss, ebp - 0x98]);   /* movsx eax, word [ebp-0x98] */
            ii(0x100e_e333, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100e_e336, 7); test(memb_a32[ds, eax + 0x101c_81c2], 0x40); /* test byte [eax+0x101c81c2], 0x40 */
            ii(0x100e_e33d, 2); if(jzd(0x100e_e35b, 0x1c)) goto l_0x100e_e35b; /* jz 0x100ee35b */
            ii(0x100e_e33f, 7); movsx(eax, memw_a32[ss, ebp - 0x98]);   /* movsx eax, word [ebp-0x98] */
            ii(0x100e_e346, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_e348, 6); add(eax, memd_a32[ss, ebp - 0xa0]);     /* add eax, [ebp-0xa0] */
            ii(0x100e_e34e, 7); mov(ax, memw_a32[ds, eax + 0x181]);     /* mov ax, [eax+0x181] */
            ii(0x100e_e355, 6); add(memd_a32[ss, ebp - 0x94], eax);     /* add [ebp-0x94], eax */
        l_0x100e_e35b:
            ii(0x100e_e35b, 2); jmpd(0x100e_e314, -0x49); goto l_0x100e_e314; /* jmp 0x100ee314 */
        l_0x100e_e35d:
            ii(0x100e_e35d, 7); movsx(eax, memw_a32[ss, ebp - 0x94]);   /* movsx eax, word [ebp-0x94] */
            ii(0x100e_e364, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e365, 5); mov(eax, 0x101a_1f8b);                  /* mov eax, 0x101a1f8b */ /* "%i" */
            ii(0x100e_e36a, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e36b, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100e_e36e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e36f, 5); calld(Definitions.sys_sprintf, 0x77b8d); /* call 0x10165f01 */
            ii(0x100e_e374, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100e_e377, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100e_e37c, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e37d, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_e380, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100e_e383, 1); cwde();                                 /* cwde */
            ii(0x100e_e384, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e385, 5); mov(ecx, 0x126);                        /* mov ecx, 0x126 */
            ii(0x100e_e38a, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_e38e, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x100e_e391, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_e394, 5); calld(0x100e_d76b, -0xc2e);             /* call 0x100ed76b */
        l_0x100e_e399:
            ii(0x100e_e399, 5); jmpd(0x100e_e2a1, -0xfd); goto l_0x100e_e2a1; /* jmp 0x100ee2a1 */
        l_0x100e_e39e:
            ii(0x100e_e39e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_e3a3, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e3a4, 5); mov(eax, 0xac);                         /* mov eax, 0xac */
            ii(0x100e_e3a9, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e3aa, 5); mov(ecx, 0x146);                        /* mov ecx, 0x146 */
            ii(0x100e_e3af, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_e3b1, 5); mov(edx, 0x101a_1f8e);                  /* mov edx, 0x101a1f8e */ /* "Upgrades" */
            ii(0x100e_e3b6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_e3b9, 5); calld(0x100e_d76b, -0xc53);             /* call 0x100ed76b */
            ii(0x100e_e3be, 7); mov(memd_a32[ss, ebp - 0x18], 0x50);    /* mov dword [ebp-0x18], 0x50 */
            ii(0x100e_e3c5, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_e3cc, 6); mov(memw_a32[ss, ebp - 0x24], 0);       /* mov word [ebp-0x24], 0x0 */
            ii(0x100e_e3d2, 2); jmpd(0x100e_e3db, 0x7); goto l_0x100e_e3db; /* jmp 0x100ee3db */
        l_0x100e_e3d4:
            ii(0x100e_e3d4, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_e3d7, 4); inc(memw_a32[ss, ebp - 0x24]);          /* inc word [ebp-0x24] */
        l_0x100e_e3db:
            ii(0x100e_e3db, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_e3df, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100e_e3e2, 6); if(jged(0x100e_e47c, 0x94)) goto l_0x100e_e47c; /* jge 0x100ee47c */
            ii(0x100e_e3e8, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_e3ec, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_e3f2, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100e_e3f8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_e3fd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_e3ff, 2); if(jzd(0x100e_e477, 0x76)) goto l_0x100e_e477; /* jz 0x100ee477 */
            ii(0x100e_e401, 4); add(memd_a32[ss, ebp - 0x18], 0x6e);    /* add dword [ebp-0x18], 0x6e */
            ii(0x100e_e405, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_e408, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
            ii(0x100e_e40b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_e40e, 5); add(eax, 0x5a);                         /* add eax, 0x5a */
            ii(0x100e_e413, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_e416, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100e_e41a, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x100e_e420, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x100e_e425, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_e427, 6); mov(memd_a32[ss, ebp - 0xa4], eax);     /* mov [ebp-0xa4], eax */
            ii(0x100e_e42d, 5); mov(eax, 0x101a_1f97);                  /* mov eax, 0x101a1f97 */ /* "Gold" */
            ii(0x100e_e432, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e433, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100e_e439, 6); mov(eax, memd_a32[ds, eax + 0x119]);    /* mov eax, [eax+0x119] */
            ii(0x100e_e43f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_e442, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e443, 5); mov(eax, 0x101a_1f9c);                  /* mov eax, 0x101a1f9c */ /* "%i %s" */
            ii(0x100e_e448, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e449, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100e_e44c, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e44d, 5); calld(Definitions.sys_sprintf, 0x77aaf); /* call 0x10165f01 */
            ii(0x100e_e452, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100e_e455, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100e_e45a, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e45b, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_e45e, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100e_e461, 1); cwde();                                 /* cwde */
            ii(0x100e_e462, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e463, 5); mov(ecx, 0x146);                        /* mov ecx, 0x146 */
            ii(0x100e_e468, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100e_e46c, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x100e_e46f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_e472, 5); calld(0x100e_d76b, -0xd0c);             /* call 0x100ed76b */
        l_0x100e_e477:
            ii(0x100e_e477, 5); jmpd(0x100e_e3d4, -0xa8); goto l_0x100e_e3d4; /* jmp 0x100ee3d4 */
        l_0x100e_e47c:
            ii(0x100e_e47c, 5); mov(eax, 0x6e4);                        /* mov eax, 0x6e4 */
            ii(0x100e_e481, 5); calld(Definitions.my_get_res_data_by_id_malloc, 0x45d65); /* call 0x101341eb */
            ii(0x100e_e486, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
            ii(0x100e_e48c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_e48f, 1); pushd(eax);                             /* push eax */
            ii(0x100e_e490, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100e_e495, 6); mov(eax, memd_a32[ss, ebp - 0xa8]);     /* mov eax, [ebp-0xa8] */
            ii(0x100e_e49b, 5); mov(edx, 0x1e0);                        /* mov edx, 0x1e0 */
            ii(0x100e_e4a0, 4); sub(dx, memw_a32[ds, eax + 0x2]);       /* sub dx, [eax+0x2] */
            ii(0x100e_e4a4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_e4a6, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_e4a9, 5); mov(edx, 0x111);                        /* mov edx, 0x111 */
            ii(0x100e_e4ae, 6); mov(eax, memd_a32[ss, ebp - 0xa8]);     /* mov eax, [ebp-0xa8] */
            ii(0x100e_e4b4, 5); calld(0x100e_8d1e, -0x579b);            /* call 0x100e8d1e */
            ii(0x100e_e4b9, 6); mov(eax, memd_a32[ss, ebp - 0xa8]);     /* mov eax, [ebp-0xa8] */
            ii(0x100e_e4bf, 5); calld(Definitions.sys_delete, 0x77aa0); /* call 0x10165f64 */
            ii(0x100e_e4c4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_e4c6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_e4c7, 1); popd(edi);                              /* pop edi */
            ii(0x100e_e4c8, 1); popd(esi);                              /* pop esi */
            ii(0x100e_e4c9, 1); retd(); return;                         /* ret */
        }
    }
}
