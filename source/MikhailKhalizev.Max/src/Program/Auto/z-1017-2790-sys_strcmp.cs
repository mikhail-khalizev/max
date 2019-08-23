using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_2790-e1998121")]
        public void /* sys */ sys_strcmp()
        {
            ii(0x1017_2790, 1); push(ebx);                              /* push ebx */
            ii(0x1017_2791, 1); push(ecx);                              /* push ecx */
            ii(0x1017_2792, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_2794, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1017_2796, 2); if(jz(0x1017_2804, 0x6c)) goto l_0x1017_2804; /* jz 0x10172804 */
        l_0x1017_2798:
            ii(0x1017_2798, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1017_279a, 2); mov(ecx, memd[ds, edx]);                /* mov ecx, [edx] */
            ii(0x1017_279c, 2); cmp(ecx, eax);                          /* cmp ecx, eax */
            ii(0x1017_279e, 2); if(jnz(0x1017_2809, 0x69)) goto l_0x1017_2809; /* jnz 0x10172809 */
            ii(0x1017_27a0, 2); not(ecx);                               /* not ecx */
            ii(0x1017_27a2, 5); add(eax, 0xfefe_feff);                  /* add eax, 0xfefefeff */
            ii(0x1017_27a7, 2); and(eax, ecx);                          /* and eax, ecx */
            ii(0x1017_27a9, 5); and(eax, 0x8080_8080);                  /* and eax, 0x80808080 */
            ii(0x1017_27ae, 2); if(jnz(0x1017_2804, 0x54)) goto l_0x1017_2804; /* jnz 0x10172804 */
            ii(0x1017_27b0, 3); mov(eax, memd[ds, ebx + 0x4]);          /* mov eax, [ebx+0x4] */
            ii(0x1017_27b3, 3); mov(ecx, memd[ds, edx + 0x4]);          /* mov ecx, [edx+0x4] */
            ii(0x1017_27b6, 2); cmp(ecx, eax);                          /* cmp ecx, eax */
            ii(0x1017_27b8, 2); if(jnz(0x1017_2809, 0x4f)) goto l_0x1017_2809; /* jnz 0x10172809 */
            ii(0x1017_27ba, 2); not(ecx);                               /* not ecx */
            ii(0x1017_27bc, 5); add(eax, 0xfefe_feff);                  /* add eax, 0xfefefeff */
            ii(0x1017_27c1, 2); and(eax, ecx);                          /* and eax, ecx */
            ii(0x1017_27c3, 5); and(eax, 0x8080_8080);                  /* and eax, 0x80808080 */
            ii(0x1017_27c8, 2); if(jnz(0x1017_2804, 0x3a)) goto l_0x1017_2804; /* jnz 0x10172804 */
            ii(0x1017_27ca, 3); mov(eax, memd[ds, ebx + 0x8]);          /* mov eax, [ebx+0x8] */
            ii(0x1017_27cd, 3); mov(ecx, memd[ds, edx + 0x8]);          /* mov ecx, [edx+0x8] */
            ii(0x1017_27d0, 2); cmp(ecx, eax);                          /* cmp ecx, eax */
            ii(0x1017_27d2, 2); if(jnz(0x1017_2809, 0x35)) goto l_0x1017_2809; /* jnz 0x10172809 */
            ii(0x1017_27d4, 2); not(ecx);                               /* not ecx */
            ii(0x1017_27d6, 5); add(eax, 0xfefe_feff);                  /* add eax, 0xfefefeff */
            ii(0x1017_27db, 2); and(eax, ecx);                          /* and eax, ecx */
            ii(0x1017_27dd, 5); and(eax, 0x8080_8080);                  /* and eax, 0x80808080 */
            ii(0x1017_27e2, 2); if(jnz(0x1017_2804, 0x20)) goto l_0x1017_2804; /* jnz 0x10172804 */
            ii(0x1017_27e4, 3); mov(eax, memd[ds, ebx + 0xc]);          /* mov eax, [ebx+0xc] */
            ii(0x1017_27e7, 3); mov(ecx, memd[ds, edx + 0xc]);          /* mov ecx, [edx+0xc] */
            ii(0x1017_27ea, 2); cmp(ecx, eax);                          /* cmp ecx, eax */
            ii(0x1017_27ec, 2); if(jnz(0x1017_2809, 0x1b)) goto l_0x1017_2809; /* jnz 0x10172809 */
            ii(0x1017_27ee, 3); add(ebx, 0x10);                         /* add ebx, 0x10 */
            ii(0x1017_27f1, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x1017_27f4, 2); not(ecx);                               /* not ecx */
            ii(0x1017_27f6, 5); add(eax, 0xfefe_feff);                  /* add eax, 0xfefefeff */
            ii(0x1017_27fb, 2); and(eax, ecx);                          /* and eax, ecx */
            ii(0x1017_27fd, 5); and(eax, 0x8080_8080);                  /* and eax, 0x80808080 */
            ii(0x1017_2802, 2); if(jz(0x1017_2798, -0x6c)) goto l_0x1017_2798; /* jz 0x10172798 */
        l_0x1017_2804:
            ii(0x1017_2804, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1017_2806, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_2807, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_2808, 1); ret(); return;                          /* ret */
        l_0x1017_2809:
            ii(0x1017_2809, 2); cmp(al, cl);                            /* cmp al, cl */
            ii(0x1017_280b, 2); if(jnz(0x1017_282a, 0x1d)) goto l_0x1017_282a; /* jnz 0x1017282a */
            ii(0x1017_280d, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1017_280f, 2); if(jz(0x1017_2804, -0xd)) goto l_0x1017_2804; /* jz 0x10172804 */
            ii(0x1017_2811, 2); cmp(ah, ch);                            /* cmp ah, ch */
            ii(0x1017_2813, 2); if(jnz(0x1017_282a, 0x15)) goto l_0x1017_282a; /* jnz 0x1017282a */
            ii(0x1017_2815, 3); cmp(ah, 0);                             /* cmp ah, 0x0 */
            ii(0x1017_2818, 2); if(jz(0x1017_2804, -0x16)) goto l_0x1017_2804; /* jz 0x10172804 */
            ii(0x1017_281a, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1017_281d, 3); shr(ecx, 0x10);                         /* shr ecx, 0x10 */
            ii(0x1017_2820, 2); cmp(al, cl);                            /* cmp al, cl */
            ii(0x1017_2822, 2); if(jnz(0x1017_282a, 0x6)) goto l_0x1017_282a; /* jnz 0x1017282a */
            ii(0x1017_2824, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1017_2826, 2); if(jz(0x1017_2804, -0x24)) goto l_0x1017_2804; /* jz 0x10172804 */
            ii(0x1017_2828, 2); cmp(ah, ch);                            /* cmp ah, ch */
        l_0x1017_282a:
            ii(0x1017_282a, 2); sbb(eax, eax);                          /* sbb eax, eax */
            ii(0x1017_282c, 2); or(al, 0x1);                            /* or al, 0x1 */
            ii(0x1017_282e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_282f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_2830, 1); ret();                                  /* ret */
        }
    }
}
