using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d4d6-70fceba7")]
        public void /* sys */ Method_1018_d4d6()
        {
            ii(0x1018_d4d6, 1); push(ebx);                              /* push ebx */
            ii(0x1018_d4d7, 1); push(ecx);                              /* push ecx */
            ii(0x1018_d4d8, 1); push(edx);                              /* push edx */
            ii(0x1018_d4d9, 1); push(esi);                              /* push esi */
            ii(0x1018_d4da, 1); push(edi);                              /* push edi */
            ii(0x1018_d4db, 6); mov(esi, memd[ds, 0x1020_a1f4]);        /* mov esi, [0x1020a1f4] */
            ii(0x1018_d4e1, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_d4e3, 2); if(jz(0x1018_d4fe, 0x19)) goto l_0x1018_d4fe; /* jz 0x1018d4fe */
            ii(0x1018_d4e5, 3); mov(ecx, memd[ds, esi + 4]);            /* mov ecx, [esi+0x4] */
            ii(0x1018_d4e8, 3); mov(edi, memd[ds, ecx + 12]);           /* mov edi, [ecx+0xc] */
            ii(0x1018_d4eb, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
            ii(0x1018_d4ed, 6); and(edi, 0x4003);                       /* and edi, 0x4003 */
            ii(0x1018_d4f3, 5); mov(memd[ds, 0x1020_a1f4], eax);        /* mov [0x1020a1f4], eax */
            ii(0x1018_d4f8, 4); or(di, 3);                              /* or di, 0x3 */
            ii(0x1018_d4fc, 2); jmp(0x1018_d545, 0x47); goto l_0x1018_d545; /* jmp 0x1018d545 */
        l_0x1018_d4fe:
            ii(0x1018_d4fe, 5); mov(ecx, 0x101b_e5a0);                  /* mov ecx, 0x101be5a0 */
            ii(0x1018_d503, 2); jmp(0x1018_d525, 0x20); goto l_0x1018_d525; /* jmp 0x1018d525 */
        l_0x1018_d505:
            ii(0x1018_d505, 4); test(memb[ds, ecx + 12], 3);            /* test byte [ecx+0xc], 0x3 */
            ii(0x1018_d509, 2); if(jnz(0x1018_d522, 0x17)) goto l_0x1018_d522; /* jnz 0x1018d522 */
            ii(0x1018_d50b, 5); mov(eax, 8);                            /* mov eax, 0x8 */
            ii(0x1018_d510, 5); call(Definitions.sys_malloc, -0x2_2537); /* call 0x1016afde */
            ii(0x1018_d515, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_d517, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_d519, 2); if(jz(0x1018_d56a, 0x4f)) goto l_0x1018_d56a; /* jz 0x1018d56a */
            ii(0x1018_d51b, 5); mov(edi, 3);                            /* mov edi, 0x3 */
            ii(0x1018_d520, 2); jmp(0x1018_d545, 0x23); goto l_0x1018_d545; /* jmp 0x1018d545 */
        l_0x1018_d522:
            ii(0x1018_d522, 3); add(ecx, 0x1a);                         /* add ecx, 0x1a */
        l_0x1018_d525:
            ii(0x1018_d525, 6); cmp(ecx, 0x101b_e7a8);                  /* cmp ecx, 0x101be7a8 */
            ii(0x1018_d52b, 2); if(jb(0x1018_d505, -0x28)) goto l_0x1018_d505; /* jb 0x1018d505 */
            ii(0x1018_d52d, 5); mov(eax, 0x22);                         /* mov eax, 0x22 */
            ii(0x1018_d532, 5); mov(edi, 0x4003);                       /* mov edi, 0x4003 */
            ii(0x1018_d537, 5); call(Definitions.sys_malloc, -0x2_255e); /* call 0x1016afde */
            ii(0x1018_d53c, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_d53e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_d540, 2); if(jz(0x1018_d56a, 0x28)) goto l_0x1018_d56a; /* jz 0x1018d56a */
            ii(0x1018_d542, 3); lea(ecx, memd[ds, eax + 8]);            /* lea ecx, [eax+0x8] */
        l_0x1018_d545:
            ii(0x1018_d545, 5); mov(ebx, 0x1a);                         /* mov ebx, 0x1a */
            ii(0x1018_d54a, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_d54c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_d54e, 5); call(Definitions.sys_memset, -0x2_7773); /* call 0x10165de0 */
            ii(0x1018_d553, 3); mov(memd[ds, ecx + 12], edi);           /* mov [ecx+0xc], edi */
            ii(0x1018_d556, 5); mov(eax, memd[ds, 0x1020_b70c]);        /* mov eax, [0x1020b70c] */
            ii(0x1018_d55b, 3); mov(memd[ds, esi + 4], ecx);            /* mov [esi+0x4], ecx */
            ii(0x1018_d55e, 6); mov(memd[ds, 0x1020_b70c], esi);        /* mov [0x1020b70c], esi */
            ii(0x1018_d564, 2); mov(memd[ds, esi], eax);                /* mov [esi], eax */
            ii(0x1018_d566, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_d568, 2); jmp(0x1018_d576, 0xc); goto l_0x1018_d576; /* jmp 0x1018d576 */
        l_0x1018_d56a:
            ii(0x1018_d56a, 5); mov(eax, 5);                            /* mov eax, 0x5 */
            ii(0x1018_d56f, 5); call(/* sys */ 0x1018_d3bf, -0x1b5);    /* call 0x1018d3bf */
            ii(0x1018_d574, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1018_d576:
            ii(0x1018_d576, 1); pop(edi);                               /* pop edi */
            ii(0x1018_d577, 1); pop(esi);                               /* pop esi */
            ii(0x1018_d578, 1); pop(edx);                               /* pop edx */
            ii(0x1018_d579, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_d57a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_d57b, 1); ret();                                  /* ret */
        }
    }
}
