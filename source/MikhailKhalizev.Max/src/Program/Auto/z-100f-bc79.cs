using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_bc79-b3c66a92")]
        public void Method_100f_bc79()
        {
            ii(0x100f_bc79, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_bc7d, 2); if(jz(0x100f_bc85, 6)) goto l_0x100f_bc85; /* jz 0x100fbc85 */
            ii(0x100f_bc7f, 4); cmp(memb[ss, ebp - 8], 6);              /* cmp byte [ebp-0x8], 0x6 */
            ii(0x100f_bc83, 2); if(jnz(0x100f_bc8a, 5)) goto l_0x100f_bc8a; /* jnz 0x100fbc8a */
        l_0x100f_bc85:
            ii(0x100f_bc85, 5); if(jmp_func(0x100f_bf54, 0x2ca)) return; /* jmp 0x100fbf54 */
        l_0x100f_bc8a:
            ii(0x100f_bc8a, 5); call(0x100e_a903, -0x1_138c);           /* call 0x100ea903 */
            ii(0x100f_bc8f, 7); mov(memb[ds, 0x101c_391e], 7);          /* mov byte [0x101c391e], 0x7 */
            ii(0x100f_bc96, 4); cmp(memb[ss, ebp - 12], 0);             /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100f_bc9a, 2); if(jz(0x100f_bcac, 0x10)) goto l_0x100f_bcac; /* jz 0x100fbcac */
        l_0x100f_bc9c:
            ii(0x100f_bc9c, 7); cmp(memb[ds, 0x101c_391e], 7);          /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_bca3, 2); if(jnz(0x100f_bcac, 7)) goto l_0x100f_bcac; /* jnz 0x100fbcac */
            ii(0x100f_bca5, 5); call(0x1010_132c, 0x5682);              /* call 0x1010132c */
            ii(0x100f_bcaa, 2); jmp(0x100f_bc9c, -0x10); goto l_0x100f_bc9c; /* jmp 0x100fbc9c */
        l_0x100f_bcac:
            ii(0x100f_bcac, 7); cmp(memb[ds, 0x101c_391e], 0xe);        /* cmp byte [0x101c391e], 0xe */
            ii(0x100f_bcb3, 2); if(jz(0x100f_bcbe, 9)) goto l_0x100f_bcbe; /* jz 0x100fbcbe */
            ii(0x100f_bcb5, 7); cmp(memb[ds, 0x101c_391e], 3);          /* cmp byte [0x101c391e], 0x3 */
            ii(0x100f_bcbc, 2); if(jnz(0x100f_bcc0, 2)) goto l_0x100f_bcc0; /* jnz 0x100fbcc0 */
        l_0x100f_bcbe:
            ii(0x100f_bcbe, 2); jmp(0x100f_bcc9, 9); goto l_0x100f_bcc9; /* jmp 0x100fbcc9 */
        l_0x100f_bcc0:
            ii(0x100f_bcc0, 7); cmp(memb[ds, 0x101c_391e], 0xf);        /* cmp byte [0x101c391e], 0xf */
            ii(0x100f_bcc7, 2); if(jnz(0x100f_bcd2, 9)) goto l_0x100f_bcd2; /* jnz 0x100fbcd2 */
        l_0x100f_bcc9:
            ii(0x100f_bcc9, 4); mov(memb[ss, ebp - 8], 6);              /* mov byte [ebp-0x8], 0x6 */
            ii(0x100f_bccd, 5); if(jmp_func(0x100f_bf54, 0x282)) return; /* jmp 0x100fbf54 */
        l_0x100f_bcd2:
            ii(0x100f_bcd2, 7); mov(memb[ds, 0x101c_391e], 7);          /* mov byte [0x101c391e], 0x7 */
            ii(0x100f_bcd9, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100f_bcde, 5); call(0x1012_0d94, 0x2_50b1);            /* call 0x10120d94 */
            ii(0x100f_bce3, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_bce7, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_bcea, 7); mov(ax, memw[ds, eax + 0x101c_35bc]);   /* mov ax, [eax+0x101c35bc] */
            ii(0x100f_bcf1, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x100f_bcf4, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_bcf8, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_bcfb, 7); mov(ax, memw[ds, eax + 0x101c_35be]);   /* mov ax, [eax+0x101c35be] */
            ii(0x100f_bd02, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100f_bd05, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_bd07, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_bd0c, 5); call(0x1013_ad11, 0x3_f000);            /* call 0x1013ad11 */
            ii(0x100f_bd11, 2); test(al, al);                           /* test al, al */
            ii(0x100f_bd13, 6); if(jz(0x100f_bda1, 0x88)) goto l_0x100f_bda1; /* jz 0x100fbda1 */
            ii(0x100f_bd19, 2); push(0);                                /* push 0x0 */
            ii(0x100f_bd1b, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100f_bd1f, 1); push(eax);                              /* push eax */
            ii(0x100f_bd20, 4); movsx(ecx, memw[ss, ebp - 56]);         /* movsx ecx, word [ebp-0x38] */
            ii(0x100f_bd24, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_bd28, 5); mov(edx, 0x30);                         /* mov edx, 0x30 */
            ii(0x100f_bd2d, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x100f_bd30, 5); call(0x1015_a6aa, 0x5_e975);            /* call 0x1015a6aa */
            ii(0x100f_bd35, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_bd37, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_bd3c, 5); call(0x1008_ac18, -0x7_1129);           /* call 0x1008ac18 */
            ii(0x100f_bd41, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_bd43, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x100f_bd46, 5); call(0x1007_5f2c, -0x8_5e1f);           /* call 0x10075f2c */
            ii(0x100f_bd4b, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_bd50, 5); call(0x1007_6574, -0x8_57e1);           /* call 0x10076574 */
            ii(0x100f_bd55, 4); mov(memb[ds, eax + 61], 0x10);          /* mov byte [eax+0x3d], 0x10 */
            ii(0x100f_bd59, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_bd5e, 5); call(0x1007_6574, -0x8_57ef);           /* call 0x10076574 */
            ii(0x100f_bd63, 5); call(0x1007_623c, -0x8_5b2c);           /* call 0x1007623c */
            ii(0x100f_bd68, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_bd6a, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100f_bd6d, 5); call(0x100c_b77c, -0x3_05f6);           /* call 0x100cb77c */
            ii(0x100f_bd72, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100f_bd75, 5); call(0x1007_6730, -0x8_564a);           /* call 0x10076730 */
            ii(0x100f_bd7a, 4); mov(ax, memw[ds, eax + 18]);            /* mov ax, [eax+0x12] */
            ii(0x100f_bd7e, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100f_bd81, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100f_bd84, 5); call(0x1007_6730, -0x8_5659);           /* call 0x10076730 */
            ii(0x100f_bd89, 4); mov(ax, memw[ds, eax + 23]);            /* mov ax, [eax+0x17] */
            ii(0x100f_bd8d, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100f_bd90, 7); mov(memb[ds, 0x101c_388a], 1);          /* mov byte [0x101c388a], 0x1 */
            ii(0x100f_bd97, 5); mov(al, memb[ds, 0x101c_388a]);         /* mov al, [0x101c388a] */
            ii(0x100f_bd9c, 5); mov(memb[ds, 0x101c_3889], al);         /* mov [0x101c3889], al */
        l_0x100f_bda1:
            ii(0x100f_bda1, 4); cmp(memb[ss, ebp - 12], 0);             /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100f_bda5, 2); if(jz(0x100f_bdad, 6)) goto l_0x100f_bdad; /* jz 0x100fbdad */
            ii(0x100f_bda7, 4); cmp(memb[ss, ebp - 8], 2);              /* cmp byte [ebp-0x8], 0x2 */
            ii(0x100f_bdab, 2); if(jz(0x100f_bdaf, 2)) goto l_0x100f_bdaf; /* jz 0x100fbdaf */
        l_0x100f_bdad:
            ii(0x100f_bdad, 2); jmp(0x100f_be09, 0x5a); goto l_0x100f_be09; /* jmp 0x100fbe09 */
        l_0x100f_bdaf:
            ii(0x100f_bdaf, 4); movsx(edx, memw[ss, ebp - 56]);         /* movsx edx, word [ebp-0x38] */
            ii(0x100f_bdb3, 4); movsx(eax, memw[ss, ebp - 40]);         /* movsx eax, word [ebp-0x28] */
            ii(0x100f_bdb7, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100f_bdb9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_bdbb, 5); call(/* sys */ 0x1016_5df8, 0x6_a038);  /* call 0x10165df8 */
            ii(0x100f_bdc0, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x100f_bdc3, 2); if(jg(0x100f_bddb, 0x16)) goto l_0x100f_bddb; /* jg 0x100fbddb */
            ii(0x100f_bdc5, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x100f_bdc9, 4); movsx(eax, memw[ss, ebp - 36]);         /* movsx eax, word [ebp-0x24] */
            ii(0x100f_bdcd, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100f_bdcf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_bdd1, 5); call(/* sys */ 0x1016_5df8, 0x6_a022);  /* call 0x10165df8 */
            ii(0x100f_bdd6, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x100f_bdd9, 2); if(jle(0x100f_bddd, 2)) goto l_0x100f_bddd; /* jle 0x100fbddd */
        l_0x100f_bddb:
            ii(0x100f_bddb, 2); jmp(0x100f_be05, 0x28); goto l_0x100f_be05; /* jmp 0x100fbe05 */
        l_0x100f_bddd:
            ii(0x100f_bddd, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100f_bde1, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100f_bde4, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100f_bde7, 7); mov(memw[ds, edx + 0x101c_35bc], ax);   /* mov [edx+0x101c35bc], ax */
            ii(0x100f_bdee, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100f_bdf2, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100f_bdf5, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100f_bdf8, 7); mov(memw[ds, edx + 0x101c_35be], ax);   /* mov [edx+0x101c35be], ax */
            ii(0x100f_bdff, 4); mov(memb[ss, ebp - 8], 4);              /* mov byte [ebp-0x8], 0x4 */
            ii(0x100f_be03, 2); jmp(0x100f_be09, 4); goto l_0x100f_be09; /* jmp 0x100fbe09 */
        l_0x100f_be05:
            ii(0x100f_be05, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
        l_0x100f_be09:
            ii(0x100f_be09, 4); cmp(memb[ss, ebp - 8], 1);              /* cmp byte [ebp-0x8], 0x1 */
            ii(0x100f_be0d, 2); if(jz(0x100f_be15, 6)) goto l_0x100f_be15; /* jz 0x100fbe15 */
            ii(0x100f_be0f, 4); cmp(memb[ss, ebp - 8], 2);              /* cmp byte [ebp-0x8], 0x2 */
            ii(0x100f_be13, 2); if(jnz(0x100f_be17, 2)) goto l_0x100f_be17; /* jnz 0x100fbe17 */
        l_0x100f_be15:
            ii(0x100f_be15, 2); jmp(0x100f_be1d, 6); goto l_0x100f_be1d; /* jmp 0x100fbe1d */
        l_0x100f_be17:
            ii(0x100f_be17, 4); cmp(memb[ss, ebp - 8], 3);              /* cmp byte [ebp-0x8], 0x3 */
            ii(0x100f_be1b, 2); if(jnz(0x100f_be39, 0x1c)) goto l_0x100f_be39; /* jnz 0x100fbe39 */
        l_0x100f_be1d:
            ii(0x100f_be1d, 4); movsx(ebx, memw[ss, ebp - 24]);         /* movsx ebx, word [ebp-0x18] */
            ii(0x100f_be21, 4); movsx(edx, memw[ss, ebp - 56]);         /* movsx edx, word [ebp-0x38] */
            ii(0x100f_be25, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_be2a, 5); call(0x1008_abbc, -0x7_1273);           /* call 0x1008abbc */
            ii(0x100f_be2f, 5); call(0x1016_309a, 0x6_7266);            /* call 0x1016309a */
            ii(0x100f_be34, 5); call(0x100f_b889, -0x5b0);              /* call 0x100fb889 */
        l_0x100f_be39:
            ii(0x100f_be39, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100f_be3d, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100f_be40, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100f_be43, 6); mov(memb[ds, edx + 0x101c_35c6], al);   /* mov [edx+0x101c35c6], al */
            ii(0x100f_be49, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_be50, 2); if(jz(0x100f_be65, 0x13)) goto l_0x100f_be65; /* jz 0x100fbe65 */
            ii(0x100f_be52, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_be56, 5); call(0x1012_8f02, 0x2_d0a7);            /* call 0x10128f02 */
            ii(0x100f_be5b, 5); call(0x1012_99ef, 0x2_db8f);            /* call 0x101299ef */
            ii(0x100f_be60, 3); mov(memb[ss, ebp - 52], al);            /* mov [ebp-0x34], al */
            ii(0x100f_be63, 2); jmp(0x100f_be7f, 0x1a); goto l_0x100f_be7f; /* jmp 0x100fbe7f */
        l_0x100f_be65:
            ii(0x100f_be65, 4); cmp(memb[ss, ebp - 12], 0);             /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100f_be69, 2); if(jz(0x100f_be79, 0xe)) goto l_0x100f_be79; /* jz 0x100fbe79 */
            ii(0x100f_be6b, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_be6f, 5); call(0x100f_bafc, -0x378);              /* call 0x100fbafc */
            ii(0x100f_be74, 3); mov(memb[ss, ebp - 52], al);            /* mov [ebp-0x34], al */
            ii(0x100f_be77, 2); jmp(0x100f_be7f, 6); goto l_0x100f_be7f; /* jmp 0x100fbe7f */
        l_0x100f_be79:
            ii(0x100f_be79, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100f_be7c, 3); mov(memb[ss, ebp - 52], al);            /* mov [ebp-0x34], al */
        l_0x100f_be7f:
            ii(0x100f_be7f, 3); mov(al, memb[ss, ebp - 52]);            /* mov al, [ebp-0x34] */
            ii(0x100f_be82, 3); mov(memb[ss, ebp - 64], al);            /* mov [ebp-0x40], al */
            ii(0x100f_be85, 5); if(jmp_func(0x100f_bf34, 0xaa)) return; /* jmp 0x100fbf34 */
        }
    }
}
