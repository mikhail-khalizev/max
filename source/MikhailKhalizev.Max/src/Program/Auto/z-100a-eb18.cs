using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_eb18-9429c5c8")]
        public void Method_100a_eb18()
        {
            ii(0x100a_eb18, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x100a_eb1d, 5); calld(Definitions.sys_check_available_stack_size, 0xb_7230); /* call 0x10165d52 */
            ii(0x100a_eb22, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_eb23, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_eb24, 1); pushd(edx);                             /* push edx */
            ii(0x100a_eb25, 1); pushd(esi);                             /* push esi */
            ii(0x100a_eb26, 1); pushd(edi);                             /* push edi */
            ii(0x100a_eb27, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_eb28, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_eb2a, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100a_eb30, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_eb33, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_eb35, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_eb38, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_eb3b, 5); calld(0x100a_aa28, -0x4118);            /* call 0x100aaa28 */
            ii(0x100a_eb40, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x100a_eb43, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_eb45, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_eb47, 5); calld(0x1007_5e64, -0x3_8ce8);          /* call 0x10075e64 */
            ii(0x100a_eb4c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_eb4e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_eb51, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_eb54, 5); calld(0x1007_65d0, -0x3_8589);          /* call 0x100765d0 */
            ii(0x100a_eb59, 5); calld(0x1007_0ca1, -0x3_debd);          /* call 0x10070ca1 */
            ii(0x100a_eb5e, 1); cwde();                                 /* cwde */
            ii(0x100a_eb5f, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_eb62, 2); if(jled(0x100a_eb6d, 0x9)) goto l_0x100a_eb6d; /* jle 0x100aeb6d */
            ii(0x100a_eb64, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_eb68, 5); jmpd(0x100a_edfa, 0x28d); goto l_0x100a_edfa; /* jmp 0x100aedfa */
        l_0x100a_eb6d:
            ii(0x100a_eb6d, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100a_eb74, 2); jmpd(0x100a_eb7c, 0x6); goto l_0x100a_eb7c; /* jmp 0x100aeb7c */
        l_0x100a_eb76:
            ii(0x100a_eb76, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_eb79, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100a_eb7c:
            ii(0x100a_eb7c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_eb7f, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_eb82, 5); calld(Definitions.my_3_get_count, -0x2_3707); /* call 0x1008b480 */
            ii(0x100a_eb87, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100a_eb8b, 6); if(jled(0x100a_ec2a, 0x99)) goto l_0x100a_ec2a; /* jle 0x100aec2a */
            ii(0x100a_eb91, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100a_eb96, 1); pushd(eax);                             /* push eax */
            ii(0x100a_eb97, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100a_eb9b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_eb9e, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_eba1, 5); calld(0x100a_aa28, -0x417e);            /* call 0x100aaa28 */
            ii(0x100a_eba6, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x100a_eba8, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100a_ebab, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100a_ebaf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ebb2, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ebb5, 5); calld(0x100a_aa28, -0x4192);            /* call 0x100aaa28 */
            ii(0x100a_ebba, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100a_ebbd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_ebc0, 3); mov(edx, memd_a32[ds, edx + 0x7]);      /* mov edx, [edx+0x7] */
            ii(0x100a_ebc3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_ebc6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ebc9, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_ebcc, 5); calld(0x1007_6574, -0x3_865d);          /* call 0x10076574 */
            ii(0x100a_ebd1, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100a_ebd4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_ebd7, 5); calld(0x1007_02b9, -0x3_e923);          /* call 0x100702b9 */
            ii(0x100a_ebdc, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100a_ebdf, 2); if(jnzd(0x100a_ebea, 0x9)) goto l_0x100a_ebea; /* jnz 0x100aebea */
            ii(0x100a_ebe1, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_ebe5, 5); jmpd(0x100a_edfa, 0x210); goto l_0x100a_edfa; /* jmp 0x100aedfa */
        l_0x100a_ebea:
            ii(0x100a_ebea, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100a_ebee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ebf1, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ebf4, 5); calld(0x100a_aa28, -0x41d1);            /* call 0x100aaa28 */
            ii(0x100a_ebf9, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x100a_ebfc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ebff, 4); cmp(dx, memw_a32[ds, eax + 0x1a]);      /* cmp dx, [eax+0x1a] */
            ii(0x100a_ec03, 2); if(jnzd(0x100a_ec21, 0x1c)) goto l_0x100a_ec21; /* jnz 0x100aec21 */
            ii(0x100a_ec05, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100a_ec09, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ec0c, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ec0f, 5); calld(0x100a_aa28, -0x41ec);            /* call 0x100aaa28 */
            ii(0x100a_ec14, 4); mov(dx, memw_a32[ds, eax + 0x2]);       /* mov dx, [eax+0x2] */
            ii(0x100a_ec18, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ec1b, 4); cmp(dx, memw_a32[ds, eax + 0x1c]);      /* cmp dx, [eax+0x1c] */
            ii(0x100a_ec1f, 2); if(jzd(0x100a_ec23, 0x2)) goto l_0x100a_ec23; /* jz 0x100aec23 */
        l_0x100a_ec21:
            ii(0x100a_ec21, 2); jmpd(0x100a_ec25, 0x2); goto l_0x100a_ec25; /* jmp 0x100aec25 */
        l_0x100a_ec23:
            ii(0x100a_ec23, 2); jmpd(0x100a_ec2a, 0x5); goto l_0x100a_ec2a; /* jmp 0x100aec2a */
        l_0x100a_ec25:
            ii(0x100a_ec25, 5); jmpd(0x100a_eb76, -0xb4); goto l_0x100a_eb76; /* jmp 0x100aeb76 */
        l_0x100a_ec2a:
            ii(0x100a_ec2a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ec2d, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ec30, 5); calld(Definitions.my_3_get_count, -0x2_37b5); /* call 0x1008b480 */
            ii(0x100a_ec35, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100a_ec39, 2); if(jnzd(0x100a_ec44, 0x9)) goto l_0x100a_ec44; /* jnz 0x100aec44 */
            ii(0x100a_ec3b, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_ec3f, 5); jmpd(0x100a_edfa, 0x1b6); goto l_0x100a_edfa; /* jmp 0x100aedfa */
        l_0x100a_ec44:
            ii(0x100a_ec44, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x100a_ec49, 5); calld(Definitions.sys_new, 0xb_71b2);   /* call 0x10165e00 */
            ii(0x100a_ec4e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_ec51, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_ec54, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_ec57, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100a_ec5b, 2); if(jzd(0x100a_ec82, 0x25)) goto l_0x100a_ec82; /* jz 0x100aec82 */
            ii(0x100a_ec5d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ec60, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100a_ec63, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_ec66, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ec69, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100a_ec6c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_ec6f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_ec72, 5); calld(Definitions.my_ctor_c20, 0x6_b2df); /* call 0x10119f56 */
            ii(0x100a_ec77, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_ec7a, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100a_ec7d, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100a_ec80, 2); jmpd(0x100a_ec88, 0x6); goto l_0x100a_ec88; /* jmp 0x100aec88 */
        l_0x100a_ec82:
            ii(0x100a_ec82, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_ec85, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x100a_ec88:
            ii(0x100a_ec88, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x100a_ec8b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_ec8e, 5); calld(0x100a_b3b0, -0x38e3);            /* call 0x100ab3b0 */
            ii(0x100a_ec93, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ec96, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_ec99, 5); calld(0x1007_6574, -0x3_872a);          /* call 0x10076574 */
            ii(0x100a_ec9e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_eca0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_eca2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_eca5, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_eca8, 5); calld(0x100a_aa28, -0x4285);            /* call 0x100aaa28 */
            ii(0x100a_ecad, 4); mov(dx, memw_a32[ds, ebx + 0x1a]);      /* mov dx, [ebx+0x1a] */
            ii(0x100a_ecb1, 3); cmp(dx, memw_a32[ds, eax]);             /* cmp dx, [eax] */
            ii(0x100a_ecb4, 2); if(jnzd(0x100a_ecda, 0x24)) goto l_0x100a_ecda; /* jnz 0x100aecda */
            ii(0x100a_ecb6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ecb9, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_ecbc, 5); calld(0x1007_6574, -0x3_874d);          /* call 0x10076574 */
            ii(0x100a_ecc1, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_ecc3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_ecc5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ecc8, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_eccb, 5); calld(0x100a_aa28, -0x42a8);            /* call 0x100aaa28 */
            ii(0x100a_ecd0, 4); mov(dx, memw_a32[ds, ebx + 0x1c]);      /* mov dx, [ebx+0x1c] */
            ii(0x100a_ecd4, 4); cmp(dx, memw_a32[ds, eax + 0x2]);       /* cmp dx, [eax+0x2] */
            ii(0x100a_ecd8, 2); if(jzd(0x100a_ed34, 0x5a)) goto l_0x100a_ed34; /* jz 0x100aed34 */
        l_0x100a_ecda:
            ii(0x100a_ecda, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_ecdc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ecdf, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ece2, 5); calld(0x100a_aa28, -0x42bf);            /* call 0x100aaa28 */
            ii(0x100a_ece7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_ece9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ecec, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_ecef, 5); calld(0x1007_6574, -0x3_8780);          /* call 0x10076574 */
            ii(0x100a_ecf4, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_ecf6, 4); mov(ax, memw_a32[ds, edx + 0x2]);       /* mov ax, [edx+0x2] */
            ii(0x100a_ecfa, 4); sub(ax, memw_a32[ds, ebx + 0x1c]);      /* sub ax, [ebx+0x1c] */
            ii(0x100a_ecfe, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100a_ed01, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ed04, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_ed07, 5); calld(0x1007_6574, -0x3_8798);          /* call 0x10076574 */
            ii(0x100a_ed0c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_ed0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_ed10, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ed13, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ed16, 5); calld(0x100a_aa28, -0x42f3);            /* call 0x100aaa28 */
            ii(0x100a_ed1b, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100a_ed1e, 4); sub(ax, memw_a32[ds, ebx + 0x1a]);      /* sub ax, [ebx+0x1a] */
            ii(0x100a_ed22, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_ed25, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_ed28, 5); calld(0x100a_b2e0, -0x3a4d);            /* call 0x100ab2e0 */
            ii(0x100a_ed2d, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x100a_ed2f, 5); calld(0x1011_aca3, 0x6_bf6f);           /* call 0x1011aca3 */
        l_0x100a_ed34:
            ii(0x100a_ed34, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
            ii(0x100a_ed3b, 2); jmpd(0x100a_ed43, 0x6); goto l_0x100a_ed43; /* jmp 0x100aed43 */
        l_0x100a_ed3d:
            ii(0x100a_ed3d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_ed40, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100a_ed43:
            ii(0x100a_ed43, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_ed46, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100a_ed4a, 2); if(jgd(0x100a_edbb, 0x6f)) goto l_0x100a_edbb; /* jg 0x100aedbb */
            ii(0x100a_ed4c, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100a_ed50, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ed53, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ed56, 5); calld(0x100a_aa28, -0x4333);            /* call 0x100aaa28 */
            ii(0x100a_ed5b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_ed5d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_ed60, 1); dec(eax);                               /* dec eax */
            ii(0x100a_ed61, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_ed64, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ed67, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ed6a, 5); calld(0x100a_aa28, -0x4347);            /* call 0x100aaa28 */
            ii(0x100a_ed6f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_ed71, 4); mov(ax, memw_a32[ds, ebx + 0x2]);       /* mov ax, [ebx+0x2] */
            ii(0x100a_ed75, 4); sub(ax, memw_a32[ds, edx + 0x2]);       /* sub ax, [edx+0x2] */
            ii(0x100a_ed79, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100a_ed7c, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100a_ed80, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ed83, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ed86, 5); calld(0x100a_aa28, -0x4363);            /* call 0x100aaa28 */
            ii(0x100a_ed8b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_ed8d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_ed90, 1); dec(eax);                               /* dec eax */
            ii(0x100a_ed91, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_ed94, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ed97, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_ed9a, 5); calld(0x100a_aa28, -0x4377);            /* call 0x100aaa28 */
            ii(0x100a_ed9f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_eda1, 3); mov(ax, memw_a32[ds, ebx]);             /* mov ax, [ebx] */
            ii(0x100a_eda4, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x100a_eda7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_edaa, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_edad, 5); calld(0x100a_b2e0, -0x3ad2);            /* call 0x100ab2e0 */
            ii(0x100a_edb2, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x100a_edb4, 5); calld(0x1011_aca3, 0x6_beea);           /* call 0x1011aca3 */
            ii(0x100a_edb9, 2); jmpd(0x100a_ed3d, -0x7e); goto l_0x100a_ed3d; /* jmp 0x100aed3d */
        l_0x100a_edbb:
            ii(0x100a_edbb, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_edbe, 3); add(edx, 0x22);                         /* add edx, 0x22 */
            ii(0x100a_edc1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_edc4, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100a_edc7, 5); calld(0x1008_8b44, -0x2_6288);          /* call 0x10088b44 */
            ii(0x100a_edcc, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_edcf, 5); calld(0x100a_b33c, -0x3a98);            /* call 0x100ab33c */
            ii(0x100a_edd4, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_edd7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_edd9, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_eddb, 5); calld(0x100a_fbb7, 0xdd7);              /* call 0x100afbb7 */
            ii(0x100a_ede0, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_ede4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_ede6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100a_ede9, 5); calld(0x100a_9f38, -0x4eb6);            /* call 0x100a9f38 */
            ii(0x100a_edee, 2); jmpd(0x100a_edfa, 0xa); goto l_0x100a_edfa; /* jmp 0x100aedfa */
        //  ii(0x100a_edf0, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100a_edf2, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
        //  ii(0x100a_edf5, 5); calld(0x100a_9f38, -0x4ec2);            /* call 0x100a9f38 */
        l_0x100a_edfa:
            ii(0x100a_edfa, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_edfd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_edff, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_ee00, 1); popd(edi);                              /* pop edi */
            ii(0x100a_ee01, 1); popd(esi);                              /* pop esi */
            ii(0x100a_ee02, 1); popd(edx);                              /* pop edx */
            ii(0x100a_ee03, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_ee04, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_ee05, 1); retd();                                 /* ret */
        }
    }
}
