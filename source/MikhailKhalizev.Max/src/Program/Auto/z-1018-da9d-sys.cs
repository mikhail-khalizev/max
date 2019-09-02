using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_da9d-b46260a4")]
        public void /* sys */ Method_1018_da9d()
        {
            ii(0x1018_da9d, 1); push(ecx);                              /* push ecx */
            ii(0x1018_da9e, 1); push(esi);                              /* push esi */
            ii(0x1018_da9f, 1); push(edi);                              /* push edi */
            ii(0x1018_daa0, 1); push(ebp);                              /* push ebp */
            ii(0x1018_daa1, 3); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1018_daa4, 6); mov(esi, memd[ds, 0x1020_bd6c]);        /* mov esi, [0x1020bd6c] */
            ii(0x1018_daaa, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1018_daac, 2); mov(ebp, ebx);                          /* mov ebp, ebx */
            ii(0x1018_daae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_dab0, 4); mov(memd[ss, esp + 4], edx);            /* mov [esp+0x4], edx */
        l_0x1018_dab4:
            ii(0x1018_dab4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_dab6, 2); mov(bl, memb[ds, eax]);                 /* mov bl, [eax] */
            ii(0x1018_dab8, 3); cmp(ebx, 0x20);                         /* cmp ebx, 0x20 */
            ii(0x1018_dabb, 2); if(jz(0x1018_dac2, 5)) goto l_0x1018_dac2; /* jz 0x1018dac2 */
            ii(0x1018_dabd, 3); cmp(ebx, 9);                            /* cmp ebx, 0x9 */
            ii(0x1018_dac0, 2); if(jnz(0x1018_dac5, 3)) goto l_0x1018_dac5; /* jnz 0x1018dac5 */
        l_0x1018_dac2:
            ii(0x1018_dac2, 1); inc(eax);                               /* inc eax */
            ii(0x1018_dac3, 2); jmp(0x1018_dab4, -0x11); goto l_0x1018_dab4; /* jmp 0x1018dab4 */
        l_0x1018_dac5:
            ii(0x1018_dac5, 2); test(bl, bl);                           /* test bl, bl */
            ii(0x1018_dac7, 6); if(jz(0x1018_db97, 0xca)) goto l_0x1018_db97; /* jz 0x1018db97 */
            ii(0x1018_dacd, 2); xor(dl, dl);                            /* xor dl, dl */
            ii(0x1018_dacf, 3); cmp(ebx, 0x22);                         /* cmp ebx, 0x22 */
            ii(0x1018_dad2, 2); if(jnz(0x1018_dad7, 3)) goto l_0x1018_dad7; /* jnz 0x1018dad7 */
            ii(0x1018_dad4, 2); mov(dl, 1);                             /* mov dl, 0x1 */
            ii(0x1018_dad6, 1); inc(eax);                               /* inc eax */
        l_0x1018_dad7:
            ii(0x1018_dad7, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1018_dada, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1018_dadc:
            ii(0x1018_dadc, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_dade, 2); mov(cl, memb[ds, eax]);                 /* mov cl, [eax] */
            ii(0x1018_dae0, 3); cmp(ecx, 0x22);                         /* cmp ecx, 0x22 */
            ii(0x1018_dae3, 2); if(jnz(0x1018_db05, 0x20)) goto l_0x1018_db05; /* jnz 0x1018db05 */
            ii(0x1018_dae5, 3); cmp(dl, 1);                             /* cmp dl, 0x1 */
            ii(0x1018_dae8, 6); if(jz(0x1018_db64, 0x76)) goto l_0x1018_db64; /* jz 0x1018db64 */
            ii(0x1018_daee, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_daf0, 2); if(jnz(0x1018_db05, 0x13)) goto l_0x1018_db05; /* jnz 0x1018db05 */
            ii(0x1018_daf2, 2); test(dl, dl);                           /* test dl, dl */
            ii(0x1018_daf4, 2); if(jnz(0x1018_dafb, 5)) goto l_0x1018_dafb; /* jnz 0x1018dafb */
            ii(0x1018_daf6, 2); mov(dl, 2);                             /* mov dl, 0x2 */
        l_0x1018_daf8:
            ii(0x1018_daf8, 1); inc(eax);                               /* inc eax */
            ii(0x1018_daf9, 2); jmp(0x1018_dadc, -0x1f); goto l_0x1018_dadc; /* jmp 0x1018dadc */
        l_0x1018_dafb:
            ii(0x1018_dafb, 3); cmp(dl, 2);                             /* cmp dl, 0x2 */
            ii(0x1018_dafe, 2); if(jnz(0x1018_db05, 5)) goto l_0x1018_db05; /* jnz 0x1018db05 */
            ii(0x1018_db00, 1); inc(eax);                               /* inc eax */
            ii(0x1018_db01, 2); xor(dl, dl);                            /* xor dl, dl */
            ii(0x1018_db03, 2); jmp(0x1018_dadc, -0x29); goto l_0x1018_dadc; /* jmp 0x1018dadc */
        l_0x1018_db05:
            ii(0x1018_db05, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_db07, 2); mov(cl, memb[ds, eax]);                 /* mov cl, [eax] */
            ii(0x1018_db09, 3); cmp(ecx, 0x20);                         /* cmp ecx, 0x20 */
            ii(0x1018_db0c, 2); if(jz(0x1018_db13, 5)) goto l_0x1018_db13; /* jz 0x1018db13 */
            ii(0x1018_db0e, 3); cmp(ecx, 9);                            /* cmp ecx, 0x9 */
            ii(0x1018_db11, 2); if(jnz(0x1018_db17, 4)) goto l_0x1018_db17; /* jnz 0x1018db17 */
        l_0x1018_db13:
            ii(0x1018_db13, 2); test(dl, dl);                           /* test dl, dl */
            ii(0x1018_db15, 2); if(jz(0x1018_db64, 0x4d)) goto l_0x1018_db64; /* jz 0x1018db64 */
        l_0x1018_db17:
            ii(0x1018_db17, 2); mov(dh, memb[ds, eax]);                 /* mov dh, [eax] */
            ii(0x1018_db19, 2); test(dh, dh);                           /* test dh, dh */
            ii(0x1018_db1b, 2); if(jz(0x1018_db64, 0x47)) goto l_0x1018_db64; /* jz 0x1018db64 */
            ii(0x1018_db1d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_db1f, 2); mov(cl, dh);                            /* mov cl, dh */
            ii(0x1018_db21, 3); cmp(ecx, 0x5c);                         /* cmp ecx, 0x5c */
            ii(0x1018_db24, 2); if(jnz(0x1018_db55, 0x2f)) goto l_0x1018_db55; /* jnz 0x1018db55 */
            ii(0x1018_db26, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_db28, 2); if(jnz(0x1018_db36, 0xc)) goto l_0x1018_db36; /* jnz 0x1018db36 */
            ii(0x1018_db2a, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_db2c, 3); mov(cl, memb[ds, eax + 1]);             /* mov cl, [eax+0x1] */
            ii(0x1018_db2f, 3); cmp(ecx, 0x22);                         /* cmp ecx, 0x22 */
        l_0x1018_db32:
            ii(0x1018_db32, 2); if(jnz(0x1018_db55, 0x21)) goto l_0x1018_db55; /* jnz 0x1018db55 */
            ii(0x1018_db34, 2); jmp(0x1018_db54, 0x1e); goto l_0x1018_db54; /* jmp 0x1018db54 */
        l_0x1018_db36:
            ii(0x1018_db36, 3); cmp(dl, 1);                             /* cmp dl, 0x1 */
            ii(0x1018_db39, 2); if(jnz(0x1018_db4a, 0xf)) goto l_0x1018_db4a; /* jnz 0x1018db4a */
            ii(0x1018_db3b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_db3d, 3); mov(cl, memb[ds, eax + 1]);             /* mov cl, [eax+0x1] */
            ii(0x1018_db40, 3); cmp(ecx, 0x22);                         /* cmp ecx, 0x22 */
            ii(0x1018_db43, 2); if(jz(0x1018_db54, 0xf)) goto l_0x1018_db54; /* jz 0x1018db54 */
            ii(0x1018_db45, 3); cmp(ecx, 0x5c);                         /* cmp ecx, 0x5c */
            ii(0x1018_db48, 2); jmp(0x1018_db32, -0x18); goto l_0x1018_db32; /* jmp 0x1018db32 */
        l_0x1018_db4a:
            ii(0x1018_db4a, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_db4c, 3); mov(cl, memb[ds, eax + 1]);             /* mov cl, [eax+0x1] */
            ii(0x1018_db4f, 3); cmp(ecx, 0x22);                         /* cmp ecx, 0x22 */
            ii(0x1018_db52, 2); if(jnz(0x1018_db55, 1)) goto l_0x1018_db55; /* jnz 0x1018db55 */
        l_0x1018_db54:
            ii(0x1018_db54, 1); inc(eax);                               /* inc eax */
        l_0x1018_db55:
            ii(0x1018_db55, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_db57, 2); if(jz(0x1018_daf8, -0x61)) goto l_0x1018_daf8; /* jz 0x1018daf8 */
            ii(0x1018_db59, 2); mov(cl, memb[ds, eax]);                 /* mov cl, [eax] */
            ii(0x1018_db5b, 1); inc(eax);                               /* inc eax */
            ii(0x1018_db5c, 2); mov(memb[ds, ebx], cl);                 /* mov [ebx], cl */
            ii(0x1018_db5e, 1); inc(ebx);                               /* inc ebx */
            ii(0x1018_db5f, 5); jmp(0x1018_dadc, -0x88); goto l_0x1018_dadc; /* jmp 0x1018dadc */
        l_0x1018_db64:
            ii(0x1018_db64, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_db66, 2); if(jz(0x1018_db8a, 0x22)) goto l_0x1018_db8a; /* jz 0x1018db8a */
            ii(0x1018_db68, 4); mov(ecx, memd[ss, esp + 4]);            /* mov ecx, [esp+0x4] */
            ii(0x1018_db6c, 3); mov(edx, memd[ss, esp]);                /* mov edx, [esp] */
            ii(0x1018_db6f, 3); mov(memd[ds, edi + ecx * 4], edx);      /* mov [edi+ecx*4], edx */
            ii(0x1018_db72, 1); inc(ecx);                               /* inc ecx */
            ii(0x1018_db73, 4); mov(memd[ss, esp + 4], ecx);            /* mov [esp+0x4], ecx */
            ii(0x1018_db77, 2); mov(cl, memb[ds, eax]);                 /* mov cl, [eax] */
            ii(0x1018_db79, 2); test(cl, cl);                           /* test cl, cl */
            ii(0x1018_db7b, 2); if(jnz(0x1018_db81, 4)) goto l_0x1018_db81; /* jnz 0x1018db81 */
            ii(0x1018_db7d, 2); mov(memb[ds, ebx], cl);                 /* mov [ebx], cl */
            ii(0x1018_db7f, 2); jmp(0x1018_db97, 0x16); goto l_0x1018_db97; /* jmp 0x1018db97 */
        l_0x1018_db81:
            ii(0x1018_db81, 1); inc(eax);                               /* inc eax */
            ii(0x1018_db82, 3); mov(memb[ds, ebx], 0);                  /* mov byte [ebx], 0x0 */
            ii(0x1018_db85, 5); jmp(0x1018_dab4, -0xd6); goto l_0x1018_dab4; /* jmp 0x1018dab4 */
        l_0x1018_db8a:
            ii(0x1018_db8a, 4); inc(memd[ss, esp + 4]);                 /* inc dword [esp+0x4] */
            ii(0x1018_db8e, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x1018_db91, 6); if(jnz(0x1018_dac2, -0xd5)) goto l_0x1018_dac2; /* jnz 0x1018dac2 */
        l_0x1018_db97:
            ii(0x1018_db97, 3); mov(memd[ss, ebp], eax);                /* mov [ebp], eax */
            ii(0x1018_db9a, 4); mov(eax, memd[ss, esp + 4]);            /* mov eax, [esp+0x4] */
            ii(0x1018_db9e, 6); mov(memd[ds, 0x1020_bd6c], esi);        /* mov [0x1020bd6c], esi */
            ii(0x1018_dba4, 3); add(esp, 8);                            /* add esp, 0x8 */
            ii(0x1018_dba7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_dba8, 1); pop(edi);                               /* pop edi */
            ii(0x1018_dba9, 1); pop(esi);                               /* pop esi */
            ii(0x1018_dbaa, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_dbab, 1); ret();                                  /* ret */
        }
    }
}
