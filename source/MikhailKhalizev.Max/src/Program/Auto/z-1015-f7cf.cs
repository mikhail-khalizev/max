using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_f7cf-267b93c1")]
        public void Method_1015_f7cf()
        {
            ii(0x1015_f7cf, 5); push(0x40);                             /* push 0x40 */
            ii(0x1015_f7d4, 5); call(Definitions.sys_check_available_stack_size, 0x6579); /* call 0x10165d52 */
            ii(0x1015_f7d9, 1); push(ebx);                              /* push ebx */
            ii(0x1015_f7da, 1); push(ecx);                              /* push ecx */
            ii(0x1015_f7db, 1); push(edx);                              /* push edx */
            ii(0x1015_f7dc, 1); push(esi);                              /* push esi */
            ii(0x1015_f7dd, 1); push(edi);                              /* push edi */
            ii(0x1015_f7de, 1); push(ebp);                              /* push ebp */
            ii(0x1015_f7df, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_f7e1, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1015_f7e7, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1015_f7ea, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x1015_f7ed, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_f7f0, 5); call(0x1015_0a5f, -0xed96);             /* call 0x10150a5f */
            ii(0x1015_f7f5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f7f7, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_f7fa, 5); call(0x1008_b228, -0xd_45d7);           /* call 0x1008b228 */
            ii(0x1015_f7ff, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1015_f802, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_f805, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_f808, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_f80b, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_f80d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_f810, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1015_f814, 5); call(0x100d_4b64, -0x8_acb5);           /* call 0x100d4b64 */
            ii(0x1015_f819, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_f81c, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1015_f821, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_f824, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1015_f827, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_f82a, 5); call(0x1007_1e00, -0xe_da2f);           /* call 0x10071e00 */
            ii(0x1015_f82f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_f832, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_f836, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1015_f839, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_f83c, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1015_f83f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_f842, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1015_f844, 2); if(jl(0x1015_f87e, 0x38)) goto l_0x1015_f87e; /* jl 0x1015f87e */
            ii(0x1015_f846, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_f849, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_f84c, 5); call(0x1007_69d8, -0xe_8e79);           /* call 0x100769d8 */
            ii(0x1015_f851, 5); call(0x1012_0c30, -0x3_ec26);           /* call 0x10120c30 */
            ii(0x1015_f856, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f858, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_f85b, 4); cmp(dx, memw[ds, eax + 0x1a]);          /* cmp dx, [eax+0x1a] */
            ii(0x1015_f85f, 2); if(jnz(0x1015_f87c, 0x1b)) goto l_0x1015_f87c; /* jnz 0x1015f87c */
            ii(0x1015_f861, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_f864, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_f867, 5); call(0x1007_69d8, -0xe_8e94);           /* call 0x100769d8 */
            ii(0x1015_f86c, 5); call(0x1012_0bfc, -0x3_ec75);           /* call 0x10120bfc */
            ii(0x1015_f871, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f873, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_f876, 4); cmp(dx, memw[ds, eax + 0x1c]);          /* cmp dx, [eax+0x1c] */
            ii(0x1015_f87a, 2); if(jz(0x1015_f87e, 2)) goto l_0x1015_f87e; /* jz 0x1015f87e */
        l_0x1015_f87c:
            ii(0x1015_f87c, 2); jmp(0x1015_f895, 0x17); goto l_0x1015_f895; /* jmp 0x1015f895 */
        l_0x1015_f87e:
            ii(0x1015_f87e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_f881, 5); call(0x1014_adca, -0x1_4abc);           /* call 0x1014adca */
            ii(0x1015_f886, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f888, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_f88b, 5); call(0x1008_8b04, -0xd_6d8c);           /* call 0x10088b04 */
            ii(0x1015_f890, 5); jmp(0x1015_f92a, 0x95); goto l_0x1015_f92a; /* jmp 0x1015f92a */
        l_0x1015_f895:
            ii(0x1015_f895, 5); cmp(memw[ss, ebp - 8], 0xc);            /* cmp word [ebp-0x8], 0xc */
            ii(0x1015_f89a, 2); if(jz(0x1015_f8a3, 7)) goto l_0x1015_f8a3; /* jz 0x1015f8a3 */
            ii(0x1015_f89c, 5); cmp(memw[ss, ebp - 8], 0x15);           /* cmp word [ebp-0x8], 0x15 */
            ii(0x1015_f8a1, 2); if(jnz(0x1015_f8a5, 2)) goto l_0x1015_f8a5; /* jnz 0x1015f8a5 */
        l_0x1015_f8a3:
            ii(0x1015_f8a3, 2); jmp(0x1015_f8ac, 7); goto l_0x1015_f8ac; /* jmp 0x1015f8ac */
        l_0x1015_f8a5:
            ii(0x1015_f8a5, 5); cmp(memw[ss, ebp - 8], 0x27);           /* cmp word [ebp-0x8], 0x27 */
            ii(0x1015_f8aa, 2); if(jnz(0x1015_f8ae, 2)) goto l_0x1015_f8ae; /* jnz 0x1015f8ae */
        l_0x1015_f8ac:
            ii(0x1015_f8ac, 2); jmp(0x1015_f8b5, 7); goto l_0x1015_f8b5; /* jmp 0x1015f8b5 */
        l_0x1015_f8ae:
            ii(0x1015_f8ae, 5); cmp(memw[ss, ebp - 8], 0x21);           /* cmp word [ebp-0x8], 0x21 */
            ii(0x1015_f8b3, 2); if(jnz(0x1015_f8b7, 2)) goto l_0x1015_f8b7; /* jnz 0x1015f8b7 */
        l_0x1015_f8b5:
            ii(0x1015_f8b5, 2); jmp(0x1015_f8bd, 6); goto l_0x1015_f8bd; /* jmp 0x1015f8bd */
        l_0x1015_f8b7:
            ii(0x1015_f8b7, 4); mov(memb[ss, ebp - 0x14], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x1015_f8bb, 2); jmp(0x1015_f8c1, 4); goto l_0x1015_f8c1; /* jmp 0x1015f8c1 */
        l_0x1015_f8bd:
            ii(0x1015_f8bd, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
        l_0x1015_f8c1:
            ii(0x1015_f8c1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_f8c3, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1015_f8c6, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1015_f8c9, 3); push(memd[ss, ebp - 0x1c]);             /* push dword [ebp-0x1c] */
            ii(0x1015_f8cc, 5); cmp(memw[ss, ebp - 8], 0xc);            /* cmp word [ebp-0x8], 0xc */
            ii(0x1015_f8d1, 2); if(jz(0x1015_f8da, 7)) goto l_0x1015_f8da; /* jz 0x1015f8da */
            ii(0x1015_f8d3, 5); cmp(memw[ss, ebp - 8], 0x15);           /* cmp word [ebp-0x8], 0x15 */
            ii(0x1015_f8d8, 2); if(jnz(0x1015_f8dc, 2)) goto l_0x1015_f8dc; /* jnz 0x1015f8dc */
        l_0x1015_f8da:
            ii(0x1015_f8da, 2); jmp(0x1015_f8e3, 7); goto l_0x1015_f8e3; /* jmp 0x1015f8e3 */
        l_0x1015_f8dc:
            ii(0x1015_f8dc, 5); cmp(memw[ss, ebp - 8], 0x27);           /* cmp word [ebp-0x8], 0x27 */
            ii(0x1015_f8e1, 2); if(jnz(0x1015_f8e5, 2)) goto l_0x1015_f8e5; /* jnz 0x1015f8e5 */
        l_0x1015_f8e3:
            ii(0x1015_f8e3, 2); jmp(0x1015_f8ec, 7); goto l_0x1015_f8ec; /* jmp 0x1015f8ec */
        l_0x1015_f8e5:
            ii(0x1015_f8e5, 5); cmp(memw[ss, ebp - 8], 0x21);           /* cmp word [ebp-0x8], 0x21 */
            ii(0x1015_f8ea, 2); if(jnz(0x1015_f8ee, 2)) goto l_0x1015_f8ee; /* jnz 0x1015f8ee */
        l_0x1015_f8ec:
            ii(0x1015_f8ec, 2); jmp(0x1015_f8f4, 6); goto l_0x1015_f8f4; /* jmp 0x1015f8f4 */
        l_0x1015_f8ee:
            ii(0x1015_f8ee, 4); mov(memb[ss, ebp - 0x18], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x1015_f8f2, 2); jmp(0x1015_f8f8, 4); goto l_0x1015_f8f8; /* jmp 0x1015f8f8 */
        l_0x1015_f8f4:
            ii(0x1015_f8f4, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x1015_f8f8:
            ii(0x1015_f8f8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_f8fa, 3); mov(al, memb[ss, ebp - 0x18]);          /* mov al, [ebp-0x18] */
            ii(0x1015_f8fd, 1); push(eax);                              /* push eax */
            ii(0x1015_f8fe, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_f900, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_f902, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_f905, 3); mov(edx, memd[ds, eax + 0x1a]);         /* mov edx, [eax+0x1a] */
            ii(0x1015_f908, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_f90b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_f90e, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1015_f911, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_f914, 5); call(0x1007_4395, -0xe_b584);           /* call 0x10074395 */
            ii(0x1015_f919, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_f91c, 4); mov(memb[ds, eax + 0x3e], 5);           /* mov byte [eax+0x3e], 0x5 */
            ii(0x1015_f920, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f922, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_f925, 5); call(0x1008_8b04, -0xd_6e26);           /* call 0x10088b04 */
        l_0x1015_f92a:
            ii(0x1015_f92a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_f92c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_f92d, 1); pop(edi);                               /* pop edi */
            ii(0x1015_f92e, 1); pop(esi);                               /* pop esi */
            ii(0x1015_f92f, 1); pop(edx);                               /* pop edx */
            ii(0x1015_f930, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_f931, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_f932, 1); ret();                                  /* ret */
        }
    }
}
