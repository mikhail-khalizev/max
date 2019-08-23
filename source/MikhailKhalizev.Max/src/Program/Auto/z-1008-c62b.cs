using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_c62b-dbb70e48")]
        public void Method_1008_c62b()
        {
            ii(0x1008_c62b, 5); push(0x38);                             /* push 0x38 */
            ii(0x1008_c630, 5); call(Definitions.sys_check_available_stack_size, 0xd_971d); /* call 0x10165d52 */
            ii(0x1008_c635, 1); push(ebx);                              /* push ebx */
            ii(0x1008_c636, 1); push(ecx);                              /* push ecx */
            ii(0x1008_c637, 1); push(edx);                              /* push edx */
            ii(0x1008_c638, 1); push(esi);                              /* push esi */
            ii(0x1008_c639, 1); push(edi);                              /* push edi */
            ii(0x1008_c63a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_c63b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_c63d, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1008_c643, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_c646, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1008_c64b, 5); call(0x1007_6338, -0x1_6318);           /* call 0x10076338 */
            ii(0x1008_c650, 3); lea(ebx, memd[ss, ebp - 0x10]);         /* lea ebx, [ebp-0x10] */
            ii(0x1008_c653, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c655, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_c657, 5); call(0x1007_64b8, -0x1_61a4);           /* call 0x100764b8 */
            ii(0x1008_c65c, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1008_c663, 2); jmp(0x1008_c66d, 0x8); goto l_0x1008_c66d; /* jmp 0x1008c66d */
        l_0x1008_c665:
            ii(0x1008_c665, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_c668, 5); call(0x1007_6bf8, -0x1_5a75);           /* call 0x10076bf8 */
        l_0x1008_c66d:
            ii(0x1008_c66d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c66f, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_c672, 5); call(0x1013_ad71, 0xa_e6fa);            /* call 0x1013ad71 */
            ii(0x1008_c677, 2); test(al, al);                           /* test al, al */
            ii(0x1008_c679, 6); if(jz(0x1008_c74a, 0xcb)) goto l_0x1008_c74a; /* jz 0x1008c74a */
            ii(0x1008_c67f, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_c682, 5); call(0x1007_63a0, -0x1_62e7);           /* call 0x100763a0 */
            ii(0x1008_c687, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c689, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1008_c68c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c68f, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_c692, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_c695, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_c697, 2); if(jnz(0x1008_c6ab, 0x12)) goto l_0x1008_c6ab; /* jnz 0x1008c6ab */
            ii(0x1008_c699, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_c69c, 5); call(0x1007_63a0, -0x1_6301);           /* call 0x100763a0 */
            ii(0x1008_c6a1, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1008_c6a4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_c6a7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_c6a9, 2); if(jg(0x1008_c6ad, 0x2)) goto l_0x1008_c6ad; /* jg 0x1008c6ad */
        l_0x1008_c6ab:
            ii(0x1008_c6ab, 2); jmp(0x1008_c6c1, 0x14); goto l_0x1008_c6c1; /* jmp 0x1008c6c1 */
        l_0x1008_c6ad:
            ii(0x1008_c6ad, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_c6b0, 5); call(0x1007_63a0, -0x1_6315);           /* call 0x100763a0 */
            ii(0x1008_c6b5, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1008_c6b8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_c6bd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_c6bf, 2); if(jg(0x1008_c6c3, 0x2)) goto l_0x1008_c6c3; /* jg 0x1008c6c3 */
        l_0x1008_c6c1:
            ii(0x1008_c6c1, 2); jmp(0x1008_c6dd, 0x1a); goto l_0x1008_c6dd; /* jmp 0x1008c6dd */
        l_0x1008_c6c3:
            ii(0x1008_c6c3, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_c6c6, 5); call(0x1007_63a0, -0x1_632b);           /* call 0x100763a0 */
            ii(0x1008_c6cb, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1008_c6ce, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_c6d1, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1008_c6d4, 7); cmp(memb[ds, eax + 0x101c_81d5], 0x1);  /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x1008_c6db, 2); if(jz(0x1008_c6df, 0x2)) goto l_0x1008_c6df; /* jz 0x1008c6df */
        l_0x1008_c6dd:
            ii(0x1008_c6dd, 2); jmp(0x1008_c745, 0x66); goto l_0x1008_c745; /* jmp 0x1008c745 */
        l_0x1008_c6df:
            ii(0x1008_c6df, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_c6e2, 5); call(0x1007_63a0, -0x1_6347);           /* call 0x100763a0 */
            ii(0x1008_c6e7, 5); call(0x1007_6204, -0x1_64e8);           /* call 0x10076204 */
            ii(0x1008_c6ec, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1008_c6ef, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c6f1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_c6f3, 5); call(0x100a_6d29, 0x1_a631);            /* call 0x100a6d29 */
            ii(0x1008_c6f8, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_c6fb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c6fe, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c701, 5); call(0x1008_abbc, -0x1b4a);             /* call 0x1008abbc */
            ii(0x1008_c706, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c708, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_c70b, 5); call(0x100a_601a, 0x1_990a);            /* call 0x100a601a */
            ii(0x1008_c710, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_c713, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1008_c717, 2); if(jz(0x1008_c722, 0x9)) goto l_0x1008_c722; /* jz 0x1008c722 */
            ii(0x1008_c719, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_c71c, 4); cmp(ax, memw[ss, ebp - 0x8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1008_c720, 2); if(jge(0x1008_c745, 0x23)) goto l_0x1008_c745; /* jge 0x1008c745 */
        l_0x1008_c722:
            ii(0x1008_c722, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_c725, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_c728, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_c72b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_c72e, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_c731, 5); call(0x1007_6408, -0x1_632e);           /* call 0x10076408 */
            ii(0x1008_c736, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1008_c739, 3); add(ebx, 0x1b);                         /* add ebx, 0x1b */
            ii(0x1008_c73c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c73e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_c740, 5); call(0x1007_6630, -0x1_6115);           /* call 0x10076630 */
        l_0x1008_c745:
            ii(0x1008_c745, 5); jmp(0x1008_c665, -0xe5); goto l_0x1008_c665; /* jmp 0x1008c665 */
        l_0x1008_c74a:
            ii(0x1008_c74a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_c74d, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_c750, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c752, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_c755, 5); call(0x1007_5f6c, -0x1_67ee);           /* call 0x10075f6c */
            ii(0x1008_c75a, 2); jmp(0x1008_c766, 0xa); goto l_0x1008_c766; /* jmp 0x1008c766 */
        //  ii(0x1008_c75c, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_c75e, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
        //  ii(0x1008_c761, 5); call(0x1007_5f6c, -0x1_67fa);           /* call 0x10075f6c */
        l_0x1008_c766:
            ii(0x1008_c766, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_c769, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_c76b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_c76c, 1); pop(edi);                               /* pop edi */
            ii(0x1008_c76d, 1); pop(esi);                               /* pop esi */
            ii(0x1008_c76e, 1); pop(edx);                               /* pop edx */
            ii(0x1008_c76f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_c770, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_c771, 1); ret();                                  /* ret */
        }
    }
}
