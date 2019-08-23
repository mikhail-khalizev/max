using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7068-69ad2c82")]
        public void /* sys */ Method_1018_7068()
        {
            ii(0x1018_7068, 1); push(ebx);                              /* push ebx */
            ii(0x1018_7069, 1); push(edx);                              /* push edx */
            ii(0x1018_706a, 1); push(esi);                              /* push esi */
            ii(0x1018_706b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_706d, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1018_706f, 3); add(edx, 0xb);                          /* add edx, 0xb */
            ii(0x1018_7072, 3); and(dl, 0xf8);                          /* and dl, 0xf8 */
            ii(0x1018_7075, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_7077, 2); if(jnz(0x1018_707f, 0x6)) goto l_0x1018_707f; /* jnz 0x1018707f */
        l_0x1018_7079:
            ii(0x1018_7079, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_707b, 1); pop(esi);                               /* pop esi */
            ii(0x1018_707c, 1); pop(edx);                               /* pop edx */
            ii(0x1018_707d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_707e, 1); ret(); return;                          /* ret */
        l_0x1018_707f:
            ii(0x1018_707f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_7081, 5); mov(al, memb[ds, 0x101b_e58e]);         /* mov al, [0x101be58e] */
            ii(0x1018_7086, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1018_7089, 2); if(jnz(0x1018_7094, 0x9)) goto l_0x1018_7094; /* jnz 0x10187094 */
            ii(0x1018_708b, 7); cmp(memb[ds, 0x101b_e58f], 0);          /* cmp byte [0x101be58f], 0x0 */
            ii(0x1018_7092, 2); if(jz(0x1018_70a0, 0xc)) goto l_0x1018_70a0; /* jz 0x101870a0 */
        l_0x1018_7094:
            ii(0x1018_7094, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_7096, 5); mov(al, memb[ds, 0x101b_e58e]);         /* mov al, [0x101be58e] */
            ii(0x1018_709b, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1018_709e, 2); if(jnz(0x1018_70a5, 0x5)) goto l_0x1018_70a5; /* jnz 0x101870a5 */
        l_0x1018_70a0:
            ii(0x1018_70a0, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1018_70a3, 2); jmp(0x1018_70ac, 0x7); goto l_0x1018_70ac; /* jmp 0x101870ac */
        l_0x1018_70a5:
            ii(0x1018_70a5, 5); call(/* sys */ 0x1018_6d4b, -0x35f);    /* call 0x10186d4b */
            ii(0x1018_70aa, 2); sub(edx, eax);                          /* sub edx, eax */
        l_0x1018_70ac:
            ii(0x1018_70ac, 2); mov(memd[ds, ebx], edx);                /* mov [ebx], edx */
            ii(0x1018_70ae, 3); add(edx, 0x3c);                         /* add edx, 0x3c */
            ii(0x1018_70b1, 2); cmp(edx, memd[ds, ebx]);                /* cmp edx, [ebx] */
            ii(0x1018_70b3, 2); if(jb(0x1018_7079, -0x3c)) goto l_0x1018_7079; /* jb 0x10187079 */
            ii(0x1018_70b5, 6); mov(esi, memd[ds, 0x101c_1c54]);        /* mov esi, [0x101c1c54] */
            ii(0x1018_70bb, 2); cmp(edx, esi);                          /* cmp edx, esi */
            ii(0x1018_70bd, 2); if(jae(0x1018_70c4, 0x5)) goto l_0x1018_70c4; /* jae 0x101870c4 */
            ii(0x1018_70bf, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1018_70c1, 3); and(dl, 0xfe);                          /* and dl, 0xfe */
        l_0x1018_70c4:
            ii(0x1018_70c4, 2); mov(memd[ds, ebx], edx);                /* mov [ebx], edx */
            ii(0x1018_70c6, 6); add(edx, 0xfff);                        /* add edx, 0xfff */
            ii(0x1018_70cc, 2); cmp(edx, memd[ds, ebx]);                /* cmp edx, [ebx] */
            ii(0x1018_70ce, 2); if(jb(0x1018_7079, -0x57)) goto l_0x1018_7079; /* jb 0x10187079 */
            ii(0x1018_70d0, 2); xor(dl, dl);                            /* xor dl, dl */
            ii(0x1018_70d2, 3); and(dh, 0xf0);                          /* and dh, 0xf0 */
            ii(0x1018_70d5, 2); mov(memd[ds, ebx], edx);                /* mov [ebx], edx */
            ii(0x1018_70d7, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_70d9, 3); setnz(al);                              /* setnz al */
            ii(0x1018_70dc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_70e1, 1); pop(esi);                               /* pop esi */
            ii(0x1018_70e2, 1); pop(edx);                               /* pop edx */
            ii(0x1018_70e3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_70e4, 1); ret();                                  /* ret */
        }
    }
}
