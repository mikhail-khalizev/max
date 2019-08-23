using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5bc1-138bf21a")]
        public void /* sys */ Method_1019_5bc1()
        {
            ii(0x1019_5bc1, 1); push(ecx);                              /* push ecx */
            ii(0x1019_5bc2, 1); push(esi);                              /* push esi */
            ii(0x1019_5bc3, 1); push(edi);                              /* push edi */
            ii(0x1019_5bc4, 1); push(ebp);                              /* push ebp */
            ii(0x1019_5bc5, 3); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1019_5bc8, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1019_5bca, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1019_5bcc, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1019_5bce, 2); xor(dl, dl);                            /* xor dl, dl */
            ii(0x1019_5bd0, 4); lea(ecx, esp + 0x1);                    /* lea ecx, [esp+0x1] */
            ii(0x1019_5bd4, 3); mov(memb[ss, esp], dl);                 /* mov [esp], dl */
        l_0x1019_5bd7:
            ii(0x1019_5bd7, 4); lea(ebx, esp + 0x24);                   /* lea ebx, [esp+0x24] */
            ii(0x1019_5bdb, 4); mov(memd[ss, esp + 0x24], edi);         /* mov [esp+0x24], edi */
            ii(0x1019_5bdf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_5be1, 2); div(memd[ds, ebx]);                     /* div dword [ebx] */
            ii(0x1019_5be3, 2); mov(memd[ds, ebx], edx);                /* mov [ebx], edx */
            ii(0x1019_5be5, 4); mov(edx, memd[ss, esp + 0x24]);         /* mov edx, [esp+0x24] */
            ii(0x1019_5be9, 7); mov(dl, memb[cs, edx + /* sys */ 0x1019_5b9c]); /* mov dl, [cs:edx+0x10195b9c] */
            ii(0x1019_5bf0, 2); mov(memb[ds, ecx], dl);                 /* mov [ecx], dl */
            ii(0x1019_5bf2, 1); inc(ecx);                               /* inc ecx */
            ii(0x1019_5bf3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_5bf5, 2); if(jnz(0x1019_5bd7, -0x20)) goto l_0x1019_5bd7; /* jnz 0x10195bd7 */
        l_0x1019_5bf7:
            ii(0x1019_5bf7, 1); dec(ecx);                               /* dec ecx */
            ii(0x1019_5bf8, 2); mov(al, memb[ds, ecx]);                 /* mov al, [ecx] */
            ii(0x1019_5bfa, 2); mov(memb[ds, esi], al);                 /* mov [esi], al */
            ii(0x1019_5bfc, 1); inc(esi);                               /* inc esi */
            ii(0x1019_5bfd, 2); test(al, al);                           /* test al, al */
            ii(0x1019_5bff, 2); if(jnz(0x1019_5bf7, -0xa)) goto l_0x1019_5bf7; /* jnz 0x10195bf7 */
            ii(0x1019_5c01, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1019_5c03, 3); add(esp, 0x28);                         /* add esp, 0x28 */
            ii(0x1019_5c06, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_5c07, 1); pop(edi);                               /* pop edi */
            ii(0x1019_5c08, 1); pop(esi);                               /* pop esi */
            ii(0x1019_5c09, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_5c0a, 1); ret();                                  /* ret */
        }
    }
}
