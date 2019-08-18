using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("836d4552-8592-45b5-b532-f3f0149ff68e")]
        public void Method_1010_daa7()
        {
            ii(0x1010_daa7, 5); pushd(0x80);                            /* push 0x80 */
            ii(0x1010_daac, 5); calld(Definitions.sys_check_available_stack_size, 0x5_82a1); /* call 0x10165d52 */
            ii(0x1010_dab1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_dab2, 1); pushd(esi);                             /* push esi */
            ii(0x1010_dab3, 1); pushd(edi);                             /* push edi */
            ii(0x1010_dab4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_dab5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_dab7, 6); sub(esp, 0x5c);                         /* sub esp, 0x5c */
            ii(0x1010_dabd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_dac0, 3); mov(memb_a32[ss, ebp - 0x8], dl);       /* mov [ebp-0x8], dl */
            ii(0x1010_dac3, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1010_dac6, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_daca, 3); imul(edx, eax, 0x18);                   /* imul edx, eax, 0x18 */
            ii(0x1010_dacd, 5); mov(eax, 0x101b_9bc4);                  /* mov eax, 0x101b9bc4 */
            ii(0x1010_dad2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_dad4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_dad7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_dadc, 5); calld(/* sys */ 0x1016_a24c, 0x5_c76b); /* call 0x1016a24c */
            ii(0x1010_dae1, 4); cmp(memb_a32[ss, ebp - 0x8], 0xc);      /* cmp byte [ebp-0x8], 0xc */
            ii(0x1010_dae5, 2); if(jld(0x1010_daed, 0x6)) goto l_0x1010_daed; /* jl 0x1010daed */
            ii(0x1010_dae7, 4); cmp(memb_a32[ss, ebp - 0x8], 0x10);     /* cmp byte [ebp-0x8], 0x10 */
            ii(0x1010_daeb, 2); if(jld(0x1010_daf2, 0x5)) goto l_0x1010_daf2; /* jl 0x1010daf2 */
        l_0x1010_daed:
            ii(0x1010_daed, 5); jmpd(0x1010_dbef, 0xfd); goto l_0x1010_dbef; /* jmp 0x1010dbef */
        l_0x1010_daf2:
            ii(0x1010_daf2, 5); movsx(ax, memb_a32[ss, ebp - 0x8]);     /* movsx ax, byte [ebp-0x8] */
            ii(0x1010_daf7, 3); sub(eax, 0xc);                          /* sub eax, 0xc */
            ii(0x1010_dafa, 4); mov(memw_a32[ss, ebp - 0x14], ax);      /* mov [ebp-0x14], ax */
            ii(0x1010_dafe, 7); mov(memd_a32[ss, ebp - 0x18], 0x2d5);   /* mov dword [ebp-0x18], 0x2d5 */
            ii(0x1010_db05, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_db08, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1010_db0c, 1); inc(eax);                               /* inc eax */
            ii(0x1010_db0d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_db10, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1010_db13, 2); add(al, 0x67);                          /* add al, 0x67 */
            ii(0x1010_db15, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1010_db18, 5); calld(0x1007_5fdc, -0x9_7b41);          /* call 0x10075fdc */
            ii(0x1010_db1d, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1010_db20, 2); if(jnzd(0x1010_db68, 0x46)) goto l_0x1010_db68; /* jnz 0x1010db68 */
            ii(0x1010_db22, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1010_db27, 5); calld(0x1007_5fdc, -0x9_7b50);          /* call 0x10075fdc */
            ii(0x1010_db2c, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1010_db2f, 2); if(jzd(0x1010_db3b, 0xa)) goto l_0x1010_db3b; /* jz 0x1010db3b */
            ii(0x1010_db31, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_db34, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1010_db38, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1010_db3b:
            ii(0x1010_db3b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_db3e, 4); cmp(memd_a32[ds, eax + 0xc], 0);        /* cmp dword [eax+0xc], 0x0 */
            ii(0x1010_db42, 2); if(jnzd(0x1010_db53, 0xf)) goto l_0x1010_db53; /* jnz 0x1010db53 */
            ii(0x1010_db44, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1010_db49, 5); calld(0x1007_5fdc, -0x9_7b72);          /* call 0x10075fdc */
            ii(0x1010_db4e, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1010_db51, 2); if(jnzd(0x1010_db68, 0x15)) goto l_0x1010_db68; /* jnz 0x1010db68 */
        l_0x1010_db53:
            ii(0x1010_db53, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1010_db56, 2); add(al, 0x6b);                          /* add al, 0x6b */
            ii(0x1010_db58, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1010_db5b, 5); calld(0x1007_5fdc, -0x9_7b84);          /* call 0x10075fdc */
            ii(0x1010_db60, 5); add(eax, 0x2d5);                        /* add eax, 0x2d5 */
            ii(0x1010_db65, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1010_db68:
            ii(0x1010_db68, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_db6d, 5); calld(Definitions.sys_new, 0x5_828e);   /* call 0x10165e00 */
            ii(0x1010_db72, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_db75, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_db78, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_db7b, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1010_db7f, 2); if(jzd(0x1010_dbb2, 0x31)) goto l_0x1010_dbb2; /* jz 0x1010dbb2 */
            ii(0x1010_db81, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_db84, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_db86, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_db89, 1); pushd(eax);                             /* push eax */
            ii(0x1010_db8a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_db8d, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1010_db90, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_db93, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1010_db97, 1); inc(eax);                               /* inc eax */
            ii(0x1010_db98, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_db9b, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1010_db9f, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_dba2, 5); calld(Definitions.my_ctor_c17, -0x3_f798); /* call 0x100ce40f */
            ii(0x1010_dba7, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1010_dbaa, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_dbad, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1010_dbb0, 2); jmpd(0x1010_dbb8, 0x6); goto l_0x1010_dbb8; /* jmp 0x1010dbb8 */
        l_0x1010_dbb2:
            ii(0x1010_dbb2, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1010_dbb5, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x1010_dbb8:
            ii(0x1010_dbb8, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_dbbc, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_dbbf, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x1010_dbc2, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1010_dbc4, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1010_dbc7, 3); mov(memd_a32[ds, ecx + 0x14], eax);     /* mov [ecx+0x14], eax */
            ii(0x1010_dbca, 5); mov(ecx, 0x28);                         /* mov ecx, 0x28 */
            ii(0x1010_dbcf, 5); mov(ebx, 0x29);                         /* mov ebx, 0x29 */
            ii(0x1010_dbd4, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1010_dbd8, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_dbdc, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_dbdf, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_dbe2, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1010_dbe5, 5); calld(0x100c_ed1b, -0x3_eecf);          /* call 0x100ced1b */
            ii(0x1010_dbea, 5); jmpd(0x1010_dd2e, 0x13f); goto l_0x1010_dd2e; /* jmp 0x1010dd2e */
        l_0x1010_dbef:
            ii(0x1010_dbef, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_dbf2, 5); cmp(memw_a32[ds, eax + 0x8], -0x1 /* 0xff */); /* cmp word [eax+0x8], 0xffff */
            ii(0x1010_dbf7, 6); if(jnzd(0x1010_dc74, 0x77)) goto l_0x1010_dc74; /* jnz 0x1010dc74 */
            ii(0x1010_dbfd, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_dc02, 5); calld(Definitions.sys_new, 0x5_81f9);   /* call 0x10165e00 */
            ii(0x1010_dc07, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1010_dc0a, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1010_dc0d, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1010_dc10, 4); cmp(memd_a32[ss, ebp - 0x34], 0);       /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1010_dc14, 2); if(jzd(0x1010_dc57, 0x41)) goto l_0x1010_dc57; /* jz 0x1010dc57 */
            ii(0x1010_dc16, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_dc19, 4); mov(ax, memw_a32[ds, eax + 0x6]);       /* mov ax, [eax+0x6] */
            ii(0x1010_dc1d, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_dc20, 4); sub(ax, memw_a32[ds, edx + 0x2]);       /* sub ax, [edx+0x2] */
            ii(0x1010_dc24, 1); cwde();                                 /* cwde */
            ii(0x1010_dc25, 1); pushd(eax);                             /* push eax */
            ii(0x1010_dc26, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_dc29, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x1010_dc2d, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_dc30, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x1010_dc33, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_dc36, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_dc39, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1010_dc3b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_dc3e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_dc41, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1010_dc44, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1010_dc47, 5); calld(0x100c_e39d, -0x3_f8af);          /* call 0x100ce39d */
            ii(0x1010_dc4c, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1010_dc4f, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1010_dc52, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1010_dc55, 2); jmpd(0x1010_dc5d, 0x6); goto l_0x1010_dc5d; /* jmp 0x1010dc5d */
        l_0x1010_dc57:
            ii(0x1010_dc57, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1010_dc5a, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
        l_0x1010_dc5d:
            ii(0x1010_dc5d, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_dc61, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_dc64, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_dc67, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_dc69, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_dc6c, 3); mov(memd_a32[ds, edx + 0x14], eax);     /* mov [edx+0x14], eax */
            ii(0x1010_dc6f, 5); jmpd(0x1010_dd2e, 0xba); goto l_0x1010_dd2e; /* jmp 0x1010dd2e */
        l_0x1010_dc74:
            ii(0x1010_dc74, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_dc79, 5); calld(Definitions.sys_new, 0x5_8182);   /* call 0x10165e00 */
            ii(0x1010_dc7e, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1010_dc81, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1010_dc84, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1010_dc87, 4); cmp(memd_a32[ss, ebp - 0x44], 0);       /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1010_dc8b, 2); if(jzd(0x1010_dcc3, 0x36)) goto l_0x1010_dcc3; /* jz 0x1010dcc3 */
            ii(0x1010_dc8d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_dc90, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_dc92, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_dc95, 1); pushd(eax);                             /* push eax */
            ii(0x1010_dc96, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_dc99, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1010_dc9c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_dc9f, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1010_dca3, 1); inc(eax);                               /* inc eax */
            ii(0x1010_dca4, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_dca7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_dcaa, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x1010_dcad, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_dcb0, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1010_dcb3, 5); calld(Definitions.my_ctor_c17, -0x3_f8a9); /* call 0x100ce40f */
            ii(0x1010_dcb8, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1010_dcbb, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1010_dcbe, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1010_dcc1, 2); jmpd(0x1010_dcc9, 0x6); goto l_0x1010_dcc9; /* jmp 0x1010dcc9 */
        l_0x1010_dcc3:
            ii(0x1010_dcc3, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1010_dcc6, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
        l_0x1010_dcc9:
            ii(0x1010_dcc9, 4); movsx(edx, memb_a32[ss, ebp - 0x8]);    /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_dccd, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1010_dcd0, 3); add(edx, memd_a32[ss, ebp - 0xc]);      /* add edx, [ebp-0xc] */
            ii(0x1010_dcd3, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1010_dcd6, 3); mov(memd_a32[ds, edx + 0x14], eax);     /* mov [edx+0x14], eax */
            ii(0x1010_dcd9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_dcdc, 4); cmp(memd_a32[ds, eax + 0xa], 0);        /* cmp dword [eax+0xa], 0x0 */
            ii(0x1010_dce0, 2); if(jzd(0x1010_dd2e, 0x4c)) goto l_0x1010_dd2e; /* jz 0x1010dd2e */
            ii(0x1010_dce2, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1010_dce5, 5); calld(0x100d_5224, -0x3_8ac6);          /* call 0x100d5224 */
            ii(0x1010_dcea, 1); pushd(eax);                             /* push eax */
            ii(0x1010_dceb, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1010_dcee, 5); calld(0x100d_5250, -0x3_8aa3);          /* call 0x100d5250 */
            ii(0x1010_dcf3, 1); pushd(eax);                             /* push eax */
            ii(0x1010_dcf4, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1010_dcf7, 5); calld(0x100d_527c, -0x3_8a80);          /* call 0x100d527c */
            ii(0x1010_dcfc, 1); pushd(eax);                             /* push eax */
            ii(0x1010_dcfd, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1010_dd00, 5); calld(0x100d_52a8, -0x3_8a5d);          /* call 0x100d52a8 */
            ii(0x1010_dd05, 1); pushd(eax);                             /* push eax */
            ii(0x1010_dd06, 5); calld(0x100d_52d4, -0x3_8a37);          /* call 0x100d52d4 */
            ii(0x1010_dd0b, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_dd0e, 5); calld(0x100d_52f8, -0x3_8a1b);          /* call 0x100d52f8 */
            ii(0x1010_dd13, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_dd16, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_dd19, 3); mov(edx, memd_a32[ds, eax + 0xa]);      /* mov edx, [eax+0xa] */
            ii(0x1010_dd1c, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_dd20, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_dd23, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_dd26, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1010_dd29, 5); calld(0x100c_ef64, -0x3_edca);          /* call 0x100cef64 */
        l_0x1010_dd2e:
            ii(0x1010_dd2e, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_dd32, 2); if(jzd(0x1010_dd69, 0x35)) goto l_0x1010_dd69; /* jz 0x1010dd69 */
            ii(0x1010_dd34, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1010_dd39, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_dd3d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_dd40, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_dd43, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1010_dd46, 5); calld(0x100d_5194, -0x3_8bb7);          /* call 0x100d5194 */
            ii(0x1010_dd4b, 4); movsx(edx, memb_a32[ss, ebp - 0x8]);    /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_dd4f, 6); add(edx, 0x3e8);                        /* add edx, 0x3e8 */
            ii(0x1010_dd55, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_dd59, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_dd5c, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_dd5f, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1010_dd62, 5); calld(0x100d_5164, -0x3_8c03);          /* call 0x100d5164 */
            ii(0x1010_dd67, 2); jmpd(0x1010_ddb5, 0x4c); goto l_0x1010_ddb5; /* jmp 0x1010ddb5 */
        l_0x1010_dd69:
            ii(0x1010_dd69, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_dd6b, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_dd6f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_dd72, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_dd75, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1010_dd78, 5); calld(0x100d_5194, -0x3_8be9);          /* call 0x100d5194 */
            ii(0x1010_dd7d, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_dd81, 6); lea(edx, eax + 0x3e8);                  /* lea edx, [eax+0x3e8] */
            ii(0x1010_dd87, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_dd8b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_dd8e, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_dd91, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1010_dd94, 5); calld(0x100d_5134, -0x3_8c65);          /* call 0x100d5134 */
            ii(0x1010_dd99, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_dd9d, 6); lea(edx, eax + 0x7000);                 /* lea edx, [eax+0x7000] */
            ii(0x1010_dda3, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_dda7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_ddaa, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_ddad, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1010_ddb0, 5); calld(0x100d_5164, -0x3_8c51);          /* call 0x100d5164 */
        l_0x1010_ddb5:
            ii(0x1010_ddb5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_ddb8, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x1010_ddbb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_ddbe, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ddc2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_ddc5, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_ddc8, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1010_ddcb, 5); calld(0x100d_50d4, -0x3_8cfc);          /* call 0x100d50d4 */
            ii(0x1010_ddd0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_ddd3, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_ddd5, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x1010_ddd8, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_dddc, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_dddf, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_dde2, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1010_dde5, 5); calld(0x100c_f85c, -0x3_e58e);          /* call 0x100cf85c */
            ii(0x1010_ddea, 4); movsx(edx, memb_a32[ss, ebp - 0x8]);    /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_ddee, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ddf2, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1010_ddf5, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_ddf8, 6); add(edx, 0x3e8);                        /* add edx, 0x3e8 */
            ii(0x1010_ddfe, 3); mov(memd_a32[ds, eax + 0x60], edx);     /* mov [eax+0x60], edx */
            ii(0x1010_de01, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_de05, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1010_de08, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_de0b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_de0d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_de10, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1010_de13, 3); mov(memd_a32[ds, edx + 0x64], eax);     /* mov [edx+0x64], eax */
            ii(0x1010_de16, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_de1a, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1010_de1d, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_de20, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_de22, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_de25, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_de28, 3); mov(memd_a32[ds, edx + 0x68], eax);     /* mov [edx+0x68], eax */
            ii(0x1010_de2b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_de2d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_de2e, 1); popd(edi);                              /* pop edi */
            ii(0x1010_de2f, 1); popd(esi);                              /* pop esi */
            ii(0x1010_de30, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_de31, 1); retd(); return;                         /* ret */
        }
    }
}
