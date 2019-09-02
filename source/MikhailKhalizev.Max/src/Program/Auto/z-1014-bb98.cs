using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_bb98-dd4936e1")]
        public void Method_1014_bb98()
        {
            ii(0x1014_bb98, 5); push(0x30);                             /* push 0x30 */
            ii(0x1014_bb9d, 5); call(Definitions.sys_check_available_stack_size, 0x1_a1b0); /* call 0x10165d52 */
            ii(0x1014_bba2, 1); push(ebx);                              /* push ebx */
            ii(0x1014_bba3, 1); push(ecx);                              /* push ecx */
            ii(0x1014_bba4, 1); push(edx);                              /* push edx */
            ii(0x1014_bba5, 1); push(esi);                              /* push esi */
            ii(0x1014_bba6, 1); push(edi);                              /* push edi */
            ii(0x1014_bba7, 1); push(ebp);                              /* push ebp */
            ii(0x1014_bba8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_bbaa, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_bbb0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_bbb3, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x1014_bbb7, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bbba, 5); call(0x1007_6998, -0xd_5227);           /* call 0x10076998 */
            ii(0x1014_bbbf, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_bbc2, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x1014_bbc6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_bbc8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bbcb, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_bbce, 5); call(0x1013_ad71, -0x1_0e62);           /* call 0x1013ad71 */
            ii(0x1014_bbd3, 2); test(al, al);                           /* test al, al */
            ii(0x1014_bbd5, 2); if(jz(0x1014_bbf7, 0x20)) goto l_0x1014_bbf7; /* jz 0x1014bbf7 */
            ii(0x1014_bbd7, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_bbda, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bbdd, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_bbe0, 5); call(0x1007_6884, -0xd_5361);           /* call 0x10076884 */
            ii(0x1014_bbe5, 5); call(0x1016_4285, 0x1_869b);            /* call 0x10164285 */
            ii(0x1014_bbea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_bbec, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bbef, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_bbf2, 5); call(0x100a_b2a8, -0xa_094f);           /* call 0x100ab2a8 */
        l_0x1014_bbf7:
            ii(0x1014_bbf7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bbfa, 4); test(memb[ds, eax + 105], 1);           /* test byte [eax+0x69], 0x1 */
            ii(0x1014_bbfe, 2); if(jz(0x1014_bc5a, 0x5a)) goto l_0x1014_bc5a; /* jz 0x1014bc5a */
            ii(0x1014_bc00, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1014_bc05, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bc08, 5); call(0x1014_b7be, -0x44f);              /* call 0x1014b7be */
            ii(0x1014_bc0d, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_bc10, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_bc14, 2); if(jz(0x1014_bc4a, 0x34)) goto l_0x1014_bc4a; /* jz 0x1014bc4a */
            ii(0x1014_bc16, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_bc18, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bc1b, 5); call(0x1013_ad11, -0x1_0f0f);           /* call 0x1013ad11 */
            ii(0x1014_bc20, 2); test(al, al);                           /* test al, al */
            ii(0x1014_bc22, 2); if(jnz(0x1014_bc48, 0x24)) goto l_0x1014_bc48; /* jnz 0x1014bc48 */
            ii(0x1014_bc24, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_bc27, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_bc2a, 5); call(0x1007_6884, -0xd_53ab);           /* call 0x10076884 */
            ii(0x1014_bc2f, 5); call(0x100e_0d64, -0x6_aed0);           /* call 0x100e0d64 */
            ii(0x1014_bc34, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_bc36, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bc39, 5); call(0x1007_6884, -0xd_53ba);           /* call 0x10076884 */
            ii(0x1014_bc3e, 5); call(0x100e_0d64, -0x6_aedf);           /* call 0x100e0d64 */
            ii(0x1014_bc43, 3); cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x1014_bc46, 2); if(jge(0x1014_bc4a, 2)) goto l_0x1014_bc4a; /* jge 0x1014bc4a */
        l_0x1014_bc48:
            ii(0x1014_bc48, 2); jmp(0x1014_bc4c, 2); goto l_0x1014_bc4c; /* jmp 0x1014bc4c */
        l_0x1014_bc4a:
            ii(0x1014_bc4a, 2); jmp(0x1014_bc5a, 0xe); goto l_0x1014_bc5a; /* jmp 0x1014bc5a */
        l_0x1014_bc4c:
            ii(0x1014_bc4c, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1014_bc4f, 3); add(edx, 0x70);                         /* add edx, 0x70 */
            ii(0x1014_bc52, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bc55, 5); call(0x1015_5344, 0x96ea);              /* call 0x10155344 */
        l_0x1014_bc5a:
            ii(0x1014_bc5a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bc5d, 4); test(memb[ds, eax + 105], 2);           /* test byte [eax+0x69], 0x2 */
            ii(0x1014_bc61, 2); if(jz(0x1014_bcbd, 0x5a)) goto l_0x1014_bcbd; /* jz 0x1014bcbd */
            ii(0x1014_bc63, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x1014_bc68, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bc6b, 5); call(0x1014_b7be, -0x4b2);              /* call 0x1014b7be */
            ii(0x1014_bc70, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_bc73, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_bc77, 2); if(jz(0x1014_bcad, 0x34)) goto l_0x1014_bcad; /* jz 0x1014bcad */
            ii(0x1014_bc79, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_bc7b, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bc7e, 5); call(0x1013_ad11, -0x1_0f72);           /* call 0x1013ad11 */
            ii(0x1014_bc83, 2); test(al, al);                           /* test al, al */
            ii(0x1014_bc85, 2); if(jnz(0x1014_bcab, 0x24)) goto l_0x1014_bcab; /* jnz 0x1014bcab */
            ii(0x1014_bc87, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_bc8a, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_bc8d, 5); call(0x1007_6884, -0xd_540e);           /* call 0x10076884 */
            ii(0x1014_bc92, 5); call(0x100e_0d64, -0x6_af33);           /* call 0x100e0d64 */
            ii(0x1014_bc97, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_bc99, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bc9c, 5); call(0x1007_6884, -0xd_541d);           /* call 0x10076884 */
            ii(0x1014_bca1, 5); call(0x100e_0d64, -0x6_af42);           /* call 0x100e0d64 */
            ii(0x1014_bca6, 3); cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x1014_bca9, 2); if(jge(0x1014_bcad, 2)) goto l_0x1014_bcad; /* jge 0x1014bcad */
        l_0x1014_bcab:
            ii(0x1014_bcab, 2); jmp(0x1014_bcaf, 2); goto l_0x1014_bcaf; /* jmp 0x1014bcaf */
        l_0x1014_bcad:
            ii(0x1014_bcad, 2); jmp(0x1014_bcbd, 0xe); goto l_0x1014_bcbd; /* jmp 0x1014bcbd */
        l_0x1014_bcaf:
            ii(0x1014_bcaf, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1014_bcb2, 3); add(edx, 0x70);                         /* add edx, 0x70 */
            ii(0x1014_bcb5, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bcb8, 5); call(0x1015_5344, 0x9687);              /* call 0x10155344 */
        l_0x1014_bcbd:
            ii(0x1014_bcbd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bcc0, 4); test(memb[ds, eax + 105], 4);           /* test byte [eax+0x69], 0x4 */
            ii(0x1014_bcc4, 2); if(jz(0x1014_bd1c, 0x56)) goto l_0x1014_bd1c; /* jz 0x1014bd1c */
            ii(0x1014_bcc6, 5); mov(edx, 4);                            /* mov edx, 0x4 */
            ii(0x1014_bccb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bcce, 5); call(0x1014_b7be, -0x515);              /* call 0x1014b7be */
            ii(0x1014_bcd3, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_bcd6, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_bcda, 2); if(jz(0x1014_bd1c, 0x40)) goto l_0x1014_bd1c; /* jz 0x1014bd1c */
            ii(0x1014_bcdc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_bcde, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bce1, 5); call(0x1013_ad11, -0x1_0fd5);           /* call 0x1013ad11 */
            ii(0x1014_bce6, 2); test(al, al);                           /* test al, al */
            ii(0x1014_bce8, 2); if(jnz(0x1014_bd0e, 0x24)) goto l_0x1014_bd0e; /* jnz 0x1014bd0e */
            ii(0x1014_bcea, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_bced, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_bcf0, 5); call(0x1007_6884, -0xd_5471);           /* call 0x10076884 */
            ii(0x1014_bcf5, 5); call(0x100e_0d64, -0x6_af96);           /* call 0x100e0d64 */
            ii(0x1014_bcfa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_bcfc, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bcff, 5); call(0x1007_6884, -0xd_5480);           /* call 0x10076884 */
            ii(0x1014_bd04, 5); call(0x100e_0d64, -0x6_afa5);           /* call 0x100e0d64 */
            ii(0x1014_bd09, 3); cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x1014_bd0c, 2); if(jge(0x1014_bd1c, 0xe)) goto l_0x1014_bd1c; /* jge 0x1014bd1c */
        l_0x1014_bd0e:
            ii(0x1014_bd0e, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1014_bd11, 3); add(edx, 0x70);                         /* add edx, 0x70 */
            ii(0x1014_bd14, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bd17, 5); call(0x1015_5344, 0x9628);              /* call 0x10155344 */
        l_0x1014_bd1c:
            ii(0x1014_bd1c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bd1f, 4); test(memb[ds, eax + 105], 8);           /* test byte [eax+0x69], 0x8 */
            ii(0x1014_bd23, 2); if(jz(0x1014_bd7b, 0x56)) goto l_0x1014_bd7b; /* jz 0x1014bd7b */
            ii(0x1014_bd25, 5); mov(edx, 8);                            /* mov edx, 0x8 */
            ii(0x1014_bd2a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bd2d, 5); call(0x1014_b7be, -0x574);              /* call 0x1014b7be */
            ii(0x1014_bd32, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_bd35, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_bd39, 2); if(jz(0x1014_bd7b, 0x40)) goto l_0x1014_bd7b; /* jz 0x1014bd7b */
            ii(0x1014_bd3b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_bd3d, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bd40, 5); call(0x1013_ad11, -0x1_1034);           /* call 0x1013ad11 */
            ii(0x1014_bd45, 2); test(al, al);                           /* test al, al */
            ii(0x1014_bd47, 2); if(jnz(0x1014_bd6d, 0x24)) goto l_0x1014_bd6d; /* jnz 0x1014bd6d */
            ii(0x1014_bd49, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_bd4c, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_bd4f, 5); call(0x1007_6884, -0xd_54d0);           /* call 0x10076884 */
            ii(0x1014_bd54, 5); call(0x100e_0d64, -0x6_aff5);           /* call 0x100e0d64 */
            ii(0x1014_bd59, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_bd5b, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bd5e, 5); call(0x1007_6884, -0xd_54df);           /* call 0x10076884 */
            ii(0x1014_bd63, 5); call(0x100e_0d64, -0x6_b004);           /* call 0x100e0d64 */
            ii(0x1014_bd68, 3); cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x1014_bd6b, 2); if(jge(0x1014_bd7b, 0xe)) goto l_0x1014_bd7b; /* jge 0x1014bd7b */
        l_0x1014_bd6d:
            ii(0x1014_bd6d, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1014_bd70, 3); add(edx, 0x70);                         /* add edx, 0x70 */
            ii(0x1014_bd73, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bd76, 5); call(0x1015_5344, 0x95c9);              /* call 0x10155344 */
        l_0x1014_bd7b:
            ii(0x1014_bd7b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bd7e, 4); test(memb[ds, eax + 105], 0x20);        /* test byte [eax+0x69], 0x20 */
            ii(0x1014_bd82, 2); if(jz(0x1014_bdda, 0x56)) goto l_0x1014_bdda; /* jz 0x1014bdda */
            ii(0x1014_bd84, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1014_bd89, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bd8c, 5); call(0x1014_b7be, -0x5d3);              /* call 0x1014b7be */
            ii(0x1014_bd91, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_bd94, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_bd98, 2); if(jz(0x1014_bdda, 0x40)) goto l_0x1014_bdda; /* jz 0x1014bdda */
            ii(0x1014_bd9a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_bd9c, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bd9f, 5); call(0x1013_ad11, -0x1_1093);           /* call 0x1013ad11 */
            ii(0x1014_bda4, 2); test(al, al);                           /* test al, al */
            ii(0x1014_bda6, 2); if(jnz(0x1014_bdcc, 0x24)) goto l_0x1014_bdcc; /* jnz 0x1014bdcc */
            ii(0x1014_bda8, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_bdab, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_bdae, 5); call(0x1007_6884, -0xd_552f);           /* call 0x10076884 */
            ii(0x1014_bdb3, 5); call(0x100e_0d64, -0x6_b054);           /* call 0x100e0d64 */
            ii(0x1014_bdb8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_bdba, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bdbd, 5); call(0x1007_6884, -0xd_553e);           /* call 0x10076884 */
            ii(0x1014_bdc2, 5); call(0x100e_0d64, -0x6_b063);           /* call 0x100e0d64 */
            ii(0x1014_bdc7, 3); cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x1014_bdca, 2); if(jge(0x1014_bdda, 0xe)) goto l_0x1014_bdda; /* jge 0x1014bdda */
        l_0x1014_bdcc:
            ii(0x1014_bdcc, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1014_bdcf, 3); add(edx, 0x70);                         /* add edx, 0x70 */
            ii(0x1014_bdd2, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bdd5, 5); call(0x1015_5344, 0x956a);              /* call 0x10155344 */
        l_0x1014_bdda:
            ii(0x1014_bdda, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bddd, 4); test(memb[ds, eax + 105], 0x10);        /* test byte [eax+0x69], 0x10 */
            ii(0x1014_bde1, 2); if(jz(0x1014_be39, 0x56)) goto l_0x1014_be39; /* jz 0x1014be39 */
            ii(0x1014_bde3, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1014_bde8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bdeb, 5); call(0x1014_b7be, -0x632);              /* call 0x1014b7be */
            ii(0x1014_bdf0, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_bdf3, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_bdf7, 2); if(jz(0x1014_be39, 0x40)) goto l_0x1014_be39; /* jz 0x1014be39 */
            ii(0x1014_bdf9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_bdfb, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bdfe, 5); call(0x1013_ad11, -0x1_10f2);           /* call 0x1013ad11 */
            ii(0x1014_be03, 2); test(al, al);                           /* test al, al */
            ii(0x1014_be05, 2); if(jnz(0x1014_be2b, 0x24)) goto l_0x1014_be2b; /* jnz 0x1014be2b */
            ii(0x1014_be07, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_be0a, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_be0d, 5); call(0x1007_6884, -0xd_558e);           /* call 0x10076884 */
            ii(0x1014_be12, 5); call(0x100e_0d64, -0x6_b0b3);           /* call 0x100e0d64 */
            ii(0x1014_be17, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_be19, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_be1c, 5); call(0x1007_6884, -0xd_559d);           /* call 0x10076884 */
            ii(0x1014_be21, 5); call(0x100e_0d64, -0x6_b0c2);           /* call 0x100e0d64 */
            ii(0x1014_be26, 3); cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x1014_be29, 2); if(jge(0x1014_be39, 0xe)) goto l_0x1014_be39; /* jge 0x1014be39 */
        l_0x1014_be2b:
            ii(0x1014_be2b, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1014_be2e, 3); add(edx, 0x70);                         /* add edx, 0x70 */
            ii(0x1014_be31, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_be34, 5); call(0x1015_5344, 0x950b);              /* call 0x10155344 */
        l_0x1014_be39:
            ii(0x1014_be39, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_be3c, 4); test(memb[ds, eax + 105], 0x80);        /* test byte [eax+0x69], 0x80 */
            ii(0x1014_be40, 2); if(jz(0x1014_be98, 0x56)) goto l_0x1014_be98; /* jz 0x1014be98 */
            ii(0x1014_be42, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1014_be47, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_be4a, 5); call(0x1014_b7be, -0x691);              /* call 0x1014b7be */
            ii(0x1014_be4f, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_be52, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_be56, 2); if(jz(0x1014_be98, 0x40)) goto l_0x1014_be98; /* jz 0x1014be98 */
            ii(0x1014_be58, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_be5a, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_be5d, 5); call(0x1013_ad11, -0x1_1151);           /* call 0x1013ad11 */
            ii(0x1014_be62, 2); test(al, al);                           /* test al, al */
            ii(0x1014_be64, 2); if(jnz(0x1014_be8a, 0x24)) goto l_0x1014_be8a; /* jnz 0x1014be8a */
            ii(0x1014_be66, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_be69, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_be6c, 5); call(0x1007_6884, -0xd_55ed);           /* call 0x10076884 */
            ii(0x1014_be71, 5); call(0x100e_0d64, -0x6_b112);           /* call 0x100e0d64 */
            ii(0x1014_be76, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_be78, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_be7b, 5); call(0x1007_6884, -0xd_55fc);           /* call 0x10076884 */
            ii(0x1014_be80, 5); call(0x100e_0d64, -0x6_b121);           /* call 0x100e0d64 */
            ii(0x1014_be85, 3); cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x1014_be88, 2); if(jge(0x1014_be98, 0xe)) goto l_0x1014_be98; /* jge 0x1014be98 */
        l_0x1014_be8a:
            ii(0x1014_be8a, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1014_be8d, 3); add(edx, 0x70);                         /* add edx, 0x70 */
            ii(0x1014_be90, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_be93, 5); call(0x1015_5344, 0x94ac);              /* call 0x10155344 */
        l_0x1014_be98:
            ii(0x1014_be98, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_be9b, 4); test(memb[ds, eax + 105], 0x40);        /* test byte [eax+0x69], 0x40 */
            ii(0x1014_be9f, 2); if(jz(0x1014_bef7, 0x56)) goto l_0x1014_bef7; /* jz 0x1014bef7 */
            ii(0x1014_bea1, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x1014_bea6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bea9, 5); call(0x1014_b7be, -0x6f0);              /* call 0x1014b7be */
            ii(0x1014_beae, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_beb1, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_beb5, 2); if(jz(0x1014_bef7, 0x40)) goto l_0x1014_bef7; /* jz 0x1014bef7 */
            ii(0x1014_beb7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_beb9, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bebc, 5); call(0x1013_ad11, -0x1_11b0);           /* call 0x1013ad11 */
            ii(0x1014_bec1, 2); test(al, al);                           /* test al, al */
            ii(0x1014_bec3, 2); if(jnz(0x1014_bee9, 0x24)) goto l_0x1014_bee9; /* jnz 0x1014bee9 */
            ii(0x1014_bec5, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_bec8, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_becb, 5); call(0x1007_6884, -0xd_564c);           /* call 0x10076884 */
            ii(0x1014_bed0, 5); call(0x100e_0d64, -0x6_b171);           /* call 0x100e0d64 */
            ii(0x1014_bed5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_bed7, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_beda, 5); call(0x1007_6884, -0xd_565b);           /* call 0x10076884 */
            ii(0x1014_bedf, 5); call(0x100e_0d64, -0x6_b180);           /* call 0x100e0d64 */
            ii(0x1014_bee4, 3); cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x1014_bee7, 2); if(jge(0x1014_bef7, 0xe)) goto l_0x1014_bef7; /* jge 0x1014bef7 */
        l_0x1014_bee9:
            ii(0x1014_bee9, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1014_beec, 3); add(edx, 0x70);                         /* add edx, 0x70 */
            ii(0x1014_beef, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bef2, 5); call(0x1015_5344, 0x944d);              /* call 0x10155344 */
        l_0x1014_bef7:
            ii(0x1014_bef7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_bef9, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_befc, 5); call(0x1013_ad11, -0x1_11f0);           /* call 0x1013ad11 */
            ii(0x1014_bf01, 2); test(al, al);                           /* test al, al */
            ii(0x1014_bf03, 2); if(jz(0x1014_bf1f, 0x1a)) goto l_0x1014_bf1f; /* jz 0x1014bf1f */
            ii(0x1014_bf05, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bf08, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1014_bf0b, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_bf0d, 1); cwde();                                 /* cwde */
            ii(0x1014_bf0e, 5); call(0x1014_892b, -0x35e8);             /* call 0x1014892b */
            ii(0x1014_bf13, 3); lea(ebx, memd[ss, ebp - 20]);           /* lea ebx, [ebp-0x14] */
            ii(0x1014_bf16, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_bf18, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_bf1a, 5); call(0x100a_b2a8, -0xa_0c77);           /* call 0x100ab2a8 */
        l_0x1014_bf1f:
            ii(0x1014_bf1f, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bf22, 5); call(0x1007_68e0, -0xd_5647);           /* call 0x100768e0 */
            ii(0x1014_bf27, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_bf29, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_bf2c, 5); call(0x1014_b9c9, -0x568);              /* call 0x1014b9c9 */
            ii(0x1014_bf31, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_bf33, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1014_bf36, 5); call(0x1007_5eac, -0xd_608f);           /* call 0x10075eac */
            ii(0x1014_bf3b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_bf3d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_bf3e, 1); pop(edi);                               /* pop edi */
            ii(0x1014_bf3f, 1); pop(esi);                               /* pop esi */
            ii(0x1014_bf40, 1); pop(edx);                               /* pop edx */
            ii(0x1014_bf41, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_bf42, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_bf43, 1); ret();                                  /* ret */
        }
    }
}
