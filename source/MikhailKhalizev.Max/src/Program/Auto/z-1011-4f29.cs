using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_4f29-d6944e12")]
        public void Method_1011_4f29()
        {
            ii(0x1011_4f29, 5); push(0x608);                            /* push 0x608 */
            ii(0x1011_4f2e, 5); call(Definitions.sys_check_available_stack_size, 0x5_0e1f); /* call 0x10165d52 */
            ii(0x1011_4f33, 1); push(ecx);                              /* push ecx */
            ii(0x1011_4f34, 1); push(esi);                              /* push esi */
            ii(0x1011_4f35, 1); push(edi);                              /* push edi */
            ii(0x1011_4f36, 1); push(ebp);                              /* push ebp */
            ii(0x1011_4f37, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_4f39, 6); sub(esp, 0x5f4);                        /* sub esp, 0x5f4 */
            ii(0x1011_4f3f, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x1011_4f42, 3); mov(memb[ss, ebp - 8], dl);             /* mov [ebp-0x8], dl */
            ii(0x1011_4f45, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x1011_4f48, 4); mov(memb[ss, ebp - 16], 0);             /* mov byte [ebp-0x10], 0x0 */
            ii(0x1011_4f4c, 5); call(0x1014_82f4, 0x3_33a3);            /* call 0x101482f4 */
            ii(0x1011_4f51, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1011_4f54, 4); cmp(memb[ss, ebp - 12], 0);             /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1011_4f58, 2); if(jz(0x1011_4f79, 0x1f)) goto l_0x1011_4f79; /* jz 0x10114f79 */
            ii(0x1011_4f5a, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1011_4f5f, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1011_4f64, 5); call(0x1010_8905, -0xc664);             /* call 0x10108905 */
            ii(0x1011_4f69, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_4f6b, 2); if(jnz(0x1011_4f79, 0xc)) goto l_0x1011_4f79; /* jnz 0x10114f79 */
            ii(0x1011_4f6d, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x1011_4f74, 5); jmp(0x1011_529c, 0x323); goto l_0x1011_529c; /* jmp 0x1011529c */
        l_0x1011_4f79:
            ii(0x1011_4f79, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1011_4f7c, 6); mov(memb[ss, ebp - 1512], al);          /* mov [ebp-0x5e8], al */
            ii(0x1011_4f82, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1011_4f85, 6); mov(memb[ss, ebp - 1511], al);          /* mov [ebp-0x5e7], al */
            ii(0x1011_4f8b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_4f8d, 3); mov(dl, memb[ss, ebp - 4]);             /* mov dl, [ebp-0x4] */
            ii(0x1011_4f90, 6); lea(eax, memd[ss, ebp - 1520]);         /* lea eax, [ebp-0x5f0] */
            ii(0x1011_4f96, 5); call(0x1011_4b29, -0x472);              /* call 0x10114b29 */
        l_0x1011_4f9b:
            ii(0x1011_4f9b, 7); cmp(memb[ss, ebp - 1512], 0);           /* cmp byte [ebp-0x5e8], 0x0 */
            ii(0x1011_4fa2, 2); if(jz(0x1011_4fb1, 0xd)) goto l_0x1011_4fb1; /* jz 0x10114fb1 */
            ii(0x1011_4fa4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_4fa6, 6); mov(al, memb[ss, ebp - 1511]);          /* mov al, [ebp-0x5e7] */
            ii(0x1011_4fac, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1011_4faf, 2); if(jz(0x1011_4fb3, 2)) goto l_0x1011_4fb3; /* jz 0x10114fb3 */
        l_0x1011_4fb1:
            ii(0x1011_4fb1, 2); jmp(0x1011_4fcf, 0x1c); goto l_0x1011_4fcf; /* jmp 0x10114fcf */
        l_0x1011_4fb3:
            ii(0x1011_4fb3, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1011_4fb6, 5); call(0x1014_85ad, 0x3_35f2);            /* call 0x101485ad */
            ii(0x1011_4fbb, 5); cmp(eax, 0xbb8);                        /* cmp eax, 0xbb8 */
            ii(0x1011_4fc0, 2); if(jbe(0x1011_4fcf, 0xd)) goto l_0x1011_4fcf; /* jbe 0x10114fcf */
            ii(0x1011_4fc2, 5); call(0x1012_a96a, 0x1_59a3);            /* call 0x1012a96a */
            ii(0x1011_4fc7, 5); call(0x1014_82f4, 0x3_3328);            /* call 0x101482f4 */
            ii(0x1011_4fcc, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
        l_0x1011_4fcf:
            ii(0x1011_4fcf, 5); call(0x1012_ac94, 0x1_5cc0);            /* call 0x1012ac94 */
            ii(0x1011_4fd4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_4fd6, 2); if(jz(0x1011_4ff7, 0x1f)) goto l_0x1011_4ff7; /* jz 0x10114ff7 */
            ii(0x1011_4fd8, 7); mov(memb[ss, ebp - 1506], 0);           /* mov byte [ebp-0x5e2], 0x0 */
            ii(0x1011_4fdf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_4fe1, 6); lea(eax, memd[ss, ebp - 1520]);         /* lea eax, [ebp-0x5f0] */
            ii(0x1011_4fe7, 5); call(0x1011_417f, -0xe6d);              /* call 0x1011417f */
            ii(0x1011_4fec, 6); lea(eax, memd[ss, ebp - 1520]);         /* lea eax, [ebp-0x5f0] */
            ii(0x1011_4ff2, 5); call(0x1011_390d, -0x16ea);             /* call 0x1011390d */
        l_0x1011_4ff7:
            ii(0x1011_4ff7, 5); call(/* sys */ 0x1016_b208, 0x5_620c);  /* call 0x1016b208 */
            ii(0x1011_4ffc, 6); mov(memd[ss, ebp - 1516], eax);         /* mov [ebp-0x5ec], eax */
            ii(0x1011_5002, 7); cmp(memd[ss, ebp - 1516], 0);           /* cmp dword [ebp-0x5ec], 0x0 */
            ii(0x1011_5009, 2); if(jle(0x1011_5017, 0xc)) goto l_0x1011_5017; /* jle 0x10115017 */
            ii(0x1011_500b, 10); cmp(memd[ss, ebp - 1516], 0x7000);     /* cmp dword [ebp-0x5ec], 0x7000 */
            ii(0x1011_5015, 2); if(jl(0x1011_5019, 2)) goto l_0x1011_5019; /* jl 0x10115019 */
        l_0x1011_5017:
            ii(0x1011_5017, 2); jmp(0x1011_501d, 4); goto l_0x1011_501d; /* jmp 0x1011501d */
        l_0x1011_5019:
            ii(0x1011_5019, 4); mov(memb[ss, ebp - 16], 0);             /* mov byte [ebp-0x10], 0x0 */
        l_0x1011_501d:
            ii(0x1011_501d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_501f, 6); mov(al, memb[ss, ebp - 1510]);          /* mov al, [ebp-0x5e6] */
            ii(0x1011_5025, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1011_5028, 2); if(jnz(0x1011_5039, 0xf)) goto l_0x1011_5039; /* jnz 0x10115039 */
            ii(0x1011_502a, 10); mov(memd[ss, ebp - 1516], 0x1b);       /* mov dword [ebp-0x5ec], 0x1b */
            ii(0x1011_5034, 5); jmp(0x1011_522f, 0x1f6); goto l_0x1011_522f; /* jmp 0x1011522f */
        l_0x1011_5039:
            ii(0x1011_5039, 7); cmp(memb[ds, 0x101c_5630], 2);          /* cmp byte [0x101c5630], 0x2 */
            ii(0x1011_5040, 6); if(jz(0x1011_522f, 0x1e9)) goto l_0x1011_522f; /* jz 0x1011522f */
            ii(0x1011_5046, 7); cmp(memd[ss, ebp - 1106], 0);           /* cmp dword [ebp-0x452], 0x0 */
            ii(0x1011_504d, 6); if(jz(0x1011_5127, 0xd4)) goto l_0x1011_5127; /* jz 0x10115127 */
            ii(0x1011_5053, 6); mov(edx, memd[ss, ebp - 1516]);         /* mov edx, [ebp-0x5ec] */
            ii(0x1011_5059, 6); mov(eax, memd[ss, ebp - 1106]);         /* mov eax, [ebp-0x452] */
            ii(0x1011_505f, 5); call(0x100e_b283, -0x2_9de1);           /* call 0x100eb283 */
            ii(0x1011_5064, 2); test(al, al);                           /* test al, al */
            ii(0x1011_5066, 2); if(jz(0x1011_5094, 0x2c)) goto l_0x1011_5094; /* jz 0x10115094 */
            ii(0x1011_5068, 7); cmp(memd[ss, ebp - 1516], 0x1b);        /* cmp dword [ebp-0x5ec], 0x1b */
            ii(0x1011_506f, 2); if(jz(0x1011_507a, 9)) goto l_0x1011_507a; /* jz 0x1011507a */
            ii(0x1011_5071, 7); cmp(memd[ss, ebp - 1516], 0xd);         /* cmp dword [ebp-0x5ec], 0xd */
            ii(0x1011_5078, 2); if(jnz(0x1011_5085, 0xb)) goto l_0x1011_5085; /* jnz 0x10115085 */
        l_0x1011_507a:
            ii(0x1011_507a, 6); lea(eax, memd[ss, ebp - 1520]);         /* lea eax, [ebp-0x5f0] */
            ii(0x1011_5080, 5); call(0x1011_2206, -0x2e7f);             /* call 0x10112206 */
        l_0x1011_5085:
            ii(0x1011_5085, 10); mov(memd[ss, ebp - 1516], 0);          /* mov dword [ebp-0x5ec], 0x0 */
            ii(0x1011_508f, 5); jmp(0x1011_522f, 0x19b); goto l_0x1011_522f; /* jmp 0x1011522f */
        l_0x1011_5094:
            ii(0x1011_5094, 7); cmp(memd[ss, ebp - 1516], 0);           /* cmp dword [ebp-0x5ec], 0x0 */
            ii(0x1011_509b, 6); if(jle(0x1011_5127, 0x86)) goto l_0x1011_5127; /* jle 0x10115127 */
            ii(0x1011_50a1, 6); mov(eax, memd[ss, ebp - 1106]);         /* mov eax, [ebp-0x452] */
            ii(0x1011_50a7, 6); cmp(eax, memd[ss, ebp - 1110]);         /* cmp eax, [ebp-0x456] */
            ii(0x1011_50ad, 2); if(jnz(0x1011_50ef, 0x40)) goto l_0x1011_50ef; /* jnz 0x101150ef */
            ii(0x1011_50af, 10); cmp(memd[ss, ebp - 1516], 0x3fa);      /* cmp dword [ebp-0x5ec], 0x3fa */
            ii(0x1011_50b9, 2); if(jz(0x1011_50c7, 0xc)) goto l_0x1011_50c7; /* jz 0x101150c7 */
            ii(0x1011_50bb, 10); cmp(memd[ss, ebp - 1516], 0x7012);     /* cmp dword [ebp-0x5ec], 0x7012 */
            ii(0x1011_50c5, 2); if(jnz(0x1011_50cc, 5)) goto l_0x1011_50cc; /* jnz 0x101150cc */
        l_0x1011_50c7:
            ii(0x1011_50c7, 5); jmp(0x1011_522f, 0x163); goto l_0x1011_522f; /* jmp 0x1011522f */
        l_0x1011_50cc:
            ii(0x1011_50cc, 10); cmp(memd[ss, ebp - 1516], 0x3f9);      /* cmp dword [ebp-0x5ec], 0x3f9 */
            ii(0x1011_50d6, 2); if(jnz(0x1011_50ed, 0x15)) goto l_0x1011_50ed; /* jnz 0x101150ed */
            ii(0x1011_50d8, 10); mov(memd[ss, ebp - 1516], 0);          /* mov dword [ebp-0x5ec], 0x0 */
            ii(0x1011_50e2, 6); mov(eax, memd[ss, ebp - 1430]);         /* mov eax, [ebp-0x596] */
            ii(0x1011_50e8, 5); call(0x100c_fbbe, -0x4_552f);           /* call 0x100cfbbe */
        l_0x1011_50ed:
            ii(0x1011_50ed, 2); jmp(0x1011_50ff, 0x10); goto l_0x1011_50ff; /* jmp 0x101150ff */
        l_0x1011_50ef:
            ii(0x1011_50ef, 10); cmp(memd[ss, ebp - 1516], 0x3e8);      /* cmp dword [ebp-0x5ec], 0x3e8 */
            ii(0x1011_50f9, 6); if(jz(0x1011_522f, 0x130)) goto l_0x1011_522f; /* jz 0x1011522f */
        l_0x1011_50ff:
            ii(0x1011_50ff, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1011_5104, 6); mov(eax, memd[ss, ebp - 1106]);         /* mov eax, [ebp-0x452] */
            ii(0x1011_510a, 5); call(0x100e_b283, -0x2_9e8c);           /* call 0x100eb283 */
            ii(0x1011_510f, 6); lea(eax, memd[ss, ebp - 1520]);         /* lea eax, [ebp-0x5f0] */
            ii(0x1011_5115, 5); call(0x1011_2206, -0x2f14);             /* call 0x10112206 */
            ii(0x1011_511a, 7); cmp(memd[ss, ebp - 1516], 0);           /* cmp dword [ebp-0x5ec], 0x0 */
            ii(0x1011_5121, 6); if(jz(0x1011_522f, 0x108)) goto l_0x1011_522f; /* jz 0x1011522f */
        l_0x1011_5127:
            ii(0x1011_5127, 10); mov(memd[ss, ebp - 1524], 0);          /* mov dword [ebp-0x5f4], 0x0 */
            ii(0x1011_5131, 2); jmp(0x1011_513f, 0xc); goto l_0x1011_513f; /* jmp 0x1011513f */
        l_0x1011_5133:
            ii(0x1011_5133, 6); mov(eax, memd[ss, ebp - 1524]);         /* mov eax, [ebp-0x5f4] */
            ii(0x1011_5139, 6); inc(memd[ss, ebp - 1524]);              /* inc dword [ebp-0x5f4] */
        l_0x1011_513f:
            ii(0x1011_513f, 7); cmp(memd[ss, ebp - 1524], 0x18);        /* cmp dword [ebp-0x5f4], 0x18 */
            ii(0x1011_5146, 6); if(jge(0x1011_522f, 0xe3)) goto l_0x1011_522f; /* jge 0x1011522f */
            ii(0x1011_514c, 6); mov(eax, memd[ss, ebp - 1524]);         /* mov eax, [ebp-0x5f4] */
            ii(0x1011_5152, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1011_5155, 8); cmp(memd[ds, eax + ebp - 1498], 0);     /* cmp dword [eax+ebp-0x5da], 0x0 */
            ii(0x1011_515d, 6); if(jz(0x1011_522a, 0xc7)) goto l_0x1011_522a; /* jz 0x1011522a */
            ii(0x1011_5163, 6); mov(eax, memd[ss, ebp - 1524]);         /* mov eax, [ebp-0x5f4] */
            ii(0x1011_5169, 5); add(eax, 0x7000);                       /* add eax, 0x7000 */
            ii(0x1011_516e, 6); cmp(eax, memd[ss, ebp - 1516]);         /* cmp eax, [ebp-0x5ec] */
            ii(0x1011_5174, 2); if(jnz(0x1011_519a, 0x24)) goto l_0x1011_519a; /* jnz 0x1011519a */
            ii(0x1011_5176, 4); cmp(memb[ss, ebp - 16], 0);             /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1011_517a, 2); if(jnz(0x1011_5191, 0x15)) goto l_0x1011_5191; /* jnz 0x10115191 */
            ii(0x1011_517c, 6); mov(eax, memd[ss, ebp - 1524]);         /* mov eax, [ebp-0x5f4] */
            ii(0x1011_5182, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1011_5185, 7); mov(eax, memd[ds, eax + ebp - 1498]);   /* mov eax, [eax+ebp-0x5da] */
            ii(0x1011_518c, 5); call(0x100c_fbbe, -0x4_55d3);           /* call 0x100cfbbe */
        l_0x1011_5191:
            ii(0x1011_5191, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
            ii(0x1011_5195, 5); jmp(0x1011_522f, 0x95); goto l_0x1011_522f; /* jmp 0x1011522f */
        l_0x1011_519a:
            ii(0x1011_519a, 7); imul(edx, memd[ss, ebp - 1524], 0xc);   /* imul edx, [ebp-0x5f4], 0xc */
            ii(0x1011_51a1, 6); mov(eax, memd[ss, ebp - 1516]);         /* mov eax, [ebp-0x5ec] */
            ii(0x1011_51a7, 7); cmp(eax, memd[ds, edx + ebp - 1398]);   /* cmp eax, [edx+ebp-0x576] */
            ii(0x1011_51ae, 2); if(jnz(0x1011_51c4, 0x14)) goto l_0x1011_51c4; /* jnz 0x101151c4 */
            ii(0x1011_51b0, 7); imul(eax, memd[ss, ebp - 1524], 0xc);   /* imul eax, [ebp-0x5f4], 0xc */
            ii(0x1011_51b7, 7); mov(eax, memd[ds, eax + ebp - 1402]);   /* mov eax, [eax+ebp-0x57a] */
            ii(0x1011_51be, 6); mov(memd[ss, ebp - 1516], eax);         /* mov [ebp-0x5ec], eax */
        l_0x1011_51c4:
            ii(0x1011_51c4, 7); imul(edx, memd[ss, ebp - 1524], 0xc);   /* imul edx, [ebp-0x5f4], 0xc */
            ii(0x1011_51cb, 6); mov(eax, memd[ss, ebp - 1516]);         /* mov eax, [ebp-0x5ec] */
            ii(0x1011_51d1, 7); cmp(eax, memd[ds, edx + ebp - 1402]);   /* cmp eax, [edx+ebp-0x57a] */
            ii(0x1011_51d8, 2); if(jnz(0x1011_522a, 0x50)) goto l_0x1011_522a; /* jnz 0x1011522a */
            ii(0x1011_51da, 7); cmp(memd[ss, ebp - 1524], 0xd);         /* cmp dword [ebp-0x5f4], 0xd */
            ii(0x1011_51e1, 2); if(jl(0x1011_51ec, 9)) goto l_0x1011_51ec; /* jl 0x101151ec */
            ii(0x1011_51e3, 7); cmp(memd[ss, ebp - 1524], 0x10);        /* cmp dword [ebp-0x5f4], 0x10 */
            ii(0x1011_51ea, 2); if(jle(0x1011_51f5, 9)) goto l_0x1011_51f5; /* jle 0x101151f5 */
        l_0x1011_51ec:
            ii(0x1011_51ec, 7); cmp(memd[ss, ebp - 1524], 0x11);        /* cmp dword [ebp-0x5f4], 0x11 */
            ii(0x1011_51f3, 2); if(jnz(0x1011_520a, 0x15)) goto l_0x1011_520a; /* jnz 0x1011520a */
        l_0x1011_51f5:
            ii(0x1011_51f5, 6); mov(eax, memd[ss, ebp - 1524]);         /* mov eax, [ebp-0x5f4] */
            ii(0x1011_51fb, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1011_51fe, 7); mov(eax, memd[ds, eax + ebp - 1498]);   /* mov eax, [eax+ebp-0x5da] */
            ii(0x1011_5205, 5); call(0x100c_fbbe, -0x4_564c);           /* call 0x100cfbbe */
        l_0x1011_520a:
            ii(0x1011_520a, 10); add(memd[ss, ebp - 1516], 0xffff_fc18); /* add dword [ebp-0x5ec], 0xfffffc18 */
            ii(0x1011_5214, 7); imul(edx, memd[ss, ebp - 1524], 0xc);   /* imul edx, [ebp-0x5f4], 0xc */
            ii(0x1011_521b, 6); lea(eax, memd[ss, ebp - 1520]);         /* lea eax, [ebp-0x5f0] */
            ii(0x1011_5221, 7); call_abs(memd[ds, edx + ebp - 1394]);   /* call dword [edx+ebp-0x572] */
            ii(0x1011_5228, 2); jmp(0x1011_522f, 5); goto l_0x1011_522f; /* jmp 0x1011522f */
        l_0x1011_522a:
            ii(0x1011_522a, 5); jmp(0x1011_5133, -0xfc); goto l_0x1011_5133; /* jmp 0x10115133 */
        l_0x1011_522f:
            ii(0x1011_522f, 7); cmp(memd[ss, ebp - 1516], 0x1b);        /* cmp dword [ebp-0x5ec], 0x1b */
            ii(0x1011_5236, 6); if(jnz(0x1011_4f9b, -0x2a1)) goto l_0x1011_4f9b; /* jnz 0x10114f9b */
            ii(0x1011_523c, 6); lea(eax, memd[ss, ebp - 1520]);         /* lea eax, [ebp-0x5f0] */
            ii(0x1011_5242, 5); call(0x1011_3c12, -0x1635);             /* call 0x10113c12 */
            ii(0x1011_5247, 7); cmp(memb[ss, ebp - 1510], 0);           /* cmp byte [ebp-0x5e6], 0x0 */
            ii(0x1011_524e, 2); if(jz(0x1011_5291, 0x41)) goto l_0x1011_5291; /* jz 0x10115291 */
            ii(0x1011_5250, 4); cmp(memb[ss, ebp - 12], 0);             /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1011_5254, 2); if(jz(0x1011_526e, 0x18)) goto l_0x1011_526e; /* jz 0x1011526e */
            ii(0x1011_5256, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_5258, 5); call(/* sys */ 0x1017_8f78, 0x6_3d1b);  /* call 0x10178f78 */
            ii(0x1011_525d, 5); mov(memd[ds, 0x101c_5628], eax);        /* mov [0x101c5628], eax */
            ii(0x1011_5262, 5); mov(eax, memd[ds, 0x101c_5628]);        /* mov eax, [0x101c5628] */
            ii(0x1011_5267, 5); call(0x1012_9093, 0x1_3e27);            /* call 0x10129093 */
            ii(0x1011_526c, 2); jmp(0x1011_5291, 0x23); goto l_0x1011_5291; /* jmp 0x10115291 */
        l_0x1011_526e:
            ii(0x1011_526e, 7); cmp(memb[ds, 0x101c_391e], 3);          /* cmp byte [0x101c391e], 0x3 */
            ii(0x1011_5275, 2); if(jnz(0x1011_5291, 0x1a)) goto l_0x1011_5291; /* jnz 0x10115291 */
            ii(0x1011_5277, 5); call(0x1012_8602, 0x1_3386);            /* call 0x10128602 */
            ii(0x1011_527c, 5); call(/* sys */ 0x1016_b208, 0x5_5f87);  /* call 0x1016b208 */
            ii(0x1011_5281, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1011_5284, 2); if(jnz(0x1011_528f, 9)) goto l_0x1011_528f; /* jnz 0x1011528f */
            ii(0x1011_5286, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x1011_528d, 2); jmp(0x1011_529c, 0xd); goto l_0x1011_529c; /* jmp 0x1011529c */
        l_0x1011_528f:
            ii(0x1011_528f, 2); jmp(0x1011_526e, -0x23); goto l_0x1011_526e; /* jmp 0x1011526e */
        l_0x1011_5291:
            ii(0x1011_5291, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_5293, 6); mov(al, memb[ss, ebp - 1510]);          /* mov al, [ebp-0x5e6] */
            ii(0x1011_5299, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
        l_0x1011_529c:
            ii(0x1011_529c, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1011_529f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_52a1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_52a2, 1); pop(edi);                               /* pop edi */
            ii(0x1011_52a3, 1); pop(esi);                               /* pop esi */
            ii(0x1011_52a4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_52a5, 1); ret();                                  /* ret */
        }
    }
}
