using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5d01-d5fcdff7")]
        public void /* sys */ Method_1019_5d01()
        {
            ii(0x1019_5d01, 1); push(ebx);                              /* push ebx */
            ii(0x1019_5d02, 1); push(ecx);                              /* push ecx */
            ii(0x1019_5d03, 1); push(edx);                              /* push edx */
            ii(0x1019_5d04, 1); push(esi);                              /* push esi */
            ii(0x1019_5d05, 1); push(edi);                              /* push edi */
            ii(0x1019_5d06, 1); push(ebp);                              /* push ebp */
            ii(0x1019_5d07, 3); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1019_5d0a, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_5d0c, 2); mov(edi, memd[ds, eax]);                /* mov edi, [eax] */
            ii(0x1019_5d0e, 3); add(edi, 0xc);                          /* add edi, 0xc */
            ii(0x1019_5d11, 3); mov(esi, memd[ds, eax + 4]);            /* mov esi, [eax+0x4] */
            ii(0x1019_5d14, 3); mov(ebp, memd[ds, edi - 8]);            /* mov ebp, [edi-0x8] */
        l_0x1019_5d17:
            ii(0x1019_5d17, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1019_5d19, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1019_5d1b, 5); call(/* sys */ 0x1019_5c28, -0xf8);     /* call 0x10195c28 */
            ii(0x1019_5d20, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1019_5d23, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_5d25, 6); if(jz(0x1019_5d88, 0x5d)) goto l_0x1019_5d88; /* jz 0x10195d88 */
            ii(0x1019_5d2b, 3); mov(edx, memd[ds, ecx + 4]);            /* mov edx, [ecx+0x4] */
            ii(0x1019_5d2e, 3); cmp(edx, memd[ds, ecx + 9]);            /* cmp edx, [ecx+0x9] */
            ii(0x1019_5d31, 6); if(jz(0x1019_5d88, 0x51)) goto l_0x1019_5d88; /* jz 0x10195d88 */
            ii(0x1019_5d37, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x1019_5d3a, 2); if(jnz(0x1019_5d88, 0x4c)) goto l_0x1019_5d88; /* jnz 0x10195d88 */
            ii(0x1019_5d3c, 3); mov(ebx, memd[ds, eax + 4]);            /* mov ebx, [eax+0x4] */
            ii(0x1019_5d3f, 3); mov(ax, memw[ds, ebx]);                 /* mov ax, [ebx] */
            ii(0x1019_5d42, 4); cmp(ax, 2);                             /* cmp ax, 0x2 */
            ii(0x1019_5d46, 2); if(jb(0x1019_5d80, 0x38)) goto l_0x1019_5d80; /* jb 0x10195d80 */
            ii(0x1019_5d48, 4); cmp(ax, 4);                             /* cmp ax, 0x4 */
            ii(0x1019_5d4c, 2); if(jbe(0x1019_5d88, 0x3a)) goto l_0x1019_5d88; /* jbe 0x10195d88 */
            ii(0x1019_5d4e, 4); cmp(ax, 5);                             /* cmp ax, 0x5 */
            ii(0x1019_5d52, 2); if(jbe(0x1019_5d5c, 8)) goto l_0x1019_5d5c; /* jbe 0x10195d5c */
            ii(0x1019_5d54, 4); cmp(ax, 0xb);                           /* cmp ax, 0xb */
            ii(0x1019_5d58, 2); if(jbe(0x1019_5d88, 0x2e)) goto l_0x1019_5d88; /* jbe 0x10195d88 */
            ii(0x1019_5d5a, 2); jmp(0x1019_5d79, 0x1d); goto l_0x1019_5d79; /* jmp 0x10195d79 */
        l_0x1019_5d5c:
            ii(0x1019_5d5c, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1019_5d5e, 3); mov(edx, memd[ds, ebx + 2]);            /* mov edx, [ebx+0x2] */
            ii(0x1019_5d61, 5); call(/* sys */ 0x1019_b4cc, 0x5766);    /* call 0x1019b4cc */
            ii(0x1019_5d66, 2); test(al, al);                           /* test al, al */
            ii(0x1019_5d68, 2); if(jz(0x1019_5d6f, 5)) goto l_0x1019_5d6f; /* jz 0x10195d6f */
            ii(0x1019_5d6a, 3); mov(esi, memd[ds, ebx + 6]);            /* mov esi, [ebx+0x6] */
            ii(0x1019_5d6d, 2); jmp(0x1019_5d17, -0x58); goto l_0x1019_5d17; /* jmp 0x10195d17 */
        l_0x1019_5d6f:
            ii(0x1019_5d6f, 3); mov(esi, memd[ds, ebx + 0xa]);          /* mov esi, [ebx+0xa] */
            ii(0x1019_5d72, 2); jmp(0x1019_5d17, -0x5d); goto l_0x1019_5d17; /* jmp 0x10195d17 */
        l_0x1019_5d74:
            ii(0x1019_5d74, 3); mov(esi, memd[ds, ebx + 2]);            /* mov esi, [ebx+0x2] */
            ii(0x1019_5d77, 2); jmp(0x1019_5d17, -0x62); goto l_0x1019_5d17; /* jmp 0x10195d17 */
        l_0x1019_5d79:
            ii(0x1019_5d79, 5); call(/* sys */ 0x1019_5dab, 0x2d);      /* call 0x10195dab */
            ii(0x1019_5d7e, 2); jmp(0x1019_5d88, 8); goto l_0x1019_5d88; /* jmp 0x10195d88 */
        l_0x1019_5d80:
            ii(0x1019_5d80, 4); cmp(ax, 1);                             /* cmp ax, 0x1 */
            ii(0x1019_5d84, 2); if(jz(0x1019_5d74, -0x12)) goto l_0x1019_5d74; /* jz 0x10195d74 */
            ii(0x1019_5d86, 2); jmp(0x1019_5d79, -0xf); goto l_0x1019_5d79; /* jmp 0x10195d79 */
        l_0x1019_5d88:
            ii(0x1019_5d88, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1019_5d8b, 3); mov(memd[ds, ecx + 4], esi);            /* mov [ecx+0x4], esi */
            ii(0x1019_5d8e, 5); if(jmp_func(0x1019_5cda, -0xb9)) return; /* jmp 0x10195cda */
        }
    }
}
