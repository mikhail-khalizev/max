using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d9dc-3e909679")]
        public void /* sys */ Method_1018_d9dc()
        {
            ii(0x1018_d9dc, 1); push(ebx);                              /* push ebx */
            ii(0x1018_d9dd, 1); push(ecx);                              /* push ecx */
            ii(0x1018_d9de, 1); push(edx);                              /* push edx */
            ii(0x1018_d9df, 1); push(esi);                              /* push esi */
            ii(0x1018_d9e0, 1); push(edi);                              /* push edi */
            ii(0x1018_d9e1, 1); push(ebp);                              /* push ebp */
            ii(0x1018_d9e2, 3); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1018_d9e5, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1018_d9e7, 5); mov(eax, memd[ds, 0x101b_e564]);        /* mov eax, [0x101be564] */
            ii(0x1018_d9ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_d9ee, 5); call(/* sys */ 0x1018_da9d, 0xaa);      /* call 0x1018da9d */
            ii(0x1018_d9f3, 3); mov(ecx, memd[ss, esp]);                /* mov ecx, [esp] */
            ii(0x1018_d9f6, 1); inc(eax);                               /* inc eax */
            ii(0x1018_d9f7, 6); mov(edx, memd[ds, 0x101b_e564]);        /* mov edx, [0x101be564] */
            ii(0x1018_d9fd, 4); mov(memd[ss, esp + 0x8], eax);          /* mov [esp+0x8], eax */
            ii(0x1018_da01, 2); sub(ecx, edx);                          /* sub ecx, edx */
            ii(0x1018_da03, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1018_da06, 1); inc(ecx);                               /* inc ecx */
            ii(0x1018_da07, 4); mov(memd[ss, esp + 0x4], eax);          /* mov [esp+0x4], eax */
            ii(0x1018_da0b, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1018_da0e, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1018_da10, 5); call(Definitions.sys_malloc, -0x2_2a37); /* call 0x1016afde */
            ii(0x1018_da15, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1018_da17, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_da19, 2); if(jz(0x1018_da76, 0x5b)) goto l_0x1018_da76; /* jz 0x1018da76 */
            ii(0x1018_da1b, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1018_da1d, 6); mov(esi, memd[ds, 0x101b_e564]);        /* mov esi, [0x101be564] */
            ii(0x1018_da23, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1018_da25, 2); mov(edi, ebp);                          /* mov edi, ebp */
            ii(0x1018_da27, 5); mov(memd[ds, 0x101b_e1fc], eax);        /* mov [0x101be1fc], eax */
            ii(0x1018_da2c, 1); push(es);                               /* push es */
            ii(0x1018_da2d, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1018_da2f, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1018_da31, 1); push(edi);                              /* push edi */
            ii(0x1018_da32, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_da34, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1018_da37, 2); repne(() => movsd());                   /* repne movsd */
            ii(0x1018_da39, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1018_da3b, 3); and(cl, 0x3);                           /* and cl, 0x3 */
            ii(0x1018_da3e, 2); repne(() => movsb());                   /* repne movsb */
            ii(0x1018_da40, 1); pop(edi);                               /* pop edi */
            ii(0x1018_da41, 1); pop(es);                                /* pop es */
            ii(0x1018_da42, 6); mov(ecx, memd[ds, 0x101b_e1fc]);        /* mov ecx, [0x101be1fc] */
            ii(0x1018_da48, 5); mov(eax, memd[ds, 0x101b_e568]);        /* mov eax, [0x101be568] */
            ii(0x1018_da4d, 3); lea(edx, memd[ds, ecx + 0x4]);          /* lea edx, [ecx+0x4] */
            ii(0x1018_da50, 2); mov(memd[ds, ecx], eax);                /* mov [ecx], eax */
            ii(0x1018_da52, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1018_da54, 4); mov(esi, memd[ss, esp + 0x4]);          /* mov esi, [esp+0x4] */
            ii(0x1018_da58, 5); call(/* sys */ 0x1018_da9d, 0x40);      /* call 0x1018da9d */
            ii(0x1018_da5d, 6); mov(ecx, memd[ds, 0x101b_e1fc]);        /* mov ecx, [0x101be1fc] */
            ii(0x1018_da63, 4); mov(eax, memd[ss, esp + 0x8]);          /* mov eax, [esp+0x8] */
            ii(0x1018_da67, 2); add(ecx, esi);                          /* add ecx, esi */
            ii(0x1018_da69, 5); mov(memd[ds, 0x101b_e1f8], eax);        /* mov [0x101be1f8], eax */
            ii(0x1018_da6e, 6); mov(memd[ds, ecx], 0);                  /* mov dword [ecx], 0x0 */
            ii(0x1018_da74, 2); jmp(0x1018_da80, 0xa); goto l_0x1018_da80; /* jmp 0x1018da80 */
        l_0x1018_da76:
            ii(0x1018_da76, 5); mov(memd[ds, 0x101b_e1fc], eax);        /* mov [0x101be1fc], eax */
            ii(0x1018_da7b, 5); mov(memd[ds, 0x101b_e1f8], eax);        /* mov [0x101be1f8], eax */
        l_0x1018_da80:
            ii(0x1018_da80, 4); mov(eax, memd[ss, esp + 0x8]);          /* mov eax, [esp+0x8] */
            ii(0x1018_da84, 5); mov(memd[ds, 0x1020_bd40], eax);        /* mov [0x1020bd40], eax */
            ii(0x1018_da89, 5); mov(eax, memd[ds, 0x101b_e1fc]);        /* mov eax, [0x101be1fc] */
            ii(0x1018_da8e, 5); mov(memd[ds, 0x1020_bd44], eax);        /* mov [0x1020bd44], eax */
            ii(0x1018_da93, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1018_da96, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_da97, 1); pop(edi);                               /* pop edi */
            ii(0x1018_da98, 1); pop(esi);                               /* pop esi */
            ii(0x1018_da99, 1); pop(edx);                               /* pop edx */
            ii(0x1018_da9a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_da9b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_da9c, 1); ret();                                  /* ret */
        }
    }
}
