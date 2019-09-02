using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_67f7-37f5bdd3")]
        public void /* sys */ Method_1019_67f7()
        {
            ii(0x1019_67f7, 1); push(ebx);                              /* push ebx */
            ii(0x1019_67f8, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1019_67fa, 3); mov(dl, memb[ds, edx + 0x14]);          /* mov dl, [edx+0x14] */
            ii(0x1019_67fd, 3); and(dl, 1);                             /* and dl, 0x1 */
            ii(0x1019_6800, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1019_6806, 2); if(jnz(0x1019_6854, 0x4c)) goto l_0x1019_6854; /* jnz 0x10196854 */
        l_0x1019_6808:
            ii(0x1019_6808, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x1019_680b, 2); if(jz(0x1019_681e, 0x11)) goto l_0x1019_681e; /* jz 0x1019681e */
            ii(0x1019_680d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_680f, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1019_6811, 3); cmp(edx, 0x65);                         /* cmp edx, 0x65 */
            ii(0x1019_6814, 2); if(jz(0x1019_681e, 8)) goto l_0x1019_681e; /* jz 0x1019681e */
            ii(0x1019_6816, 3); cmp(edx, 0x45);                         /* cmp edx, 0x45 */
            ii(0x1019_6819, 2); if(jz(0x1019_681e, 3)) goto l_0x1019_681e; /* jz 0x1019681e */
            ii(0x1019_681b, 1); inc(eax);                               /* inc eax */
            ii(0x1019_681c, 2); jmp(0x1019_6808, -0x16); goto l_0x1019_6808; /* jmp 0x10196808 */
        l_0x1019_681e:
            ii(0x1019_681e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_6820, 3); mov(bl, memb[ds, ebx + 0x15]);          /* mov bl, [ebx+0x15] */
            ii(0x1019_6823, 6); and(ebx, 0xff);                         /* and ebx, 0xff */
            ii(0x1019_6829, 1); dec(eax);                               /* dec eax */
            ii(0x1019_682a, 3); cmp(ebx, 0x47);                         /* cmp ebx, 0x47 */
            ii(0x1019_682d, 2); if(jz(0x1019_6834, 5)) goto l_0x1019_6834; /* jz 0x10196834 */
            ii(0x1019_682f, 3); cmp(ebx, 0x67);                         /* cmp ebx, 0x67 */
            ii(0x1019_6832, 2); if(jnz(0x1019_6840, 0xc)) goto l_0x1019_6840; /* jnz 0x10196840 */
        l_0x1019_6834:
            ii(0x1019_6834, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_6836, 2); mov(bl, memb[ds, eax]);                 /* mov bl, [eax] */
            ii(0x1019_6838, 3); cmp(ebx, 0x30);                         /* cmp ebx, 0x30 */
            ii(0x1019_683b, 2); if(jnz(0x1019_6840, 3)) goto l_0x1019_6840; /* jnz 0x10196840 */
            ii(0x1019_683d, 1); dec(eax);                               /* dec eax */
            ii(0x1019_683e, 2); jmp(0x1019_6834, -0xc); goto l_0x1019_6834; /* jmp 0x10196834 */
        l_0x1019_6840:
            ii(0x1019_6840, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_6842, 2); mov(bl, memb[ds, eax]);                 /* mov bl, [eax] */
            ii(0x1019_6844, 3); cmp(ebx, 0x2e);                         /* cmp ebx, 0x2e */
            ii(0x1019_6847, 2); if(jz(0x1019_684a, 1)) goto l_0x1019_684a; /* jz 0x1019684a */
            ii(0x1019_6849, 1); inc(eax);                               /* inc eax */
        l_0x1019_684a:
            ii(0x1019_684a, 2); mov(bl, memb[ds, edx]);                 /* mov bl, [edx] */
            ii(0x1019_684c, 1); inc(edx);                               /* inc edx */
            ii(0x1019_684d, 2); mov(memb[ds, eax], bl);                 /* mov [eax], bl */
            ii(0x1019_684f, 1); inc(eax);                               /* inc eax */
            ii(0x1019_6850, 2); test(bl, bl);                           /* test bl, bl */
            ii(0x1019_6852, 2); if(jnz(0x1019_684a, -0xa)) goto l_0x1019_684a; /* jnz 0x1019684a */
        l_0x1019_6854:
            ii(0x1019_6854, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_6855, 1); ret();                                  /* ret */
        }
    }
}
