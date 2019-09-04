using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_efb8-37fe3aa2")]
        public void /* sys */ Method_1017_efb8()
        {
            ii(0x1017_efb8, 1); push(ecx);                              /* push ecx */
            ii(0x1017_efb9, 1); push(esi);                              /* push esi */
            ii(0x1017_efba, 1); push(edi);                              /* push edi */
            ii(0x1017_efbb, 1); push(ebp);                              /* push ebp */
            ii(0x1017_efbc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_efbe, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1017_efc4, 4); mov(memw[ss, ebp - 12], dx);            /* mov [ebp-0xc], dx */
            ii(0x1017_efc8, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1017_efcb, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1017_efce, 5); call(/* sys */ 0x1017_ec5c, -0x377);    /* call 0x1017ec5c */
            ii(0x1017_efd3, 10); mov(memd[ds, 0x101b_e558], 1);         /* mov dword [0x101be558], 0x1 */
            ii(0x1017_efdd, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1017_efe1, 2); if(jnz(0x1017_efea, 7)) goto l_0x1017_efea; /* jnz 0x1017efea */
            ii(0x1017_efe3, 5); cmp(memw[ss, ebp - 12], 0);             /* cmp word [ebp-0xc], 0x0 */
            ii(0x1017_efe8, 2); if(jz(0x1017_f00a, 0x20)) goto l_0x1017_f00a; /* jz 0x1017f00a */
        l_0x1017_efea:
            ii(0x1017_efea, 3); mov(esi, memd[ss, ebp - 12]);           /* mov esi, [ebp-0xc] */
            ii(0x1017_efed, 3); mov(edi, memd[ss, ebp - 16]);           /* mov edi, [ebp-0x10] */
            ii(0x1017_eff0, 2); mov(ebx, ds);                           /* mov ebx, ds */
            ii(0x1017_eff2, 5); mov(edx, 0x101c_07ca);                  /* mov edx, 0x101c07ca */
            ii(0x1017_eff7, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_eff9, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_effb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_effd, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_efff, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1017_f001, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1017_f003, 5); call(/* sys */ 0x1019_5b35, 0x1_6b2d);  /* call 0x10195b35 */
            ii(0x1017_f008, 2); jmp(0x1017_f011, 7); goto l_0x1017_f011; /* jmp 0x1017f011 */
        l_0x1017_f00a:
            ii(0x1017_f00a, 7); mov(memb[ds, 0x101c_07ca], 0);          /* mov byte [0x101c07ca], 0x0 */
        l_0x1017_f011:
            ii(0x1017_f011, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1017_f018, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1017_f01b, 1); leave();                                /* leave */
            ii(0x1017_f01c, 1); pop(edi);                               /* pop edi */
            ii(0x1017_f01d, 1); pop(esi);                               /* pop esi */
            ii(0x1017_f01e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_f01f, 1); ret();                                  /* ret */
        }
    }
}
