using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9580-b2b0140a")]
        public void /* sys */ Method_1017_9580()
        {
            ii(0x1017_9580, 1); push(ebp);                              /* push ebp */
            ii(0x1017_9581, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_9583, 1); push(ebx);                              /* push ebx */
            ii(0x1017_9584, 1); push(ecx);                              /* push ecx */
            ii(0x1017_9585, 1); push(esi);                              /* push esi */
            ii(0x1017_9586, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_9588, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1017_958a, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_958c, 2); if(jz(0x1017_95a8, 0x1a)) goto l_0x1017_95a8; /* jz 0x101795a8 */
            ii(0x1017_958e, 4); cmp(memd[ds, eax + 12], 0);             /* cmp dword [eax+0xc], 0x0 */
            ii(0x1017_9592, 2); if(jnz(0x1017_95be, 0x2a)) goto l_0x1017_95be; /* jnz 0x101795be */
            ii(0x1017_9594, 4); cmp(memd[ds, eax + 4], 0);              /* cmp dword [eax+0x4], 0x0 */
            ii(0x1017_9598, 2); if(jz(0x1017_95be, 0x24)) goto l_0x1017_95be; /* jz 0x101795be */
            ii(0x1017_959a, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_959c, 3); mov(ebx, memd[ds, ecx + 4]);            /* mov ebx, [ecx+0x4] */
            ii(0x1017_959f, 2); mov(eax, memd[ds, ecx]);                /* mov eax, [ecx] */
            ii(0x1017_95a1, 5); call(/* sys */ 0x1019_44a0, 0x1_aefa);  /* call 0x101944a0 */
            ii(0x1017_95a6, 2); jmp(0x1017_95be, 0x16); goto l_0x1017_95be; /* jmp 0x101795be */
        l_0x1017_95a8:
            ii(0x1017_95a8, 4); cmp(memd[ds, eax + 12], 0);             /* cmp dword [eax+0xc], 0x0 */
            ii(0x1017_95ac, 2); if(jz(0x1017_95be, 0x10)) goto l_0x1017_95be; /* jz 0x101795be */
            ii(0x1017_95ae, 3); mov(ebx, memd[ds, eax + 4]);            /* mov ebx, [eax+0x4] */
            ii(0x1017_95b1, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_95b3, 2); if(jz(0x1017_95be, 9)) goto l_0x1017_95be; /* jz 0x101795be */
            ii(0x1017_95b5, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_95b7, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1017_95b9, 5); call(/* sys */ 0x1019_44f0, 0x1_af32);  /* call 0x101944f0 */
        l_0x1017_95be:
            ii(0x1017_95be, 3); mov(memd[ds, ecx + 12], esi);           /* mov [ecx+0xc], esi */
            ii(0x1017_95c1, 3); lea(esp, memd[ss, ebp - 12]);           /* lea esp, [ebp-0xc] */
            ii(0x1017_95c4, 1); pop(esi);                               /* pop esi */
            ii(0x1017_95c5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_95c6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_95c7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_95c8, 1); ret();                                  /* ret */
        }
    }
}
